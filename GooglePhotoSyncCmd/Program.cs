using System;
using System.Configuration;
using GooglePhotoSyncLib;

namespace GooglePhotoSyncCmd
{
    class Program
    {
        /// <summary>
        ///     Папка-источник
        /// </summary>
        public static string SourceFolder;

        /// <summary>
        ///     Папка-приёмник
        /// </summary>
        public static string DestFolder;

        static void Main(string[] args)
        {
            PhotoSync photoSync = new PhotoSync();

            while (true)
            {
                SourceFolder = ConfigurationManager.AppSettings[nameof(SourceFolder)];

                DestFolder = ConfigurationManager.AppSettings[nameof(DestFolder)];

                Console.WriteLine("Начало сканирования каталога " + SourceFolder);
                Console.WriteLine("Папка-приёмник " + DestFolder);
                Console.WriteLine("Для остановки сканирования нажмите Enter");
                photoSync.StartChecking();
                Console.ReadLine();
                photoSync.StopChecking();
                Console.WriteLine("Для начала сканирования нажмите Enter");
                Console.ReadLine();
            }
        }
    }
}
