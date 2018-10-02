using IMGOgranizer.Extension;

namespace IMGOgranizer
{
    partial class IMGOrganizer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMGOrganizer));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbPatchToSourceFolder = new System.Windows.Forms.TextBox();
            this.btChoseSourceFolderDialog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMoveCopiedFiles = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNewDirectoryName = new System.Windows.Forms.TextBox();
            this.cbCreateNewDirectoryToCopiedFiles = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btChoseDestinationFolderDialog = new System.Windows.Forms.Button();
            this.tbPatchToDestinationFolder = new System.Windows.Forms.TextBox();
            this.btExecuteOperation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPatchToSourceFolder
            // 
            this.tbPatchToSourceFolder.BackColor = System.Drawing.SystemColors.Window;
            this.tbPatchToSourceFolder.Enabled = false;
            this.tbPatchToSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPatchToSourceFolder.Location = new System.Drawing.Point(6, 58);
            this.tbPatchToSourceFolder.Name = "tbPatchToSourceFolder";
            this.tbPatchToSourceFolder.Size = new System.Drawing.Size(291, 22);
            this.tbPatchToSourceFolder.TabIndex = 1;
            // 
            // btChoseSourceFolderDialog
            // 
            this.btChoseSourceFolderDialog.Location = new System.Drawing.Point(6, 19);
            this.btChoseSourceFolderDialog.Name = "btChoseSourceFolderDialog";
            this.btChoseSourceFolderDialog.Size = new System.Drawing.Size(291, 33);
            this.btChoseSourceFolderDialog.TabIndex = 0;
            this.btChoseSourceFolderDialog.Text = "Chose Source Folder";
            this.btChoseSourceFolderDialog.UseVisualStyleBackColor = true;
            this.btChoseSourceFolderDialog.Click += new System.EventHandler(this.btChoseSourceFolderDialog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChoseSourceFolderDialog);
            this.groupBox1.Controls.Add(this.tbPatchToSourceFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source ";
            // 
            // cbMoveCopiedFiles
            // 
            this.cbMoveCopiedFiles.AutoSize = true;
            this.cbMoveCopiedFiles.Location = new System.Drawing.Point(6, 28);
            this.cbMoveCopiedFiles.Name = "cbMoveCopiedFiles";
            this.cbMoveCopiedFiles.Size = new System.Drawing.Size(77, 17);
            this.cbMoveCopiedFiles.TabIndex = 6;
            this.cbMoveCopiedFiles.Text = "Move Files";
            this.cbMoveCopiedFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNewDirectoryName);
            this.groupBox3.Controls.Add(this.cbCreateNewDirectoryToCopiedFiles);
            this.groupBox3.Controls.Add(this.cbMoveCopiedFiles);
            this.groupBox3.Location = new System.Drawing.Point(14, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // tbNewDirectoryName
            // 
            this.tbNewDirectoryName.Location = new System.Drawing.Point(176, 26);
            this.tbNewDirectoryName.Name = "tbNewDirectoryName";
            this.tbNewDirectoryName.Size = new System.Drawing.Size(119, 20);
            this.tbNewDirectoryName.TabIndex = 9;
            // 
            // cbCreateNewDirectoryToCopiedFiles
            // 
            this.cbCreateNewDirectoryToCopiedFiles.AutoSize = true;
            this.cbCreateNewDirectoryToCopiedFiles.Location = new System.Drawing.Point(89, 28);
            this.cbCreateNewDirectoryToCopiedFiles.Name = "cbCreateNewDirectoryToCopiedFiles";
            this.cbCreateNewDirectoryToCopiedFiles.Size = new System.Drawing.Size(91, 17);
            this.cbCreateNewDirectoryToCopiedFiles.TabIndex = 7;
            this.cbCreateNewDirectoryToCopiedFiles.Text = "New directory";
            this.cbCreateNewDirectoryToCopiedFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btChoseDestinationFolderDialog);
            this.groupBox2.Controls.Add(this.tbPatchToDestinationFolder);
            this.groupBox2.Location = new System.Drawing.Point(13, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // btChoseDestinationFolderDialog
            // 
            this.btChoseDestinationFolderDialog.Location = new System.Drawing.Point(8, 19);
            this.btChoseDestinationFolderDialog.Name = "btChoseDestinationFolderDialog";
            this.btChoseDestinationFolderDialog.Size = new System.Drawing.Size(289, 33);
            this.btChoseDestinationFolderDialog.TabIndex = 0;
            this.btChoseDestinationFolderDialog.Text = "Chose Destination Folder";
            this.btChoseDestinationFolderDialog.UseVisualStyleBackColor = true;
            this.btChoseDestinationFolderDialog.Click += new System.EventHandler(this.btChoseDestinationFolderDialog_Click);
            // 
            // tbPatchToDestinationFolder
            // 
            this.tbPatchToDestinationFolder.Enabled = false;
            this.tbPatchToDestinationFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPatchToDestinationFolder.Location = new System.Drawing.Point(7, 61);
            this.tbPatchToDestinationFolder.Name = "tbPatchToDestinationFolder";
            this.tbPatchToDestinationFolder.Size = new System.Drawing.Size(290, 22);
            this.tbPatchToDestinationFolder.TabIndex = 1;
            // 
            // btExecuteOperation
            // 
            this.btExecuteOperation.BackColor = System.Drawing.Color.OrangeRed;
            this.btExecuteOperation.Enabled = false;
            this.btExecuteOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExecuteOperation.ForeColor = System.Drawing.SystemColors.Control;
            this.btExecuteOperation.Location = new System.Drawing.Point(11, 289);
            this.btExecuteOperation.Name = "btExecuteOperation";
            this.btExecuteOperation.Size = new System.Drawing.Size(305, 55);
            this.btExecuteOperation.TabIndex = 8;
            this.btExecuteOperation.Text = "EXECUTE";
            this.btExecuteOperation.UseVisualStyleBackColor = false;
            this.btExecuteOperation.Click += new System.EventHandler(this.btExecuteOperation_Click);
            // 
            // IMGOrganizer
            // 
            this.AcceptButton = this.btExecuteOperation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 356);
            this.Controls.Add(this.btExecuteOperation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IMGOrganizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMGOrganizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox tbPatchToSourceFolder;
        private System.Windows.Forms.Button btChoseSourceFolderDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMoveCopiedFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btChoseDestinationFolderDialog;
        private System.Windows.Forms.TextBox tbPatchToDestinationFolder;
        private System.Windows.Forms.Button btExecuteOperation;
        private System.Windows.Forms.CheckBox cbCreateNewDirectoryToCopiedFiles;
        private System.Windows.Forms.TextBox tbNewDirectoryName;
    }
}

