namespace Analogy
{
    partial class FolderTreeViewUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderTreeViewUC));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new Syncfusion.WinForms.Controls.SfButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this._fileFolderTreeViewUcFileSystem1 = new Analogy.FileFolderTreeViewUC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbFolder);
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 23);
            this.panel2.TabIndex = 5;
            // 
            // txtbFolder
            // 
            this.txtbFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbFolder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFolder.Location = new System.Drawing.Point(0, 0);
            this.txtbFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbFolder.Name = "txtbFolder";
            this.txtbFolder.Size = new System.Drawing.Size(418, 27);
            this.txtbFolder.TabIndex = 12;
            this.txtbFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbFolder_KeyUp);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AccessibleName = "Button";
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(418, 0);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(26, 23);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
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
            // _fileFolderTreeViewUcFileSystem1
            // 
            this._fileFolderTreeViewUcFileSystem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileFolderTreeViewUcFileSystem1.Location = new System.Drawing.Point(0, 23);
            this._fileFolderTreeViewUcFileSystem1.Margin = new System.Windows.Forms.Padding(2);
            this._fileFolderTreeViewUcFileSystem1.Name = "_fileFolderTreeViewUcFileSystem1";
            this._fileFolderTreeViewUcFileSystem1.Size = new System.Drawing.Size(444, 288);
            this._fileFolderTreeViewUcFileSystem1.TabIndex = 6;
            // 
            // FolderTreeViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._fileFolderTreeViewUcFileSystem1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "FolderTreeViewUC";
            this.Size = new System.Drawing.Size(444, 311);
            this.Load += new System.EventHandler(this.FolderTreeViewUC_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbFolder;
        private System.Windows.Forms.ImageList imageList;
        private Syncfusion.WinForms.Controls.SfButton btnOpenFile;
        private FileFolderTreeViewUC _fileFolderTreeViewUcFileSystem1;
    }
}
