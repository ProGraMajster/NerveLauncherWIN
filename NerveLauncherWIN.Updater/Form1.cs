using System.Diagnostics;
using System.Net;

namespace NerveLauncherWIN.Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string cv = GetCurrentVerison();
                if (string.IsNullOrEmpty(cv))
                {
                    labelStatus.Text = "Pobieranie aktualizacji";
                   Thread thread = new Thread(() =>
                    {
                        DonwloadLatestRelease();
                    });
                    thread.Start();
                    return;
                }
            }
            catch(Exception ex)
            {

            }
        }

        async void DonwloadLatestRelease()
        {
            try
            {
                using (var wc = new HttpClient())
                {
                    var fileName = @"LatestRelease.zip";
                    var uri = new Uri("https://github.com/ProGraMajster/AniAppProject/releases/latest/download/AniApp-x64.zip");
                    await wc.DownloadFileTaskAsync(uri, fileName);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        string GetCurrentVerison()
        {
            try
            {
                string currentVersion = String.Empty;
#if DEBUG
                currentVersion = File.ReadAllText(@"C:\Users\HARDPC\source\repos\NerveLauncherWIN\NerveLauncherWIN\bin\Debug\net9.0-windows10.0.22621.0\Version.txt");
#else
            currentVersion = File.ReadAllText("Version.txt");
#endif
                return currentVersion;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }

        async Task<string> GetOnlineVersion()
        {
            try
            {
                string r = null;
                using (var wc = new HttpClient())
                {
                    r = await wc.GetStringAsync(@"https://raw.githubusercontent.com/ProGraMajster/NerveLauncherWIN/refs/heads/master/NerveLauncherWIN/Program.cs");
                }
                return r;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
