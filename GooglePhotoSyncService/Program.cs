using System.ServiceProcess;

namespace GooglePhotoSyncService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new PhotoSyncService()
            };
            ServiceBase.Run(ServicesToRun);


        }
    }
}
