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
using Syncfusion.Windows.Forms.Tools.Navigation;

namespace Analogy
{
    public partial class Form1 : RibbonForm
    {
        TouchStyleColorTable touch = new TouchStyleColorTable();
        bool isPopupVisible = false;

        public Form1()
        {

            InitializeComponent();
            ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2013;
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

            ribbonControlAdv1.ApplyTouchStyleColorTable(touch);
            treeViewAdv1.FullRowSelect = true;
            treeViewAdv1.HideSelection = false;
            treeViewAdv1.SelectedNode = null;
            popupControlContainer1.Visible = false;
            Load += new EventHandler(Form1_Load);
            ribbonControlAdv1.MenuButtonClick += new EventHandler(ribbonControlAdv1_MenuButtonClick);
            treeViewAdv1.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#d1e8ff"));
            treeViewAdv1.SelectedNodeForeColor = Color.Black;
            treeViewAdv1.MouseMove += new MouseEventHandler(treeViewAdv1_MouseMove);
            treeViewAdv1.MouseLeave += new EventHandler(treeViewAdv1_MouseLeave);
            popupControlContainer1.VisibleChanged += new EventHandler(popupControlContainer1_VisibleChanged);
            popupControlContainer1.BeforeCloseUp += new CancelEventHandler(popupControlContainer1_BeforeCloseUp);
            buttonEdit1.TextBox.Text = "";
            buttonEditChildButton1.Image = imageList3.Images[0];
            buttonEditChildButton1.FlatStyle = FlatStyle.Flat;
            buttonEdit1.FlatStyle = FlatStyle.Flat;
            buttonEditChildButton1.Text = "";
            listView2.BorderStyle = BorderStyle.None;
            treeViewAdv1.BorderStyle = BorderStyle.None;

            panel2.Width = 2;
            panel2.BorderStyle = BorderStyle.None;
            panel2.BackColor = ColorTranslator.FromHtml("#f7f7f7");
            listView2.Groups[0].HeaderAlignment = HorizontalAlignment.Right;
            int i = 6;
            foreach (Control ctrl in popupControlContainer1.Controls)
            {
                if (ctrl is ButtonAdv)
                {
                    ctrl.Height = 45;
                    ctrl.Text = "     " + ctrl.Text;
                    (ctrl as ButtonAdv).ImageAlign = ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).Image = imageList3.Images[i];
                    (ctrl as ButtonAdv).BeforeTouchSize = new Size(297, 38);
                    (ctrl as ButtonAdv).Dock = DockStyle.Top;
                    (ctrl as ButtonAdv).FlatAppearance.BorderSize = 0;
                    (ctrl as ButtonAdv).FlatStyle = FlatStyle.Flat;
                    (ctrl as ButtonAdv).ImageAlign = ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).IsBackStageButton = false;
                    (ctrl as ButtonAdv).Location = new Point(0, 0);
                    (ctrl as ButtonAdv).Name = "buttonAdv1";
                    (ctrl as ButtonAdv).Size = new Size(297, 38);

                    (ctrl as ButtonAdv).TextAlign = ContentAlignment.MiddleLeft;
                    (ctrl as ButtonAdv).TextImageRelation = TextImageRelation.ImageBeforeText;
                    i--;
                }

            }
            buttonAdv6.Click += new EventHandler(buttonAdv6_Click);
            ribbonControlAdv1.SelectedTab = toolStripTabItem1;

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

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x001C:
                    popupControlContainer1.HidePopup();
                    break;
            }
            base.WndProc(ref m);
        }

        private void DockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {

            dockingManager1.DockControl(panel1, this, DockingStyle.Bottom, 250);
            dockingManager1.DockControl(panel3, this, DockingStyle.Top, 250);
            //  dockingManager1.DockControl(gradientPanel1,this,DockingStyle.Left,250);
            //dockingManager1.DockControl(gradientPanel2, this, DockingStyle.Right, 250);
        }


        void buttonAdv6_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            navigationView2.Width = buttonEdit1.Left;
        }

        void popupControlContainer1_BeforeCloseUp(object sender, CancelEventArgs e)
        {
            superAccelerator1.Active = true;
        }

        void popupControlContainer1_VisibleChanged(object sender, EventArgs e)
        {
            if (popupControlContainer1.Visible)
                superAccelerator1.Active = false;
            else
                superAccelerator1.Active = true;
        }

        void treeViewAdv1_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as TreeViewAdv) == treeViewAdv1)
            {
                //this.treeViewAdv1.Nodes[0].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                for (int i = 0; i < treeViewAdv1.Nodes.Count; i++)
                {
                    foreach (TreeNodeAdv item in treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.White);

                        foreach (TreeNodeAdv node in item.Nodes)
                        {
                            node.Background = new Syncfusion.Drawing.BrushInfo(Color.White);
                        }
                    }
                }

            }
        }

        void treeViewAdv1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((sender as TreeViewAdv) == treeViewAdv1)
            {
                for (int i = 0; i < treeViewAdv1.Nodes.Count; i++)
                {
                    treeViewAdv1.Nodes[i].Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    foreach (TreeNodeAdv item in treeViewAdv1.Nodes[i].Nodes)
                    {
                        item.Background = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(0, 255, 255, 255));
                    }
                }
                if (treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y)) != null)
                {
                    TreeNodeAdv node = treeViewAdv1.GetNodeAtPoint(new Point(e.X, e.Y));
                    node.Background = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#e5f3fb"));
                }
            }
        }


        void ribbonControlAdv1_MenuButtonClick(object sender, EventArgs e)
        {
            if (!isPopupVisible)
            {
                if (sender is ToolStripDropDownButton)
                {
                    isPopupVisible = true;
                    popupControlContainer1.ShowPopup(PointToScreen(new Point((int)((sender as ToolStripDropDownButton).Bounds.X), (int)((sender as ToolStripDropDownButton).Bounds.Y + (sender as ToolStripDropDownButton).Bounds.Height))));
                }
            }
            else
            {
                isPopupVisible = false;
                popupControlContainer1.HidePopup();
            }
        }
        string substringDirectory;
        void Form1_Load(object sender, EventArgs e)
        {
            ribbonControlAdv1.MenuButtonText = "FILE";
            ribbonControlAdv1.BackStageNavigationButtonStyle = BackStageNavigationButtonStyles.Office2013;
            ribbonControlAdv1.QuickPanelAlignment = QuickPanelAlignment.Top;
            touch.CloseButtonForeColor = Color.Black;
            touch.RestoreButtonForeColor = Color.Black;
            touch.BottomToolStripBackColor = ColorTranslator.FromHtml("#ffffff");
            touch.QATDownArrowColor = Color.Black;
            touch.ToolStripSpliterColor = ColorTranslator.FromHtml("#e2e3e4");
            superAccelerator1.BackColor = ColorTranslator.FromHtml("#eaf0f8");
            popupControlContainer1.BorderStyle = BorderStyle.FixedSingle;
            popupControlContainer1.BackColor = ColorTranslator.FromHtml("#fbfcfd");
            treeViewAdv1.BorderStyle = BorderStyle.None;
            superAccelerator1.SetMenuButtonAccelerator(ribbonControlAdv1, "F");
            navigationView2.Focus();
            treeViewAdv1.AfterSelect += new EventHandler(treeViewAdv1_AfterSelect);


        }


        void treeViewAdv1_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                listView2.Items.Clear();

                TreeNodeAdv selectednode = treeViewAdv1.SelectedNode;
                selectednode.Expand();
                treeViewAdv1.Text = selectednode.FullPath;
                navigationView2.Refresh();
                Bar bar = new Bar(selectednode.Text);
                //bar.ImageIndex = selectednode.image;
                navigationView2.Bars.Add(bar);
                navigationView2.SelectedBar = bar;
                string[] splitedText = treeViewAdv1.Text.Split('\\');
                int count = 0;
                if (selectednode.Nodes.Count == 0)
                    count = 1;
                else
                    count = selectednode.Nodes.Count;
                if (selectednode.Nodes.Count > 0)
                {
                    ListViewGroup Group = new ListViewGroup("selectednode.Text", HorizontalAlignment.Left);
                    Group.Header = selectednode.Text + " (" + count + ")";
                    listView2.Groups.Add(Group);
                    foreach (TreeNodeAdv n in selectednode.Nodes)
                    {

                        ListViewItem lst = new ListViewItem(n.Text, 5);
                        listView2.Items.Add(lst);
                        lst.Group = Group;


                    }
                }
                else
                {
                    ListViewGroup Group = new ListViewGroup("selectednode.Text", HorizontalAlignment.Left);
                    Group.Header = selectednode.Text + " (" + count + ")";
                    listView2.Groups.Add(Group);
                    if (selectednode.Text == "New Volume(D:)")
                    {
                        DirectoryInfo di = new DirectoryInfo("D:\\");
                        try
                        {
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                ListViewItem lst = new ListViewItem(fi.Name, 5);
                                listView2.Items.Add(lst);
                                lst.Group = Group;
                            }
                            try
                            {
                                foreach (DirectoryInfo listd in di.GetDirectories())
                                {
                                    ListViewItem lst = new ListViewItem(listd.Name, 10);
                                    listView2.Items.Add(lst);
                                    lst.Group = Group;
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        ListViewItem lst = new ListViewItem(selectednode.Text, 1);
                        listView2.Items.Add(lst);
                        lst.Group = Group;
                        //listView2.Items.Add(selectednode.FullPath, selectednode.Text, 1);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void PopulateTreeView(string directoryValue, TreeNodeAdv parentNode)
        {
            try
            {
                if (directoryValue.Contains("C:\\Users\\Default\\AppData"))
                {
                    string[] directoryArray =
     Directory.GetDirectories(directoryValue);
                    if (directoryArray.Length != 0)
                    {
                        foreach (string directory in directoryArray)
                        {
                            substringDirectory = directory.Substring(
                            directory.LastIndexOf('\\') + 1,
                            directory.Length - directory.LastIndexOf('\\') - 1);

                            TreeNodeAdv myNode = new TreeNodeAdv(substringDirectory);
                            if (myNode.Text != "TreeNodeAdv")
                            {
                                parentNode.Nodes.Add(myNode);
                                PopulateTreeView(directory, myNode);
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // parentNode.Nodes.Add("Access denied");
            } // end catch
        }

        private void navigationView2_BarSelectionChanging(object sender, BarSelectionChangingEventArgs e)
        {
            listView2.Items.Clear();
            bool needToAdd = true;
            Bar parent = e.Bar;
            if (parent == null) return;
            if (parent.Bars.Count > 0)
            {
                needToAdd = false;
            }
            DirectoryInfo dirInfo = null;
            if (parent.Tag is DriveInfo)
            {
                DriveInfo driveInfo = (DriveInfo)parent.Tag;
                dirInfo = driveInfo.RootDirectory;

            }
            else if (parent.Tag is DirectoryInfo)
            {
                dirInfo = (DirectoryInfo)parent.Tag;
            }
            if (dirInfo != null)
            {
                try
                {
                    DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
                    FileInfo[] files = dirInfo.GetFiles();
                    foreach (DirectoryInfo directoryInfo in subDirectories)
                    {
                        Bar node = new Bar();
                        node.Tag = directoryInfo;
                        node.Text = directoryInfo.FullName;
                        node.ImageIndex = 8;
                        if (needToAdd)
                            parent.Bars.Add(node);
                        listView2.Items.Add(node.Text, 5);
                    }
                    foreach (FileInfo file in files)
                    {
                        listView2.Items.Add(file.FullName, 5);
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show(this, ex.Message, "Info");
                }
            }
            else if (parent.Text == "MyComputer")
            {
                listView1.Items.Add("Local Disk(C:)", 8);
            }
        }


    }
}
