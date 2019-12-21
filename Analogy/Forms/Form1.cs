using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using Analogy.DataSources;
using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.Managers;
using Analogy.Properties;
using Analogy.Types;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using Syncfusion.Windows.Forms.Tools.Navigation;
using Bar = Syncfusion.Windows.Forms.Tools.Navigation.Bar;
using RibbonForm = Syncfusion.Windows.Forms.Tools.RibbonForm;

namespace Analogy
{
    public partial class Form1 : RibbonForm
    {
        private string filePoolingTitle = "File Pooling";
        private string offlineTitle = "Offline log";
        private string onlineTitle = "Online log";
        private Dictionary<Guid, ToolStripTabItem> Mapping = new Dictionary<Guid, ToolStripTabItem>();

        private Dictionary<XtraTabPage, IAnalogyRealTimeDataProvider> onlineDataSourcesMapping =
            new Dictionary<XtraTabPage, IAnalogyRealTimeDataProvider>();

        private List<Task<bool>> OnlineSources = new List<Task<bool>>();
        private int offline;
        private int online;
        private int filePooling;
        private bool disableOnlineDueToFileOpen;
        private XtraTabPage currentContextPage;
        private UserSettingsManager settings => UserSettingsManager.UserSettings;
        private bool Initialized { get; set; }

        TouchStyleColorTable touch = new TouchStyleColorTable();

        public Form1()
        {
            InitializeComponent();
            AnalogyLogManager.Instance.OnNewError += (s, e) => tsslblError.Visible = true;
            //  ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
            touch.HeaderColor = Color.White;//ColorTranslator.FromHtml("#f5f6f7");
            touch.ActiveToolStripTabItemBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.RibbonPanelBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BackStageNavigationButtonBackColor = ColorTranslator.FromHtml("#1979ca");
            touch.ToolStripBorderColor = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripSelectedTabItemBorder = ColorTranslator.FromHtml("#dadbdc");
            touch.ToolstripTabItemBorder = Color.Transparent;
            touch.ToolstripTabItemForeColor = ColorTranslator.FromHtml("#3c3c3c");
            touch.HoverTabBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#f5f6f7");
            touch.ToolstripActiveTabItemForeColor = Color.Black;
            touch.HoverTabForeColor = Color.Black;
            touch.MinimizeButtonForeColor = Color.Black;
            touch.MaximizeButtonForeColor = Color.Black;

            ribbonControlMain.ApplyTouchStyleColorTable(touch);

    
            ribbonControlMain.SelectedTab = toolStripTabItem1;

            UCLogs log1 = new UCLogs();
            dockingManager1.SetDockLabel(log1, "logs");
            var ccbcLog1 = new CaptionButtonsCollection();
            dockingManager1.SetCustomCaptionButtons(log1, ccbcLog1);


            UCLogs log2 = new UCLogs();
            dockingManager1.SetDockLabel(log2, "logs");
            var ccbcLog2 = new CaptionButtonsCollection();
            dockingManager1.SetCustomCaptionButtons(log2, ccbcLog2);

            dockingManager1.EnableDocumentMode = true;
            dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Top;
            dockingManager1.DockAsDocument(log1);
            dockingManager1.DockAsDocument(log2);

            //dockingManager1.SetDockLabel(panel3, "Top");
            //dockingManager1.SetDockLabel(panel1, "Buttom");
            //dockingManager1.SetEnableDocking(panel1, true);
            //dockingManager1.SetEnableDocking(panel3, true);
            //var ccbgradientPanel1 = new CaptionButtonsCollection();
            //ccbgradientPanel1.MergeWith(dockingManager1.CaptionButtons, false);
            //var ccbgradientPanel3 = new CaptionButtonsCollection();
            //ccbgradientPanel3.MergeWith(dockingManager1.CaptionButtons, false);
            //this.dockingManager1.EnableDocumentMode = true;
            //dockingManager1.DockTabAlignment = DockTabAlignmentStyle.Top;
            //dockingManager1.SetCustomCaptionButtons(this.panel3, ccbgradientPanel1);
            //dockingManager1.DockAsDocument(panel3);
            //dockingManager1.DockAsDocument(panel1);
        }

        private void DockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {

            //dockingManager1.DockControl(panel1, this, DockingStyle.Bottom, 250);
            //dockingManager1.DockControl(panel3, this, DockingStyle.Top, 250);
            //  dockingManager1.DockControl(gradientPanel1,this,DockingStyle.Left,250);
            //dockingManager1.DockControl(gradientPanel2, this, DockingStyle.Right, 250);
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            string[] arguments = Environment.GetCommandLineArgs();
            disableOnlineDueToFileOpen = arguments.Length == 2;
            if (DesignMode) return;

            MainStatusStrip.Text = "File caching is " + (settings.EnableFileCaching ? "on" : "off");
            //bbtnCloseCurrentTabPage.ItemClick += (object s, ItemClickEventArgs ea) => { CloseCurrentTabPage(); };
            //bbtnCloseAllTabPage.ItemClick += (object s, ItemClickEventArgs ea) =>
            //{
            //    var pages = xtcLogs.TabPages.ToList();
            //    foreach (var page in pages)
            //    {
            //        if (onlineDataSourcesMapping.ContainsKey(page))
            //        {
            //            onlineDataSourcesMapping[page].StopReceiving();
            //            onlineDataSourcesMapping.Remove(page);
            //        }

            //        xtcLogs.TabPages.Remove(page);

            //    }
            //};
            //bbtnCloseOtherTabPages.ItemClick += (object s, ItemClickEventArgs ea) =>
            //{
            //    var pages = xtcLogs.TabPages.Where(p => p != currentContextPage).ToList();
            //    foreach (var page in pages)
            //    {
            //        if (onlineDataSourcesMapping.ContainsKey(page))
            //        {
            //            onlineDataSourcesMapping[page].StopReceiving();
            //            onlineDataSourcesMapping.Remove(page);
            //        }

            //        xtcLogs.TabPages.Remove(page);

            //    }

            //};
            ribbonControlMain.MinimizePanel = UserSettingsManager.UserSettings.StartupRibbonMinimized;

            //todo
            //CreateAnalogyBuiltinDataProviders();
            await FactoriesManager.Instance.AddExternalDataSources();

            CreateDataSources();

            //set Default page:
            Guid defaultPage = new Guid(UserSettingsManager.UserSettings.InitialSelectedDataProvider);
            if (Mapping.ContainsKey(defaultPage))
            {
                ribbonControlMain.SelectedTab = Mapping[defaultPage];
            }

            if (OnlineSources.Any())
                TmrAutoConnect.Start();

            Initialized = true;
            //todo: fine handler for file
            if (arguments.Length == 2)
            {
                string[] fileNames = { arguments[1] };
                await OpenOfflineFileWithSpecificDataProvider(fileNames);

            }
            else
                TmrAutoConnect.Enabled = true;

            if (UserSettingsManager.UserSettings.ShowChangeLogAtStartUp)
            {
                var change = new ChangeLog();
                change.ShowDialog(this);
            }
            if (UserSettingsManager.UserSettings.RememberLastOpenedDataProvider && Mapping.ContainsKey(UserSettingsManager.UserSettings.LastOpenedDataProvider))
            {
                ribbonControlMain.SelectPage(Mapping[UserSettingsManager.UserSettings.LastOpenedDataProvider]);
            }
            ribbonControlMain.SelectedPageChanging += ribbonControlMain_SelectedPageChanging;
            if (AnalogyLogManager.Instance.HasErrorMessages || AnalogyLogManager.Instance.HasWarningMessages)
                tsslblError.Visible = true;



















            ribbonControlMain.MenuButtonText = "FILE";
            ribbonControlMain.BackStageNavigationButtonStyle = BackStageNavigationButtonStyles.Office2013;
            ribbonControlMain.QuickPanelAlignment = QuickPanelAlignment.Top;
            touch.CloseButtonForeColor = Color.Black;
            touch.RestoreButtonForeColor = Color.Black;
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#ffffff");
            touch.QATDownArrowColor = Color.Black;
            touch.ToolStripSpliterColor = ColorTranslator.FromHtml("#e2e3e4");
            superAccelerator1.BackColor = ColorTranslator.FromHtml("#eaf0f8");
            superAccelerator1.SetMenuButtonAccelerator(ribbonControlMain, "F");

        }

        private void CreateDataSources()
        {
            foreach (IAnalogyFactory factory in FactoriesManager.Instance.GetFactories()
                .Where(factory => !FactoriesManager.Instance.IsBuiltInFactory(factory) &&
                                  settings.GetFactorySetting(factory.FactoryID).Status != DataProviderFactoryStatus.Disabled))
            {
                CreateDataSource(factory, 3);
            }

        }

        private void CreateDataSource(IAnalogyFactory factory, int position)
        {
            if (factory.Title == null) return;

            RibbonPage ribbonPage = new RibbonPage(factory.Title);
            ribbonControlMain.Pages.Insert(position, ribbonPage);
            Mapping.Add(factory.FactoryID, ribbonPage);

            //todo:move logic to factory manager
            var dataSourceFactory = factory.DataProviders;
            if (dataSourceFactory?.Items != null && dataSourceFactory.Items.Any() &&
                !string.IsNullOrEmpty(dataSourceFactory.Title))
            {
                CreateDataSourceRibbonGroup(dataSourceFactory, ribbonPage);
            }

            var actionFactory = factory.Actions;
            if (actionFactory?.Items != null && actionFactory.Items.Any() && !string.IsNullOrEmpty(actionFactory.Title))
            {
                RibbonPageGroup groupActionSource = new RibbonPageGroup(actionFactory.Title);
                groupActionSource.AllowTextClipping = false;
                ribbonPage.Groups.Add(groupActionSource);
                foreach (IAnalogyCustomAction action in actionFactory.Items)
                {
                    BarButtonItem actionBtn = new BarButtonItem();
                    actionBtn.Caption = action.Title;
                    actionBtn.RibbonStyle = RibbonItemStyles.All;
                    groupActionSource.ItemLinks.Add(actionBtn);
                    actionBtn.ImageOptions.Image = Resources.PageSetup_32x32;
                    actionBtn.ImageOptions.LargeImage = Resources.PageSetup_32x32;
                    actionBtn.ItemClick += (sender, e) => { action.Action(); };
                }
            }

            RibbonPageGroup groupInfoSource = new RibbonPageGroup("About");
            groupInfoSource.Alignment = RibbonPageGroupAlignment.Far;
            BarButtonItem aboutBtn = new BarButtonItem();
            aboutBtn.Caption = "Data Source Information";
            aboutBtn.RibbonStyle = RibbonItemStyles.All;
            groupInfoSource.ItemLinks.Add(aboutBtn);
            aboutBtn.ImageOptions.Image = Resources.About_16x16;
            aboutBtn.ImageOptions.LargeImage = Resources.About_32x32;
            aboutBtn.ItemClick += (sender, e) => { new AboutDataSourceBox(factory).ShowDialog(this); };
            ribbonPage.Groups.Add(groupInfoSource);
        }
        //private void CreateAnalogyBuiltinDataProviders()
        //{
        //    IAnalogyFactory analogy = FactoriesManager.Instance.Get(AnalogyBuiltInFactory.AnalogyGuid);
        //    if (settings.GetFactorySetting(analogy.FactoryID).Status != DataProviderFactoryStatus.Disabled)
        //        CreateDataSource(analogy, 0);
        //    ribbonControlMain.SelectedPage = ribbonControlMain.Pages.First();
        //    IAnalogyFactory eventLogDataFactory = FactoriesManager.Instance.Get(EventLogDataFactory.ID);
        //    if (settings.GetFactorySetting(eventLogDataFactory.FactoryID).Status == DataProviderFactoryStatus.Disabled)
        //        return;
        //    //CreateEventLogsGroup
        //    RibbonPage ribbonPage = new RibbonPage(eventLogDataFactory.Title);
        //    EventLogDataProvider elds = eventLogDataFactory.DataProviders.Items.First() as EventLogDataProvider;
        //    ribbonControlMain.Pages.Insert(2, ribbonPage);
        //    RibbonPageGroup group = new RibbonPageGroup(eventLogDataFactory.DataProviders.Title);
        //    ribbonPage.Groups.Add(group);


        //    BarButtonItem evtxRealTime = new BarButtonItem();
        //    evtxRealTime.Caption = "Real Time Windows Event Logs";
        //    evtxRealTime.RibbonStyle = RibbonItemStyles.All;
        //    evtxRealTime.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    evtxRealTime.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    evtxRealTime.ItemClick += (s, be) =>
        //    {
        //        UserControl windowsEventlog = new WindowsEventLog();
        //        XtraTabPage page = new XtraTabPage();
        //        page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
        //        page.Controls.Add(windowsEventlog);
        //        windowsEventlog.Dock = DockStyle.Fill;
        //        page.Text = $"Windows Log";
        //        xtcLogs.TabPages.Add(page);
        //        xtcLogs.SelectedTabPage = page;
        //    };
        //    group.ItemLinks.Add(evtxRealTime);

        //    BarButtonItem evtxFile = new BarButtonItem();
        //    evtxFile.Caption = "Open Event log file (*.Evtx)";
        //    evtxFile.RibbonStyle = RibbonItemStyles.All;
        //    evtxFile.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    evtxFile.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    evtxFile.ItemClick += (s, be) =>
        //    {

        //        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //        openFileDialog1.Filter = "Windows Event log files (*.evtx)|*.evtx";
        //        openFileDialog1.Title = @"Open Files";
        //        openFileDialog1.Multiselect = true;
        //        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            OpenOfflineLogs(ribbonPage, openFileDialog1.FileNames, elds, "Windows Event log");
        //            AddRecentWindowsEventLogFiles(openFileDialog1.FileNames.ToList());
        //        }
        //    };
        //    group.ItemLinks.Add(evtxFile);

        //    BarButtonItem systemLog = new BarButtonItem();
        //    systemLog.Caption = $"Open {Environment.MachineName} System Log file";
        //    systemLog.RibbonStyle = RibbonItemStyles.All;
        //    systemLog.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    systemLog.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    systemLog.ItemClick += (s, be) =>
        //    {
        //        string file = Path.Combine(Environment.ExpandEnvironmentVariables("%SystemRoot%"), "System32", "Winevt",
        //            "Logs", "System.evtx");
        //        if (File.Exists(file))
        //        {
        //            OpenOfflineLogs(ribbonPage, new[] { file }, elds, "Windows Event log");
        //            AddRecentWindowsEventLogFiles(new List<string>() { file });
        //        }
        //    };
        //    group.ItemLinks.Add(systemLog);

        //    BarButtonItem appLog = new BarButtonItem();
        //    appLog.Caption = $"Open {Environment.MachineName} Application Log file";
        //    appLog.RibbonStyle = RibbonItemStyles.All;
        //    appLog.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    appLog.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    appLog.ItemClick += (s, be) =>
        //    {
        //        string file = Path.Combine(Environment.ExpandEnvironmentVariables("%SystemRoot%"), "System32", "Winevt",
        //            "Logs", "Application.evtx");
        //        if (File.Exists(file))
        //        {
        //            OpenOfflineLogs(ribbonPage, new[] { file }, elds, "Windows Event log");
        //            AddRecentWindowsEventLogFiles(new List<string>() { file });
        //        }
        //    };
        //    group.ItemLinks.Add(appLog);

        //    BarButtonItem secLog = new BarButtonItem();
        //    secLog.Caption = $"Open {Environment.MachineName} Security Log file";
        //    secLog.RibbonStyle = RibbonItemStyles.All;
        //    secLog.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    secLog.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    secLog.ItemClick += (s, be) =>
        //    {
        //        string file = Path.Combine(Environment.ExpandEnvironmentVariables("%SystemRoot%"), "System32", "Winevt",
        //            "Logs", "Security.evtx");
        //        if (File.Exists(file))
        //        {
        //            OpenOfflineLogs(ribbonPage, new[] { file }, elds, "Windows Event log");
        //            AddRecentWindowsEventLogFiles(new List<string>() { file });
        //        }
        //    };
        //    group.ItemLinks.Add(secLog);
        //    BarButtonItem btnFolder = new BarButtonItem();
        //    btnFolder.Caption = $"Local Machine logs - {Environment.MachineName}";
        //    btnFolder.RibbonStyle = RibbonItemStyles.All;
        //    btnFolder.ImageOptions.Image = Resources.OperatingSystem_16x16;
        //    btnFolder.ImageOptions.LargeImage = Resources.OperatingSystem_32x32;
        //    btnFolder.ItemClick += (s, be) =>
        //    {
        //        OfflineUCLogs offlineUC = new OfflineUCLogs(new EventLogDataProvider());
        //        offlineUC.SelectedPath = Path.Combine(Environment.ExpandEnvironmentVariables("%SystemRoot%"),
        //            "System32", "Winevt", "Logs");
        //        XtraTabPage page = new XtraTabPage();
        //        page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
        //        page.Tag = ribbonPage;
        //        page.Controls.Add(offlineUC);
        //        offlineUC.Dock = DockStyle.Fill;
        //        page.Text = $"Local Machine logs";
        //        xtcLogs.TabPages.Add(page);
        //        xtcLogs.SelectedTabPage = page;
        //    };
        //    group.ItemLinks.Add(btnFolder);
        //    CreateEventLogsMenu(ribbonPage);
        //}
        private void tsslblError_Click(object sender, EventArgs e)
        {
            AnalogyLogManager.Instance.Show(this);
        }
    }
}
