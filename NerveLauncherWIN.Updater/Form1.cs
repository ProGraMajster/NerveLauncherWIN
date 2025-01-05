using System.Diagnostics;
using System.IO.Compression;
using System.Net;

namespace NerveLauncherWIN.Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            C();
        }

        async void C()
        {
            try
            {
                panelB.Hide();
                panel1.Show();
                string cv = GetCurrentVerison();
                string ov = await GetOnlineVersion();

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
                if (string.IsNullOrEmpty(ov))
                {
                    labelStatus.Text = "Nie uda³o siê sprawdziæ numeru najnowszej wersji.";
                    labelB2.Text = labelStatus.Text;
                    panel1.Hide();
                    panelB.Show();
                    return;
                }
                string[] stringsCv = cv.Replace(" ", "").Split(".");
                int vl1 = int.Parse(stringsCv[0]);
                int vl2 = int.Parse(stringsCv[1]);
                int vl3 = int.Parse(stringsCv[2]);
                int vl4 = int.Parse(stringsCv[3]);
                
                string[] stringsOv = ov.Replace(" ", "").Split(".");
                int vO1 = int.Parse(stringsOv[0]);
                int vO2 = int.Parse(stringsOv[1]);
                int vO3 = int.Parse(stringsOv[2]);
                int vO4 = int.Parse(stringsOv[3]);


                Version versionLocal = new Version(vl1,vl2,vl3,vl4);
                Version versionOnline = new Version(vO1,vO2,vO3,vO4);

                if (versionLocal >= versionOnline)
                {
                    Debug.WriteLine("versionLocal >= versionOnline");
                    RunL();
                    return;
                }

                bool o1 = OperationIO1();
                if(o1 == false)
                {
                    labelStatus.Text = "Wyst¹pi³ b³¹d. \n IO1";
                    labelB2.Text = labelStatus.Text;
                    panel1.Hide();
                    panelB.Show();
                    return;
                }
                OperationIO2();
                RunL();
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex);
#endif
            }
        }

        async void DonwloadLatestRelease()
        {
            try
            {
                if(File.Exists("LatestRelease.zip"))
                {
                    File.Delete("LatestRelease.zip");
                }
                using (var wc = new HttpClient())
                {
                    var fileName = @"LatestRelease.zip";
                    var uri = new Uri("https://github.com/ProGraMajster/NerveLauncherWIN/releases/latest/download/NerveLauncherWIN.zip");
                    await wc.DownloadFileTaskAsync(uri, fileName);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        bool OperationIO1()
        {
            try
            {
                labelStatus.Text = "Rozpakowywanie";
                if(!Directory.Exists("Temp"))
                {
                    Directory.CreateDirectory("Temp");
                }
                else
                {
                    Directory.Delete("Temp", true);
                    Directory.CreateDirectory("Temp");
                }

                ZipFile.ExtractToDirectory("LatestRelease.zip", "Temp");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Console.WriteLine(ex);
            }
            return false;
        }

        bool OperationIO2()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("Temp");
                int f = directoryInfo.GetFiles().Length;
                int i = 0;
                foreach(FileInfo file in directoryInfo.GetFiles())
                {
                    try
                    {
#if DEBUG
                        File.Copy(file.FullName, 
                            @"C:\Users\HARDPC\source\repos\NerveLauncherWIN\NerveLauncherWIN\bin\Debug\net9.0-windows10.0.22621.0\"+file.Name, true);
#else
            File.Copy(file.FullName, file.Name, true);
#endif
                        i++;
                        labelStatus.Text = "Przenoszenie plików ("+i+"/"+f+")";
                        Application.DoEvents();
                    }
                    catch(Exception exOp)
                    {
                        Debug.WriteLine(exOp.ToString());
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return false;
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
            catch (Exception ex)
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
                    r = await wc.GetStringAsync(@"https://raw.githubusercontent.com/ProGraMajster/NerveLauncherWIN/refs/heads/master/NerveLauncherWIN/Version.txt");
                }
                return r;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void RunL()
        {
            Process p = null;
#if DEBUG
            p = Process.Start(@"C:\Users\HARDPC\source\repos\NerveLauncherWIN\NerveLauncherWIN\bin\Debug\net9.0-windows10.0.22621.0\NerveLauncher.exe", "-RunNerveLauncher");
#else
                p = Process.Start("NerveLauncher.exe", "-RunNerveLauncher");
#endif

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunL();
        }
    }
}
