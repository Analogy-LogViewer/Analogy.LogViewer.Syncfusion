﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.Types;

namespace Analogy
{
    public partial class FileSystemUC : UserControl
    {
        private IAnalogyOfflineDataProvider _dataProvider;
        public event EventHandler<SelectionEventArgs> SelectionChanged;
        public bool ZipFilesOnly { get; set; }

        public IAnalogyOfflineDataProvider DataProvider
        {
            get => _dataProvider;
            set
            {
                _dataProvider = value;
                if (value != null)
                {
                    tvFolderUC.SetFolder(value.InitialFolderFullPath, _dataProvider);
                }
            }
        }

        public FileSystemUC()
        {
            InitializeComponent();
            tvFolderUC.FolderChanged += TvFolderUC_FolderChanged;
            btnOpen.Click += (s, e) =>
            {
                if (lBoxFiles.SelectedItem != null)
                {
                    var filename = (lBoxFiles.SelectedItem as FileInfo)?.FullName;
                    if (filename == null || !File.Exists(filename)) return;
                    Process.Start("explorer.exe", "/select, \"" + filename + "\"");
                }
            };
        }

        private void TvFolderUC_FolderChanged(object sender, FolderSelectionEventArgs e)
        {
            lBoxFiles.SelectedIndexChanged -= lBoxFiles_SelectedIndexChanged;
            DirectoryInfo dirInfo = new DirectoryInfo(e.SelectedFolderPath);
            bool recursive = checkBoxRecursiveLoad.Checked;
            List<FileInfo> fileInfos = (ZipFilesOnly ? dirInfo.GetFiles("*.zip").ToList() : DataProvider.GetSupportedFiles(dirInfo, recursive)).OrderByDescending(f => f.LastWriteTime).ToList();
            lBoxFiles.DisplayMember = recursive ? "FullName" : "Name";
            lBoxFiles.DataSource = fileInfos;
            lBoxFiles.SelectedIndexChanged += lBoxFiles_SelectedIndexChanged;
            SelectionChangedNotify();

        }
        private void lBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChangedNotify();
        }

        private void SelectionChangedNotify()
        {
            SelectionChanged?.Invoke(this,
                new SelectionEventArgs(lBoxFiles.SelectedItems.Cast<FileInfo>().Select(f => f.FullName).ToList()));
        }
        public List<string> GetSelectedFileNames() =>
            lBoxFiles.SelectedItems.Cast<FileInfo>().Select(f => f.FullName).ToList();

    }

}
