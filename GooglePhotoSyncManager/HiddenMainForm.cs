using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;
using GooglePhotoSyncManager.Properties;

namespace GooglePhotoSyncManager
{
    public partial class HiddenMainForm : Form
    {
        private readonly ServiceController _service;

        private const string ServiceName = "PhotoSyncService";

        private void ServiceManagement(Action serviceAction, ServiceControllerStatus targetStatus,
            params ServiceControllerStatus[] conditionStatuses)
        {
            if (conditionStatuses.Any(s => s == _service.Status))
            {
                try
                {
                    notifyIcon.Icon = Resources.More;
                    Application.DoEvents();
                    TimeSpan timeout = TimeSpan.FromMilliseconds(10000);
                    serviceAction();
                    _service.WaitForStatus(targetStatus, timeout);
                }
                catch (Exception exception)
                {
                    notifyIcon.ShowBalloonTip(1000, "Google Photo Sync Manager", exception.Message, ToolTipIcon.Error);
                }
                RereshState();
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceManagement(_service.Start, ServiceControllerStatus.Running, ServiceControllerStatus.Stopped);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceManagement(_service.Stop, ServiceControllerStatus.Stopped, ServiceControllerStatus.Running, ServiceControllerStatus.Paused);
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceManagement(_service.Pause, ServiceControllerStatus.Paused, ServiceControllerStatus.Running);
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceManagement(_service.Continue, ServiceControllerStatus.Running, ServiceControllerStatus.Stopped, ServiceControllerStatus.Paused);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void RereshState()
        {
            var serviceExists = ServiceController.GetServices().Any(s => s.ServiceName == ServiceName);
            if (serviceExists)
            {
                _service.Refresh();
                installGoogleServiceToolStripMenuItem.Visible = false;
                unstallGoolgleServiceToolStripMenuItem.Visible = true;

                pauseToolStripMenuItem.Visible = _service.Status == ServiceControllerStatus.Running;
                stopToolStripMenuItem.Visible = _service.Status == ServiceControllerStatus.Running ||
                                                _service.Status == ServiceControllerStatus.Paused;
                resumeToolStripMenuItem.Visible = _service.Status == ServiceControllerStatus.Paused;
                startToolStripMenuItem.Visible = _service.Status == ServiceControllerStatus.Stopped;
                switch (_service.Status)
                {
                    case ServiceControllerStatus.Running:
                        notifyIcon.Icon = Resources.Play;
                        break;
                    case ServiceControllerStatus.Stopped:
                        notifyIcon.Icon = Resources.Stop;
                        break;
                    case ServiceControllerStatus.Paused:
                        notifyIcon.Icon = Resources.Pause;
                        break;
                    default:
                        notifyIcon.Icon = Resources.More;
                        break;
                }
            }
            else
            {
                installGoogleServiceToolStripMenuItem.Visible = true;
                unstallGoolgleServiceToolStripMenuItem.Visible = false;
                pauseToolStripMenuItem.Visible = false;
                stopToolStripMenuItem.Visible = false;
                resumeToolStripMenuItem.Visible = false;
                startToolStripMenuItem.Visible = false;
                notifyIcon.Icon = Resources.Cross;
            }
        }

        private void ServiceInstallation(int operation)
        {
            string key = String.Empty;
            if (operation == 0)
                key = @"/u";
            string instUtilDir = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\";
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            ProcessStartInfo procInfo = new ProcessStartInfo
            {
                FileName = strPath + "\\cmd.exe",
                UseShellExecute = true,
                CreateNoWindow = true,
                WorkingDirectory = strPath,
                Arguments = $"/k {instUtilDir}InstallUtil.exe {key} {Application.StartupPath}\\GooglePhotoSyncService.exe",
                Verb = "runas"
            };
            Process proc = new Process { StartInfo = procInfo };
            proc.Start();
        }

        private void installGoogleServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceInstallation(1);
        }

        private void unstallGoolgleServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceInstallation(0);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                value = false;
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        public HiddenMainForm()
        {
            InitializeComponent();
            _service = new ServiceController(ServiceName, Environment.MachineName);
            RereshState();
            Timer timer = new Timer {Interval = 1000};
            // 60 seconds
            timer.Tick += (sender, args) => { RereshState(); };
            timer.Start();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }
    }
}
