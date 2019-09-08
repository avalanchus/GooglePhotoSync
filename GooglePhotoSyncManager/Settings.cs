using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using GooglePhotoSyncLib;

namespace GooglePhotoSyncManager
{
    public partial class Settings : Form
    {
        private readonly Configuration _configuration;

        public string Exclusions
        {
            get { return tbxExlusions.Text; }
            set { tbxExlusions.Text = value; }
        }

        public string Extensions
        {
            get { return tbxExtensions.Text; }
            set { tbxExtensions.Text = value; }
        }

        public string Period
        {
            get { return refreshPeriodNumericUpDown.Value.ToString(CultureInfo.InvariantCulture); }
            set
            {
                int period;
                Int32.TryParse(value, out period);
                refreshPeriodNumericUpDown.Value = period;
            }
        }

        public string SourceFolder
        {
            get { return tbxSourceFolder.Text; }
            set { tbxSourceFolder.Text = value; }
        }

        public string DestFolder
        {
            get { return tbxDestFolder.Text; }
            set { tbxDestFolder.Text = value; }
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbxSourceFolder.Text))
                sourceFolderBrowserDialog.SelectedPath = tbxSourceFolder.Text;
            if (sourceFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxSourceFolder.Text = sourceFolderBrowserDialog.SelectedPath;
            }
        }

        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbxDestFolder.Text))
                destFolderBrowserDialog.SelectedPath = tbxDestFolder.Text;
            if (destFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxDestFolder.Text = destFolderBrowserDialog.SelectedPath;
            }
        }

        private bool SetConfig(string name, string value)
        {
            var isDiffer = value != _configuration.AppSettings.Settings[name].Value;
            if (isDiffer)
            {
                _configuration.AppSettings.Settings.Remove(name);
                _configuration.AppSettings.Settings.Add(name, value);
            }
            return isDiffer;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            bool isDiffer = false;
            isDiffer |= SetConfig(nameof(Exclusions), Exclusions);
            isDiffer |= SetConfig(nameof(Extensions), Extensions);
            isDiffer |= SetConfig(nameof(Period), Period);
            isDiffer |= SetConfig(nameof(SourceFolder), SourceFolder);
            isDiffer |= SetConfig(nameof(DestFolder), DestFolder);
            if (isDiffer)
                _configuration.Save(ConfigurationSaveMode.Modified);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;            
        }

        public Settings()
        {
            InitializeComponent();
            _configuration = PhotoSync.GetConfiguration();
            Exclusions = _configuration.AppSettings.Settings[nameof(Exclusions)].Value;
            Extensions = _configuration.AppSettings.Settings[nameof(Extensions)].Value;
            Period = _configuration.AppSettings.Settings[nameof(Period)].Value;
            SourceFolder = _configuration.AppSettings.Settings[nameof(SourceFolder)].Value;
            DestFolder = _configuration.AppSettings.Settings[nameof(DestFolder)].Value;
        }
    }
}
