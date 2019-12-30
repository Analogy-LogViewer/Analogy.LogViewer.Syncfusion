
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Types;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using TreeNodeAdv = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv;

namespace Analogy
{
    public partial class XtraUCFileSystem : UserControl
    {
        //todo
        public event EventHandler<EventArgs> SelectionChanged;
        public event EventHandler<FolderSelectionEventArgs> FolderChanged;
        private string startupDrive;
        private bool ListFolders;
        private bool ListFiles;
        private IAnalogyOfflineDataProvider DataProvider { get; set; }

        public XtraUCFileSystem() : this(false, false)
        {

        }
        public XtraUCFileSystem(bool listFoldersToLoad, bool listFilesToLoad)
        {
            ListFolders = listFoldersToLoad;
            ListFiles = listFilesToLoad;
            InitializeComponent();
            treeColumnAdv1.BaseStyle = (multiColumnTreeView1.BaseStylePairs[2] as StyleNamePair)?.Name;
            multiColumnTreeView1.BeforeExpand += multiColumnTreeView1_BeforeExpand;
            //this.MinimumSize = this.Size;


        }

        bool IsFile(DirectoryInfo info)
        {
            try
            {
                return (info.Attributes & FileAttributes.Directory) == 0;
            }
            catch
            {
                return false;
            }
        }
        bool IsDrive(string val)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                if (drive.Equals(val)) return true;
            }
            return false;
        }

        public void SetPath(string path, IAnalogyOfflineDataProvider dataProvider)
        {
            DataProvider = dataProvider;
            startupDrive = path;
            multiColumnTreeView1.Nodes.Clear();
            TreeNodeAdv root = new TreeNodeAdv();
            root.Text = path;
            multiColumnTreeView1.Nodes.AddRange(new[] { root });
            multiColumnTreeView1.Nodes[0].Expanded = true;
            multiColumnTreeView1.SelectedNode = multiColumnTreeView1.Nodes[0];
            multiColumnTreeView1.Focus();
        }


        public void IsFolderMode(bool listFolders, bool listFiles)
        {
            ListFolders = listFolders;
            ListFiles = listFiles;

        }

        void multiColumnTreeView1_BeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            try
            {
                //Checking whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                DirectoryInfo dir = null;
                DirectoryInfo[] subDir = null;
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
            catch { }
        }

        public void SortLastChanged(SortOrder order)
        {
            //todo
        }

        public List<string> GetSelection()
        {
            //todo:
            return new List<string>();
        }

        public void SelectAll()
        {
            //todo:
        }

        public void HighlightFile(string dataFile)
        {
            //todo
        }
        public void Clear()
        {
            //todo
            
        }

        public void Add(string name, DateTime lastWriteTime, long length, string fullName)
        {
            //
        }
    }
}
