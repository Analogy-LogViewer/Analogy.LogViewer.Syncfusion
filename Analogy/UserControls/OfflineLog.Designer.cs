using DevExpress.XtraGrid.Views.Grid;

namespace Analogy
{
    partial class OfflineUCLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineUCLogs));
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.splcLeft = new System.Windows.Forms.SplitContainer();
            this.folderTreeViewUC1 = new Analogy.FolderTreeViewUC();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsBtnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSelecAll = new System.Windows.Forms.ToolStripButton();
            this.checkBoxSelectionMode = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxRecursiveLoad = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ucLogs1 = new Analogy.UCLogs();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.tsPrimary = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bBtnOpenFolder = new DevExpress.XtraBars.BarButtonItem();
            this.folderTreeViewUC2 = new Analogy.FolderTreeViewUC();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).BeginInit();
            this.splcLeft.Panel1.SuspendLayout();
            this.splcLeft.Panel2.SuspendLayout();
            this.splcLeft.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSelectionMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tsPrimary.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spltMain.Name = "spltMain";
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.splcLeft);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.ucLogs1);
            this.spltMain.Size = new System.Drawing.Size(1387, 700);
            this.spltMain.SplitterDistance = 437;
            this.spltMain.TabIndex = 5;
            // 
            // splcLeft
            // 
            this.splcLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcLeft.Location = new System.Drawing.Point(0, 0);
            this.splcLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splcLeft.Name = "splcLeft";
            this.splcLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcLeft.Panel1
            // 
            this.splcLeft.Panel1.Controls.Add(this.folderTreeViewUC1);
            // 
            // splcLeft.Panel2
            // 
            this.splcLeft.Panel2.Controls.Add(this.folderTreeViewUC2);
            this.splcLeft.Panel2.Controls.Add(this.toolStripEx2);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxSelectionMode);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxRecursiveLoad);
            this.splcLeft.Size = new System.Drawing.Size(437, 700);
            this.splcLeft.SplitterDistance = 225;
            this.splcLeft.TabIndex = 4;
            // 
            // folderTreeViewUC1
            // 
            this.folderTreeViewUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTreeViewUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.folderTreeViewUC1.Location = new System.Drawing.Point(0, 0);
            this.folderTreeViewUC1.Margin = new System.Windows.Forms.Padding(4);
            this.folderTreeViewUC1.Name = "folderTreeViewUC1";
            this.folderTreeViewUC1.Size = new System.Drawing.Size(437, 225);
            this.folderTreeViewUC1.TabIndex = 0;
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnOpenFolder,
            this.tsBtnRefresh,
            this.tsBtnDelete,
            this.tsBtnSelecAll});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 38);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEx2.Size = new System.Drawing.Size(437, 27);
            this.toolStripEx2.TabIndex = 13;
            this.toolStripEx2.Text = "toolStripEx2";
            // 
            // tsBtnOpenFolder
            // 
            this.tsBtnOpenFolder.Image = global::Analogy.Properties.Resources.Open2_32x32;
            this.tsBtnOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenFolder.Name = "tsBtnOpenFolder";
            this.tsBtnOpenFolder.Size = new System.Drawing.Size(115, 24);
            this.tsBtnOpenFolder.Text = "Open Folder";
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.Image = global::Analogy.Properties.Resources.RefreshAllPivotTable_32x32;
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(82, 24);
            this.tsBtnRefresh.Text = "Refresh";
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnDelete.Image = global::Analogy.Properties.Resources.DeleteList_32x32;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(77, 24);
            this.tsBtnDelete.Text = "Delete";
            // 
            // tsBtnSelecAll
            // 
            this.tsBtnSelecAll.Image = global::Analogy.Properties.Resources.DifferentOddEvenPages_32x32;
            this.tsBtnSelecAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelecAll.Name = "tsBtnSelecAll";
            this.tsBtnSelecAll.Size = new System.Drawing.Size(95, 24);
            this.tsBtnSelecAll.Text = "Select All";
            // 
            // checkBoxSelectionMode
            // 
            this.checkBoxSelectionMode.BeforeTouchSize = new System.Drawing.Size(437, 19);
            this.checkBoxSelectionMode.Checked = true;
            this.checkBoxSelectionMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelectionMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxSelectionMode.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxSelectionMode.Location = new System.Drawing.Point(0, 19);
            this.checkBoxSelectionMode.Name = "checkBoxSelectionMode";
            this.checkBoxSelectionMode.Size = new System.Drawing.Size(437, 19);
            this.checkBoxSelectionMode.TabIndex = 15;
            this.checkBoxSelectionMode.Text = "Clear log between selection";
            // 
            // checkBoxRecursiveLoad
            // 
            this.checkBoxRecursiveLoad.BeforeTouchSize = new System.Drawing.Size(437, 19);
            this.checkBoxRecursiveLoad.Checked = true;
            this.checkBoxRecursiveLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursiveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRecursiveLoad.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxRecursiveLoad.Location = new System.Drawing.Point(0, 0);
            this.checkBoxRecursiveLoad.Name = "checkBoxRecursiveLoad";
            this.checkBoxRecursiveLoad.Size = new System.Drawing.Size(437, 19);
            this.checkBoxRecursiveLoad.TabIndex = 14;
            this.checkBoxRecursiveLoad.Text = "Load Recursive Files";
            // 
            // ucLogs1
            // 
            this.ucLogs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogs1.DoNotAddToRecentHistory = false;
            this.ucLogs1.ForceNoFileCaching = false;
            this.ucLogs1.Location = new System.Drawing.Point(0, 0);
            this.ucLogs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucLogs1.Name = "ucLogs1";
            this.ucLogs1.OnlineMode = false;
            this.ucLogs1.Size = new System.Drawing.Size(946, 700);
            this.ucLogs1.TabIndex = 0;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Folder_Closed.png");
            this.imageCollection1.Images.SetKeyName(1, "Folder_Opened.png");
            this.imageCollection1.Images.SetKeyName(2, "File.png");
            this.imageCollection1.Images.SetKeyName(3, "Local_Disk.png");
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1387, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1387, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1387, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
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
            // 
            // imageListBottom
            // 
            this.imageListBottom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBottom.ImageStream")));
            this.imageListBottom.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBottom.Images.SetKeyName(0, "Info_16x16.png");
            this.imageListBottom.Images.SetKeyName(1, "RichEditBookmark_16x16.png");
            this.imageListBottom.Images.SetKeyName(2, "RichEditBookmark_32x32.png");
            // 
            // tsPrimary
            // 
            this.tsPrimary.AutoSize = false;
            this.tsPrimary.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPrimary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.tsPrimary.Location = new System.Drawing.Point(0, 0);
            this.tsPrimary.Name = "tsPrimary";
            this.tsPrimary.Size = new System.Drawing.Size(1387, 46);
            this.tsPrimary.TabIndex = 6;
            this.tsPrimary.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 4";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(346, 374);
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 4";
            // 
            // bBtnOpenFolder
            // 
            this.bBtnOpenFolder.Caption = "Open";
            this.bBtnOpenFolder.Id = 2;
            this.bBtnOpenFolder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bBtnOpenFolder.ImageOptions.Image")));
            this.bBtnOpenFolder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bBtnOpenFolder.ImageOptions.LargeImage")));
            this.bBtnOpenFolder.Name = "bBtnOpenFolder";
            this.bBtnOpenFolder.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // folderTreeViewUC2
            // 
            this.folderTreeViewUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTreeViewUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.folderTreeViewUC2.Location = new System.Drawing.Point(0, 65);
            this.folderTreeViewUC2.Margin = new System.Windows.Forms.Padding(4);
            this.folderTreeViewUC2.Name = "folderTreeViewUC2";
            this.folderTreeViewUC2.Size = new System.Drawing.Size(437, 406);
            this.folderTreeViewUC2.TabIndex = 16;
            // 
            // OfflineUCLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spltMain);
            this.Controls.Add(this.tsPrimary);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfflineUCLogs";
            this.Size = new System.Drawing.Size(1387, 700);
            this.Load += new System.EventHandler(this.OfflineUCLogs_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AnalogyUCLogs_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AnalogyUCLogs_DragEnter);
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.splcLeft.Panel1.ResumeLayout(false);
            this.splcLeft.Panel2.ResumeLayout(false);
            this.splcLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).EndInit();
            this.splcLeft.ResumeLayout(false);
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxSelectionMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tsPrimary.ResumeLayout(false);
            this.tsPrimary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip tsPrimary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splcLeft;
        private System.Windows.Forms.ImageList imageListBottom;
        private UCLogs ucLogs1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bBtnOpenFolder;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private FolderTreeViewUC folderTreeViewUC1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton tsBtnOpenFolder;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnSelecAll;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxSelectionMode;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxRecursiveLoad;
        private FolderTreeViewUC folderTreeViewUC2;
    }
}
