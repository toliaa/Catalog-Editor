using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileManagerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            treeView.Nodes.Clear();
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name)
                {
                    Tag = info
                };
                GetDirectories(info.GetDirectories(), rootNode);
                treeView.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0)
                {
                    Tag = subDir,
                    ImageKey = "folder"
                };
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(txtDirectoryPath.Text);
            PopulateTreeView();
        }

        private void btnDeleteDirectory_Click(object sender, EventArgs e)
        {
            Directory.Delete(txtDirectoryPath.Text, true);
            PopulateTreeView();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            File.Create(txtFilePath.Text).Close();
            PopulateTreeView();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete(txtFilePath.Text);
            PopulateTreeView();
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            File.Copy(txtSourceFilePath.Text, txtDestFilePath.Text, true);
            PopulateTreeView();
        }

        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            File.Move(txtSourceFilePath.Text, txtDestFilePath.Text);
            PopulateTreeView();
        }

        private void btnEditFileAttributes_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(txtFilePath.Text);
            fileInfo.Attributes = (FileAttributes)Enum.Parse(typeof(FileAttributes), txtFileAttributes.Text);
        }

        private void btnEditTextFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtFilePath.Text, txtFileContent.Text);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ZipFile.CreateFromDirectory(txtSourceDirectory.Text, txtZipFilePath.Text);
            PopulateTreeView();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(txtZipFilePath.Text, txtExtractDirectory.Text);
            PopulateTreeView();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo nodeDirInfo = (DirectoryInfo)e.Node.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            listView.Items.Clear();

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item,
                    dir.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item,
                    file.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
