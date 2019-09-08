namespace GooglePhotoSyncManager
{
    partial class HiddenMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiddenMainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installDeinstallGoogleSyncServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installGoogleServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unstallGoolgleServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.installDeinstallGoogleSyncServiceToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 180);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.startToolStripMenuItem.Text = "Start GoogleSync";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stopToolStripMenuItem.Text = "Stop GoogleSync";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pauseToolStripMenuItem.Text = "Pause GoogleSync";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.resumeToolStripMenuItem.Text = "Resume GoogleSync";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // installDeinstallGoogleSyncServiceToolStripMenuItem
            // 
            this.installDeinstallGoogleSyncServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installGoogleServiceToolStripMenuItem,
            this.unstallGoolgleServiceToolStripMenuItem});
            this.installDeinstallGoogleSyncServiceToolStripMenuItem.Name = "installDeinstallGoogleSyncServiceToolStripMenuItem";
            this.installDeinstallGoogleSyncServiceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.installDeinstallGoogleSyncServiceToolStripMenuItem.Text = "Install/Deinstall";
            // 
            // installGoogleServiceToolStripMenuItem
            // 
            this.installGoogleServiceToolStripMenuItem.Name = "installGoogleServiceToolStripMenuItem";
            this.installGoogleServiceToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.installGoogleServiceToolStripMenuItem.Text = "Install GoogleSync Service";
            this.installGoogleServiceToolStripMenuItem.Click += new System.EventHandler(this.installGoogleServiceToolStripMenuItem_Click);
            // 
            // unstallGoolgleServiceToolStripMenuItem
            // 
            this.unstallGoolgleServiceToolStripMenuItem.Name = "unstallGoolgleServiceToolStripMenuItem";
            this.unstallGoolgleServiceToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.unstallGoolgleServiceToolStripMenuItem.Text = "Unstall GoolgleSync Service";
            this.unstallGoolgleServiceToolStripMenuItem.Click += new System.EventHandler(this.unstallGoolgleServiceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Google Photo Sync Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // HiddenMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "HiddenMainForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installDeinstallGoogleSyncServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installGoogleServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unstallGoolgleServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

