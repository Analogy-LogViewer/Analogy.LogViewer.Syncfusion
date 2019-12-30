using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;

namespace Analogy
{
    public partial class XtraUCFileSystem : XtraUserControl
    {
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
            Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv root = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv();
            DriveInfo drive = new DriveInfo(Environment.SystemDirectory);
            root.Text = drive.ToString();
            multiColumnTreeView1.Nodes.AddRange(new[] {root});

            treeColumnAdv1 = new TreeColumnAdv();
            treeColumnAdv2 = new TreeColumnAdv();
            treeColumnAdv3 = new TreeColumnAdv();

            treeColumnAdv1.HelpText = "Name";
            treeColumnAdv1.Highlighted = false;
            treeColumnAdv1.Text = "Name";
            treeColumnAdv1.Background = new Syncfusion.Drawing.BrushInfo(SystemColors.Highlight);
            treeColumnAdv1.AreaBackground = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, Color.White, Color.Snow);
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv2.HelpText = "Full Path";
            treeColumnAdv2.Highlighted = false;
            treeColumnAdv2.Text = "Full Path";
            treeColumnAdv2.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;

            treeColumnAdv3.HelpText = "Date Modified";
            treeColumnAdv3.Highlighted = false;
            treeColumnAdv3.Text = "Date Modified";
            treeColumnAdv3.Background = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, SystemColors.Highlight, SystemColors.Highlight);
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;

            multiColumnTreeView1.Columns.AddRange(new[]{
                treeColumnAdv1,treeColumnAdv2,treeColumnAdv3});
            multiColumnTreeView1.AutoSizeMode = Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.AutoSizeMode.Fill;
            Load += MultiColumnTreeViewDemo_Load;
            multiColumnTreeView1.BeforeExpand += multiColumnTreeView1_BeforeExpand;
            //this.MinimumSize = this.Size;
            treeColumnAdv1.BaseStyle = (multiColumnTreeView1.BaseStylePairs[2] as Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair).Name;
            treeColumnAdv1.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv2.BorderStyle = BorderStyle.FixedSingle;
            treeColumnAdv3.BorderStyle = BorderStyle.FixedSingle;
            multiColumnTreeView1.FullRowSelect = true;
           
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

        private void treeList1_VirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            //if (!loadDrives)
            //{
            //    string[] roots = Directory.GetLogicalDrives();
            //    e.Children = roots;
            //    loadDrives = true;
            //}
            {
                try
                {
                    string path = startupDrive;
                    if (e.Node is string node)
                        path = node;
                    if (Directory.Exists(path))
                    {
                        string[] dirs = new string[0];
                        if (ListFolders)
                            try
                            {
                                dirs = Directory.GetDirectories(path);
                            }
                            catch (Exception)
                            {
                                dirs = new string[0];
                            }
                        string[] files = ListFiles ? DataProvider.GetSupportedFiles(new DirectoryInfo(path), false).Select(f => f.Name).ToArray() : new string[0];
                        string[] arr = new string[dirs.Length + files.Length];
                        if (ListFolders)
                            dirs.CopyTo(arr, 0);
                        if (!ListFolders)
                            files.CopyTo(arr, dirs.Length);
                        e.Children = arr;
                    }
                    else e.Children = new object[] { };
                }
                catch { e.Children = new object[] { }; }
            }
            Cursor.Current = current;

        }

        public void SetPath(string path, IAnalogyOfflineDataProvider dataProvider)
        {
            DataProvider = dataProvider;
            startupDrive = path;
            treeList1.ClearNodes();
            treeList1.DataSource = new object();
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null) return;
            FolderChanged?.Invoke(this, new FolderSelectionEventArgs(e.Node.GetDisplayText("Path")));
        }

        public void SetListing(bool listFolders, bool listFiles)
        {
            ListFolders = listFolders;
            ListFiles = listFiles;
            colType.Visible = false;
            if (listFolders & !listFiles)
            {
                colSize.Visible = false;
                treeList1.OptionsSelection.MultiSelect = false;
            }
            else
            {
                colSize.Visible = true;
                treeList1.OptionsSelection.MultiSelect = true;
                treeList1.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect;
            }
        }


        void MultiColumnTreeViewDemo_Load(object sender, EventArgs e)
        {
            multiColumnTreeView1.Nodes[0].Expanded = true;
            multiColumnTreeView1.SelectedNode = multiColumnTreeView1.Nodes[0];
            multiColumnTreeView1.Focus();
        }

        void multiColumnTreeView1_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeViewAdvCancelableNodeEventArgs e)
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

                        Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv node = new Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdv(dirinfo.Name);

                        node.SubItems.AddRange(new[]{
                            subitem1,subitem2});
                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }
    }
}
