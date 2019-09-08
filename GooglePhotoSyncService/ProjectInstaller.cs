using System.ComponentModel;
using System.Configuration.Install;

namespace GooglePhotoSyncService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
