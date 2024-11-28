namespace NerveLauncherWIN
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
            ApplicationConfiguration.Initialize();
            if(Environment.GetCommandLineArgs().Contains("-RunNerveLauncher"))
            {
                Application.Run(new FormMain());
            }
            else
            {
                Application.Run(new FormUpdate());
            }
        }
    }
}