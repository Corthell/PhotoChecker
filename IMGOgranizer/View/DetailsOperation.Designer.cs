namespace IMGOgranizer.View
{
    partial class DetailsOperation
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
            this.rbPatchFiles = new System.Windows.Forms.RichTextBox();
            this.lbNumberFilesToTransfer = new System.Windows.Forms.Label();
            this.lbTransfered = new System.Windows.Forms.Label();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbNumberFilesToTransferValue = new System.Windows.Forms.Label();
            this.lbTransferedValue = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.lbNumberTargetFilesValue = new System.Windows.Forms.Label();
            this.lbNumberTargetFiles = new System.Windows.Forms.Label();
            this.lbNumberSourceFilesValue = new System.Windows.Forms.Label();
            this.lbNumberSourceFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbPatchFiles
            // 
            this.rbPatchFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPatchFiles.Location = new System.Drawing.Point(12, 126);
            this.rbPatchFiles.Name = "rbPatchFiles";
            this.rbPatchFiles.Size = new System.Drawing.Size(303, 222);
            this.rbPatchFiles.TabIndex = 0;
            this.rbPatchFiles.Text = "";
            // 
            // lbNumberFilesToTransfer
            // 
            this.lbNumberFilesToTransfer.Location = new System.Drawing.Point(66, 76);
            this.lbNumberFilesToTransfer.Name = "lbNumberFilesToTransfer";
            this.lbNumberFilesToTransfer.Size = new System.Drawing.Size(153, 18);
            this.lbNumberFilesToTransfer.TabIndex = 1;
            this.lbNumberFilesToTransfer.Text = "Number of files to transfer:";
            this.lbNumberFilesToTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTransfered
            // 
            this.lbTransfered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTransfered.Location = new System.Drawing.Point(49, 94);
            this.lbTransfered.Name = "lbTransfered";
            this.lbTransfered.Size = new System.Drawing.Size(170, 18);
            this.lbTransfered.TabIndex = 2;
            this.lbTransfered.Text = "Transfered:";
            this.lbTransfered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSuccess
            // 
            this.lbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSuccess.Location = new System.Drawing.Point(30, 9);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(285, 18);
            this.lbSuccess.TabIndex = 3;
            this.lbSuccess.Text = "Operation successful";
            this.lbSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumberFilesToTransferValue
            // 
            this.lbNumberFilesToTransferValue.Location = new System.Drawing.Point(225, 76);
            this.lbNumberFilesToTransferValue.Name = "lbNumberFilesToTransferValue";
            this.lbNumberFilesToTransferValue.Size = new System.Drawing.Size(90, 18);
            this.lbNumberFilesToTransferValue.TabIndex = 4;
            this.lbNumberFilesToTransferValue.Text = "345";
            this.lbNumberFilesToTransferValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransferedValue
            // 
            this.lbTransferedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTransferedValue.Location = new System.Drawing.Point(224, 94);
            this.lbTransferedValue.Name = "lbTransferedValue";
            this.lbTransferedValue.Size = new System.Drawing.Size(90, 18);
            this.lbTransferedValue.TabIndex = 5;
            this.lbTransferedValue.Text = "345";
            this.lbTransferedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOk.Location = new System.Drawing.Point(121, 354);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(85, 30);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbNumberTargetFilesValue
            // 
            this.lbNumberTargetFilesValue.Location = new System.Drawing.Point(225, 58);
            this.lbNumberTargetFilesValue.Name = "lbNumberTargetFilesValue";
            this.lbNumberTargetFilesValue.Size = new System.Drawing.Size(90, 18);
            this.lbNumberTargetFilesValue.TabIndex = 8;
            this.lbNumberTargetFilesValue.Text = "345";
            this.lbNumberTargetFilesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumberTargetFiles
            // 
            this.lbNumberTargetFiles.Location = new System.Drawing.Point(34, 58);
            this.lbNumberTargetFiles.Name = "lbNumberTargetFiles";
            this.lbNumberTargetFiles.Size = new System.Drawing.Size(185, 18);
            this.lbNumberTargetFiles.TabIndex = 7;
            this.lbNumberTargetFiles.Text = "Number of files in the target directory:";
            this.lbNumberTargetFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNumberSourceFilesValue
            // 
            this.lbNumberSourceFilesValue.Location = new System.Drawing.Point(224, 40);
            this.lbNumberSourceFilesValue.Name = "lbNumberSourceFilesValue";
            this.lbNumberSourceFilesValue.Size = new System.Drawing.Size(91, 18);
            this.lbNumberSourceFilesValue.TabIndex = 10;
            this.lbNumberSourceFilesValue.Text = "345";
            this.lbNumberSourceFilesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumberSourceFiles
            // 
            this.lbNumberSourceFiles.Location = new System.Drawing.Point(31, 40);
            this.lbNumberSourceFiles.Name = "lbNumberSourceFiles";
            this.lbNumberSourceFiles.Size = new System.Drawing.Size(187, 18);
            this.lbNumberSourceFiles.TabIndex = 9;
            this.lbNumberSourceFiles.Text = "Number of files in the source directory:";
            this.lbNumberSourceFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetailsOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 396);
            this.ControlBox = false;
            this.Controls.Add(this.lbNumberSourceFilesValue);
            this.Controls.Add(this.lbNumberSourceFiles);
            this.Controls.Add(this.lbNumberTargetFilesValue);
            this.Controls.Add(this.lbNumberTargetFiles);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbTransferedValue);
            this.Controls.Add(this.lbNumberFilesToTransferValue);
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.lbTransfered);
            this.Controls.Add(this.lbNumberFilesToTransfer);
            this.Controls.Add(this.rbPatchFiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsOperation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details operation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbPatchFiles;
        private System.Windows.Forms.Label lbNumberFilesToTransfer;
        private System.Windows.Forms.Label lbTransfered;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbNumberFilesToTransferValue;
        private System.Windows.Forms.Label lbTransferedValue;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbNumberTargetFilesValue;
        private System.Windows.Forms.Label lbNumberTargetFiles;
        private System.Windows.Forms.Label lbNumberSourceFilesValue;
        private System.Windows.Forms.Label lbNumberSourceFiles;
    }
}