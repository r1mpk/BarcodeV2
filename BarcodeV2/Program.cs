namespace BarcodeV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string baseDir = AppContext.BaseDirectory;
            string pathString = System.IO.Path.Combine(baseDir, "Models.txt");
            if(!System.IO.File.Exists(pathString))
            {
               // System.IO.
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new BarcodeWindow());
        }
    }
}