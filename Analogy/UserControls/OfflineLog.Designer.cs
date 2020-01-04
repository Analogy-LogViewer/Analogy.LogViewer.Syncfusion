﻿namespace Analogy
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageListBottom = new System.Windows.Forms.ImageList(this.components);
            this.tsPrimary = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.treeList1 = new DirectoryListing();
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
            this.splcLeft.Panel2.Controls.Add(this.treeList1);
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
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 65);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(437, 406);
            this.treeList1.TabIndex = 16;
            // 
            // OfflineUCLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spltMain);
            this.Controls.Add(this.tsPrimary);
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
        private FolderTreeViewUC folderTreeViewUC1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton tsBtnOpenFolder;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnSelecAll;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxSelectionMode;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxRecursiveLoad;
        private DirectoryListing treeList1;
    }
}
