namespace GooglePhotoSyncManager
{
    partial class Settings
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.tbxDestFolder = new System.Windows.Forms.TextBox();
            this.lblDestFolder = new System.Windows.Forms.Label();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.tbxSourceFolder = new System.Windows.Forms.TextBox();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.refreshPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tbxExtensions = new System.Windows.Forms.TextBox();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.tbxExlusions = new System.Windows.Forms.TextBox();
            this.lblExlusions = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPeriodNumericUpDown)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnDestFolder);
            this.pnlMain.Controls.Add(this.tbxDestFolder);
            this.pnlMain.Controls.Add(this.lblDestFolder);
            this.pnlMain.Controls.Add(this.btnSourceFolder);
            this.pnlMain.Controls.Add(this.tbxSourceFolder);
            this.pnlMain.Controls.Add(this.lblSourceFolder);
            this.pnlMain.Controls.Add(this.refreshPeriodNumericUpDown);
            this.pnlMain.Controls.Add(this.lblPeriod);
            this.pnlMain.Controls.Add(this.tbxExtensions);
            this.pnlMain.Controls.Add(this.lblExtensions);
            this.pnlMain.Controls.Add(this.tbxExlusions);
            this.pnlMain.Controls.Add(this.lblExlusions);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(706, 361);
            this.pnlMain.TabIndex = 0;
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestFolder.Location = new System.Drawing.Point(659, 254);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(28, 22);
            this.btnDestFolder.TabIndex = 11;
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // tbxDestFolder
            // 
            this.tbxDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDestFolder.Location = new System.Drawing.Point(22, 255);
            this.tbxDestFolder.Name = "tbxDestFolder";
            this.tbxDestFolder.Size = new System.Drawing.Size(637, 20);
            this.tbxDestFolder.TabIndex = 10;
            // 
            // lblDestFolder
            // 
            this.lblDestFolder.AutoSize = true;
            this.lblDestFolder.Location = new System.Drawing.Point(19, 239);
            this.lblDestFolder.Name = "lblDestFolder";
            this.lblDestFolder.Size = new System.Drawing.Size(92, 13);
            this.lblDestFolder.TabIndex = 9;
            this.lblDestFolder.Text = "Destination Folder";
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceFolder.Location = new System.Drawing.Point(659, 206);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(28, 22);
            this.btnSourceFolder.TabIndex = 8;
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // tbxSourceFolder
            // 
            this.tbxSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSourceFolder.Location = new System.Drawing.Point(22, 207);
            this.tbxSourceFolder.Name = "tbxSourceFolder";
            this.tbxSourceFolder.Size = new System.Drawing.Size(637, 20);
            this.tbxSourceFolder.TabIndex = 7;
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(19, 191);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(73, 13);
            this.lblSourceFolder.TabIndex = 6;
            this.lblSourceFolder.Text = "Source Folder";
            // 
            // refreshPeriodNumericUpDown
            // 
            this.refreshPeriodNumericUpDown.Location = new System.Drawing.Point(22, 155);
            this.refreshPeriodNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.refreshPeriodNumericUpDown.Name = "refreshPeriodNumericUpDown";
            this.refreshPeriodNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.refreshPeriodNumericUpDown.TabIndex = 5;
            this.refreshPeriodNumericUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(19, 139);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(76, 13);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Refresh period";
            // 
            // tbxExtensions
            // 
            this.tbxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExtensions.Location = new System.Drawing.Point(22, 98);
            this.tbxExtensions.Name = "tbxExtensions";
            this.tbxExtensions.Size = new System.Drawing.Size(665, 20);
            this.tbxExtensions.TabIndex = 3;
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Location = new System.Drawing.Point(19, 82);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(246, 13);
            this.lblExtensions.TabIndex = 2;
            this.lblExtensions.Text = "Extensions uploaded files (separated by semicolon)";
            // 
            // tbxExlusions
            // 
            this.tbxExlusions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExlusions.Location = new System.Drawing.Point(22, 39);
            this.tbxExlusions.Name = "tbxExlusions";
            this.tbxExlusions.Size = new System.Drawing.Size(665, 20);
            this.tbxExlusions.TabIndex = 1;
            // 
            // lblExlusions
            // 
            this.lblExlusions.AutoSize = true;
            this.lblExlusions.Location = new System.Drawing.Point(19, 23);
            this.lblExlusions.Name = "lblExlusions";
            this.lblExlusions.Size = new System.Drawing.Size(280, 13);
            this.lblExlusions.TabIndex = 0;
            this.lblExlusions.Text = "Folder names with uploaded files (separated by semicolon)";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 306);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(706, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(380, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(248, 20);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // sourceFolderBrowserDialog
            // 
            this.sourceFolderBrowserDialog.Description = "Source Folder";
            // 
            // destFolderBrowserDialog
            // 
            this.destFolderBrowserDialog.Description = "Destination Folder";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 361);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.MaximumSize = new System.Drawing.Size(4000, 400);
            this.MinimumSize = new System.Drawing.Size(0, 400);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPeriodNumericUpDown)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox tbxExtensions;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.TextBox tbxExlusions;
        private System.Windows.Forms.Label lblExlusions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.TextBox tbxDestFolder;
        private System.Windows.Forms.Label lblDestFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.TextBox tbxSourceFolder;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.NumericUpDown refreshPeriodNumericUpDown;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderBrowserDialog;
    }
}