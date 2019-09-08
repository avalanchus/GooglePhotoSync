using System.ServiceProcess;
using GooglePhotoSyncLib;

namespace GooglePhotoSyncService
{
    public partial class PhotoSyncService : ServiceBase
    {
        private PhotoSync _photoSync;

        public PhotoSyncService()
        {
            InitializeComponent();
            CanPauseAndContinue = true;
            _photoSync = new PhotoSync();
        }

        protected override void OnStart(string[] args)
        {
            _photoSync.StartChecking();
        }

        protected override void OnStop()
        {
            _photoSync.StopChecking();
        }

        protected override void OnPause()
        {
            _photoSync.StopChecking(); 
        }

        protected override void OnContinue()
        {
            _photoSync.StartChecking();
        }
    }
}
