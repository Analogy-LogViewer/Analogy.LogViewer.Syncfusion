using Syncfusion.WinForms.DataGridConverter;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataSources;
using Analogy.Interfaces;
using Analogy.Types;
using DevExpress.Data.Filtering;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.DataGrid.Serialization;
using static System.Enum;
using Message = System.Windows.Forms.Message;

namespace Analogy
{

    public partial class UCLogs : XtraUserControl, ILogMessageCreatedHandler
    {
        private string timeDiffColumnName = "TimeDiff";
        public bool ForceNoFileCaching { get; set; } = false;
        public bool DoNotAddToRecentHistory { get; set; } = false;
        private PagingManager PagingManager { get; set; }
        private FileProcessor fileProcessor { get; set; }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public event EventHandler<AnalogyClearedHistoryEventArgs> OnHistoryCleared;
        public event EventHandler<(string, AnalogyLogMessage)> OnFocusedRowChanged;
        private Dictionary<string, List<AnalogyLogMessage>> groupingByChars;
        private string OldTextInclude = string.Empty;
        private string OldTextExclude = string.Empty;
        public int fileLoadingCount;
        private bool LoadingInProgress => fileLoadingCount > 0;
        private UserSettingsManager Settings => UserSettingsManager.UserSettings;
        private IExtensionsManager ExtensionManager { get; set; } = ExtensionsManager.Instance;
        private IEnumerable<IAnalogyExtension> InPlaceRegisteredExtensions { get; set; }
        private List<IAnalogyExtension> UserControlRegisteredExtensions { get; set; }
        private List<int> HighlightRows { get; set; } = new List<int>();
        private int SelectedHighlightRow { get; set; }
        private ToolTip Tip { get; set; }
        private List<string> _excludeMostCommon = new List<string>();
        public const string DataGridDateColumnName = "Date";
        private bool _realtimeUpdate = true;

        private ReaderWriterLockSlim lockExternalWindowsObject = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);
        private ReaderWriterLockSlim lockSlim;
        private DataTable _messageData;
        private DataTable _bookmarkedMessages;
        private IProgress<AnalogyProgressReport> ProgressReporter { get; set; }
        private readonly List<XtraFormLogGrid> _externalWindows = new List<XtraFormLogGrid>();
        private List<XtraFormLogGrid> ExternalWindows
        {
            get
            {
                lockExternalWindowsObject.EnterReadLock();
                var items = _externalWindows.ToList();
                lockExternalWindowsObject.ExitReadLock();
                return items;
            }
        }

        private int ExternalWindowsCount;
        private List<AnalogyLogMessage> Messages
        {
            get
            {
                var filterDatatable = GetFilteredDataTable();
                return filterDatatable.Rows.OfType<DataRow>().Select(r => (AnalogyLogMessage)r["Object"]).ToList();
            }
        }
        private List<AnalogyLogMessage> BookmarkedMessages
        {
            get { return _bookmarkedMessages.Rows.OfType<DataRow>().Select(r => (AnalogyLogMessage)r["Object"]).ToList(); }
        }

        private bool EnableOTA { get; } = false;//GeneralUtils.UseDebugMode("AnalogyOTA");
        private AnalogyLogMessage _currentMassage;
        private FilterCriteriaObject _filterCriteria = new FilterCriteriaObject();
        public bool OnlineMode { get; set; }

        // private bool FilterHasChanged { get; set; }
        private bool NewDataExist { get; set; }
        private bool hasAnyInPlaceExtensions;
        private bool hasAnyUserControlExtensions;
        private DateTime diffStartTime = DateTime.MinValue;
        private string LayoutFileNameMain;
        private bool BookmarkView;
        private int pageNumber = 1;
        private CancellationTokenSource filterTokenSource;
        private CancellationToken filterToken;

        private int TotalPages => PagingManager.TotalPages;
        private IAnalogyOfflineDataProvider FileDataProvider { get; set; }
        private IAnalogyOfflineDataProvider AnalogyOfflineDataProvider { get; } = new AnalogyOfflineDataProvider();

        public UCLogs()
        {
            InitializeComponent();
            SetupControlEvents();
            filterTokenSource = new CancellationTokenSource();
            filterToken = filterTokenSource.Token;
            fileProcessor = new FileProcessor(this);
            if (DesignMode) return;
            //splitContainerMain.IsSplitterFixed = false;
            //splitContainerMain.FixedPanel = SplitFixedPanel.None;
            //ClientSizeChanged += (s, e) => { splitContainerMain.SplitterPosition = (int)0.8 * splitContainerMain.Height; };
            LayoutFileNameMain = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "layoutMain.xml");
            PagingManager = new PagingManager(this);
            lockSlim = PagingManager.lockSlim;
            _messageData = PagingManager.CurrentPage();
            sfDataGridMain.DataSource = _messageData;
            sfDataGridMain.RowValidating += SfDataGridMain_RowValidating;
        }

        private void SetupControlEvents()
        {
            //include combobox
            //cbInclude. txtbInclude.SelectAll();
            cbInclude.TextBox.TextChanged += async (s, e) =>
             {
                 if (OldTextInclude.Equals(cbInclude.Text)) return;
                 OldTextInclude = cbInclude.Text;
                 txtbHighlight.Text = cbInclude.Text;
                 if (string.IsNullOrEmpty(cbInclude.Text))
                 {
                     chkbIncludeText.Checked = false;
                     return;
                 }

                 chkbHighlight.Checked = false;
                 chkbIncludeText.Checked = true;
                 await FilterHasChanged();
             };
            cbInclude.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var added = Settings.AddNewSearchesEntryToLists(cbInclude.Text, true);
                    if (added)
                        cbInclude.DataSource = Settings.LastSearchesInclude;
                }
            };

            cbExclude.TextBox.TextChanged += async (s, e) =>
            {
                if (OldTextExclude.Equals(cbExclude.Text)) return;
                Settings.ExcludedText = cbExclude.Text;
                OldTextExclude = cbExclude.Text;
                if (string.IsNullOrEmpty(cbExclude.Text))
                {
                    chkExclude.Checked = false;
                    return;
                }

                chkExclude.Checked = true;
                await FilterHasChanged();
            };
            cbExclude.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var added = Settings.AddNewSearchesEntryToLists(cbExclude.Text, false);
                    if (added)
                        cbExclude.DataSource = Settings.LastSearchesExclude;
                }
            };

            cbSource.TextBox.TextChanged += async (s, e) =>
            {
                if (string.IsNullOrEmpty(cbSource.Text))
                {
                    chkbSources.Checked = false;
                }
                else
                {
                    if (!chkbSources.Checked)
                        chkbSources.Checked = true;
                }

                await FilterHasChanged();
                Settings.SourceText = cbSource.Text;
            };

            cbModule.TextBox.TextChanged += async (s, e) =>
            {
                if (string.IsNullOrEmpty(cbModule.Text))
                {
                    chkbModules.Checked = false;
                }
                else
                {
                    if (!chkbModules.Checked)
                        chkbModules.Checked = true;
                }

                await FilterHasChanged();
                Settings.ModuleText = cbModule.Text;
            };
            #region sfDataGrid Main
            sfDataGridMain.QueryRowStyle += sfDataGrid_QueryRowStyle;
            sfDataGridMain.CellClick += (s, e) =>
            {
                if (btsAutoScrollToBottom.Checked)
                    btsAutoScrollToBottom.Checked = false;

                var selectedItems = sfDataGridMain.SelectedItems.Cast<DataRowView>().ToList();
                if (!selectedItems.Any()) return;
                DataRow dataRow = selectedItems.First().Row;
                _currentMassage = GetMessageFromRow(dataRow);
                LoadTextBoxes(_currentMassage);
                if (hasAnyInPlaceExtensions)
                {
                    var column = sfDataGridMain.Columns[e.DataColumn.ColumnIndex];
                    if (column == null) return;
                    foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                    {
                        var columns = extension.GetColumnsInfo();
                        foreach (AnalogyColumnInfo exColumn in columns)
                        {
                            if (column.MappingName.Equals(exColumn.ColumnName) &&
                                column.HeaderText.Equals(exColumn.ColumnCaption))
                            {

                                var cellValue = sfDataGridMain.GetSelectedCells().First().ToString();
                                AnalogyCellClickedEventArgs argsForEx =
                                    new AnalogyCellClickedEventArgs(exColumn.ColumnName, cellValue, _currentMassage);
                                extension.CellClicked(s, argsForEx);
                            }
                        }
                    }
                }

            };
            sfDataGridMain.CellDoubleClick += (s, e) =>
            {
                OpenMessageDetails();
            };
            sfDataGridMain.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)13)
                {
                    OpenMessageDetails();
                }
            };
            sfDataGridMain.SelectionChanged += (s, e) =>
            {
                //int row = e.FocusedRowHandle;
                //if (row < 0) return;
                //AnalogyLogMessage m = (AnalogyLogMessage)LogGrid.GetRowCellValue(e.FocusedRowHandle, "Object");
                //LoadTextBoxes(m);
                //string dataProvider = (string)LogGrid.GetRowCellValue(e.FocusedRowHandle, "DataProvider");
                //if (!LoadingInProgress)
                //{
                //    OnFocusedRowChanged?.Invoke(this, (dataProvider, m));
                //}
            };
            #endregion

            #region Radio buttons log level

            rbAllLevel.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbErrorCritical.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbDebug.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbVerbose.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbWarning.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            rbTrace.CheckChanged += async (s, e) => { await FilterHasChanged(); };
            #endregion
        }
        private void SfDataGridMain_RowValidating(object sender, Syncfusion.WinForms.DataGrid.Events.RowValidatingEventArgs e)
        {

        }

        private static AnalogyLogMessage GetMessageFromRow(DataRow row) => row[9] as AnalogyLogMessage;

        private void UCLogs_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            sfDataGridMain.Columns[timeDiffColumnName].Visible = false;
            PagingManager.OnPageChanged += (s, arg) =>
            {
                if (IsDisposed) return;
                BeginInvoke(new MethodInvoker(() =>
                    lblPageNumber.Text = $"Page {pageNumber} / {arg.AnalogyPage.PageNumber}"));

            };
            LoadUISettings();
            BookmarkModeUI();

            hasAnyInPlaceExtensions = ExtensionManager.HasAnyInPlace;
            hasAnyUserControlExtensions = ExtensionManager.HasAnyInPlace;
            InPlaceRegisteredExtensions = ExtensionManager.InPlaceRegisteredExtensions.ToList();
            UserControlRegisteredExtensions = ExtensionManager.UserControlRegisteredExtensions.ToList();
            InitializeExtensionsColumns();
            ProgressReporter = new Progress<AnalogyProgressReport>((value) =>
            {
                progressBar1.Maximum = value.Total;
                if (value.Processed < progressBar1.Maximum && value.Total > 1)
                    progressBar1.Value = value.Processed;
                if (value.Processed == value.Total)
                    progressBar1.Visible = false;
            });

            //todo: auto scroll to last
            //LogGrid.RowCountChanged += (s, arg) =>
            //{
            //    if (Settings.AutoScrollToLastMessage && !IsDisposed)
            //    {
            //        BeginInvoke(new MethodInvoker(() =>
            //        {
            //            LogGrid.MoveLast();
            //            LogGrid.MakeRowVisible(LogGrid.FocusedRowHandle);
            //        }));

            //    }
            //};

            _bookmarkedMessages = Utils.DataTableConstructor();
            gridControlBookmarkedMessages.DataSource = _bookmarkedMessages;

        }

        public void SetFileDataSource(IAnalogyOfflineDataProvider fileDataProvider)
        {
            FileDataProvider = fileDataProvider;
            if (FileDataProvider is EventLogDataProvider eventDataSource)
                eventDataSource.LogWindow = this;
            if (FileDataProvider == null)
            {
                //disable specific saving
                bBtnSaveLog.Visibility = BarItemVisibility.Never;
                bBtnSaveEntireLog.Visibility = BarItemVisibility.Never;
            }
        }


        public void ProcessCmdKeyFromParent(Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.Control && e.KeyCode == Keys.F)
            {
                cbInclude.Focus();
            }
            if (e.Shift && e.KeyCode == Keys.F)

            {
                cbExclude.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.E)
            {
                rbErrorCritical.Checked = !rbErrorCritical.Checked;
            }
            if (e.Alt && e.KeyCode == Keys.W)
            {
                rbWarning.Checked = !rbWarning.Checked;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.Control && e.KeyCode == Keys.F)

            {
                cbInclude.Focus();
                return true;
            }
            if (e.Shift && e.KeyCode == Keys.F)

            {
                cbExclude.Focus();
                return true;
            }

            if (e.Alt && e.KeyCode == Keys.E)
            {
                rbErrorCritical.Checked = !rbErrorCritical.Checked;
                return true;
            }
            if (e.Alt && e.KeyCode == Keys.W)
            {
                rbWarning.Checked = !rbWarning.Checked;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void LoadUISettings()
        {
            Tip = new ToolTip();
            Tip.SetToolTip(pboxInfo, "Use & or + for AND operations. Use | for OR operations");
            Tip.SetToolTip(pboxInfoExclude, "Use , to separate values. to exclude source or module prefix it with -");

            spltFilteringBoth.SplitterDistance = spltFilteringBoth.Width - 150;
            pnlFilteringLeft.Dock = DockStyle.Fill;
            cbInclude.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbExclude.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            if (Settings.RememberLastSearches)
            {
                cbInclude.DataSource = Settings.LastSearchesInclude;
                cbExclude.DataSource = Settings.LastSearchesExclude;
            }

            if (File.Exists(LayoutFileNameMain))
            {
                using (FileStream fileStream = File.OpenRead(LayoutFileNameMain))
                {
                    sfDataGridMain.Deserialize(fileStream, Deserialization());
                }
            }
            if (Settings.SaveSearchFilters)
            {
                cbInclude.Text = Settings.IncludeText;
                cbExclude.Text = Settings.ExcludedText;
            }
            btswitchRefreshLog.Checked = true;

            btswitchExpand.Checked = true;
            splitContainerMain.Collapsed = true;
            if (Settings.StartupErrorLogLevel)
                rbErrorCritical.Checked = true;

            //todo:font
            //LogGrid.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);

            btsAutoScrollToBottom.Checked = Settings.AutoScrollToLastMessage;
        }

        private void BookmarkModeUI()
        {
            if (BookmarkView)
            {
                sfDataGridMain.ContextMenuStrip = cmsBookmarked;
                bBtnRemoveBoomark.Visibility = BarItemVisibility.Always;
                bBtnImport.Visibility = BarItemVisibility.Never;
            }
        }

        private void InitializeExtensionsColumns()
        {
            foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
            {
                var columns = extension.GetColumnsInfo();
                foreach (AnalogyColumnInfo column in columns)
                {
                    var gridColumn = new Syncfusion.WinForms.DataGrid.GridColumn();
                    gridColumn.HeaderText = column.ColumnCaption;
                    gridColumn.MappingName = column.ColumnName;
                    //todo:index?
                    //gridColumn.index = ExtensionManager.GetIndexForExtension(extension);
                    sfDataGridMain.Columns.Add(gridColumn);
                    gridColumn.Visible = true;
                }

            }
        }



        private void UCLogs_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

        private async void UCLogs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            await LoadFilesAsync(files.ToList(), false);

        }

        #region UI events

        private void PmsGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            LoadTextBoxes(message);

        }

        private void LogGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                OpenMessageDetails();
            }
        }

        private void pmsGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (sender is GridView view && e.RowHandle >= 0)
            {
                string level = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Level"]);
                var parsed = TryParse(level, true, out AnalogyLogLevel enumLevel);
                if (parsed)
                {
                    e.Appearance.BackColor = Settings.ColorSettings.GetColorForLogLevel(enumLevel);
                    switch (enumLevel)
                    {
                        case AnalogyLogLevel.Warning:
                        case AnalogyLogLevel.Error:
                        case AnalogyLogLevel.Critical:
                            if (UserLookAndFeel.Default.ActiveLookAndFeel.ActiveSkinName.Contains("Dark"))
                                e.Appearance.ForeColor = Color.Black;
                            break;
                        case AnalogyLogLevel.Event:
                        case AnalogyLogLevel.Verbose:
                        case AnalogyLogLevel.Debug:
                        case AnalogyLogLevel.Disabled:
                        case AnalogyLogLevel.Trace:
                        case AnalogyLogLevel.Unknown:
                        case AnalogyLogLevel.AnalogyInformation:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                string text = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Text"]);
                if (chkbHighlight.Checked && FilterCriteriaObject.Match(text, txtbHighlight.Text, PreDefinedQueryType.Contains))
                {
                    e.Appearance.BackColor = Settings.ColorSettings.GetHighlightColor();
                }

                foreach (PreDefineHighlight preDefineHighlight in Settings.PreDefinedQueries.Highlights)
                {
                    if (FilterCriteriaObject.Match(text, preDefineHighlight.Text, preDefineHighlight.PreDefinedQueryType))
                    {
                        e.Appearance.BackColor = preDefineHighlight.Color;
                    }
                }
            }
        }

        private void pmsGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!(e.RowHandle >= 0) || !e.Info.IsRowIndicator || !(sender is GridView view)) return;
            AnalogyLogMessage msg = (AnalogyLogMessage)view.GetRowCellValue(e.RowHandle, "Object");
            Image img = imageList.Images[7];
            switch (msg.Level)
            {
                case AnalogyLogLevel.Critical:
                case AnalogyLogLevel.Error:
                    img = imageList.Images[0];
                    break;
                case AnalogyLogLevel.Warning:
                    img = imageList.Images[1];
                    break;
                case AnalogyLogLevel.Trace:
                case AnalogyLogLevel.Event:
                    img = imageList.Images[7];
                    break;
                case AnalogyLogLevel.Verbose:
                    img = imageList.Images[2];
                    break;
                case AnalogyLogLevel.Debug:
                    img = imageList.Images[6];
                    break;
                case AnalogyLogLevel.Disabled:
                    break;
                case AnalogyLogLevel.AnalogyInformation:
                    img = imageList.Images[8];
                    break;
                case AnalogyLogLevel.Unknown:
                    img = imageList.Images[9];
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Rectangle r = e.Bounds;
            int x = r.X + (r.Width - imageList.ImageSize.Width) / 2;
            int y = r.Y + (r.Height - imageList.ImageSize.Height) / 2;
            e.Cache.DrawImage(img, x, y);
            e.Handled = true;
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage m, _) = GetMessageFromSelectedRowInGrid();
            if (m != null)
                Clipboard.SetText(m.Text);
        }

        private void tsmiEmail_Click(object sender, EventArgs e)
        {

            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            try
            {
                Process.Start($"mailto:?Subject=Analogy message&Body={message.Text}");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Error opening mail client", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Clipboard.SetText(message.Text);

        }

        private async Task FilterHasChanged()
        {
            async Task RefreshData(CancellationToken token)
            {
                await Task.Delay(500);
                if (token.IsCancellationRequested) return;
                FilterResults();

            }

            filterTokenSource.Cancel();
            filterTokenSource = new CancellationTokenSource();
            filterToken = filterTokenSource.Token;
            await RefreshData(filterToken);
        }
        private async void tsmiExclude_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            var ef = new AnalogyExcludeMessage(message);
            if (ef.ShowDialog(this) == DialogResult.OK)
            {
                string exclude = ef.Exclude;
                cbExclude.Text = cbExclude.Text + "|" + exclude;
                chkExclude.Checked = true;
                await FilterHasChanged();
            }
        }

        private async void chkbInclude_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private async void chkbExclude_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }
        //private async void txtbInclude_TextChanged(object sender, EventArgs e)
        //{
        //    if (OldTextInclude.Equals(txtbInclude.Text)) return;
        //    OldTextInclude = txtbInclude.Text;
        //    txtbHighlight.Text = txtbInclude.Text;
        //    if (string.IsNullOrEmpty(txtbInclude.Text))
        //    {
        //        chkbIncludeText.Checked = false;
        //        return;
        //    }

        //    chkbHighlight.Checked = false;
        //    chkbIncludeText.Checked = true;
        //    await FilterHasChanged();
        //}

        //private async void txtbExclude_TextChanged(object sender, EventArgs e)
        //{
        //    if (OldTextExclude.Equals(txtbExclude.Text)) return;
        //    Settings.ExcludedText = txtbExclude.Text;
        //    OldTextExclude = txtbExclude.Text;
        //    if (string.IsNullOrEmpty(txtbExclude.Text))
        //    {
        //        chkExclude.Checked = false;
        //        return;
        //    }

        //    chkExclude.Checked = true;
        //    await FilterHasChanged();
        //}

        /// <summary>
        /// Set custom column display text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewCustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.GroupRowHandle == BaseListSourceDataController.FilterRow &&
                e.Column.FieldName == DataGridDateColumnName)
            {
                e.DisplayText = e.Column.FilterInfo.DisplayText;
            }
        }

        /// <summary>
        /// Called when column filter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewShowFilterPopupListBox(object sender, FilterPopupListBoxEventArgs e)
        {
            if (e.Column.FieldName != DataGridDateColumnName)
            {
                return;
            }

            e.ComboBox.Items.Clear();

            int index = 0;

            #region Create and add custom filter criteria to select the records which refer to the current date.

            // ALL
            ColumnFilterInfo fInfo = new ColumnFilterInfo();
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterNone, fInfo));

            // Today
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.Today),
                GetFilterDisplayText(DateRangeFilter.Today));
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterToday, fInfo));

            // Last 2 days
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.Last2Days),
                GetFilterDisplayText(DateRangeFilter.Last2Days));
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterLast2Days, fInfo));
            // Last 3 days
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.Last3Days),
                GetFilterDisplayText(DateRangeFilter.Last3Days));
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterLast3Days, fInfo));
            // Last week
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.LastWeek),
                GetFilterDisplayText(DateRangeFilter.LastWeek));
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterLastWeek, fInfo));
            // Last 2 weeks
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.Last2Weeks),
                GetFilterDisplayText(DateRangeFilter.Last2Weeks));
            e.ComboBox.Items.Insert(index++, new FilterItem(Utils.DateFilterLast2Weeks, fInfo));
            // Last month.
            fInfo = new ColumnFilterInfo(GetFilterString(DataGridDateColumnName, DateRangeFilter.LastMonth),
                GetFilterDisplayText(DateRangeFilter.LastMonth));
            e.ComboBox.Items.Insert(index, new FilterItem(Utils.DateFilterLastMonth, fInfo));

            #endregion Create and add custom filter criteria to select the records which refer to the current date.
        }

        #endregion

        #region Messages logic



        internal DataTable GetFilteredDataTable()
        {

            // Create a data view by applying the grid view row filter
            try
            {
                lockSlim.EnterReadLock();
                string filter = _messageData.DefaultView.RowFilter;
                return new DataView(_messageData, filter, null, DataViewRowState.CurrentRows).ToTable();
            }
            finally
            {
                lockSlim.ExitReadLock();
            }
        }

        private (int total, int error, int warning, int critical, int alerts) GetRowsCount()
        {

            // Create a data view by applying the grid view row filter
            try
            {
                lockSlim.EnterReadLock();

                string filter = _messageData.DefaultView.RowFilter;
                var rows = _messageData.Select(filter);
                var total = rows.Length;
                var error = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Error.ToString());
                var warning = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Warning.ToString());
                var critical = rows.Count(r => r["Level"].ToString() == AnalogyLogLevel.Critical.ToString());
                var alertCount = 0;
                if (Settings.PreDefinedQueries.Alerts.Any())
                {
                    var messages = rows.Select(r => (AnalogyLogMessage)r["Object"]).ToList();
                    alertCount = messages.Count(m =>
                        Settings.PreDefinedQueries.Alerts.Any(a => FilterCriteriaObject.MatchAlert(m, a)));

                }

                return (total, error, warning, critical, alertCount);
            }
            finally
            {
                lockSlim.ExitReadLock();
            }
        }
        private string GetFilterDisplayText(DateRangeFilter filterType)
        {
            string displayText = string.Empty;
            switch (filterType)
            {
                case DateRangeFilter.None:
                    displayText = Utils.DateFilterNone;
                    break;
                case DateRangeFilter.Today:
                    displayText = Utils.DateFilterToday;
                    break;
                case DateRangeFilter.Last2Days:
                    displayText = Utils.DateFilterLast2Days;
                    break;
                case DateRangeFilter.Last3Days:
                    displayText = Utils.DateFilterLast3Days;
                    break;
                case DateRangeFilter.LastWeek:
                    displayText = Utils.DateFilterLastWeek;
                    break;
                case DateRangeFilter.Last2Weeks:
                    displayText = Utils.DateFilterLast2Weeks;
                    break;
                case DateRangeFilter.LastMonth:
                    displayText = Utils.DateFilterLastMonth;
                    break;
            }

            return displayText;
        }

        /// <summary>
        /// Get the filter string for Quick filter
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="filterType"></param>
        /// <returns></returns>
        private string GetFilterString(string columnName, DateRangeFilter filterType)
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;

            switch (filterType)
            {
                // The filter expression for the TODAY item.
                case DateRangeFilter.Today:
                    startDate = DateTime.Today;
                    endDate = startDate.AddDays(1);
                    break;

                // The filter expression for the last 2 days item.
                case DateRangeFilter.Last2Days:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-1);
                    break;

                // The filter expression for the last 3 days item.
                case DateRangeFilter.Last3Days:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-2);
                    break;

                // The filter expression for the last week item.
                case DateRangeFilter.LastWeek:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-7);
                    break;

                // The filter expression for the last 2 weeks item.
                case DateRangeFilter.Last2Weeks:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddDays(-14);
                    break;

                // The filter expression for the last month item.
                case DateRangeFilter.LastMonth:
                    endDate = DateTime.Today.AddDays(1);
                    startDate = DateTime.Today.AddMonths(-1);
                    break;
            }

            string startDateStr = "#" + startDate.ToString("g", CultureInfo.CreateSpecificCulture("en-US")) + "#";
            string endDateStr = "#" + endDate.ToString("g", CultureInfo.CreateSpecificCulture("en-US")) + "#";
            var filter = "([" + columnName + "] >= " + startDateStr + " AND [" + columnName + "] < " + endDateStr + ")";
            return filter;
        }


        #endregion


        public void AppendMessage(AnalogyLogMessage message, string dataSource)
        {
            if (message.Level == AnalogyLogLevel.Disabled)
                return; //ignore those messages

            if (Settings.IdleMode && Utils.IdleTime().TotalMinutes > Settings.IdleTimeMinutes)
            {
                PagingManager.IncrementTotalMissedMessages();
            }
            lockSlim.EnterWriteLock();
            if (ExternalWindowsCount > 0)
            {
                foreach (XtraFormLogGrid grid in ExternalWindows)
                {
                    grid.AppendMessage(message, dataSource);
                }
            }


            DataRow dtr = PagingManager.AppendMessage(message, dataSource);
            if (diffStartTime > DateTime.MinValue)
            {
                dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
            }

            if (hasAnyInPlaceExtensions)
            {
                foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                {
                    var columns = extension.GetColumnsInfo();
                    foreach (AnalogyColumnInfo column in columns)
                    {
                        dtr[column.ColumnName] = extension.GetValueForCellColumn(message, column.ColumnName);
                    }
                }
            }

            if (hasAnyUserControlExtensions)
            {
                foreach (IAnalogyExtension extension in UserControlRegisteredExtensions)
                {
                    extension.NewMessage(message);
                }
            }
            lockSlim.ExitWriteLock();
            if (PagingManager.IsCurrentPageInView(_messageData))
                NewDataExist = true;
        }

        public void AppendMessages(List<AnalogyLogMessage> messages, string dataSource)
        {

            if (Settings.IdleMode && Utils.IdleTime().TotalMinutes > Settings.IdleTimeMinutes)
            {
                PagingManager.IncrementTotalMissedMessages();
            }
            lockSlim.EnterWriteLock();
            if (ExternalWindowsCount > 0)
            {
                foreach (XtraFormLogGrid grid in ExternalWindows)
                {
                    grid.AppendMessages(messages, dataSource);
                }
            }

            foreach (var (dtr, message) in PagingManager.AppendMessages(messages, dataSource))
            {
                if (diffStartTime > DateTime.MinValue)
                {
                    dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
                }

                if (hasAnyInPlaceExtensions)
                {
                    foreach (IAnalogyExtension extension in InPlaceRegisteredExtensions)
                    {
                        var columns = extension.GetColumnsInfo();
                        foreach (AnalogyColumnInfo column in columns)
                        {
                            dtr[column.ColumnName] = extension.GetValueForCellColumn(message, column.ColumnName);
                        }
                    }
                }

                dtr.EndEdit();
            }
            lockSlim.ExitWriteLock();
            if (PagingManager.IsCurrentPageInView(_messageData))
                NewDataExist = true;

            if (hasAnyUserControlExtensions)
            {
                foreach (IAnalogyExtension extension in UserControlRegisteredExtensions)
                {
                    extension.NewMessages(messages);
                }
            }

        }

        public void AcceptChanges(bool forceRefresh)
        {
            if (!IsHandleCreated) return;
            if (_realtimeUpdate || forceRefresh)

                BeginInvoke(new MethodInvoker(() =>
                {
                    lockSlim.EnterWriteLock();
                    try
                    {
                        sfDataGridMain.BeginUpdate();
                        _messageData.AcceptChanges();
                        RefreshUIMessagesCount();
                        sfDataGridMain.EndUpdate();
                    }
                    finally
                    {
                        lockSlim.ExitWriteLock();
                    }

                }));
        }

        private void UpdatePage(DataTable page)
        {

            _messageData = page;
            lockSlim.EnterWriteLock();
            try
            {
                sfDataGridMain.DataSource = _messageData;
                //NewDataExist = true;
                //FilterHasChanged = true;
                lblPageNumber.Text = $"Page {pageNumber} / {TotalPages}";
                NewDataExist = true;
                FilterResults();
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }
        }

        public void FilterResults(string module)
        {
            cbModule.Text = module;
            FilterResults();
        }


        private void FilterResults()
        {
            _filterCriteria.NewerThan = chkDateNewerThan.Checked ? deNewerThanFilter.DateTime : DateTime.MinValue;
            _filterCriteria.OlderThan = chkDateOlderThan.Checked ? deOlderThanFilter.DateTime : DateTime.MaxValue;
            _filterCriteria.TextInclude = chkbIncludeText.Checked ? cbInclude.Text : string.Empty;
            _filterCriteria.TextExclude = chkExclude.Checked ? cbExclude.Text + "|" + string.Join("|", _excludeMostCommon) : string.Empty;


            Settings.IncludeText = Settings.SaveSearchFilters ? _filterCriteria.TextInclude : string.Empty;
            Settings.ExcludedText = Settings.SaveSearchFilters ? _filterCriteria.TextExclude : string.Empty;


            _filterCriteria.Levels = null;
            if (rbTrace.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Trace, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            if (rbErrorCritical.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Error, AnalogyLogLevel.Critical, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbWarning.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Warning, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbDebug.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Debug, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };
            else if (rbVerbose.Checked)
                _filterCriteria.Levels = new[] { AnalogyLogLevel.Verbose, AnalogyLogLevel.Disabled, AnalogyLogLevel.Unknown };



            if (chkbSources.Checked && !string.IsNullOrEmpty(cbSource.Text))
            {
                var items = cbSource.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var includeItems = items.Where(i => !i.StartsWith("-"));
                var excludeItems = items.Where(i => i.StartsWith("-") && i.Length > 1)
                    .Select(i => i.Substring(1, i.Length - 1));

                _filterCriteria.Sources = includeItems.Select(val => val.Trim()).ToArray();
                _filterCriteria.ExcludedSources = excludeItems.Select(val => val.Trim()).ToArray();
            }
            else
            {
                _filterCriteria.Sources = null;
                _filterCriteria.ExcludedSources = null;
            }

            Settings.SourceText = Settings.SaveSearchFilters ? cbSource.Text : string.Empty;

            if (chkbModules.Checked && !string.IsNullOrEmpty(cbSource.Text))
            {

                var items = cbSource.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var includeItems = items.Where(i => !i.StartsWith("-"));
                var excludeItems = items.Where(i => i.StartsWith("-") && i.Length > 1)
                      .Select(i => i.Substring(1, i.Length - 1));

                _filterCriteria.Modules = includeItems.Select(val => val.Trim()).ToArray();
                _filterCriteria.ExcludedModules = excludeItems.Select(val => val.Trim()).ToArray();


            }
            else
            {
                _filterCriteria.Modules = null;
                _filterCriteria.ExcludedModules = null;
            }
            Settings.ModuleText = Settings.SaveSearchFilters ? cbModule.Text : string.Empty;
            string filter = _filterCriteria.GetSqlExpression();
            lockSlim.EnterWriteLock();
            try
            {

                //var rows = _messageData.Select(filter);
                //var dt = _messageData.Clone();
                //foreach (DataRow row in rows)
                //{
                //    dt.ImportRow(row);
                //}
                //gridControl.DataSource = dt;
                _messageData.DefaultView.RowFilter = _filterCriteria.GetSqlExpression();
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }

            //todo: selectin of current message
            //var location = LocateByValue(0, gridColumnObject, _currentMassage);
            //if (location >= 0)
            //    LogGrid.FocusedRowHandle = location;

            RefreshUIMessagesCount();

        }
        public virtual int LocateByValue(int startRowHandle, GridColumn column, AnalogyLogMessage val)
        {
            return 0;
            //todo: fix this
            //if (!LogGrid.DataController.IsReady || val == null)
            //    return int.MinValue;
            //startRowHandle = Math.Max(0, startRowHandle);
            //if (LogGrid.IsServerMode)
            //{
            //    if (startRowHandle != 0)
            //        throw new ArgumentException("Argument must be '0' in server mode.", nameof(startRowHandle));
            //}
            //try
            //{
            //    if (LogGrid.IsServerMode)
            //        return LogGrid.DataController.FindRowByValue(column.FieldName, val, null);
            //    for (int rowHandle = startRowHandle; rowHandle < LogGrid.DataController.VisibleListSourceRowCount; ++rowHandle)
            //    {
            //        object rowCellValue = LogGrid.GetRowCellValue(rowHandle, column.Caption);
            //        if (Equals(val, rowCellValue))
            //            return rowHandle;
            //    }
            //}
            //catch
            //{
            //}
            //return int.MinValue;
        }
        private void RefreshUIMessagesCount()
        {
            if (!IsHandleCreated) return;
            BeginInvoke(new MethodInvoker(() =>
            {
                var result = GetRowsCount();
                lblTotalMessages.Text = $"Total messages:{result.total}. Errors:{result.error}. Warnings:{result.warning}. Criticals:{result.critical}.";
                if (result.alerts > 0)
                {
                    lblTotalMessagesAlert.Text = $" ALERTS EXISTS: {result.alerts}!";
                    lblTotalMessagesAlert.Visible = true;
                }
                else
                {
                    lblTotalMessagesAlert.Visible = false;
                }

            }));
        }

        public void RefreshUI()
        {
            //gridColumnDataSource.VisibleIndex = 0;
            //gridColumnDate.VisibleIndex = 1;
            //gridColumnText.VisibleIndex = 2;
            //gridColumnSource.VisibleIndex = 3;
            //gridColumnLevel.VisibleIndex = 4;
            //gridColumnClass.VisibleIndex = 5;
            //gridColumnModule.VisibleIndex = 6;
            //gridColumnProcessID.VisibleIndex = 7;
            //gridColumnUser.VisibleIndex = 8;
            //gridColumnCategory.VisibleIndex = 9;
            //gridColumnAudit.VisibleIndex = 10;

        }

        public async Task LoadFilesAsync(List<string> fileNames, bool clearLogBeforeLoading)
        {
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            if (clearLogBeforeLoading)
                ClearLogs(false);
            sBtnCancel.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = fileNames.Count;
            progressBar1.Style = fileNames.Count > 1 ? ProgressBarStyle.Continuous : ProgressBarStyle.Marquee;
            fileLoadingCount = +fileNames.Count;
            progressBar1.Visible = true;
            int processed = 0;
            foreach (string filename in fileNames)
            {
                if (!File.Exists(filename))
                {
                    AnalogyLogMessage m = new AnalogyLogMessage($"File {filename} does not exist", AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None");
                    AppendMessage(m, "Analogy");
                    continue;
                }

                Text = @"File: " + filename;
                await fileProcessor.Process(FileDataProvider, filename, cancellationTokenSource.Token);
                processed++;
                ProgressReporter.Report(new AnalogyProgressReport("Processed", processed, fileNames.Count, filename));
                if (token.IsCancellationRequested)
                {
                    progressBar1.Visible = false;
                    break;
                }
            }

            sBtnCancel.Visible = false;
        }

        private void ClearLogs(bool raiseEvent)
        {

            lockSlim.EnterWriteLock();

            if (raiseEvent)
            {
                OnHistoryCleared?.Invoke(this, new AnalogyClearedHistoryEventArgs(PagingManager.GetAllMessages()));
            }

            PagingManager.ClearLogs();
            pageNumber = 1;
            UpdatePage(PagingManager.FirstPage());
            AcceptChanges(true);
            rtxtContent.Text = string.Empty;
            if (BookmarkView)
                BookmarkPersistManager.Instance.ClearBookmarks();
            lockSlim.ExitWriteLock();

        }


        private void LoadTextBoxes(AnalogyLogMessage m)
        {
            if (InvokeRequired)
                BeginInvoke(new MethodInvoker(() => rtxtContent.Text = m.Text));
            else
            {
                rtxtContent.Text = m.Text;
            }

        }

        private void tsmiOTAFull_Click(object sender, EventArgs e)
        {
            if (EnableOTA)
            {
                AnalogyOTAClient client = new AnalogyOTAClient(GetFilteredDataTable());
                client.Show(this);
            }
            else
            {
                MessageBox.Show("Sending logs feature has been disabled", "Operation Is Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsBtnShare_Click(object sender, EventArgs e)
        {
            if (EnableOTA)
            {
                AnalogyOTAClient client = new AnalogyOTAClient(GetFilteredDataTable());
                client.Show(this);
            }
            else
            {
                XtraMessageBox.Show("Sharing logs feature has been disabled", "Operation Is Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tmrNewData_Tick(object sender, EventArgs e)
        {
            if (NewDataExist)
            {
                NewDataExist = false;
                AcceptChanges(false);
            }

        }

        //private void txtbInclude_MouseEnter(object sender, EventArgs e)
        //{
        //    txtbInclude.Focus();
        //    txtbInclude.SelectAll();
        //}

        //private void txtbInclude_Enter(object sender, EventArgs e)
        //{
        //    txtbInclude.SelectAll();
        //}

        private void txtbExcludeSource_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtbExcludeSource.Text))
            //{
            //    chkbExcludeSources.Checked = false;
            //}
            //else
            //{
            //    if (!chkbExcludeSources.Checked)
            //        chkbExcludeSources.Checked = true;
            //}

            //RefreshUserFilter();
            //Settings.ExcludedSource = txtbExcludeSource.Text;

        }

        private void gridControlBookmarkedMessages_DoubleClick(object sender, EventArgs e)
        {
            if (!(e is DXMouseEventArgs args))
                return;
            GoToMessage();

        }

        private void pmsGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!(e is DXMouseEventArgs args))
                return;
            OpenMessageDetails();


        }

        private void OpenMessageDetails()
        {
            (AnalogyLogMessage message, string dataSource) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;
            FormMessageDetails details = new FormMessageDetails(message, Messages, dataSource);
            details.Show(this);
        }

        private void tsmiBookmark_Click(object sender, EventArgs e)
        {
            CreateBookmark(false);
        }

        private void CreateBookmark(bool persists)
        {

            (AnalogyLogMessage message, string dataprovider) = GetMessageFromSelectedRowInGrid();
            if (message == null) return;

            lockSlim.EnterWriteLock();
            DataRow dtr = _bookmarkedMessages.NewRow();
            dtr["Date"] = message.Date;
            dtr["Text"] = message.Text ?? "";
            dtr["Source"] = message.Source ?? "";
            dtr["Level"] = message.Level.ToString();
            dtr["Class"] = message.Class.ToString();
            dtr["Category"] = message.Category ?? "";
            dtr["User"] = message.User ?? "";
            dtr["Module"] = message.Module ?? "";
            dtr["Object"] = message;
            dtr["ProcessID"] = message.ProcessID;
            dtr["DataProvider"] = dataprovider;
            if (diffStartTime > DateTime.MinValue)
            {
                dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
            }

            _bookmarkedMessages.Rows.Add(dtr);
            _bookmarkedMessages.AcceptChanges();
            btswitchExpand.Checked = true;
            splitContainerMain.Collapsed = false;
            tcBottom.SelectedTabPage = xtpBookmarks;
            if (persists)
                BookmarkPersistManager.Instance.AddBookmarkedMessage(message, dataprovider);
            lockSlim.ExitWriteLock();
        }

        private void GoToMessage()
        {
            //int[] selRows = gridViewBookmarkedMessages.GetSelectedRows();
            //if (selRows == null || selRows.Length != 1) return;
            //int rownum = selRows.First();
            //var currentRow = (DataRowView)gridViewBookmarkedMessages.GetRow(rownum);
            //try
            //{
            //    var LogMessage = currentRow["Object"] as AnalogyLogMessage;
            //    var location = LocateByValue(0, gridColumnObject, LogMessage);
            //    if (location >= 0)
            //        LogGrid.FocusedRowHandle = location;
            //    else
            //        XtraMessageBox.Show("Cannot go to message", "Message not found", MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);
            //}
            //catch (Exception)
            //{

            //    XtraMessageBox.Show("Cannot go to message", "Message not found", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }



        private async void chkbHighlight_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private async void txtbHighlight_KeyUp(object sender, KeyEventArgs e)
        {
            chkbHighlight.Checked = !string.IsNullOrEmpty(txtbHighlight.Text);
            HighlightRows.Clear();
            await FilterHasChanged();
        }

        private void tsmiExcludeSource_Click(object sender, EventArgs e)
        {

            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (!string.IsNullOrEmpty(message?.Source))
                cbSource.Text = cbSource.Text + ",-" + message.Source;
        }

        private void tsmiExcludeModule_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (!string.IsNullOrEmpty(message?.Module))
                cbModule.Text = cbModule.Text + ",-" + message.Module;
        }


        private void tsmiTimeDiff_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                diffStartTime = message.Date;
                UpdateTimes();
            }
        }

        private void UpdateTimes()
        {
            sfDataGridMain.Columns[timeDiffColumnName].Visible = false;
            try
            {


                lockSlim.EnterWriteLock();
                sfDataGridMain.BeginUpdate();
                foreach (DataRow row in _messageData.Rows)
                {
                    AnalogyLogMessage message = (AnalogyLogMessage)row["Object"];
                    //row["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString("d\\.hh\\:mm\\:ss\\.fff");
                    row["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
                }

                sfDataGridMain.EndUpdate();
                AcceptChanges(true);
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }


        }

        private async void tsbtnImport_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter =
                "Plain XML log file (*.log)|*.log|JSON file (*.json)|*.json|NLOG file (*.nlog)|*.nlog|Zipped XML log file (*.zip)|*.zip|ETW log file (*.etl)|*.etl";
            openFileDialog1.Title = @"Import file to current view";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await LoadFilesAsync(new List<string> { openFileDialog1.FileName }, false);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, @"Error Opening file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //if (HighlightRows.Any() && LogGrid.GetSelectedRows().Any())
            //{
            //    int selected = LogGrid.GetSelectedRows().First();
            //    if (HighlightRows.All(r => r >= selected))
            //        LogGrid.SelectRow(HighlightRows.Last());
            //    else
            //        LogGrid.SelectRow(HighlightRows.First(r => r < selected));
            //}
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //if (HighlightRows.Any() && LogGrid.GetSelectedRows().Any())
            //{
            //    int selected = LogGrid.GetSelectedRows().First();
            //    if (HighlightRows.All(r => r <= selected))
            //        LogGrid.SelectRow(HighlightRows.First());
            //    else
            //        LogGrid.SelectRow(HighlightRows.First(r => r > selected));
            //}
        }

        private void btswitchExpand_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            splitContainerMain.Collapsed = btswitchExpand.Checked;
        }

        private void btswitchRefreshLog_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            _realtimeUpdate = btswitchRefreshLog.Checked;
            AcceptChanges(false);
            //btswitchRefreshLog.Caption = _realtimeUpdate ? "Refresh log:" : "Paused:";
        }

        private void bBtnSaveLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = Messages;
            SaveMessagesToLog(FileDataProvider, messages);
        }

        private async void SaveMessagesToLog(IAnalogyOfflineDataProvider fileHandler, List<AnalogyLogMessage> messages)
        {

            if (fileHandler != null && fileHandler.CanSaveToLogFile)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = fileHandler.FileSaveDialogFilters;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        await fileHandler.SaveAsync(messages, saveFileDialog.FileName);
                    }
                    catch (Exception e)
                    {
                        XtraMessageBox.Show(e.Message, @"Error Saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                if (XtraMessageBox.Show("Current Data Source does not support Save Operation" + Environment.NewLine + "Do you want to Save in Analogy XML Format?", @"Save not Supported", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
                    //SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.Filter = "Plain XML log file - Analogy Data format (*.xml)| *.xml";

                    //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    //{
                    //    try
                    //    {
                    //        AnalogyXmlLogFile save = new AnalogyXmlLogFile();
                    //        save.Save(Messages, saveFileDialog.FileName);
                    //        XtraMessageBox.Show("Operation Completed", $"Messages were saved to {saveFileDialog.FileName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    catch (Exception e)
                    //    {
                    //        XtraMessageBox.Show(e.Message, @"Error Saving file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                }
                else
                {
                    XtraMessageBox.Show("Operation Aborted", @"Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private async void bBtnImport_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter =
                "Plain XML log file (*.log)|*.log|JSON file (*.json)|*.json|NLOG file (*.nlog)|*.nlog|Zipped XML log file (*.zip)|*.zip|ETW log file (*.etl)|*.etl";
            openFileDialog1.Title = @"Import file to current view";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await LoadFilesAsync(new List<string> { openFileDialog1.FileName }, false);
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message, @"Error Opening file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void bBtnClearLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearLogs(true);
        }

        private async void sBtnMostCommon_Click(object sender, EventArgs e)
        {
            List<string> items;

            lockSlim.EnterReadLock();
            items = Messages.Select(r => r.Text).ToList();
            lockSlim.ExitReadLock();

            AnalogyExclude ef = new AnalogyExclude(items, _excludeMostCommon);
            if (ef.ShowDialog(this) == DialogResult.OK)
            {
                _excludeMostCommon = AnalogyExclude.GlobalExclusion;
                chkExclude.Checked = true;
                await FilterHasChanged();
            }
        }

        private async void chkLstLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }


        private async void chkLstLogLevel_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            await FilterHasChanged();
        }

        private void sBtnLength_Click(object sender, EventArgs e)
        {
            nudGroupBychars.Value = Math.Max(txtbGroupByCharsLimit.Text.Length, nudGroupBychars.Value);
            ApplyGrouping();
        }

        private void sBtnGroup_Click(object sender, EventArgs e)
        {
            ApplyGrouping();

        }

        private void ApplyGrouping()
        {
            List<IGrouping<string, AnalogyLogMessage>> grouped = Messages
                .GroupBy(s => s.Text.Substring(0, Math.Min(s.Text.Length, (int)nudGroupBychars.Value)))
                .OrderByDescending(i => i.Count()).ToList();
            groupingByChars = grouped.ToDictionary(g => g.Key, g => g.ToList());
            gCtrlGrouping.DataSource = groupingByChars.Keys;
        }
        private void bBtnCopyButtom_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clipboard.SetText(rtxtContent.Text);
        }

        private void bBtnButtomExpand_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {

            splitContainerMain.Collapsed = !btSwitchExpandButtomMessage.Checked;

        }

        private void bBtnGoToMessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoToMessage();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            _bookmarkedMessages.Clear();
        }

        private void bBtnopyBookmarked_ItemClick(object sender, ItemClickEventArgs e)
        {
            int[] selRows = gridViewBookmarkedMessages.GetSelectedRows();

            if (selRows != null && selRows.Length == 1)
            {
                var message = (AnalogyLogMessage)gridViewBookmarkedMessages.GetRowCellValue(selRows.First(), "Object");
                Clipboard.SetText(message.Text);
            }
        }

        private void tsmiSaveLayout_Click(object sender, EventArgs e)
        {
            SaveGridLayout();
        }

        private void SaveGridLayout()
        {
            try
            {
                using (FileStream fileStream = File.Create(LayoutFileNameMain))
                {
                    sfDataGridMain.Serialize(fileStream, Serialization());
                }
            }
            catch (Exception exception)
            {
                AnalogyLogger.Intance.LogException(exception, nameof(UCLogs), "Error saving layout");
                throw;
            }
        }
        private void tsmiBookmarkPersist_Click(object sender, EventArgs e)
        {
            CreateBookmark(true);
        }

        private void tsmiRemoveBookmark_Click(object sender, EventArgs e)
        {
            RemoveBookmark();
        }

        private void bBtnRemoveBoomark_ItemClick(object sender, ItemClickEventArgs e)
        {
            RemoveBookmark();
        }

        private void RemoveBookmark()
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
                BookmarkPersistManager.Instance.RemoveBookmark(message);

        }
        //private void logGrid_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        //{
        //    if (e.Column.FieldName == "gridColumnLevelImage")
        //    {
        //        string severity = logGrid.GetListSourceRowCellValue(e.ListSourceRowIndex, gridView1.Columns["Level"])
        //            .ToString();
        //        LogLevel level = Utils.GetLogLevel(severity);
        //        switch (level)
        //        {
        //            case LogLevel.Critical:
        //            case LogLevel.Error:
        //                e.Value = imageList.Images[0];
        //                break;
        //            case LogLevel.Warning:
        //                e.Value = imageList.Images[1];
        //                break;
        //            case LogLevel.Event:
        //                e.Value = imageList.Images[2];
        //                break;
        //            case LogLevel.Verbose:
        //                e.Value = imageList.Images[2];
        //                break;
        //            case LogLevel.Debug:
        //                e.Value = imageList.Images[1];
        //                break;
        //            case LogLevel.Disabled:
        //                e.Value = imageList.Images[1];
        //                break;
        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }

        //    }
        //}

        public void SetBookmarkMode()
        {
            BookmarkView = true;
            BookmarkModeUI();
        }

        public void RemoveMessage(AnalogyLogMessage msgMessage)
        {
            var row = _messageData.AsEnumerable().SingleOrDefault(r => r["Object"] == msgMessage);
            if (row != null)
                _messageData.Rows.Remove(row);
        }

        private void cmsMessageOperation_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                tsmiExcludeModule.Text = $"Exclude Process: {message.Module}";
                tsmiExcludeSource.Text = $"Exclude Source: {message.Source}";
                tsmiDateFilterNewer.Text = $"Show all messages after {message.Date}";
                tsmiDateFilterOlder.Text = $"Show all messages Before {message.Date}";
                tsmiDateFilterNewer.Visible = true;
                tsmiDateFilterOlder.Visible = true;
            }
            else
            {
                tsmiDateFilterNewer.Visible = false;
                tsmiDateFilterOlder.Visible = false;

            }
        }

        private (AnalogyLogMessage, string) GetMessageFromSelectedRowInGrid()
        {
            if (!sfDataGridMain.SelectedItems.Any()) return (null, string.Empty);
            var selectedItems = sfDataGridMain.SelectedItems.Cast<DataRowView>();
            DataRow dataRow = selectedItems.First().Row;
            AnalogyLogMessage message = GetMessageFromRow(dataRow);
            string datasource = (string)dataRow["DataProvider"].ToString();
            return (message, datasource);

        }

        private void cmsBookmarked_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            if (message != null)
            {
                tsmiExcludeModuleBookmark.Text = $"Exclude Process: {message.Module}";
                tsmiExcludeSourceBookmark.Text = $"Exclude Source: {message.Source}";
                tsmiBookmarkDateFilterNewer.Text = $"Show all messages after {message.Date}";
                tsmiBookmarkDateFilterOlder.Text = $"Show all messages Before {message.Date}";
                tsmiBookmarkDateFilterNewer.Visible = true;
                tsmiBookmarkDateFilterOlder.Visible = true;
            }
            else
            {
                tsmiDateFilterNewer.Visible = false;
                tsmiBookmarkDateFilterOlder.Visible = false;

            }
        }


        private void gridViewGrouping_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var grouped = Utils.DataTableConstructor();
            string key =
                (string)gridViewGrouping.GetRowCellValue(e.FocusedRowHandle, gridViewGrouping.Columns.First());
            var messages = groupingByChars[key];
            foreach (var message in messages)
            {

                DataRow dtr = grouped.NewRow();

                dtr["Date"] = message.Date;
                dtr["Text"] = message.Text ?? "";
                dtr["Source"] = message.Source ?? "";
                dtr["Level"] = message.Level;
                dtr["Class"] = message.Class;
                dtr["Category"] = message.Category ?? "";
                dtr["User"] = message.User ?? "";
                dtr["Module"] = message.Module ?? "";
                dtr["Object"] = message;
                dtr["ProcessID"] = message.ProcessID;
                dtr["DataProvider"] = "";
                if (diffStartTime > DateTime.MinValue)
                {
                    dtr["TimeDiff"] = message.Date.Subtract(diffStartTime).ToString();
                }

                grouped.Rows.Add(dtr);

            }

            grouped.AcceptChanges();
            gridControlMessageGrouping.DataSource = grouped;
        }

        private void sBtnCancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel(false);
            Interlocked.Exchange(ref fileLoadingCount, 0);

            cancellationTokenSource = new CancellationTokenSource();
            sBtnCancel.Visible = false;
        }

        private void tsmiCopyMessages_Click(object sender, EventArgs e)
        {
            var messages = Messages;
            string all = string.Join(Environment.NewLine, messages.Select(m => $"{m.Date.ToString()}: {m.Text}"));
            Clipboard.SetText(all);
        }

        private void bBtnCopyAllBookmarks_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = BookmarkedMessages;
            if (!messages.Any()) return;
            string all = string.Join(Environment.NewLine, messages.Select(m => $"{m.Date.ToString()}: {m.Text}"));
            Clipboard.SetText(all);
        }

        private void btsAutoScrollToBottom_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            Settings.AutoScrollToLastMessage = btsAutoScrollToBottom.Checked;
        }

        private void pmsGrid_Click(object sender, EventArgs e)
        {
            if (btsAutoScrollToBottom.Checked)
                btsAutoScrollToBottom.Checked = false;
        }

        private void sbtnPageFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            UpdatePage(PagingManager.FirstPage());
        }

        private void sbtnPagePrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1) return;
            pageNumber--;
            UpdatePage(PagingManager.PrevPage().Data);
        }

        private void sBtnPageNext_Click(object sender, EventArgs e)
        {
            if (pageNumber == TotalPages) return;
            pageNumber++;
            UpdatePage(PagingManager.NextPage().Data);
        }

        private void sBtnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = TotalPages;
            UpdatePage(PagingManager.LastPage());
        }

        private void bBtnExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var count = sfDataGridMain.RowCount;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file XLSX (*.xlsx)|*.xlsx|Excel file XLS (*.XLS)|*.xls";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    if (count > 1048576)
                    {
                        XtraMessageBox.Show($"XLSX files are limited to 1,048,576 rows (and 16,384 columns). You have {count} rows", "Export Aborted");
                    }
                    else
                    {
                        var options = new ExcelExportingOptions();
                        var excelEngine = sfDataGridMain.ExportToExcel(sfDataGridMain.View, options);
                        var workBook = excelEngine.Excel.Workbooks[0];
                        workBook.SaveAs(saveFileDialog.FileName);
                        OpenFolder(saveFileDialog.FileName);
                    }
                }
                if (saveFileDialog.FilterIndex == 2)
                {
                    if (count > 65536)
                    {
                        XtraMessageBox.Show($"XLS files are limited to 65,536 rows (and 256 columns). You have {count} rows", "Export Aborted");
                    }
                    else
                    {
                        var options = new ExcelExportingOptions();
                        var excelEngine = sfDataGridMain.ExportToExcel(sfDataGridMain.View, options);
                        var workBook = excelEngine.Excel.Workbooks[0];
                        workBook.SaveAs(saveFileDialog.FileName);
                        OpenFolder(saveFileDialog.FileName);
                    }
                }
            }
        }

        private void bBtnExportCSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Comma Separated File (*.csv)|*.csv";

            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{

            //    var excelEngine = sfDataGridMain.export(sfDataGridMain.View, options);
            //    var workBook = excelEngine.Excel.Workbooks[0];
            //    workBook.SaveAs(saveFileDialog.FileName);

            //    LogGrid.ExportToCsv(saveFileDialog.FileName);
            //    OpenFolder(saveFileDialog.FileName);
            //}
        }

        private void bBtnExportHtml_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "HTML File (*.html)|*.html";

            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    HtmlExportOptions op = new HtmlExportOptions();
            //    op.ExportMode = HtmlExportMode.SingleFile;
            //    LogGrid.ExportToHtml(saveFileDialog.FileName, op);
            //    OpenFolder(saveFileDialog.FileName);
            //}
        }
        private void OpenFolder(string filename)
        {
            try
            {
                Process.Start("explorer.exe", "/select, \"" + filename + "\"");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error Opening file location", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void bBtnUndockView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var msg = Messages;
            if (!msg.Any()) return;
            var source = GetFilteredDataTable().Rows[0]?["DataProvider"]?.ToString();
            if (source == null) return;
            XtraFormLogGrid grid = new XtraFormLogGrid(msg, source);
            lockExternalWindowsObject.EnterWriteLock();
            _externalWindows.Add(grid);
            Interlocked.Increment(ref ExternalWindowsCount);
            lockExternalWindowsObject.ExitWriteLock();
            grid.FormClosing += (s, arg) =>
            {
                lockExternalWindowsObject.EnterWriteLock();
                Interlocked.Decrement(ref ExternalWindowsCount);
                _externalWindows.Remove(grid);
                lockExternalWindowsObject.ExitWriteLock();
            };
            grid.Show(this);
        }

        private void bBtnSaveEntireLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = PagingManager.GetAllMessages();
            SaveMessagesToLog(FileDataProvider, messages);
        }



        private void tsmiIncreaseFont_Click(object sender, EventArgs e)
        {
            Settings.FontSize = sfDataGridMain.Font.Size + 2;
            sfDataGridMain.Font = new Font(sfDataGridMain.Font.Name, Settings.FontSize);
            //todo:
            /// gridViewBookmarkedMessages.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);
            SaveGridLayout();
        }

        private void tsmiDecreaseFont_Click(object sender, EventArgs e)
        {
            if (sfDataGridMain.Font.Size < 5) return;
            {
                Settings.FontSize = sfDataGridMain.Font.Size - 2;
                sfDataGridMain.Font = new Font(sfDataGridMain.Font.Name, Settings.FontSize);
                //todo:
                //gridViewBookmarkedMessages.Appearance.Row.Font = new Font(LogGrid.Appearance.Row.Font.Name, Settings.FontSize);
                SaveGridLayout();
            }
        }

        private void tsmiClearLog_Click(object sender, EventArgs e)
        {
            ClearLogs(true);
        }

        private void tsmiREmoveAllPreviousMessages_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage current, _) = GetMessageFromSelectedRowInGrid();
            if (current == null) return;

            lockSlim.EnterWriteLock();
            while (_messageData.Rows.Count > 0)
            {
                if (_messageData.Rows[0]["Object"] != current)
                    _messageData.Rows.RemoveAt(0);
                else
                {
                    break;
                }
            }
            lockSlim.ExitWriteLock();
            RefreshUIMessagesCount();

        }

        private void bBtnDataVisualizer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = Messages;
            DataVisualizerForm sv = new DataVisualizerForm(messages);
            sv.Show(this);
        }

        private void bbiScreenshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            Bitmap image = takeComponentScreenShot(sfDataGridMain);
            Clipboard.SetImage(image);
            MessageBox.Show("Screenshot of messages was copied to clipboard.", "Image was taken", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private static Bitmap takeComponentScreenShot(Control control)
        {
            // find absolute position of the control in the screen.
            Control ctrl = control;
            Rectangle rect = new Rectangle(Point.Empty, ctrl.Size);
            do
            {
                rect.Offset(ctrl.Location);
                ctrl = ctrl.Parent;
            }
            while (ctrl != null);

            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        private void BbtnSaveViewAgnostic_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = Messages;
            SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
        }

        private void BarButtonItemSaveEntireInAnalogy_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messages = PagingManager.GetAllMessages();
            SaveMessagesToLog(AnalogyOfflineDataProvider, messages);
        }

        private void bBtnUndockViewPerProcess_ItemClick(object sender, ItemClickEventArgs e)
        {
            UndockViewPerProcess();
        }

        private void UndockViewPerProcess()
        {
            var msg = Messages;
            if (!msg.Any()) return;
            var source = GetFilteredDataTable().Rows[0]?["DataProvider"]?.ToString();
            if (source == null) return;

            var processes = msg.Select(m => m.Module).Distinct().ToList();
            foreach (string process in processes)
            {
                XtraFormLogGrid grid = new XtraFormLogGrid(msg, source, process);
                lockExternalWindowsObject.EnterWriteLock();
                _externalWindows.Add(grid);
                Interlocked.Increment(ref ExternalWindowsCount);
                lockExternalWindowsObject.ExitWriteLock();
                grid.FormClosing += (s, arg) =>
                {
                    lockExternalWindowsObject.EnterWriteLock();
                    Interlocked.Decrement(ref ExternalWindowsCount);
                    _externalWindows.Remove(grid);
                    lockExternalWindowsObject.ExitWriteLock();
                };
                grid.Show(this);
            }
        }

        private void sbtnTextInclude_Click(object sender, EventArgs e)
        {
            //txtbInclude.Text = "";
        }

        private void sbtnTextExclude_Click(object sender, EventArgs e)
        {
            // txtbExclude.Text = "";
        }

        private void sbtnIncludeSources_Click(object sender, EventArgs e)
        {
            cbSource.Text = "";
        }

        private async void txtbIncludeSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSource.Text))
            {
                chkbSources.Checked = false;
            }
            else
            {
                if (!chkbSources.Checked)
                    chkbSources.Checked = true;
            }

            await FilterHasChanged();
            Settings.SourceText = chkbSources.Text;
        }


        private void sbtnIncludeModules_Click(object sender, EventArgs e)
        {
            cbModule.Text = "";
        }

        private async void txtbIncludeModule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbModule.Text))
            {
                chkbModules.Checked = false;
            }
            else
            {
                if (!chkbModules.Checked)
                    chkbModules.Checked = true;
            }

            await FilterHasChanged();
            Settings.ModuleText = chkbModules.Text;
        }

        private void sbtnUndockPerProcess_Click(object sender, EventArgs e)
        {
            UndockViewPerProcess();
        }

        private async void deNewerThanFilter_EditValueChanged(object sender, EventArgs e)
        {
            chkDateNewerThan.Checked = true;
            await FilterHasChanged();
        }
        private async void deNewerThanFilter_Properties_EditValueChanged(object sender, EventArgs e)
        {
            chkDateNewerThan.Checked = true;
            await FilterHasChanged();
        }

        private async void deOlderThanFilter_EditValueChanged(object sender, EventArgs e)
        {
            chkDateOlderThan.Checked = true;
            await FilterHasChanged();
        }

        private async void deOlderThanFilter_Properties_EditValueChanged(object sender, EventArgs e)
        {
            chkDateOlderThan.Checked = true;
            await FilterHasChanged();
        }

        private async void chkDateOlderThan_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private async void chkDateNewerThan_CheckedChanged(object sender, EventArgs e)
        {
            await FilterHasChanged();
        }

        private void tsmiDateFilterNewer_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deNewerThanFilter.DateTime = message.Date;
            chkDateNewerThan.Checked = true;
        }

        private void tsmiDateFilterOlder_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deOlderThanFilter.DateTime = message.Date;
            chkDateOlderThan.Checked = true;
        }

        private void tsmiBookmarkDateFilterNewer_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deNewerThanFilter.DateTime = message.Date;
            chkDateNewerThan.Checked = true;
        }

        private void tsmiBookmarkDateFilterOlder_Click(object sender, EventArgs e)
        {
            (AnalogyLogMessage message, _) = GetMessageFromSelectedRowInGrid();
            deOlderThanFilter.DateTime = message.Date;
            chkDateOlderThan.Checked = true;
        }

        private void sbtnMoreHighlight_Click(object sender, EventArgs e)
        {
            UserSettingsForm user = new UserSettingsForm(1);
            user.ShowDialog(this);
        }

        private void sbtnPreDefinedFilters_Click(object sender, EventArgs e)
        {
            if (!Settings.PreDefinedQueries.Filters.Any()) return;
            contextMenuStripFilters.Items.Clear();
            foreach (PreDefineFilter filter in Settings.PreDefinedQueries.Filters)
            {

                ToolStripMenuItem item = new ToolStripMenuItem(filter.ToString());
                item.Click += (s, arg) =>
                {
                    cbInclude.Text = filter.IncludeText;
                    cbExclude.Text = filter.ExcludeText;
                    cbSource.Text = filter.Sources;
                    cbModule.Text = filter.Modules;
                };
                contextMenuStripFilters.Items.Add(item);
            }

            contextMenuStripFilters.Show(sbtnPreDefinedFilters.PointToScreen(sbtnPreDefinedFilters.Location));
        }

        private void sfDataGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {

            if (e.RowIndex >= 0 && (e.RowData is DataRowView drv) && drv.Row.ItemArray[9] is AnalogyLogMessage message)
            {
                var data = e.RowData;
                e.Style.BackColor = Settings.ColorSettings.GetColorForLogLevel(message.Level);
                string text = message.Text;
                if (chkbHighlight.Checked && FilterCriteriaObject.Match(text, txtbHighlight.Text, PreDefinedQueryType.Contains))
                {
                    e.Style.BackColor = Settings.ColorSettings.GetHighlightColor();
                }

                foreach (PreDefineHighlight preDefineHighlight in Settings.PreDefinedQueries.Highlights)
                {
                    if (FilterCriteriaObject.Match(text, preDefineHighlight.Text, preDefineHighlight.PreDefinedQueryType))
                    {
                        e.Style.BackColor = preDefineHighlight.Color;
                    }
                }
            }
        }
        private SerializationOptions Serialization()
        {
            SerializationOptions serializationOptions = new SerializationOptions
            {
                SerializeStyle = true,
                SerializeCaptionSummaries = true,
                SerializeColumns = true,
                SerializeFiltering = true,
                SerializeGrouping = true,
                SerializeGroupSummaries = true,
                SerializeSorting = true,
                SerializeStackedHeaders = true,
                SerializeTableSummaries = true,
                SerializeUnboundRows = true
            };
            return serializationOptions;
        }
        private DeserializationOptions Deserialization()
        {
            DeserializationOptions deserializationOptions = new DeserializationOptions
            {
                DeserializeCaptionSummary = true,
                DeserializeColumns = true,
                DeserializeFiltering = true,
                DeserializeGrouping = true,
                DeserializeGroupSummaries = true,
                DeserializeSorting = true,
                DeserializeStackedHeaders = true,
                DeserializeStyle = true,
                DeserializeTableSummaries = true,
                DeserializeUnboundRows = true
            };

            return deserializationOptions;
        }

        private void sfDataGridMain_StyleChanged(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = File.Create(LayoutFileNameMain))
                {
                    sfDataGridMain.Serialize(fileStream, Serialization());
                }
            }
            catch (Exception exception)
            {
                AnalogyLogger.Intance.LogException(exception, nameof(UCLogs), "Error saving layout");

            }
        }
    }
}



