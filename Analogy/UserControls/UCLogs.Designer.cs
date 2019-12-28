﻿using DevExpress.XtraGrid.Views.Grid;
using Syncfusion.WinForms.Controls;

namespace Analogy
{
    partial class UCLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (DesignMode) return;
            tmrNewData.Stop();
            tmrNewData.Dispose();
            if (disposing)
            {

                if (components != null)
                {
                    components.Dispose();

                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogs));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn21 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn22 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn23 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn24 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.cmsMessageOperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiREmoveAllPreviousMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateFilterNewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateFilterOlder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkPersist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCommentToMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeSource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeModule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOTAFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecreaseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHighlights = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sbtnMoreHighlight = new Syncfusion.WinForms.Controls.SfButton();
            this.pnlButtonsHighlight = new System.Windows.Forms.Panel();
            this.sbtnPageFirst = new Syncfusion.WinForms.Controls.SfButton();
            this.sbtnPagePrevious = new Syncfusion.WinForms.Controls.SfButton();
            this.lblPageNumber = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.sBtnPageNext = new Syncfusion.WinForms.Controls.SfButton();
            this.sBtnLastPage = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbHighlight = new System.Windows.Forms.CheckBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barTopFiltering = new DevExpress.XtraBars.Bar();
            this.bBtnClearLog = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnRemoveBoomark = new DevExpress.XtraBars.BarButtonItem();
            this.btswitchExpand = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btswitchRefreshLog = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsAutoScrollToBottom = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barSubItemSaveEntireLog = new DevExpress.XtraBars.BarSubItem();
            this.bBtnSaveEntireLog = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSaveEntireInAnalogy = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemSaveView = new DevExpress.XtraBars.BarSubItem();
            this.bBtnSaveLog = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSaveViewAgnostic = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bBtnUndockView = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnUndockViewPerProcess = new DevExpress.XtraBars.BarButtonItem();
            this.bbiScreenshot = new DevExpress.XtraBars.BarButtonItem();
            this.bSMExports = new DevExpress.XtraBars.BarSubItem();
            this.bBtnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExportHtml = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnImport = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnDataVisualizer = new DevExpress.XtraBars.BarButtonItem();
            this.bdcTopFiltering = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.BbarMainMenu = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdcMessageBottom = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnExpand = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnButtomExpand = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnCopyButtom = new DevExpress.XtraBars.BarButtonItem();
            this.btSwitchExpandButtomMessage = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.pnlTopFiltering = new System.Windows.Forms.Panel();
            this.spltFilteringBoth = new System.Windows.Forms.SplitContainer();
            this.pnlFilteringLeft = new System.Windows.Forms.Panel();
            this.spltcDateFiltering = new System.Windows.Forms.SplitContainer();
            this.deOlderThanFilter = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.chkDateOlderThan = new System.Windows.Forms.CheckBox();
            this.deNewerThanFilter = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.chkDateNewerThan = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spltcProcessesModule = new System.Windows.Forms.SplitContainer();
            this.cbModule = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnModules = new Syncfusion.WinForms.Controls.SfButton();
            this.sbtnUndockPerProcess = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbModules = new System.Windows.Forms.CheckBox();
            this.spltcSources = new System.Windows.Forms.SplitContainer();
            this.cbSource = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnSources = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbSources = new System.Windows.Forms.CheckBox();
            this.pboxInfoExclude = new System.Windows.Forms.PictureBox();
            this.spltTextExclude = new System.Windows.Forms.SplitContainer();
            this.cbExclude = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnTextExclude = new Syncfusion.WinForms.Controls.SfButton();
            this.sBtnMostCommon = new Syncfusion.WinForms.Controls.SfButton();
            this.chkExclude = new System.Windows.Forms.CheckBox();
            this.spltText = new System.Windows.Forms.SplitContainer();
            this.cbInclude = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnTextInclude = new Syncfusion.WinForms.Controls.SfButton();
            this.chkbIncludeText = new System.Windows.Forms.CheckBox();
            this.pboxInfo = new System.Windows.Forms.PictureBox();
            this.sbtnPreDefinedFilters = new Syncfusion.WinForms.Controls.SfButton();
            this.rbVerbose = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbDebug = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbWarning = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbErrorCritical = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbTrace = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbAllLevel = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.tcBottom = new DevExpress.XtraTab.XtraTabControl();
            this.xtpMessageInfo = new DevExpress.XtraTab.XtraTabPage();
            this.tbMessageInfo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tsMessageInfo = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnMessageInfoCopy = new System.Windows.Forms.ToolStripButton();
            this.xtpBookmarks = new DevExpress.XtraTab.XtraTabPage();
            this.sfDataGridBookmarks = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tsBookmark = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnBookmarkCopySingle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkCopyAll = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkClear = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBookmarkGoToOriginal = new System.Windows.Forms.ToolStripButton();
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrNewData = new System.Windows.Forms.Timer(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpMain = new DevExpress.XtraTab.XtraTabPage();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTotalMessagesAlert = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblTotalMessages = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.xtCounts = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.sfDataGridMain = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.nudGroupBychars = new DevExpress.XtraEditors.SpinEdit();
            this.txtbGroupByCharsLimit = new DevExpress.XtraEditors.TextEdit();
            this.sBtnGroup = new Syncfusion.WinForms.Controls.SfButton();
            this.sBtnLength = new Syncfusion.WinForms.Controls.SfButton();
            this.lblGroupByCharsLimit = new System.Windows.Forms.Label();
            this.lblGroupByChars = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cmsBookmarked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCalcDiffBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkDateFilterNewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkDateFilterOlder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRemoveBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyMessagesBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExcludeBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeSourceBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcludeModuleBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEmailBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOTAFullBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveLayoutBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncreaseFontBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDecreaseFontBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsTopClear = new System.Windows.Forms.ToolStripButton();
            this.tsTopRefresh = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripCheckBox1 = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.cmsMessageOperation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlights)).BeginInit();
            this.pnlButtonsHighlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnlTopFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltFilteringBoth)).BeginInit();
            this.spltFilteringBoth.Panel1.SuspendLayout();
            this.spltFilteringBoth.Panel2.SuspendLayout();
            this.spltFilteringBoth.SuspendLayout();
            this.pnlFilteringLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).BeginInit();
            this.spltcDateFiltering.Panel1.SuspendLayout();
            this.spltcDateFiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).BeginInit();
            this.spltcProcessesModule.Panel1.SuspendLayout();
            this.spltcProcessesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).BeginInit();
            this.spltcSources.Panel1.SuspendLayout();
            this.spltcSources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).BeginInit();
            this.spltTextExclude.Panel1.SuspendLayout();
            this.spltTextExclude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbExclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).BeginInit();
            this.spltText.Panel1.SuspendLayout();
            this.spltText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVerbose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDebug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbErrorCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBottom)).BeginInit();
            this.tcBottom.SuspendLayout();
            this.xtpMessageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessageInfo)).BeginInit();
            this.tsMessageInfo.SuspendLayout();
            this.xtpBookmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBookmarks)).BeginInit();
            this.tsBookmark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupBychars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbGroupByCharsLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.cmsBookmarked.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMessageOperation
            // 
            this.cmsMessageOperation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMessageOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearLog,
            this.tsmiREmoveAllPreviousMessages,
            this.tsmiTimeDiff,
            this.tsmiDateFilterNewer,
            this.tsmiDateFilterOlder,
            this.toolStripSeparator4,
            this.tsmiBookmark,
            this.tsmiBookmarkPersist,
            this.tsmiCopy,
            this.tsmiCopyMessages,
            this.tsmiAddCommentToMessage,
            this.toolStripSeparator2,
            this.tsmiExclude,
            this.tsmiExcludeSource,
            this.tsmiExcludeModule,
            this.toolStripSeparator3,
            this.tsmiEmail,
            this.tsmiOTAFull,
            this.toolStripSeparator1,
            this.tsmiSaveLayout,
            this.tsmiIncreaseFont,
            this.tsmiDecreaseFont});
            this.cmsMessageOperation.Name = "cmsMessageOperation";
            this.cmsMessageOperation.Size = new System.Drawing.Size(416, 496);
            this.cmsMessageOperation.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMessageOperation_Opening);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Image = global::Analogy.Properties.Resources.Delete_16x16;
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(415, 26);
            this.tsmiClearLog.Text = "Clear Log";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // tsmiREmoveAllPreviousMessages
            // 
            this.tsmiREmoveAllPreviousMessages.Image = global::Analogy.Properties.Resources.FitNone_16x16;
            this.tsmiREmoveAllPreviousMessages.Name = "tsmiREmoveAllPreviousMessages";
            this.tsmiREmoveAllPreviousMessages.Size = new System.Drawing.Size(415, 26);
            this.tsmiREmoveAllPreviousMessages.Text = "Remove all messages before selected message";
            this.tsmiREmoveAllPreviousMessages.Click += new System.EventHandler(this.tsmiREmoveAllPreviousMessages_Click);
            // 
            // tsmiTimeDiff
            // 
            this.tsmiTimeDiff.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiTimeDiff.Name = "tsmiTimeDiff";
            this.tsmiTimeDiff.Size = new System.Drawing.Size(415, 26);
            this.tsmiTimeDiff.Text = "Calculate Time Difference from this entry";
            this.tsmiTimeDiff.Click += new System.EventHandler(this.tsmiTimeDiff_Click);
            // 
            // tsmiDateFilterNewer
            // 
            this.tsmiDateFilterNewer.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiDateFilterNewer.Name = "tsmiDateFilterNewer";
            this.tsmiDateFilterNewer.Size = new System.Drawing.Size(415, 26);
            this.tsmiDateFilterNewer.Text = "DateTime filter: After";
            this.tsmiDateFilterNewer.Click += new System.EventHandler(this.tsmiDateFilterNewer_Click);
            // 
            // tsmiDateFilterOlder
            // 
            this.tsmiDateFilterOlder.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiDateFilterOlder.Name = "tsmiDateFilterOlder";
            this.tsmiDateFilterOlder.Size = new System.Drawing.Size(415, 26);
            this.tsmiDateFilterOlder.Text = "DateTime filter: before ";
            this.tsmiDateFilterOlder.Click += new System.EventHandler(this.tsmiDateFilterOlder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiBookmark
            // 
            this.tsmiBookmark.Image = global::Analogy.Properties.Resources.RichEditBookmark_16x16;
            this.tsmiBookmark.Name = "tsmiBookmark";
            this.tsmiBookmark.Size = new System.Drawing.Size(415, 26);
            this.tsmiBookmark.Text = "Bookmark this message (current Analogy instance)";
            this.tsmiBookmark.Click += new System.EventHandler(this.tsmiBookmark_Click);
            // 
            // tsmiBookmarkPersist
            // 
            this.tsmiBookmarkPersist.Image = global::Analogy.Properties.Resources.RichEditBookmark_16x16;
            this.tsmiBookmarkPersist.Name = "tsmiBookmarkPersist";
            this.tsmiBookmarkPersist.Size = new System.Drawing.Size(415, 26);
            this.tsmiBookmarkPersist.Text = "Bookmark this message for later use (persistent)";
            this.tsmiBookmarkPersist.Click += new System.EventHandler(this.tsmiBookmarkPersist_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(415, 26);
            this.tsmiCopy.Text = "Copy selected message to clipboard";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCopyMessages
            // 
            this.tsmiCopyMessages.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyMessages.Name = "tsmiCopyMessages";
            this.tsmiCopyMessages.Size = new System.Drawing.Size(415, 26);
            this.tsmiCopyMessages.Text = "Copy all messages in view to clipboard";
            this.tsmiCopyMessages.Click += new System.EventHandler(this.tsmiCopyMessages_Click);
            // 
            // tsmiAddCommentToMessage
            // 
            this.tsmiAddCommentToMessage.Enabled = false;
            this.tsmiAddCommentToMessage.Image = global::Analogy.Properties.Resources.EditComment_16x16;
            this.tsmiAddCommentToMessage.Name = "tsmiAddCommentToMessage";
            this.tsmiAddCommentToMessage.Size = new System.Drawing.Size(415, 26);
            this.tsmiAddCommentToMessage.Text = "Add message/comment at this timestamp";
            this.tsmiAddCommentToMessage.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiExclude
            // 
            this.tsmiExclude.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExclude.Name = "tsmiExclude";
            this.tsmiExclude.Size = new System.Drawing.Size(415, 26);
            this.tsmiExclude.Text = "Exclude selected message ";
            this.tsmiExclude.Click += new System.EventHandler(this.tsmiExclude_Click);
            // 
            // tsmiExcludeSource
            // 
            this.tsmiExcludeSource.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeSource.Name = "tsmiExcludeSource";
            this.tsmiExcludeSource.Size = new System.Drawing.Size(415, 26);
            this.tsmiExcludeSource.Text = "Exclude Source";
            this.tsmiExcludeSource.Click += new System.EventHandler(this.tsmiExcludeSource_Click);
            // 
            // tsmiExcludeModule
            // 
            this.tsmiExcludeModule.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeModule.Name = "tsmiExcludeModule";
            this.tsmiExcludeModule.Size = new System.Drawing.Size(415, 26);
            this.tsmiExcludeModule.Text = "Exclude Process";
            this.tsmiExcludeModule.Click += new System.EventHandler(this.tsmiExcludeModule_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiEmail
            // 
            this.tsmiEmail.Image = global::Analogy.Properties.Resources.Send_16x16;
            this.tsmiEmail.Name = "tsmiEmail";
            this.tsmiEmail.Size = new System.Drawing.Size(415, 26);
            this.tsmiEmail.Text = "Send selected message by mail";
            this.tsmiEmail.Click += new System.EventHandler(this.tsmiEmail_Click);
            // 
            // tsmiOTAFull
            // 
            this.tsmiOTAFull.Enabled = false;
            this.tsmiOTAFull.Image = global::Analogy.Properties.Resources.logIcon;
            this.tsmiOTAFull.Name = "tsmiOTAFull";
            this.tsmiOTAFull.Size = new System.Drawing.Size(415, 26);
            this.tsmiOTAFull.Text = "Send Log to another Analogy";
            this.tsmiOTAFull.Visible = false;
            this.tsmiOTAFull.Click += new System.EventHandler(this.tsmiOTAFull_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmiSaveLayout
            // 
            this.tsmiSaveLayout.Image = global::Analogy.Properties.Resources.Save_16x16;
            this.tsmiSaveLayout.Name = "tsmiSaveLayout";
            this.tsmiSaveLayout.Size = new System.Drawing.Size(415, 26);
            this.tsmiSaveLayout.Text = "Save columns layout";
            this.tsmiSaveLayout.Click += new System.EventHandler(this.tsmiSaveLayout_Click);
            // 
            // tsmiIncreaseFont
            // 
            this.tsmiIncreaseFont.Image = global::Analogy.Properties.Resources.IncreaseFontSize_16x16;
            this.tsmiIncreaseFont.Name = "tsmiIncreaseFont";
            this.tsmiIncreaseFont.Size = new System.Drawing.Size(415, 26);
            this.tsmiIncreaseFont.Text = "Increase Font Size";
            this.tsmiIncreaseFont.Click += new System.EventHandler(this.tsmiIncreaseFont_Click);
            // 
            // tsmiDecreaseFont
            // 
            this.tsmiDecreaseFont.Image = global::Analogy.Properties.Resources.DecreaseFontSize_16x16;
            this.tsmiDecreaseFont.Name = "tsmiDecreaseFont";
            this.tsmiDecreaseFont.Size = new System.Drawing.Size(415, 26);
            this.tsmiDecreaseFont.Text = "Decrease Font Size";
            this.tsmiDecreaseFont.Click += new System.EventHandler(this.tsmiDecreaseFont_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Error_16x16.png");
            this.imageList.Images.SetKeyName(1, "Warning_16x16.png");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "folder32x32.gif");
            this.imageList.Images.SetKeyName(4, "Error_32x32.png");
            this.imageList.Images.SetKeyName(5, "Warning_32x32.png");
            this.imageList.Images.SetKeyName(6, "debug.gif");
            this.imageList.Images.SetKeyName(7, "New_16x16.png");
            this.imageList.Images.SetKeyName(8, "log16x16.ico");
            this.imageList.Images.SetKeyName(9, "Question_16x16.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHighlights);
            this.panel1.Controls.Add(this.sbtnMoreHighlight);
            this.panel1.Controls.Add(this.pnlButtonsHighlight);
            this.panel1.Controls.Add(this.chkbHighlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2124, 26);
            this.panel1.TabIndex = 4;
            // 
            // cbHighlights
            // 
            this.cbHighlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHighlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Location = new System.Drawing.Point(200, 0);
            this.cbHighlights.Margin = new System.Windows.Forms.Padding(4);
            this.cbHighlights.Name = "cbHighlights";
            this.cbHighlights.Size = new System.Drawing.Size(1330, 26);
            this.cbHighlights.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHighlights.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHighlights.TabIndex = 44;
            // 
            // sbtnMoreHighlight
            // 
            this.sbtnMoreHighlight.AccessibleName = "Button";
            this.sbtnMoreHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnMoreHighlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnMoreHighlight.Location = new System.Drawing.Point(1530, 0);
            this.sbtnMoreHighlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnMoreHighlight.Name = "sbtnMoreHighlight";
            this.sbtnMoreHighlight.Size = new System.Drawing.Size(83, 26);
            this.sbtnMoreHighlight.TabIndex = 43;
            this.sbtnMoreHighlight.Text = "More ...";
            this.sbtnMoreHighlight.Click += new System.EventHandler(this.sbtnMoreHighlight_Click);
            // 
            // pnlButtonsHighlight
            // 
            this.pnlButtonsHighlight.Controls.Add(this.sbtnPageFirst);
            this.pnlButtonsHighlight.Controls.Add(this.sbtnPagePrevious);
            this.pnlButtonsHighlight.Controls.Add(this.lblPageNumber);
            this.pnlButtonsHighlight.Controls.Add(this.sBtnPageNext);
            this.pnlButtonsHighlight.Controls.Add(this.sBtnLastPage);
            this.pnlButtonsHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonsHighlight.Location = new System.Drawing.Point(1613, 0);
            this.pnlButtonsHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonsHighlight.Name = "pnlButtonsHighlight";
            this.pnlButtonsHighlight.Size = new System.Drawing.Size(511, 26);
            this.pnlButtonsHighlight.TabIndex = 12;
            // 
            // sbtnPageFirst
            // 
            this.sbtnPageFirst.AccessibleName = "Button";
            this.sbtnPageFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnPageFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnPageFirst.Location = new System.Drawing.Point(23, 0);
            this.sbtnPageFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnPageFirst.Name = "sbtnPageFirst";
            this.sbtnPageFirst.Size = new System.Drawing.Size(87, 26);
            this.sbtnPageFirst.TabIndex = 42;
            this.sbtnPageFirst.Text = "First Page ";
            this.sbtnPageFirst.Click += new System.EventHandler(this.sbtnPageFirst_Click);
            // 
            // sbtnPagePrevious
            // 
            this.sbtnPagePrevious.AccessibleName = "Button";
            this.sbtnPagePrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnPagePrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnPagePrevious.Location = new System.Drawing.Point(110, 0);
            this.sbtnPagePrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtnPagePrevious.Name = "sbtnPagePrevious";
            this.sbtnPagePrevious.Size = new System.Drawing.Size(128, 26);
            this.sbtnPagePrevious.TabIndex = 43;
            this.sbtnPagePrevious.Text = "previous page";
            this.sbtnPagePrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sbtnPagePrevious.Click += new System.EventHandler(this.sbtnPagePrevious_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblPageNumber.BeforeTouchSize = new System.Drawing.Size(103, 26);
            this.lblPageNumber.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPageNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPageNumber.Location = new System.Drawing.Point(238, 0);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(103, 26);
            this.lblPageNumber.TabIndex = 6;
            this.lblPageNumber.Text = "Page 1 / 1";
            this.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sBtnPageNext
            // 
            this.sBtnPageNext.AccessibleName = "Button";
            this.sBtnPageNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnPageNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnPageNext.Location = new System.Drawing.Point(341, 0);
            this.sBtnPageNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnPageNext.Name = "sBtnPageNext";
            this.sBtnPageNext.Size = new System.Drawing.Size(87, 26);
            this.sBtnPageNext.TabIndex = 45;
            this.sBtnPageNext.Text = "Next Page";
            this.sBtnPageNext.Click += new System.EventHandler(this.sBtnPageNext_Click);
            // 
            // sBtnLastPage
            // 
            this.sBtnLastPage.AccessibleName = "Button";
            this.sBtnLastPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnLastPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnLastPage.Location = new System.Drawing.Point(428, 0);
            this.sBtnLastPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sBtnLastPage.Name = "sBtnLastPage";
            this.sBtnLastPage.Size = new System.Drawing.Size(83, 26);
            this.sBtnLastPage.TabIndex = 44;
            this.sBtnLastPage.Text = "Last Page";
            this.sBtnLastPage.Click += new System.EventHandler(this.sBtnLastPage_Click);
            // 
            // chkbHighlight
            // 
            this.chkbHighlight.AutoSize = true;
            this.chkbHighlight.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbHighlight.Location = new System.Drawing.Point(0, 0);
            this.chkbHighlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbHighlight.Name = "chkbHighlight";
            this.chkbHighlight.Size = new System.Drawing.Size(200, 26);
            this.chkbHighlight.TabIndex = 11;
            this.chkbHighlight.Text = "Highlight lines that contains:";
            this.chkbHighlight.UseVisualStyleBackColor = true;
            this.chkbHighlight.CheckedChanged += new System.EventHandler(this.chkbHighlight_CheckedChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTopFiltering,
            this.BbarMainMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.bdcTopFiltering);
            this.barManager1.DockControls.Add(this.bdcMessageBottom);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btswitchExpand,
            this.btswitchRefreshLog,
            this.bBtnSaveLog,
            this.bBtnImport,
            this.bBtnClearLog,
            this.bBtnExpand,
            this.barButtonItem3,
            this.bBtnButtomExpand,
            this.bBtnCopyButtom,
            this.btSwitchExpandButtomMessage,
            this.bBtnRemoveBoomark,
            this.btsAutoScrollToBottom,
            this.bSMExports,
            this.bBtnExportExcel,
            this.bBtnExportCSV,
            this.bBtnExportHtml,
            this.bBtnUndockView,
            this.bBtnSaveEntireLog,
            this.bBtnDataVisualizer,
            this.bbiScreenshot,
            this.barSubItemSaveView,
            this.bbtnSaveViewAgnostic,
            this.barSubItemSaveEntireLog,
            this.barButtonItemSaveEntireInAnalogy,
            this.barSubItem1,
            this.bBtnUndockViewPerProcess});
            this.barManager1.MainMenu = this.BbarMainMenu;
            this.barManager1.MaxItemId = 36;
            // 
            // barTopFiltering
            // 
            this.barTopFiltering.BarName = "Log Operations";
            this.barTopFiltering.DockCol = 0;
            this.barTopFiltering.DockRow = 0;
            this.barTopFiltering.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barTopFiltering.FloatLocation = new System.Drawing.Point(192, 279);
            this.barTopFiltering.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnClearLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnRemoveBoomark),
            new DevExpress.XtraBars.LinkPersistInfo(this.btswitchExpand),
            new DevExpress.XtraBars.LinkPersistInfo(this.btswitchRefreshLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsAutoScrollToBottom),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSaveEntireLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSaveView),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiScreenshot),
            new DevExpress.XtraBars.LinkPersistInfo(this.bSMExports),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnImport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnDataVisualizer)});
            this.barTopFiltering.OptionsBar.AllowQuickCustomization = false;
            this.barTopFiltering.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barTopFiltering.OptionsBar.DisableClose = true;
            this.barTopFiltering.OptionsBar.DisableCustomization = true;
            this.barTopFiltering.OptionsBar.UseWholeRow = true;
            this.barTopFiltering.StandaloneBarDockControl = this.bdcTopFiltering;
            this.barTopFiltering.Text = "Operations";
            // 
            // bBtnClearLog
            // 
            this.bBtnClearLog.Caption = "Clear Log";
            this.bBtnClearLog.Id = 6;
            this.bBtnClearLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnClearLog.ImageOptions.Image")));
            this.bBtnClearLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnClearLog.ImageOptions.LargeImage")));
            this.bBtnClearLog.Name = "bBtnClearLog";
            this.bBtnClearLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnClearLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnClearLog_ItemClick);
            // 
            // bBtnRemoveBoomark
            // 
            this.bBtnRemoveBoomark.Caption = "Delete message";
            this.bBtnRemoveBoomark.Id = 15;
            this.bBtnRemoveBoomark.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnRemoveBoomark.ImageOptions.Image")));
            this.bBtnRemoveBoomark.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnRemoveBoomark.ImageOptions.LargeImage")));
            this.bBtnRemoveBoomark.Name = "bBtnRemoveBoomark";
            this.bBtnRemoveBoomark.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnRemoveBoomark.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnRemoveBoomark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnRemoveBoomark_ItemClick);
            // 
            // btswitchExpand
            // 
            this.btswitchExpand.Caption = "Expand";
            this.btswitchExpand.Id = 2;
            this.btswitchExpand.Name = "btswitchExpand";
            this.btswitchExpand.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btswitchExpand_CheckedChanged);
            // 
            // btswitchRefreshLog
            // 
            this.btswitchRefreshLog.Caption = "Refresh log:";
            this.btswitchRefreshLog.Id = 3;
            this.btswitchRefreshLog.Name = "btswitchRefreshLog";
            this.btswitchRefreshLog.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btswitchRefreshLog_CheckedChanged);
            // 
            // btsAutoScrollToBottom
            // 
            this.btsAutoScrollToBottom.Caption = "Auto Scroll to bottom:";
            this.btsAutoScrollToBottom.Id = 18;
            this.btsAutoScrollToBottom.Name = "btsAutoScrollToBottom";
            this.btsAutoScrollToBottom.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsAutoScrollToBottom_CheckedChanged);
            // 
            // barSubItemSaveEntireLog
            // 
            this.barSubItemSaveEntireLog.Caption = "Save Entire Log";
            this.barSubItemSaveEntireLog.Id = 31;
            this.barSubItemSaveEntireLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveEntireLog.ImageOptions.Image")));
            this.barSubItemSaveEntireLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveEntireLog.ImageOptions.LargeImage")));
            this.barSubItemSaveEntireLog.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveEntireLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSaveEntireInAnalogy)});
            this.barSubItemSaveEntireLog.Name = "barSubItemSaveEntireLog";
            this.barSubItemSaveEntireLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnSaveEntireLog
            // 
            this.bBtnSaveEntireLog.Caption = "Save Entire Log (custom Format)";
            this.bBtnSaveEntireLog.Id = 25;
            this.bBtnSaveEntireLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveEntireLog.ImageOptions.Image")));
            this.bBtnSaveEntireLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveEntireLog.ImageOptions.LargeImage")));
            this.bBtnSaveEntireLog.Name = "bBtnSaveEntireLog";
            this.bBtnSaveEntireLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnSaveEntireLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveEntireLog_ItemClick);
            // 
            // barButtonItemSaveEntireInAnalogy
            // 
            this.barButtonItemSaveEntireInAnalogy.Caption = "Save Entire Log in Analogy Format (agnostic to specific implementation)";
            this.barButtonItemSaveEntireInAnalogy.Id = 32;
            this.barButtonItemSaveEntireInAnalogy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveEntireInAnalogy.ImageOptions.Image")));
            this.barButtonItemSaveEntireInAnalogy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSaveEntireInAnalogy.ImageOptions.LargeImage")));
            this.barButtonItemSaveEntireInAnalogy.Name = "barButtonItemSaveEntireInAnalogy";
            this.barButtonItemSaveEntireInAnalogy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemSaveEntireInAnalogy_ItemClick);
            // 
            // barSubItemSaveView
            // 
            this.barSubItemSaveView.Caption = "Save Current View";
            this.barSubItemSaveView.Id = 29;
            this.barSubItemSaveView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveView.ImageOptions.Image")));
            this.barSubItemSaveView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItemSaveView.ImageOptions.LargeImage")));
            this.barSubItemSaveView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnSaveLog),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnSaveViewAgnostic)});
            this.barSubItemSaveView.Name = "barSubItemSaveView";
            this.barSubItemSaveView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnSaveLog
            // 
            this.bBtnSaveLog.Caption = "Save Current View (custom Format)";
            this.bBtnSaveLog.Id = 4;
            this.bBtnSaveLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnSaveLog.ImageOptions.Image")));
            this.bBtnSaveLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnSaveLog.ImageOptions.LargeImage")));
            this.bBtnSaveLog.Name = "bBtnSaveLog";
            this.bBtnSaveLog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnSaveLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnSaveLog_ItemClick);
            // 
            // bbtnSaveViewAgnostic
            // 
            this.bbtnSaveViewAgnostic.Caption = "Save Current View in Analogy Format (agnostic to Specific implementation)";
            this.bbtnSaveViewAgnostic.Id = 30;
            this.bbtnSaveViewAgnostic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSaveViewAgnostic.ImageOptions.Image")));
            this.bbtnSaveViewAgnostic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSaveViewAgnostic.ImageOptions.LargeImage")));
            this.bbtnSaveViewAgnostic.Name = "bbtnSaveViewAgnostic";
            this.bbtnSaveViewAgnostic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbtnSaveViewAgnostic_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Undock View";
            this.barSubItem1.Id = 34;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnUndockView),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnUndockViewPerProcess)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnUndockView
            // 
            this.bBtnUndockView.Caption = "Undock View (No Filtering)";
            this.bBtnUndockView.Id = 24;
            this.bBtnUndockView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnUndockView.ImageOptions.Image")));
            this.bBtnUndockView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnUndockView.ImageOptions.LargeImage")));
            this.bBtnUndockView.Name = "bBtnUndockView";
            this.bBtnUndockView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnUndockView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUndockView_ItemClick);
            // 
            // bBtnUndockViewPerProcess
            // 
            this.bBtnUndockViewPerProcess.Caption = "Undock View per process/Module";
            this.bBtnUndockViewPerProcess.Id = 35;
            this.bBtnUndockViewPerProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnUndockViewPerProcess.ImageOptions.Image")));
            this.bBtnUndockViewPerProcess.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnUndockViewPerProcess.ImageOptions.LargeImage")));
            this.bBtnUndockViewPerProcess.Name = "bBtnUndockViewPerProcess";
            this.bBtnUndockViewPerProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnUndockViewPerProcess_ItemClick);
            // 
            // bbiScreenshot
            // 
            this.bbiScreenshot.Caption = "Take screenshot";
            this.bbiScreenshot.Hint = "Take screenshot of the messages control";
            this.bbiScreenshot.Id = 27;
            this.bbiScreenshot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiScreenshot.ImageOptions.Image")));
            this.bbiScreenshot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiScreenshot.ImageOptions.LargeImage")));
            this.bbiScreenshot.Name = "bbiScreenshot";
            this.bbiScreenshot.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiScreenshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiScreenshot_ItemClick);
            // 
            // bSMExports
            // 
            this.bSMExports.Caption = "Export";
            this.bSMExports.Id = 20;
            this.bSMExports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bSMExports.ImageOptions.Image")));
            this.bSMExports.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bSMExports.ImageOptions.LargeImage")));
            this.bSMExports.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bBtnExportExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnExportCSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.bBtnExportHtml)});
            this.bSMExports.Name = "bSMExports";
            this.bSMExports.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnExportExcel
            // 
            this.bBtnExportExcel.Caption = "Export To Excel";
            this.bBtnExportExcel.Id = 21;
            this.bBtnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportExcel.ImageOptions.Image")));
            this.bBtnExportExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportExcel.ImageOptions.LargeImage")));
            this.bBtnExportExcel.Name = "bBtnExportExcel";
            this.bBtnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportExcel_ItemClick);
            // 
            // bBtnExportCSV
            // 
            this.bBtnExportCSV.Caption = "Export To CSV";
            this.bBtnExportCSV.Id = 22;
            this.bBtnExportCSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportCSV.ImageOptions.Image")));
            this.bBtnExportCSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportCSV.ImageOptions.LargeImage")));
            this.bBtnExportCSV.Name = "bBtnExportCSV";
            this.bBtnExportCSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportCSV_ItemClick);
            // 
            // bBtnExportHtml
            // 
            this.bBtnExportHtml.Caption = "Export To Html";
            this.bBtnExportHtml.Id = 23;
            this.bBtnExportHtml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExportHtml.ImageOptions.Image")));
            this.bBtnExportHtml.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExportHtml.ImageOptions.LargeImage")));
            this.bBtnExportHtml.Name = "bBtnExportHtml";
            this.bBtnExportHtml.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnExportHtml.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnExportHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnExportHtml_ItemClick);
            // 
            // bBtnImport
            // 
            this.bBtnImport.Caption = "Import Log";
            this.bBtnImport.Id = 5;
            this.bBtnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnImport.ImageOptions.Image")));
            this.bBtnImport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnImport.ImageOptions.LargeImage")));
            this.bBtnImport.Name = "bBtnImport";
            this.bBtnImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnImport_ItemClick);
            // 
            // bBtnDataVisualizer
            // 
            this.bBtnDataVisualizer.Caption = "Data Visualizer";
            this.bBtnDataVisualizer.Id = 26;
            this.bBtnDataVisualizer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnDataVisualizer.ImageOptions.Image")));
            this.bBtnDataVisualizer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnDataVisualizer.ImageOptions.LargeImage")));
            this.bBtnDataVisualizer.Name = "bBtnDataVisualizer";
            this.bBtnDataVisualizer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnDataVisualizer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bBtnDataVisualizer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnDataVisualizer_ItemClick);
            // 
            // bdcTopFiltering
            // 
            this.bdcTopFiltering.CausesValidation = false;
            this.bdcTopFiltering.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdcTopFiltering.Location = new System.Drawing.Point(0, 0);
            this.bdcTopFiltering.Manager = this.barManager1;
            this.bdcTopFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdcTopFiltering.Name = "bdcTopFiltering";
            this.bdcTopFiltering.Size = new System.Drawing.Size(2124, 38);
            this.bdcTopFiltering.Text = "standaloneBarDockControl1";
            // 
            // BbarMainMenu
            // 
            this.BbarMainMenu.BarName = "Main menu";
            this.BbarMainMenu.DockCol = 0;
            this.BbarMainMenu.DockRow = 0;
            this.BbarMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BbarMainMenu.FloatLocation = new System.Drawing.Point(258, 133);
            this.BbarMainMenu.OptionsBar.MultiLine = true;
            this.BbarMainMenu.OptionsBar.UseWholeRow = true;
            this.BbarMainMenu.Text = "Main menu";
            this.BbarMainMenu.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(2131, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 759);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(2131, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 739);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2131, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 739);
            // 
            // bdcMessageBottom
            // 
            this.bdcMessageBottom.AutoSize = true;
            this.bdcMessageBottom.CausesValidation = false;
            this.bdcMessageBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.bdcMessageBottom.Location = new System.Drawing.Point(0, 0);
            this.bdcMessageBottom.Manager = this.barManager1;
            this.bdcMessageBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdcMessageBottom.Name = "bdcMessageBottom";
            this.bdcMessageBottom.Size = new System.Drawing.Size(2117, 0);
            this.bdcMessageBottom.Text = "standaloneBarDockControl2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bBtnExpand
            // 
            this.bBtnExpand.Caption = "Expand";
            this.bBtnExpand.Id = 7;
            this.bBtnExpand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnExpand.ImageOptions.Image")));
            this.bBtnExpand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnExpand.ImageOptions.LargeImage")));
            this.bBtnExpand.Name = "bBtnExpand";
            this.bBtnExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Copy";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bBtnButtomExpand
            // 
            this.bBtnButtomExpand.Caption = "Expand";
            this.bBtnButtomExpand.Id = 9;
            this.bBtnButtomExpand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnButtomExpand.ImageOptions.Image")));
            this.bBtnButtomExpand.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnButtomExpand.ImageOptions.LargeImage")));
            this.bBtnButtomExpand.Name = "bBtnButtomExpand";
            this.bBtnButtomExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnButtomExpand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnButtomExpand_ItemClick);
            // 
            // bBtnCopyButtom
            // 
            this.bBtnCopyButtom.Caption = "Copy";
            this.bBtnCopyButtom.Id = 10;
            this.bBtnCopyButtom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnCopyButtom.ImageOptions.Image")));
            this.bBtnCopyButtom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnCopyButtom.ImageOptions.LargeImage")));
            this.bBtnCopyButtom.Name = "bBtnCopyButtom";
            this.bBtnCopyButtom.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bBtnCopyButtom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnCopyButtom_ItemClick);
            // 
            // btSwitchExpandButtomMessage
            // 
            this.btSwitchExpandButtomMessage.Caption = "Expand";
            this.btSwitchExpandButtomMessage.Id = 11;
            this.btSwitchExpandButtomMessage.Name = "btSwitchExpandButtomMessage";
            this.btSwitchExpandButtomMessage.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleSwitchItem1_CheckedChanged);
            // 
            // pnlTopFiltering
            // 
            this.pnlTopFiltering.Controls.Add(this.spltFilteringBoth);
            this.pnlTopFiltering.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFiltering.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopFiltering.Name = "pnlTopFiltering";
            this.pnlTopFiltering.Size = new System.Drawing.Size(2124, 153);
            this.pnlTopFiltering.TabIndex = 3;
            // 
            // spltFilteringBoth
            // 
            this.spltFilteringBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltFilteringBoth.Location = new System.Drawing.Point(0, 0);
            this.spltFilteringBoth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltFilteringBoth.Name = "spltFilteringBoth";
            // 
            // spltFilteringBoth.Panel1
            // 
            this.spltFilteringBoth.Panel1.Controls.Add(this.pnlFilteringLeft);
            // 
            // spltFilteringBoth.Panel2
            // 
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbVerbose);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbDebug);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbWarning);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbErrorCritical);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbTrace);
            this.spltFilteringBoth.Panel2.Controls.Add(this.rbAllLevel);
            this.spltFilteringBoth.Panel2MinSize = 150;
            this.spltFilteringBoth.Size = new System.Drawing.Size(2124, 153);
            this.spltFilteringBoth.SplitterDistance = 1881;
            this.spltFilteringBoth.SplitterWidth = 3;
            this.spltFilteringBoth.TabIndex = 19;
            // 
            // pnlFilteringLeft
            // 
            this.pnlFilteringLeft.Controls.Add(this.spltcDateFiltering);
            this.pnlFilteringLeft.Controls.Add(this.spltcProcessesModule);
            this.pnlFilteringLeft.Controls.Add(this.spltcSources);
            this.pnlFilteringLeft.Controls.Add(this.spltTextExclude);
            this.pnlFilteringLeft.Controls.Add(this.spltText);
            this.pnlFilteringLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilteringLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlFilteringLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilteringLeft.Name = "pnlFilteringLeft";
            this.pnlFilteringLeft.Size = new System.Drawing.Size(1881, 153);
            this.pnlFilteringLeft.TabIndex = 20;
            // 
            // spltcDateFiltering
            // 
            this.spltcDateFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcDateFiltering.Location = new System.Drawing.Point(3, 124);
            this.spltcDateFiltering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcDateFiltering.Name = "spltcDateFiltering";
            // 
            // spltcDateFiltering.Panel1
            // 
            this.spltcDateFiltering.Panel1.Controls.Add(this.deOlderThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.chkDateOlderThan);
            this.spltcDateFiltering.Panel1.Controls.Add(this.deNewerThanFilter);
            this.spltcDateFiltering.Panel1.Controls.Add(this.chkDateNewerThan);
            this.spltcDateFiltering.Panel1.Controls.Add(this.pictureBox1);
            this.spltcDateFiltering.Panel2Collapsed = true;
            this.spltcDateFiltering.Size = new System.Drawing.Size(1871, 25);
            this.spltcDateFiltering.SplitterDistance = 683;
            this.spltcDateFiltering.SplitterWidth = 3;
            this.spltcDateFiltering.TabIndex = 27;
            // 
            // deOlderThanFilter
            // 
            this.deOlderThanFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.deOlderThanFilter.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.deOlderThanFilter.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.deOlderThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deOlderThanFilter.Format = "yyyy.MM.dd HH:mm:ss.ff";
            this.deOlderThanFilter.Location = new System.Drawing.Point(579, 0);
            this.deOlderThanFilter.Name = "deOlderThanFilter";
            this.deOlderThanFilter.Size = new System.Drawing.Size(235, 25);
            this.deOlderThanFilter.TabIndex = 28;
            // 
            // chkDateOlderThan
            // 
            this.chkDateOlderThan.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDateOlderThan.Location = new System.Drawing.Point(467, 0);
            this.chkDateOlderThan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDateOlderThan.Name = "chkDateOlderThan";
            this.chkDateOlderThan.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.chkDateOlderThan.Size = new System.Drawing.Size(112, 25);
            this.chkDateOlderThan.TabIndex = 26;
            this.chkDateOlderThan.Text = "And:";
            this.chkDateOlderThan.UseVisualStyleBackColor = true;
            this.chkDateOlderThan.CheckedChanged += new System.EventHandler(this.chkDateOlderThan_CheckedChanged);
            // 
            // deNewerThanFilter
            // 
            this.deNewerThanFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.deNewerThanFilter.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.deNewerThanFilter.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.deNewerThanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.deNewerThanFilter.Format = "yyyy.MM.dd HH:mm:ss.ff";
            this.deNewerThanFilter.Location = new System.Drawing.Point(232, 0);
            this.deNewerThanFilter.Name = "deNewerThanFilter";
            this.deNewerThanFilter.Size = new System.Drawing.Size(235, 25);
            this.deNewerThanFilter.TabIndex = 27;
            // 
            // chkDateNewerThan
            // 
            this.chkDateNewerThan.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkDateNewerThan.Location = new System.Drawing.Point(19, 0);
            this.chkDateNewerThan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDateNewerThan.Name = "chkDateNewerThan";
            this.chkDateNewerThan.Size = new System.Drawing.Size(213, 25);
            this.chkDateNewerThan.TabIndex = 23;
            this.chkDateNewerThan.Text = "Time between:";
            this.chkDateNewerThan.UseVisualStyleBackColor = true;
            this.chkDateNewerThan.CheckedChanged += new System.EventHandler(this.chkDateNewerThan_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 25);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // spltcProcessesModule
            // 
            this.spltcProcessesModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcProcessesModule.Location = new System.Drawing.Point(7, 94);
            this.spltcProcessesModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcProcessesModule.Name = "spltcProcessesModule";
            // 
            // spltcProcessesModule.Panel1
            // 
            this.spltcProcessesModule.Panel1.Controls.Add(this.cbModule);
            this.spltcProcessesModule.Panel1.Controls.Add(this.btnModules);
            this.spltcProcessesModule.Panel1.Controls.Add(this.sbtnUndockPerProcess);
            this.spltcProcessesModule.Panel1.Controls.Add(this.chkbModules);
            this.spltcProcessesModule.Panel2Collapsed = true;
            this.spltcProcessesModule.Size = new System.Drawing.Size(1871, 25);
            this.spltcProcessesModule.SplitterDistance = 574;
            this.spltcProcessesModule.SplitterWidth = 3;
            this.spltcProcessesModule.TabIndex = 26;
            // 
            // cbModule
            // 
            this.cbModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Location = new System.Drawing.Point(275, 0);
            this.cbModule.Margin = new System.Windows.Forms.Padding(4);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(1331, 25);
            this.cbModule.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbModule.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModule.TabIndex = 27;
            // 
            // btnModules
            // 
            this.btnModules.AccessibleName = "Button";
            this.btnModules.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnModules.Location = new System.Drawing.Point(1606, 0);
            this.btnModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(23, 25);
            this.btnModules.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnModules.TabIndex = 24;
            // 
            // sbtnUndockPerProcess
            // 
            this.sbtnUndockPerProcess.AccessibleName = "Button";
            this.sbtnUndockPerProcess.AutoSize = true;
            this.sbtnUndockPerProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnUndockPerProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnUndockPerProcess.Location = new System.Drawing.Point(1629, 0);
            this.sbtnUndockPerProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnUndockPerProcess.Name = "sbtnUndockPerProcess";
            this.sbtnUndockPerProcess.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sbtnUndockPerProcess.Size = new System.Drawing.Size(242, 25);
            this.sbtnUndockPerProcess.TabIndex = 24;
            this.sbtnUndockPerProcess.Text = "Split view per Process/Module";
            this.sbtnUndockPerProcess.Click += new System.EventHandler(this.sbtnUndockPerProcess_Click);
            // 
            // chkbModules
            // 
            this.chkbModules.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbModules.Location = new System.Drawing.Point(0, 0);
            this.chkbModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModules.Name = "chkbModules";
            this.chkbModules.Size = new System.Drawing.Size(275, 25);
            this.chkbModules.TabIndex = 25;
            this.chkbModules.Text = "Include/Exclude Processes/Modules:";
            this.chkbModules.UseVisualStyleBackColor = true;
            // 
            // spltcSources
            // 
            this.spltcSources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltcSources.Location = new System.Drawing.Point(7, 65);
            this.spltcSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltcSources.Name = "spltcSources";
            // 
            // spltcSources.Panel1
            // 
            this.spltcSources.Panel1.Controls.Add(this.cbSource);
            this.spltcSources.Panel1.Controls.Add(this.btnSources);
            this.spltcSources.Panel1.Controls.Add(this.chkbSources);
            this.spltcSources.Panel1.Controls.Add(this.pboxInfoExclude);
            this.spltcSources.Panel2Collapsed = true;
            this.spltcSources.Size = new System.Drawing.Size(1871, 25);
            this.spltcSources.SplitterDistance = 683;
            this.spltcSources.SplitterWidth = 3;
            this.spltcSources.TabIndex = 25;
            // 
            // cbSource
            // 
            this.cbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Location = new System.Drawing.Point(228, 0);
            this.cbSource.Margin = new System.Windows.Forms.Padding(4);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(1620, 25);
            this.cbSource.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSource.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.TabIndex = 27;
            // 
            // btnSources
            // 
            this.btnSources.AccessibleName = "Button";
            this.btnSources.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSources.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSources.Location = new System.Drawing.Point(1848, 0);
            this.btnSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(23, 25);
            this.btnSources.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnSources.TabIndex = 24;
            // 
            // chkbSources
            // 
            this.chkbSources.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbSources.Location = new System.Drawing.Point(19, 0);
            this.chkbSources.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbSources.Name = "chkbSources";
            this.chkbSources.Size = new System.Drawing.Size(209, 25);
            this.chkbSources.TabIndex = 23;
            this.chkbSources.Text = "Include/Exclude Sources:";
            this.chkbSources.UseVisualStyleBackColor = true;
            // 
            // pboxInfoExclude
            // 
            this.pboxInfoExclude.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxInfoExclude.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pboxInfoExclude.Location = new System.Drawing.Point(0, 0);
            this.pboxInfoExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxInfoExclude.Name = "pboxInfoExclude";
            this.pboxInfoExclude.Size = new System.Drawing.Size(19, 25);
            this.pboxInfoExclude.TabIndex = 15;
            this.pboxInfoExclude.TabStop = false;
            // 
            // spltTextExclude
            // 
            this.spltTextExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltTextExclude.Location = new System.Drawing.Point(7, 37);
            this.spltTextExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltTextExclude.Name = "spltTextExclude";
            // 
            // spltTextExclude.Panel1
            // 
            this.spltTextExclude.Panel1.Controls.Add(this.cbExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.btnTextExclude);
            this.spltTextExclude.Panel1.Controls.Add(this.sBtnMostCommon);
            this.spltTextExclude.Panel1.Controls.Add(this.chkExclude);
            this.spltTextExclude.Panel2Collapsed = true;
            this.spltTextExclude.Size = new System.Drawing.Size(1871, 25);
            this.spltTextExclude.SplitterDistance = 998;
            this.spltTextExclude.SplitterWidth = 3;
            this.spltTextExclude.TabIndex = 24;
            // 
            // cbExclude
            // 
            this.cbExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Location = new System.Drawing.Point(127, 0);
            this.cbExclude.Margin = new System.Windows.Forms.Padding(4);
            this.cbExclude.Name = "cbExclude";
            this.cbExclude.Size = new System.Drawing.Size(1601, 25);
            this.cbExclude.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbExclude.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclude.TabIndex = 27;
            // 
            // btnTextExclude
            // 
            this.btnTextExclude.AccessibleName = "Button";
            this.btnTextExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextExclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextExclude.Location = new System.Drawing.Point(1728, 0);
            this.btnTextExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextExclude.Name = "btnTextExclude";
            this.btnTextExclude.Size = new System.Drawing.Size(23, 25);
            this.btnTextExclude.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnTextExclude.TabIndex = 20;
            // 
            // sBtnMostCommon
            // 
            this.sBtnMostCommon.AccessibleName = "Button";
            this.sBtnMostCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.sBtnMostCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnMostCommon.Location = new System.Drawing.Point(1751, 0);
            this.sBtnMostCommon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnMostCommon.Name = "sBtnMostCommon";
            this.sBtnMostCommon.Size = new System.Drawing.Size(120, 25);
            this.sBtnMostCommon.TabIndex = 8;
            this.sBtnMostCommon.Text = "Most Common";
            this.sBtnMostCommon.Click += new System.EventHandler(this.sBtnMostCommon_Click);
            // 
            // chkExclude
            // 
            this.chkExclude.AutoSize = true;
            this.chkExclude.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkExclude.Location = new System.Drawing.Point(0, 0);
            this.chkExclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExclude.Name = "chkExclude";
            this.chkExclude.Size = new System.Drawing.Size(127, 25);
            this.chkExclude.TabIndex = 10;
            this.chkExclude.Text = "Exclude Text:   ";
            this.chkExclude.UseVisualStyleBackColor = true;
            this.chkExclude.CheckedChanged += new System.EventHandler(this.chkbExclude_CheckedChanged);
            // 
            // spltText
            // 
            this.spltText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltText.Location = new System.Drawing.Point(7, 7);
            this.spltText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltText.Name = "spltText";
            // 
            // spltText.Panel1
            // 
            this.spltText.Panel1.Controls.Add(this.cbInclude);
            this.spltText.Panel1.Controls.Add(this.btnTextInclude);
            this.spltText.Panel1.Controls.Add(this.chkbIncludeText);
            this.spltText.Panel1.Controls.Add(this.pboxInfo);
            this.spltText.Panel1.Controls.Add(this.sbtnPreDefinedFilters);
            this.spltText.Panel2Collapsed = true;
            this.spltText.Size = new System.Drawing.Size(1871, 25);
            this.spltText.SplitterDistance = 998;
            this.spltText.SplitterWidth = 3;
            this.spltText.TabIndex = 22;
            // 
            // cbInclude
            // 
            this.cbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Location = new System.Drawing.Point(127, 0);
            this.cbInclude.Margin = new System.Windows.Forms.Padding(4);
            this.cbInclude.Name = "cbInclude";
            this.cbInclude.Size = new System.Drawing.Size(1698, 25);
            this.cbInclude.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbInclude.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInclude.TabIndex = 26;
            // 
            // btnTextInclude
            // 
            this.btnTextInclude.AccessibleName = "Button";
            this.btnTextInclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTextInclude.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTextInclude.Location = new System.Drawing.Point(1825, 0);
            this.btnTextInclude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextInclude.Name = "btnTextInclude";
            this.btnTextInclude.Size = new System.Drawing.Size(23, 25);
            this.btnTextInclude.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnTextInclude.TabIndex = 20;
            // 
            // chkbIncludeText
            // 
            this.chkbIncludeText.AutoSize = true;
            this.chkbIncludeText.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkbIncludeText.Location = new System.Drawing.Point(16, 0);
            this.chkbIncludeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbIncludeText.Name = "chkbIncludeText";
            this.chkbIncludeText.Size = new System.Drawing.Size(111, 25);
            this.chkbIncludeText.TabIndex = 9;
            this.chkbIncludeText.Text = "Include Text:";
            this.chkbIncludeText.UseVisualStyleBackColor = true;
            this.chkbIncludeText.CheckedChanged += new System.EventHandler(this.chkbInclude_CheckedChanged);
            // 
            // pboxInfo
            // 
            this.pboxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxInfo.Image = global::Analogy.Properties.Resources.Info_16x16;
            this.pboxInfo.Location = new System.Drawing.Point(0, 0);
            this.pboxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxInfo.Name = "pboxInfo";
            this.pboxInfo.Size = new System.Drawing.Size(16, 25);
            this.pboxInfo.TabIndex = 12;
            this.pboxInfo.TabStop = false;
            // 
            // sbtnPreDefinedFilters
            // 
            this.sbtnPreDefinedFilters.AccessibleName = "Button";
            this.sbtnPreDefinedFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.sbtnPreDefinedFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sbtnPreDefinedFilters.Location = new System.Drawing.Point(1848, 0);
            this.sbtnPreDefinedFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnPreDefinedFilters.Name = "sbtnPreDefinedFilters";
            this.sbtnPreDefinedFilters.Size = new System.Drawing.Size(23, 25);
            this.sbtnPreDefinedFilters.Style.Image = global::Analogy.Properties.Resources.SingleMasterFilter_16x16;
            this.sbtnPreDefinedFilters.TabIndex = 21;
            this.sbtnPreDefinedFilters.Click += new System.EventHandler(this.sbtnPreDefinedFilters_Click);
            // 
            // rbVerbose
            // 
            this.rbVerbose.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbVerbose.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbVerbose.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbVerbose.Location = new System.Drawing.Point(0, 100);
            this.rbVerbose.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbVerbose.Name = "rbVerbose";
            this.rbVerbose.Size = new System.Drawing.Size(240, 20);
            this.rbVerbose.TabIndex = 28;
            this.rbVerbose.TabStop = false;
            this.rbVerbose.Text = "Verbose";
            // 
            // rbDebug
            // 
            this.rbDebug.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbDebug.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDebug.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbDebug.Location = new System.Drawing.Point(0, 80);
            this.rbDebug.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbDebug.Name = "rbDebug";
            this.rbDebug.Size = new System.Drawing.Size(240, 20);
            this.rbDebug.TabIndex = 27;
            this.rbDebug.TabStop = false;
            this.rbDebug.Text = "Debug";
            // 
            // rbWarning
            // 
            this.rbWarning.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbWarning.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbWarning.Location = new System.Drawing.Point(0, 60);
            this.rbWarning.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(240, 20);
            this.rbWarning.TabIndex = 26;
            this.rbWarning.TabStop = false;
            this.rbWarning.Text = "Warning";
            // 
            // rbErrorCritical
            // 
            this.rbErrorCritical.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbErrorCritical.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbErrorCritical.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbErrorCritical.Location = new System.Drawing.Point(0, 40);
            this.rbErrorCritical.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbErrorCritical.Name = "rbErrorCritical";
            this.rbErrorCritical.Size = new System.Drawing.Size(240, 20);
            this.rbErrorCritical.TabIndex = 25;
            this.rbErrorCritical.TabStop = false;
            this.rbErrorCritical.Text = "Errors + Critical";
            // 
            // rbTrace
            // 
            this.rbTrace.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbTrace.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbTrace.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbTrace.Location = new System.Drawing.Point(0, 20);
            this.rbTrace.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbTrace.Name = "rbTrace";
            this.rbTrace.Size = new System.Drawing.Size(240, 20);
            this.rbTrace.TabIndex = 24;
            this.rbTrace.TabStop = false;
            this.rbTrace.Text = "Trace";
            // 
            // rbAllLevel
            // 
            this.rbAllLevel.BeforeTouchSize = new System.Drawing.Size(240, 20);
            this.rbAllLevel.Checked = true;
            this.rbAllLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAllLevel.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbAllLevel.Location = new System.Drawing.Point(0, 0);
            this.rbAllLevel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbAllLevel.Name = "rbAllLevel";
            this.rbAllLevel.Size = new System.Drawing.Size(240, 20);
            this.rbAllLevel.TabIndex = 23;
            this.rbAllLevel.Text = "All";
            // 
            // tcBottom
            // 
            this.tcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBottom.Location = new System.Drawing.Point(0, 0);
            this.tcBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedTabPage = this.xtpMessageInfo;
            this.tcBottom.Size = new System.Drawing.Size(2124, 204);
            this.tcBottom.TabIndex = 6;
            this.tcBottom.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpMessageInfo,
            this.xtpBookmarks});
            // 
            // xtpMessageInfo
            // 
            this.xtpMessageInfo.Controls.Add(this.tbMessageInfo);
            this.xtpMessageInfo.Controls.Add(this.tsMessageInfo);
            this.xtpMessageInfo.Controls.Add(this.bdcMessageBottom);
            this.xtpMessageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpMessageInfo.Name = "xtpMessageInfo";
            this.xtpMessageInfo.Size = new System.Drawing.Size(2117, 170);
            this.xtpMessageInfo.Text = "Message Info";
            // 
            // tbMessageInfo
            // 
            this.tbMessageInfo.BackColor = System.Drawing.Color.White;
            this.tbMessageInfo.BeforeTouchSize = new System.Drawing.Size(2117, 143);
            this.tbMessageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbMessageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbMessageInfo.Location = new System.Drawing.Point(0, 27);
            this.tbMessageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessageInfo.Multiline = true;
            this.tbMessageInfo.Name = "tbMessageInfo";
            this.tbMessageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessageInfo.Size = new System.Drawing.Size(2117, 143);
            this.tbMessageInfo.TabIndex = 14;
            this.tbMessageInfo.ThemeName = "";
            // 
            // tsMessageInfo
            // 
            this.tsMessageInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsMessageInfo.Image = null;
            this.tsMessageInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMessageInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMessageInfoCopy});
            this.tsMessageInfo.Location = new System.Drawing.Point(0, 0);
            this.tsMessageInfo.Name = "tsMessageInfo";
            this.tsMessageInfo.ShowCaption = false;
            this.tsMessageInfo.ShowLauncher = false;
            this.tsMessageInfo.Size = new System.Drawing.Size(2117, 27);
            this.tsMessageInfo.TabIndex = 4;
            this.tsMessageInfo.ThemeName = "Default";
            // 
            // tsBtnMessageInfoCopy
            // 
            this.tsBtnMessageInfoCopy.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnMessageInfoCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMessageInfoCopy.Name = "tsBtnMessageInfoCopy";
            this.tsBtnMessageInfoCopy.Size = new System.Drawing.Size(67, 24);
            this.tsBtnMessageInfoCopy.Text = "Copy";
            // 
            // xtpBookmarks
            // 
            this.xtpBookmarks.Controls.Add(this.sfDataGridBookmarks);
            this.xtpBookmarks.Controls.Add(this.tsBookmark);
            this.xtpBookmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpBookmarks.Name = "xtpBookmarks";
            this.xtpBookmarks.Size = new System.Drawing.Size(2117, 170);
            this.xtpBookmarks.Text = "Bookmarks";
            // 
            // sfDataGridBookmarks
            // 
            this.sfDataGridBookmarks.AccessibleName = "Table";
            this.sfDataGridBookmarks.AllowDraggingColumns = true;
            this.sfDataGridBookmarks.AllowEditing = false;
            this.sfDataGridBookmarks.AllowResizingColumns = true;
            this.sfDataGridBookmarks.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            gridTextColumn13.AllowDragging = true;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowResizing = true;
            gridTextColumn13.HeaderText = "Data Source/File Name";
            gridTextColumn13.MappingName = "DataProvider";
            gridDateTimeColumn2.AllowDragging = true;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowResizing = true;
            gridDateTimeColumn2.Format = "yyyy.MM.dd HH:mm:ss.ff";
            gridDateTimeColumn2.HeaderText = "Date";
            gridDateTimeColumn2.MappingName = "Date";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            gridTextColumn14.AllowDragging = true;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "Time Differenace";
            gridTextColumn14.MappingName = "TimeDiff";
            gridTextColumn14.Visible = false;
            gridTextColumn15.AllowDragging = true;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowResizing = true;
            gridTextColumn15.HeaderText = "Text";
            gridTextColumn15.MappingName = "Text";
            gridTextColumn16.AllowDragging = true;
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.AllowResizing = true;
            gridTextColumn16.HeaderText = "Source";
            gridTextColumn16.MappingName = "Source";
            gridTextColumn17.AllowDragging = true;
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.AllowResizing = true;
            gridTextColumn17.HeaderText = "Level";
            gridTextColumn17.MappingName = "Level";
            gridTextColumn18.AllowDragging = true;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.AllowResizing = true;
            gridTextColumn18.HeaderText = "Class";
            gridTextColumn18.MappingName = "Class";
            gridTextColumn19.AllowDragging = true;
            gridTextColumn19.AllowEditing = false;
            gridTextColumn19.AllowResizing = true;
            gridTextColumn19.HeaderText = "Category";
            gridTextColumn19.MappingName = "Category";
            gridTextColumn20.AllowDragging = true;
            gridTextColumn20.AllowEditing = false;
            gridTextColumn20.AllowResizing = true;
            gridTextColumn20.HeaderText = "User";
            gridTextColumn20.MappingName = "User";
            gridTextColumn21.AllowDragging = true;
            gridTextColumn21.AllowEditing = false;
            gridTextColumn21.AllowResizing = true;
            gridTextColumn21.HeaderText = "Module";
            gridTextColumn21.MappingName = "Module";
            gridTextColumn22.AllowDragging = true;
            gridTextColumn22.AllowEditing = false;
            gridTextColumn22.AllowResizing = true;
            gridTextColumn22.HeaderText = "Object";
            gridTextColumn22.MappingName = "Object";
            gridTextColumn22.Visible = false;
            gridTextColumn23.AllowDragging = true;
            gridTextColumn23.AllowEditing = false;
            gridTextColumn23.AllowResizing = true;
            gridTextColumn23.HeaderText = "Process ID";
            gridTextColumn23.MappingName = "ProcessID";
            gridTextColumn24.AllowDragging = true;
            gridTextColumn24.AllowEditing = false;
            gridTextColumn24.AllowResizing = true;
            gridTextColumn24.HeaderText = "Thread id";
            gridTextColumn24.MappingName = "ThreadID";
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn13);
            this.sfDataGridBookmarks.Columns.Add(gridDateTimeColumn2);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn14);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn15);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn16);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn17);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn18);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn19);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn20);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn21);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn22);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn23);
            this.sfDataGridBookmarks.Columns.Add(gridTextColumn24);
            this.sfDataGridBookmarks.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridBookmarks.Location = new System.Drawing.Point(0, 27);
            this.sfDataGridBookmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridBookmarks.Name = "sfDataGridBookmarks";
            this.sfDataGridBookmarks.PreviewRowHeight = 35;
            this.sfDataGridBookmarks.RowHeight = 20;
            this.sfDataGridBookmarks.ShowRowHeader = true;
            this.sfDataGridBookmarks.Size = new System.Drawing.Size(2117, 143);
            this.sfDataGridBookmarks.TabIndex = 6;
            this.sfDataGridBookmarks.Text = "Bookmarks";
            this.sfDataGridBookmarks.UsePLINQ = true;
            // 
            // tsBookmark
            // 
            this.tsBookmark.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsBookmark.Image = null;
            this.tsBookmark.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBookmark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBookmarkCopySingle,
            this.tsBtnBookmarkCopyAll,
            this.tsBtnBookmarkClear,
            this.tsBtnBookmarkGoToOriginal});
            this.tsBookmark.Location = new System.Drawing.Point(0, 0);
            this.tsBookmark.Name = "tsBookmark";
            this.tsBookmark.ShowCaption = false;
            this.tsBookmark.ShowLauncher = false;
            this.tsBookmark.Size = new System.Drawing.Size(2117, 27);
            this.tsBookmark.TabIndex = 5;
            this.tsBookmark.ThemeName = "Default";
            // 
            // tsBtnBookmarkCopySingle
            // 
            this.tsBtnBookmarkCopySingle.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnBookmarkCopySingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkCopySingle.Name = "tsBtnBookmarkCopySingle";
            this.tsBtnBookmarkCopySingle.Size = new System.Drawing.Size(190, 24);
            this.tsBtnBookmarkCopySingle.Text = "Copy Selected Message";
            // 
            // tsBtnBookmarkCopyAll
            // 
            this.tsBtnBookmarkCopyAll.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsBtnBookmarkCopyAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkCopyAll.Name = "tsBtnBookmarkCopyAll";
            this.tsBtnBookmarkCopyAll.Size = new System.Drawing.Size(202, 24);
            this.tsBtnBookmarkCopyAll.Text = "Copy all messages in grid";
            // 
            // tsBtnBookmarkClear
            // 
            this.tsBtnBookmarkClear.Image = global::Analogy.Properties.Resources.Clear_16x16;
            this.tsBtnBookmarkClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkClear.Name = "tsBtnBookmarkClear";
            this.tsBtnBookmarkClear.Size = new System.Drawing.Size(144, 24);
            this.tsBtnBookmarkClear.Text = "Clear Bookmarks";
            // 
            // tsBtnBookmarkGoToOriginal
            // 
            this.tsBtnBookmarkGoToOriginal.Image = global::Analogy.Properties.Resources.Stop_32x32;
            this.tsBtnBookmarkGoToOriginal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBookmarkGoToOriginal.Name = "tsBtnBookmarkGoToOriginal";
            this.tsBtnBookmarkGoToOriginal.Size = new System.Drawing.Size(135, 24);
            this.tsBtnBookmarkGoToOriginal.Text = "Go To Message";
            // 
            // imageListBottom
            // 
            this.imageListBottom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBottom.ImageStream")));
            this.imageListBottom.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBottom.Images.SetKeyName(0, "Info_16x16.png");
            this.imageListBottom.Images.SetKeyName(1, "RichEditBookmark_16x16.png");
            this.imageListBottom.Images.SetKeyName(2, "RichEditBookmark_32x32.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(271, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1660, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // tmrNewData
            // 
            this.tmrNewData.Enabled = true;
            this.tmrNewData.Interval = 1000;
            this.tmrNewData.Tick += new System.EventHandler(this.tmrNewData_Tick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 20);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtpMain;
            this.xtraTabControl1.Size = new System.Drawing.Size(2131, 90);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpMain,
            this.xtCounts});
            // 
            // xtpMain
            // 
            this.xtpMain.Controls.Add(this.bdcTopFiltering);
            this.xtpMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtpMain.Name = "xtpMain";
            this.xtpMain.Size = new System.Drawing.Size(2124, 56);
            this.xtpMain.Text = "Logs";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.progressBar1);
            this.pnlBottom.Controls.Add(this.lblTotalMessagesAlert);
            this.pnlBottom.Controls.Add(this.lblTotalMessages);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 592);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(2124, 23);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblTotalMessagesAlert
            // 
            this.lblTotalMessagesAlert.AutoSize = true;
            this.lblTotalMessagesAlert.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.Red);
            this.lblTotalMessagesAlert.BeforeTouchSize = new System.Drawing.Size(145, 21);
            this.lblTotalMessagesAlert.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTotalMessagesAlert.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMessagesAlert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMessagesAlert.Location = new System.Drawing.Point(126, 0);
            this.lblTotalMessagesAlert.Name = "lblTotalMessagesAlert";
            this.lblTotalMessagesAlert.Size = new System.Drawing.Size(145, 21);
            this.lblTotalMessagesAlert.TabIndex = 8;
            this.lblTotalMessagesAlert.Text = "ALERTS EXISTS: !";
            this.lblTotalMessagesAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMessages
            // 
            this.lblTotalMessages.AutoSize = true;
            this.lblTotalMessages.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblTotalMessages.BeforeTouchSize = new System.Drawing.Size(126, 21);
            this.lblTotalMessages.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTotalMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMessages.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMessages.Location = new System.Drawing.Point(0, 0);
            this.lblTotalMessages.Name = "lblTotalMessages";
            this.lblTotalMessages.Size = new System.Drawing.Size(126, 21);
            this.lblTotalMessages.TabIndex = 7;
            this.lblTotalMessages.Text = "Total Messages";
            this.lblTotalMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.AutoSize = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1931, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnCancel.Size = new System.Drawing.Size(193, 23);
            this.btnCancel.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Processing";
            this.btnCancel.Visible = false;
            // 
            // xtCounts
            // 
            this.xtCounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtCounts.Name = "xtCounts";
            this.xtCounts.Size = new System.Drawing.Size(1191, 346);
            this.xtCounts.Text = "Messages Grouping";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerMain.Horizontal = false;
            this.splitContainerMain.Location = new System.Drawing.Point(33, 69);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Panel1.Controls.Add(this.pnlMessages);
            this.splitContainerMain.Panel1.Controls.Add(this.panel1);
            this.splitContainerMain.Panel1.Controls.Add(this.pnlTopFiltering);
            this.splitContainerMain.Panel1.Text = "Panel1";
            this.splitContainerMain.Panel2.Controls.Add(this.tcBottom);
            this.splitContainerMain.Panel2.Text = "Panel2";
            this.splitContainerMain.Size = new System.Drawing.Size(2124, 644);
            this.splitContainerMain.SplitterPosition = 204;
            this.splitContainerMain.TabIndex = 21;
            this.splitContainerMain.Text = "splitContainerControl1";
            // 
            // pnlMessages
            // 
            this.pnlMessages.Controls.Add(this.sfDataGridMain);
            this.pnlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessages.Location = new System.Drawing.Point(0, 153);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(2124, 255);
            this.pnlMessages.TabIndex = 7;
            // 
            // sfDataGridMain
            // 
            this.sfDataGridMain.AccessibleName = "Table";
            this.sfDataGridMain.AllowDraggingColumns = true;
            this.sfDataGridMain.AllowEditing = false;
            this.sfDataGridMain.AllowResizingColumns = true;
            this.sfDataGridMain.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.ColumnHeader;
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Data Source/File Name";
            gridTextColumn1.MappingName = "DataProvider";
            gridDateTimeColumn1.AllowDragging = true;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowResizing = true;
            gridDateTimeColumn1.Format = "yyyy.MM.dd HH:mm:ss.ff";
            gridDateTimeColumn1.HeaderText = "Date";
            gridDateTimeColumn1.MappingName = "Date";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            gridTextColumn2.AllowDragging = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Time Differenace";
            gridTextColumn2.MappingName = "TimeDiff";
            gridTextColumn2.Visible = false;
            gridTextColumn3.AllowDragging = true;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Text";
            gridTextColumn3.MappingName = "Text";
            gridTextColumn4.AllowDragging = true;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Source";
            gridTextColumn4.MappingName = "Source";
            gridTextColumn5.AllowDragging = true;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderText = "Level";
            gridTextColumn5.MappingName = "Level";
            gridTextColumn6.AllowDragging = true;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "Class";
            gridTextColumn6.MappingName = "Class";
            gridTextColumn7.AllowDragging = true;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "Category";
            gridTextColumn7.MappingName = "Category";
            gridTextColumn8.AllowDragging = true;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "User";
            gridTextColumn8.MappingName = "User";
            gridTextColumn9.AllowDragging = true;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "Module";
            gridTextColumn9.MappingName = "Module";
            gridTextColumn10.AllowDragging = true;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "Object";
            gridTextColumn10.MappingName = "Object";
            gridTextColumn10.Visible = false;
            gridTextColumn11.AllowDragging = true;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "Process ID";
            gridTextColumn11.MappingName = "ProcessID";
            gridTextColumn12.AllowDragging = true;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Thread id";
            gridTextColumn12.MappingName = "ThreadID";
            this.sfDataGridMain.Columns.Add(gridTextColumn1);
            this.sfDataGridMain.Columns.Add(gridDateTimeColumn1);
            this.sfDataGridMain.Columns.Add(gridTextColumn2);
            this.sfDataGridMain.Columns.Add(gridTextColumn3);
            this.sfDataGridMain.Columns.Add(gridTextColumn4);
            this.sfDataGridMain.Columns.Add(gridTextColumn5);
            this.sfDataGridMain.Columns.Add(gridTextColumn6);
            this.sfDataGridMain.Columns.Add(gridTextColumn7);
            this.sfDataGridMain.Columns.Add(gridTextColumn8);
            this.sfDataGridMain.Columns.Add(gridTextColumn9);
            this.sfDataGridMain.Columns.Add(gridTextColumn10);
            this.sfDataGridMain.Columns.Add(gridTextColumn11);
            this.sfDataGridMain.Columns.Add(gridTextColumn12);
            this.sfDataGridMain.ContextMenuStrip = this.cmsMessageOperation;
            this.sfDataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridMain.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGridMain.Name = "sfDataGridMain";
            this.sfDataGridMain.PreviewRowHeight = 35;
            this.sfDataGridMain.RowHeight = 20;
            this.sfDataGridMain.ShowRowHeader = true;
            this.sfDataGridMain.Size = new System.Drawing.Size(2124, 255);
            this.sfDataGridMain.TabIndex = 5;
            this.sfDataGridMain.Text = "sfDataGridMain";
            this.sfDataGridMain.UsePLINQ = true;
            this.sfDataGridMain.StyleChanged += new System.EventHandler(this.sfDataGridMain_StyleChanged);
            // 
            // nudGroupBychars
            // 
            this.nudGroupBychars.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGroupBychars.Location = new System.Drawing.Point(749, 20);
            this.nudGroupBychars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGroupBychars.MenuManager = this.barManager1;
            this.nudGroupBychars.Name = "nudGroupBychars";
            this.nudGroupBychars.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudGroupBychars.Properties.IsFloatValue = false;
            this.nudGroupBychars.Properties.Mask.EditMask = "N00";
            this.nudGroupBychars.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGroupBychars.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGroupBychars.Size = new System.Drawing.Size(98, 22);
            this.nudGroupBychars.TabIndex = 15;
            // 
            // txtbGroupByCharsLimit
            // 
            this.txtbGroupByCharsLimit.Location = new System.Drawing.Point(150, 20);
            this.txtbGroupByCharsLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbGroupByCharsLimit.MenuManager = this.barManager1;
            this.txtbGroupByCharsLimit.Name = "txtbGroupByCharsLimit";
            this.txtbGroupByCharsLimit.Size = new System.Drawing.Size(250, 22);
            this.txtbGroupByCharsLimit.TabIndex = 14;
            // 
            // sBtnGroup
            // 
            this.sBtnGroup.AccessibleName = "Button";
            this.sBtnGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnGroup.Location = new System.Drawing.Point(863, 17);
            this.sBtnGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnGroup.Name = "sBtnGroup";
            this.sBtnGroup.Size = new System.Drawing.Size(83, 25);
            this.sBtnGroup.TabIndex = 13;
            this.sBtnGroup.Text = "Group";
            this.sBtnGroup.Click += new System.EventHandler(this.sBtnGroup_Click);
            // 
            // sBtnLength
            // 
            this.sBtnLength.AccessibleName = "Button";
            this.sBtnLength.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sBtnLength.Location = new System.Drawing.Point(406, 18);
            this.sBtnLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtnLength.Name = "sBtnLength";
            this.sBtnLength.Size = new System.Drawing.Size(83, 25);
            this.sBtnLength.TabIndex = 12;
            this.sBtnLength.Text = "Set Length";
            this.sBtnLength.Click += new System.EventHandler(this.sBtnLength_Click);
            // 
            // lblGroupByCharsLimit
            // 
            this.lblGroupByCharsLimit.AutoSize = true;
            this.lblGroupByCharsLimit.Location = new System.Drawing.Point(3, 25);
            this.lblGroupByCharsLimit.Name = "lblGroupByCharsLimit";
            this.lblGroupByCharsLimit.Size = new System.Drawing.Size(141, 17);
            this.lblGroupByCharsLimit.TabIndex = 7;
            this.lblGroupByCharsLimit.Text = "group by text length:";
            // 
            // lblGroupByChars
            // 
            this.lblGroupByChars.AutoSize = true;
            this.lblGroupByChars.Location = new System.Drawing.Point(518, 25);
            this.lblGroupByChars.Name = "lblGroupByChars";
            this.lblGroupByChars.Size = new System.Drawing.Size(225, 17);
            this.lblGroupByChars.TabIndex = 2;
            this.lblGroupByChars.Text = "Or group by number of characters:";
            // 
            // cmsBookmarked
            // 
            this.cmsBookmarked.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBookmarked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalcDiffBookmark,
            this.tsmiBookmarkDateFilterNewer,
            this.tsmiBookmarkDateFilterOlder,
            this.toolStripSeparator5,
            this.tsmiRemoveBookmark,
            this.tsmiCopyBookmark,
            this.tsmiCopyMessagesBookmark,
            this.toolStripMenuItem5,
            this.toolStripSeparator6,
            this.tsmiExcludeBookmark,
            this.tsmiExcludeSourceBookmark,
            this.tsmiExcludeModuleBookmark,
            this.toolStripSeparator7,
            this.tsmiEmailBookmark,
            this.tsmiOTAFullBookmark,
            this.toolStripSeparator8,
            this.tsmiSaveLayoutBookmark,
            this.tsmiIncreaseFontBookmark,
            this.tsmiDecreaseFontBookmark});
            this.cmsBookmarked.Name = "cmsMessageOperation";
            this.cmsBookmarked.Size = new System.Drawing.Size(361, 418);
            this.cmsBookmarked.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBookmarked_Opening);
            // 
            // tsmiCalcDiffBookmark
            // 
            this.tsmiCalcDiffBookmark.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiCalcDiffBookmark.Name = "tsmiCalcDiffBookmark";
            this.tsmiCalcDiffBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCalcDiffBookmark.Text = "Calculate Time Difference from this entry";
            this.tsmiCalcDiffBookmark.Click += new System.EventHandler(this.tsmiTimeDiff_Click);
            // 
            // tsmiBookmarkDateFilterNewer
            // 
            this.tsmiBookmarkDateFilterNewer.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiBookmarkDateFilterNewer.Name = "tsmiBookmarkDateFilterNewer";
            this.tsmiBookmarkDateFilterNewer.Size = new System.Drawing.Size(360, 26);
            this.tsmiBookmarkDateFilterNewer.Text = "dateTime filtering:after";
            this.tsmiBookmarkDateFilterNewer.Click += new System.EventHandler(this.tsmiBookmarkDateFilterNewer_Click);
            // 
            // tsmiBookmarkDateFilterOlder
            // 
            this.tsmiBookmarkDateFilterOlder.Image = global::Analogy.Properties.Resources.Time2_16x16;
            this.tsmiBookmarkDateFilterOlder.Name = "tsmiBookmarkDateFilterOlder";
            this.tsmiBookmarkDateFilterOlder.Size = new System.Drawing.Size(360, 26);
            this.tsmiBookmarkDateFilterOlder.Text = "dateTime filtering:before";
            this.tsmiBookmarkDateFilterOlder.Click += new System.EventHandler(this.tsmiBookmarkDateFilterOlder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiRemoveBookmark
            // 
            this.tsmiRemoveBookmark.Image = global::Analogy.Properties.Resources.Clear_16x16;
            this.tsmiRemoveBookmark.Name = "tsmiRemoveBookmark";
            this.tsmiRemoveBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiRemoveBookmark.Text = "Remove this message";
            this.tsmiRemoveBookmark.Click += new System.EventHandler(this.tsmiRemoveBookmark_Click);
            // 
            // tsmiCopyBookmark
            // 
            this.tsmiCopyBookmark.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyBookmark.Name = "tsmiCopyBookmark";
            this.tsmiCopyBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCopyBookmark.Text = "Copy selected message to clipboard";
            this.tsmiCopyBookmark.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCopyMessagesBookmark
            // 
            this.tsmiCopyMessagesBookmark.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.tsmiCopyMessagesBookmark.Name = "tsmiCopyMessagesBookmark";
            this.tsmiCopyMessagesBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiCopyMessagesBookmark.Text = "Copy all messages in view to clipboard";
            this.tsmiCopyMessagesBookmark.Click += new System.EventHandler(this.tsmiCopyMessages_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Image = global::Analogy.Properties.Resources.EditComment_16x16;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(360, 26);
            this.toolStripMenuItem5.Text = "Add message/comment at this timestamp";
            this.toolStripMenuItem5.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiExcludeBookmark
            // 
            this.tsmiExcludeBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeBookmark.Name = "tsmiExcludeBookmark";
            this.tsmiExcludeBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeBookmark.Text = "Exclude selected message ";
            this.tsmiExcludeBookmark.Click += new System.EventHandler(this.tsmiExclude_Click);
            // 
            // tsmiExcludeSourceBookmark
            // 
            this.tsmiExcludeSourceBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeSourceBookmark.Name = "tsmiExcludeSourceBookmark";
            this.tsmiExcludeSourceBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeSourceBookmark.Text = "Exclude Source";
            this.tsmiExcludeSourceBookmark.Click += new System.EventHandler(this.tsmiExcludeSource_Click);
            // 
            // tsmiExcludeModuleBookmark
            // 
            this.tsmiExcludeModuleBookmark.Image = global::Analogy.Properties.Resources.ClearFilter_16x16;
            this.tsmiExcludeModuleBookmark.Name = "tsmiExcludeModuleBookmark";
            this.tsmiExcludeModuleBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiExcludeModuleBookmark.Text = "Exclude Module";
            this.tsmiExcludeModuleBookmark.Click += new System.EventHandler(this.tsmiExcludeModule_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiEmailBookmark
            // 
            this.tsmiEmailBookmark.Image = global::Analogy.Properties.Resources.Send_16x16;
            this.tsmiEmailBookmark.Name = "tsmiEmailBookmark";
            this.tsmiEmailBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiEmailBookmark.Text = "Send selected message by mail";
            this.tsmiEmailBookmark.Click += new System.EventHandler(this.tsmiEmail_Click);
            // 
            // tsmiOTAFullBookmark
            // 
            this.tsmiOTAFullBookmark.Image = global::Analogy.Properties.Resources.logIcon;
            this.tsmiOTAFullBookmark.Name = "tsmiOTAFullBookmark";
            this.tsmiOTAFullBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiOTAFullBookmark.Text = "Send Log to another Analogy";
            this.tsmiOTAFullBookmark.Visible = false;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(357, 6);
            // 
            // tsmiSaveLayoutBookmark
            // 
            this.tsmiSaveLayoutBookmark.Image = global::Analogy.Properties.Resources.Save_16x16;
            this.tsmiSaveLayoutBookmark.Name = "tsmiSaveLayoutBookmark";
            this.tsmiSaveLayoutBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiSaveLayoutBookmark.Text = "Save columns layout";
            this.tsmiSaveLayoutBookmark.Click += new System.EventHandler(this.tsmiSaveLayout_Click);
            // 
            // tsmiIncreaseFontBookmark
            // 
            this.tsmiIncreaseFontBookmark.Image = global::Analogy.Properties.Resources.IncreaseFontSize_16x16;
            this.tsmiIncreaseFontBookmark.Name = "tsmiIncreaseFontBookmark";
            this.tsmiIncreaseFontBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiIncreaseFontBookmark.Text = "Increase Font Size";
            this.tsmiIncreaseFontBookmark.Click += new System.EventHandler(this.tsmiIncreaseFont_Click);
            // 
            // tsmiDecreaseFontBookmark
            // 
            this.tsmiDecreaseFontBookmark.Image = global::Analogy.Properties.Resources.DecreaseFontSize_16x16;
            this.tsmiDecreaseFontBookmark.Name = "tsmiDecreaseFontBookmark";
            this.tsmiDecreaseFontBookmark.Size = new System.Drawing.Size(360, 26);
            this.tsmiDecreaseFontBookmark.Text = "Decrease Font Size";
            this.tsmiDecreaseFontBookmark.Click += new System.EventHandler(this.tsmiDecreaseFont_Click);
            // 
            // contextMenuStripFilters
            // 
            this.contextMenuStripFilters.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFilters.Name = "contextMenuStripFilters";
            this.contextMenuStripFilters.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Analogy.Properties.Resources.Copy_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton1.Text = "Copy";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowLauncher = false;
            this.toolStripEx1.Size = new System.Drawing.Size(2117, 27);
            this.toolStripEx1.TabIndex = 4;
            this.toolStripEx1.ThemeName = "Default";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(2131, 649);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 110);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(2131, 649);
            this.tabControlAdv1.TabIndex = 27;
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.pnlBottom);
            this.tabPageAdv1.Controls.Add(this.splitContainerMain);
            this.tabPageAdv1.Controls.Add(this.toolStripEx2);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv1.Location = new System.Drawing.Point(3, 31);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(2124, 615);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "tabPageAdv1";
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTopClear,
            this.tsTopRefresh,
            this.toolStripCheckBox1});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.ShowCaption = false;
            this.toolStripEx2.ShowLauncher = false;
            this.toolStripEx2.Size = new System.Drawing.Size(2124, 27);
            this.toolStripEx2.TabIndex = 5;
            this.toolStripEx2.ThemeName = "Default";
            // 
            // tsTopClear
            // 
            this.tsTopClear.Image = global::Analogy.Properties.Resources.Delete_16x16;
            this.tsTopClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTopClear.Name = "tsTopClear";
            this.tsTopClear.Size = new System.Drawing.Size(96, 24);
            this.tsTopClear.Text = "Clear Log";
            // 
            // tsTopRefresh
            // 
            this.tsTopRefresh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsTopRefresh.Name = "tsTopRefresh";
            this.tsTopRefresh.Size = new System.Drawing.Size(146, 24);
            this.tsTopRefresh.Text = "Pause Refershing:";
            // 
            // toolStripCheckBox1
            // 
            this.toolStripCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripCheckBox1.Name = "toolStripCheckBox1";
            this.toolStripCheckBox1.Size = new System.Drawing.Size(179, 24);
            this.toolStripCheckBox1.Text = "Auto scroll to last row:";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.sBtnGroup);
            this.tabPageAdv2.Controls.Add(this.nudGroupBychars);
            this.tabPageAdv2.Controls.Add(this.lblGroupByCharsLimit);
            this.tabPageAdv2.Controls.Add(this.txtbGroupByCharsLimit);
            this.tabPageAdv2.Controls.Add(this.lblGroupByChars);
            this.tabPageAdv2.Controls.Add(this.sBtnLength);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(20, 20);
            this.tabPageAdv2.Location = new System.Drawing.Point(3, 31);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(982, 223);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // UCLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCLogs";
            this.Size = new System.Drawing.Size(2131, 759);
            this.Load += new System.EventHandler(this.UCLogs_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCLogs_DragEnter);
            this.cmsMessageOperation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHighlights)).EndInit();
            this.pnlButtonsHighlight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnlTopFiltering.ResumeLayout(false);
            this.spltFilteringBoth.Panel1.ResumeLayout(false);
            this.spltFilteringBoth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltFilteringBoth)).EndInit();
            this.spltFilteringBoth.ResumeLayout(false);
            this.pnlFilteringLeft.ResumeLayout(false);
            this.spltcDateFiltering.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcDateFiltering)).EndInit();
            this.spltcDateFiltering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.spltcProcessesModule.Panel1.ResumeLayout(false);
            this.spltcProcessesModule.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcProcessesModule)).EndInit();
            this.spltcProcessesModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbModule)).EndInit();
            this.spltcSources.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcSources)).EndInit();
            this.spltcSources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfoExclude)).EndInit();
            this.spltTextExclude.Panel1.ResumeLayout(false);
            this.spltTextExclude.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTextExclude)).EndInit();
            this.spltTextExclude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbExclude)).EndInit();
            this.spltText.Panel1.ResumeLayout(false);
            this.spltText.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltText)).EndInit();
            this.spltText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbInclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbVerbose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDebug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbErrorCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAllLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBottom)).EndInit();
            this.tcBottom.ResumeLayout(false);
            this.xtpMessageInfo.ResumeLayout(false);
            this.xtpMessageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMessageInfo)).EndInit();
            this.tsMessageInfo.ResumeLayout(false);
            this.tsMessageInfo.PerformLayout();
            this.xtpBookmarks.ResumeLayout(false);
            this.xtpBookmarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridBookmarks)).EndInit();
            this.tsBookmark.ResumeLayout(false);
            this.tsBookmark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupBychars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbGroupByCharsLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.cmsBookmarked.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel pnlTopFiltering;
        private System.Windows.Forms.CheckBox chkbIncludeText;
        private System.Windows.Forms.CheckBox chkExclude;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip cmsMessageOperation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExclude;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOTAFull;
        private System.Windows.Forms.Timer tmrNewData;
        private System.Windows.Forms.PictureBox pboxInfo;
        private System.Windows.Forms.PictureBox pboxInfoExclude;
        private System.Windows.Forms.ImageList imageListBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCommentToMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbHighlight;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeModule;
        private System.Windows.Forms.Panel pnlButtonsHighlight;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeDiff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SplitContainer spltFilteringBoth;
        private System.Windows.Forms.Panel pnlFilteringLeft;
        private DevExpress.XtraTab.XtraTabPage xtCounts;
        private System.Windows.Forms.Label lblGroupByChars;
        private System.Windows.Forms.Label lblGroupByCharsLimit;
        private DevExpress.XtraTab.XtraTabControl tcBottom;
        private DevExpress.XtraTab.XtraTabPage xtpMessageInfo;
        private DevExpress.XtraTab.XtraTabPage xtpBookmarks;
        private DevExpress.XtraBars.StandaloneBarDockControl bdcTopFiltering;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barTopFiltering;
        private DevExpress.XtraBars.Bar BbarMainMenu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToggleSwitchItem btswitchExpand;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveLog;
        private DevExpress.XtraBars.BarButtonItem bBtnImport;
        private DevExpress.XtraBars.BarButtonItem bBtnClearLog;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private SfButton sBtnMostCommon;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private SfButton sBtnLength;
        private SfButton sBtnGroup;
        private DevExpress.XtraBars.StandaloneBarDockControl bdcMessageBottom;
        private DevExpress.XtraBars.BarButtonItem bBtnExpand;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bBtnButtomExpand;
        private DevExpress.XtraBars.BarButtonItem bBtnCopyButtom;
        private DevExpress.XtraBars.BarToggleSwitchItem btSwitchExpandButtomMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLayout;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkPersist;
        private System.Windows.Forms.ContextMenuStrip cmsBookmarked;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalcDiffBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyBookmark;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeSourceBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcludeModuleBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmailBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiOTAFullBookmark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLayoutBookmark;
        private DevExpress.XtraBars.BarButtonItem bBtnRemoveBoomark;
        private SfButton btnCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyMessagesBookmark;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerMain;
        private SfButton sbtnPageFirst;
        private SfButton sBtnPageNext;
        private SfButton sBtnLastPage;
        private SfButton sbtnPagePrevious;
        private DevExpress.XtraBars.BarSubItem bSMExports;
        private DevExpress.XtraBars.BarButtonItem bBtnExportExcel;
        private DevExpress.XtraBars.BarButtonItem bBtnExportCSV;
        private DevExpress.XtraBars.BarButtonItem bBtnExportHtml;
        private DevExpress.XtraBars.BarButtonItem bBtnUndockView;
        private DevExpress.XtraBars.BarButtonItem bBtnSaveEntireLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncreaseFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecreaseFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncreaseFontBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiDecreaseFontBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiREmoveAllPreviousMessages;
        private DevExpress.XtraBars.BarButtonItem bBtnDataVisualizer;
        private DevExpress.XtraBars.BarButtonItem bbiScreenshot;
        private DevExpress.XtraBars.BarSubItem barSubItemSaveView;
        private DevExpress.XtraBars.BarButtonItem bbtnSaveViewAgnostic;
        private DevExpress.XtraBars.BarSubItem barSubItemSaveEntireLog;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSaveEntireInAnalogy;
        private DevExpress.XtraEditors.TextEdit txtbGroupByCharsLimit;
        private DevExpress.XtraEditors.SpinEdit nudGroupBychars;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bBtnUndockViewPerProcess;
        private System.Windows.Forms.SplitContainer spltText;
        private SfButton btnTextInclude;
        private System.Windows.Forms.SplitContainer spltTextExclude;
        private SfButton btnTextExclude;
        private System.Windows.Forms.SplitContainer spltcSources;
        private SfButton btnSources;
        private System.Windows.Forms.CheckBox chkbSources;
        private System.Windows.Forms.SplitContainer spltcProcessesModule;
        private System.Windows.Forms.CheckBox chkbModules;
        private SfButton btnModules;
        private SfButton sbtnUndockPerProcess;
        private System.Windows.Forms.SplitContainer spltcDateFiltering;
        private System.Windows.Forms.CheckBox chkDateNewerThan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkDateOlderThan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateFilterNewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateFilterOlder;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkDateFilterNewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkDateFilterOlder;
        private SfButton sbtnMoreHighlight;
        private SfButton sbtnPreDefinedFilters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFilters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridMain;
        public DevExpress.XtraBars.BarToggleSwitchItem btswitchRefreshLog;
        public DevExpress.XtraBars.BarToggleSwitchItem btsAutoScrollToBottom;
        private Syncfusion.WinForms.ListView.SfComboBox cbInclude;
        private System.Windows.Forms.Panel pnlMessages;
        private Syncfusion.WinForms.ListView.SfComboBox cbExclude;
        private Syncfusion.WinForms.ListView.SfComboBox cbModule;
        private Syncfusion.WinForms.ListView.SfComboBox cbSource;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbAllLevel;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbVerbose;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbDebug;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbWarning;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbErrorCritical;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbTrace;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblPageNumber;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTotalMessagesAlert;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTotalMessages;
        private Syncfusion.WinForms.ListView.SfComboBox cbHighlights;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsMessageInfo;
        private System.Windows.Forms.ToolStripButton tsBtnMessageInfoCopy;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsBookmark;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkCopySingle;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkCopyAll;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridBookmarks;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkClear;
        private System.Windows.Forms.ToolStripButton tsBtnBookmarkGoToOriginal;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbMessageInfo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit deOlderThanFilter;
        private Syncfusion.WinForms.Input.SfDateTimeEdit deNewerThanFilter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton tsTopClear;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox tsTopRefresh;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox toolStripCheckBox1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
    }
}
