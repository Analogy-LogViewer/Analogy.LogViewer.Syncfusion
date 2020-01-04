using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Analogy.Interfaces;
using Analogy.Types;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Syncfusion.Drawing;
using Syncfusion.WinForms.Controls;
using TreeNodeAdv = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv;

namespace Analogy
{
    public partial class DirectoryListing : UserControl
    {
        public bool ShowFolders { get; set; }
        public event EventHandler<EventArgs> SelectionChanged;
        public event EventHandler<FolderSelectionEventArgs> FolderChanged;
        TreeColumnAdv treeColumnAdv1;
        TreeColumnAdv treeColumnAdv2;
        TreeColumnAdv treeColumnAdv3;

        public DirectoryListing()
        {
            InitializeComponent();

            TreeNodeAdv root = new TreeNodeAdv();
            DriveInfo drive = new DriveInfo(Environment.SystemDirectory);
            root.Text = drive.ToString();
            multiColumnTreeView1.Nodes.AddRange(new[] {
            root});

            treeColumnAdv1 = new TreeColumnAdv();
            treeColumnAdv2 = new TreeColumnAdv();
            treeColumnAdv3 = new TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Background = new BrushInfo(SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new BrushInfo(GradientStyle.ForwardDiagonal, Color.White, Color.Snow);
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Background = new BrushInfo(GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Background = new BrushInfo(GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;

            multiColumnTreeView1.Columns.AddRange(new[]{
                treeColumnAdv1,treeColumnAdv2,treeColumnAdv3});
            multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;
            Load += new EventHandler(MultiColumnTreeViewDemo_Load);
            multiColumnTreeView1.BeforeExpand += new TreeViewAdvCancelableNodeEventHandler(multiColumnTreeView1_BeforeExpand);
            //this.MinimumSize = this.Size;
            treeColumnAdv1.BaseStyle = (multiColumnTreeView1.BaseStylePairs[2] as StyleNamePair).Name;
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
            multiColumnTreeView1.FullRowSelect = true;
        }

        


        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            multiColumnTreeView1.Nodes[0].Expanded = true;
            multiColumnTreeView1.SelectedNode = multiColumnTreeView1.Nodes[0];
            multiColumnTreeView1.Focus();
        }

        void multiColumnTreeView1_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir;
                DirectoryInfo[] subDir;
                if (multiColumnTreeView1.Nodes[0].Nodes.Count == 0) //Root directory
                {
                    DriveInfo drive = new DriveInfo(e.Node.Text);
                    dir = drive.RootDirectory;

                    subDir = dir.GetDirectories();
                }

                else
                {
                    //Get the Path of the node and AddSeparatorAtEnd Property set to true
                    string path = e.Node.GetPath("\\");

                    dir = new DirectoryInfo(path);
                    subDir = dir.GetDirectories();
                }

                if (subDir != null)
                {
                    foreach (DirectoryInfo dirinfo in subDir)
                    {
                        TreeNodeAdvSubItem subitem1 = new TreeNodeAdvSubItem();
                        TreeNodeAdvSubItem subitem2 = new TreeNodeAdvSubItem();

                        subitem1.Text = dirinfo.FullName;
                        subitem1.HelpText = subitem1.Text;

                        subitem2.Text = dirinfo.LastWriteTime.ToString();
                        subitem2.HelpText = subitem2.Text;

                        TreeNodeAdv node = new TreeNodeAdv(dirinfo.Name);

                        node.SubItems.AddRange(new[]{
                            subitem1,subitem2});
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        public List<string> GetSelection()
        {
            //todo
            return new List<string>();
        }

        public void SelectAll()
        {
            //todo
        }

        public void SortLastChanged(SortOrder sortOrder)
        {
            //todo
        }

        public void Clear()
        {
            //todo
        }

        public void HighlightFile(string file)
        {
            //todo
        }

        public void Add(string fileName, DateTime fileLastWriteTime, long fileLength, string fileFullName)
        {
            //todo
        }

        public void SetPath(string folderPath, IAnalogyOfflineDataProvider dataProvider)
        {
         //todo
        }
    }
}
