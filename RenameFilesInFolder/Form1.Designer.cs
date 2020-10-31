namespace RenameFilesInFolder
{
    partial class frmRenameFiles
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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblBeginIn = new System.Windows.Forms.Label();
            this.txtBeginIn = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(50, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(222, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(101, 73);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(50, 38);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(87, 20);
            this.txtPrefix.TabIndex = 3;
            this.txtPrefix.Text = "S1E";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(12, 41);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 4;
            this.lblPrefix.Text = "Prefix:";
            // 
            // lblBeginIn
            // 
            this.lblBeginIn.AutoSize = true;
            this.lblBeginIn.Location = new System.Drawing.Point(147, 41);
            this.lblBeginIn.Name = "lblBeginIn";
            this.lblBeginIn.Size = new System.Drawing.Size(48, 13);
            this.lblBeginIn.TabIndex = 5;
            this.lblBeginIn.Text = "Begin in:";
            // 
            // txtBeginIn
            // 
            this.txtBeginIn.Location = new System.Drawing.Point(201, 38);
            this.txtBeginIn.Name = "txtBeginIn";
            this.txtBeginIn.Size = new System.Drawing.Size(71, 20);
            this.txtBeginIn.TabIndex = 6;
            this.txtBeginIn.Text = "1";
            // 
            // txtProcess
            // 
            this.txtProcess.BackColor = System.Drawing.SystemColors.Info;
            this.txtProcess.Location = new System.Drawing.Point(15, 102);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProcess.Size = new System.Drawing.Size(257, 147);
            this.txtProcess.TabIndex = 7;
            this.txtProcess.WordWrap = false;
            // 
            // frmRenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtBeginIn);
            this.Controls.Add(this.lblBeginIn);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblBeginIn;
        private System.Windows.Forms.TextBox txtBeginIn;
        private System.Windows.Forms.TextBox txtProcess;
    }
}

