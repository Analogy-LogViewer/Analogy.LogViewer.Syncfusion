namespace Analogy
{
    partial class FileSystemUC
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.splcLeft = new System.Windows.Forms.SplitContainer();
            this.tvFolderUC = new Analogy.FolderTreeViewUC();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lBoxFiles = new System.Windows.Forms.ListBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.checkBoxRecursiveLoad = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).BeginInit();
            this.splcLeft.Panel1.SuspendLayout();
            this.splcLeft.Panel2.SuspendLayout();
            this.splcLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // splcLeft
            // 
            this.splcLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcLeft.Location = new System.Drawing.Point(0, 20);
            this.splcLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splcLeft.Name = "splcLeft";
            this.splcLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcLeft.Panel1
            // 
            this.splcLeft.Panel1.Controls.Add(this.tvFolderUC);
            // 
            // splcLeft.Panel2
            // 
            this.splcLeft.Panel2.Controls.Add(this.lBoxFiles);
            this.splcLeft.Panel2.Controls.Add(this.toolStripEx1);
            this.splcLeft.Panel2.Controls.Add(this.checkBoxRecursiveLoad);
            this.splcLeft.Size = new System.Drawing.Size(523, 406);
            this.splcLeft.SplitterDistance = 192;
            this.splcLeft.TabIndex = 5;
            // 
            // tvFolderUC
            // 
            this.tvFolderUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFolderUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tvFolderUC.Location = new System.Drawing.Point(0, 0);
            this.tvFolderUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvFolderUC.Name = "tvFolderUC";
            this.tvFolderUC.Size = new System.Drawing.Size(523, 192);
            this.tvFolderUC.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.Visible = false;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(523, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 426);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(523, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(523, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // lBoxFiles
            // 
            this.lBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxFiles.FormattingEnabled = true;
            this.lBoxFiles.ItemHeight = 16;
            this.lBoxFiles.Location = new System.Drawing.Point(0, 46);
            this.lBoxFiles.Name = "lBoxFiles";
            this.lBoxFiles.Size = new System.Drawing.Size(523, 164);
            this.lBoxFiles.TabIndex = 9;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 19);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripEx1.Size = new System.Drawing.Size(523, 27);
            this.toolStripEx1.TabIndex = 10;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Analogy.Properties.Resources.Open2_32x32;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(69, 24);
            this.btnOpen.Text = "Open";
            // 
            // checkBoxRecursiveLoad
            // 
            this.checkBoxRecursiveLoad.BeforeTouchSize = new System.Drawing.Size(523, 19);
            this.checkBoxRecursiveLoad.Checked = true;
            this.checkBoxRecursiveLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursiveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRecursiveLoad.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxRecursiveLoad.Location = new System.Drawing.Point(0, 0);
            this.checkBoxRecursiveLoad.Name = "checkBoxRecursiveLoad";
            this.checkBoxRecursiveLoad.Size = new System.Drawing.Size(523, 19);
            this.checkBoxRecursiveLoad.TabIndex = 12;
            this.checkBoxRecursiveLoad.Text = "Load Recursive Files";
            // 
            // FileSystemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splcLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileSystemUC";
            this.Size = new System.Drawing.Size(523, 450);
            this.splcLeft.Panel1.ResumeLayout(false);
            this.splcLeft.Panel2.ResumeLayout(false);
            this.splcLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcLeft)).EndInit();
            this.splcLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxRecursiveLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splcLeft;
        private FolderTreeViewUC tvFolderUC;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ListBox lBoxFiles;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxRecursiveLoad;
    }
}
