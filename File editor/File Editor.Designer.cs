namespace FileManagerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnDeleteDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnMoveFile = new System.Windows.Forms.Button();
            this.btnEditFileAttributes = new System.Windows.Forms.Button();
            this.btnEditTextFile = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.txtDestFilePath = new System.Windows.Forms.TextBox();
            this.txtFileAttributes = new System.Windows.Forms.TextBox();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtZipFilePath = new System.Windows.Forms.TextBox();
            this.txtExtractDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblSourceFilePath = new System.Windows.Forms.Label();
            this.lblDestFilePath = new System.Windows.Forms.Label();
            this.lblFileAttributes = new System.Windows.Forms.Label();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.lblZipFilePath = new System.Windows.Forms.Label();
            this.lblExtractDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // TreeView
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Size = new System.Drawing.Size(200, 400);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);

            // ListView
            this.listView.Location = new System.Drawing.Point(220, 12);
            this.listView.Size = new System.Drawing.Size(400, 400);
            this.listView.View = System.Windows.Forms.View.Details;

            // Labels
            this.lblDirectoryPath.Text = "Directory Path:";
            this.lblDirectoryPath.Location = new System.Drawing.Point(630, 12);
            this.lblFilePath.Text = "File Path:";
            this.lblFilePath.Location = new System.Drawing.Point(630, 72);
            this.lblSourceFilePath.Text = "Source File Path:";
            this.lblSourceFilePath.Location = new System.Drawing.Point(630, 132);
            this.lblDestFilePath.Text = "Destination File Path:";
            this.lblDestFilePath.Location = new System.Drawing.Point(630, 192);
            this.lblFileAttributes.Text = "File Attributes:";
            this.lblFileAttributes.Location = new System.Drawing.Point(630, 252);
            this.lblFileContent.Text = "File Content:";
            this.lblFileContent.Location = new System.Drawing.Point(630, 312);
            this.lblSourceDirectory.Text = "Source Directory:";
            this.lblSourceDirectory.Location = new System.Drawing.Point(630, 372);
            this.lblZipFilePath.Text = "Zip File Path:";
            this.lblZipFilePath.Location = new System.Drawing.Point(630, 432);
            this.lblExtractDirectory.Text = "Extract Directory:";
            this.lblExtractDirectory.Location = new System.Drawing.Point(630, 492);

            // TextBoxes
            this.txtDirectoryPath.Location = new System.Drawing.Point(630, 32);
            this.txtDirectoryPath.Size = new System.Drawing.Size(200, 20);
            this.txtFilePath.Location = new System.Drawing.Point(630, 92);
            this.txtFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtSourceFilePath.Location = new System.Drawing.Point(630, 152);
            this.txtSourceFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtDestFilePath.Location = new System.Drawing.Point(630, 212);
            this.txtDestFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtFileAttributes.Location = new System.Drawing.Point(630, 272);
            this.txtFileAttributes.Size = new System.Drawing.Size(200, 20);
            this.txtFileContent.Location = new System.Drawing.Point(630, 332);
            this.txtFileContent.Size = new System.Drawing.Size(200, 20);
            this.txtSourceDirectory.Location = new System.Drawing.Point(630, 392);
            this.txtSourceDirectory.Size = new System.Drawing.Size(200, 20);
            this.txtZipFilePath.Location = new System.Drawing.Point(630, 452);
            this.txtZipFilePath.Size = new System.Drawing.Size(200, 20);
            this.txtExtractDirectory.Location = new System.Drawing.Point(630, 512);
            this.txtExtractDirectory.Size = new System.Drawing.Size(200, 20);

            // Buttons
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.Location = new System.Drawing.Point(630, 550);
            this.btnCreateDirectory.Size = new System.Drawing.Size(100, 30);
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);

            this.btnDeleteDirectory.Text = "Delete Directory";
            this.btnDeleteDirectory.Location = new System.Drawing.Point(740, 550);
            this.btnDeleteDirectory.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteDirectory.Click += new System.EventHandler(this.btnDeleteDirectory_Click);

            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.Location = new System.Drawing.Point(630, 590);
            this.btnCreateFile.Size = new System.Drawing.Size(100, 30);
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);

            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.Location = new System.Drawing.Point(740, 590);
            this.btnDeleteFile.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);

            this.btnCopyFile.Text = "Copy File";
            this.btnCopyFile.Location = new System.Drawing.Point(630, 630);
            this.btnCopyFile.Size = new System.Drawing.Size(100, 30);
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);

            this.btnMoveFile.Text = "Move File";
            this.btnMoveFile.Location = new System.Drawing.Point(740, 630);
            this.btnMoveFile.Size = new System.Drawing.Size(100, 30);
            this.btnMoveFile.Click += new System.EventHandler(this.btnMoveFile_Click);

            this.btnEditFileAttributes.Text = "Edit File Attributes";
            this.btnEditFileAttributes.Location = new System.Drawing.Point(630, 670);
            this.btnEditFileAttributes.Size = new System.Drawing.Size(210, 30);
            this.btnEditFileAttributes.Click += new System.EventHandler(this.btnEditFileAttributes_Click);

            this.btnEditTextFile.Text = "Edit Text File";
            this.btnEditTextFile.Location = new System.Drawing.Point(630, 710);
            this.btnEditTextFile.Size = new System.Drawing.Size(210, 30);
            this.btnEditTextFile.Click += new System.EventHandler(this.btnEditTextFile_Click);

            this.btnArchive.Text = "Archive";
            this.btnArchive.Location = new System.Drawing.Point(630, 750);
            this.btnArchive.Size = new System.Drawing.Size(100, 30);
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);

            this.btnExtract.Text = "Extract";
            this.btnExtract.Location = new System.Drawing.Point(740, 750);
            this.btnExtract.Size = new System.Drawing.Size(100, 30);
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);

            // Add controls to form
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnDeleteDirectory);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnCopyFile);
            this.Controls.Add(this.btnMoveFile);
            this.Controls.Add(this.btnEditFileAttributes);
            this.Controls.Add(this.btnEditTextFile);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtSourceFilePath);
            this.Controls.Add(this.txtDestFilePath);
            this.Controls.Add(this.txtFileAttributes);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.txtZipFilePath);
            this.Controls.Add(this.txtExtractDirectory);
            this.Controls.Add(this.lblDirectoryPath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblSourceFilePath);
            this.Controls.Add(this.lblDestFilePath);
            this.Controls.Add(this.lblFileAttributes);
            this.Controls.Add(this.lblFileContent);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.lblZipFilePath);
            this.Controls.Add(this.lblExtractDirectory);

            this.Text = "File Manager";
            this.ClientSize = new System.Drawing.Size(850, 800);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnDeleteDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button btnMoveFile;
        private System.Windows.Forms.Button btnEditFileAttributes;
        private System.Windows.Forms.Button btnEditTextFile;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.TextBox txtDestFilePath;
        private System.Windows.Forms.TextBox txtFileAttributes;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.TextBox txtZipFilePath;
        private System.Windows.Forms.TextBox txtExtractDirectory;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblSourceFilePath;
        private System.Windows.Forms.Label lblDestFilePath;
        private System.Windows.Forms.Label lblFileAttributes;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Label lblZipFilePath;
        private System.Windows.Forms.Label lblExtractDirectory;
    }
}
