using NerveLauncher.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Downloader;
using System.Security.Policy;
using System.IO.Compression;
using System.Net.Mime;
using System.Security.Cryptography.Xml;

namespace NerveLauncherWIN.Pages
{
    public partial class PageViewItem : UserControl
    {
        NervePackage NervePackage { get; set; }
        string PackageIdentifier;

        string STATUS = "NODOWNLOADED";
        public PageViewItem(string packageidentifier)
        {
            InitializeComponent();
            PackageIdentifier = packageidentifier;
        }
        public PageViewItem(NerveLauncher.Data.NervePackage nervePackage)
        {
            InitializeComponent();
            NervePackage = nervePackage;
            PackageIdentifier = nervePackage.PackageIdentifier;
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private async void PageViewItem_Load(object sender, EventArgs e)
        {
            try
            {
                var r = await ContentManager.GetNervePackage(PackageIdentifier);
                if (r == null)
                {
                    return;
                }
                labelTitle.Text = r.Name;
                pictureBoxIcon.ImageLocation = r.IconLink;
                labelDes.Text = r.Description;
                CheckStatusLocal();
                if(NervePackage != null)
                {
                    if (r.Version != NervePackage.Version)
                    {
                        if(r.Version > NervePackage.Version)
                        {
                            STATUS = "UPDATE"; 
                            buttonAction.Text = "Zaktualizuj";
                        }
                    }
                    else
                    {
                        NervePackage = r;
                        labelVersion.Text = r.DisplayVersion;
                    }
                }
                else
                {
                    NervePackage = r;
                    labelVersion.Text = r.DisplayVersion;
                }
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        void CheckStatusLocal()
        {
            var item = ContentManager.InstalledPackage.Packages.Find(i => i.PackageIdentifier == PackageIdentifier);
            if (item == null)
            {
                buttonManage.Visible = false;
                STATUS = "NODOWNLOADED";
                return;
            }
            NervePackage = item;
            STATUS = "INSTALED";
            this.Invoke(() =>
            {
                buttonAction.Text = "Uruchom";
                buttonManage.Visible = true;
                labelVersion.Text = item.DisplayVersion;
            });
        }

        void Uninstall()
        {
            Directory.Delete(ContentManager.PathContent+PackageIdentifier, true);
            ContentManager.UninstallFIP(PackageIdentifier);
            panelManage.Hide();
            Thread.Sleep(100);
            CheckStatusLocal();
        }


        private async void buttonAction_Click(object sender, EventArgs e)
        {
            if (STATUS == "NODOWNLOADED")
            {
                panelDowload.Controls.Clear();
                foreach (var i in NervePackage.DirectDownloadLink)
                {
                    if (i.Key.ToUpper().Contains("WINDOWS"))
                    {
                        Button button = new Button();
                        button.Text = i.Key;
                        button.CommandParameter = i.Value;
                        button.Click += ButtonDownload_Click;
                        button.Dock = DockStyle.Top;
                        button.FlatStyle = FlatStyle.Flat;

                        panelDowload.Controls.Add(button);
                    }
                }
                panelDowload.Show();
            }
            else if (STATUS == "INSTALED")
            {
                try
                {
                    if (NervePackage.FileStartPath == null)
                    {
                        Process.Start("explorer.exe", ContentManager.PathContent + NervePackage.PackageIdentifier);
                    }
                    else
                    {
                        Process.Start(ContentManager.PathContent + NervePackage.PackageIdentifier + "\\" + NervePackage.FileStartPath);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else if(STATUS == "UPDATE")
            {
                var downloadOpt = new DownloadConfiguration()
                {
                    BufferBlockSize = 8000,
                    Timeout = 1000
                };
                labelStatusAction.Show();
                progressBarDownloaded.Show();
                progressBarDownloaded.Value = 0;
                progressBarDownloaded.Maximum = 100;
                progressBarDownloaded.Style = ProgressBarStyle.Blocks;
                Button button = (Button)sender;
                string fileName = ContentManager.PathTemp + NervePackage.PackageIdentifier;


                string url = NervePackage.DirectDownloadLink.First(x => x.Key.ToUpper().Contains("WINDOWS")).Value;
                
                var downloader = new DownloadService(downloadOpt);
                downloader.DownloadStarted += Downloader_DownloadStarted;
                downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                downloader.DownloadFileCompleted += Downloader_DownloadFileCompleted2; ;
                await downloader.DownloadFileTaskAsync(url, fileName);
            }
        }

        private async void Downloader_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Invoke(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                });
            }
            Invoke(() =>
            {
                labelStatusAction.Text = "Zaktualizowano!";
                STATUS = "INSTALED";
                buttonAction.Text = "Uruchom";
                panelDowload.Hide();
                progressBarDownloaded.Hide();
            });
            var r = await ContentManager.GetNervePackage(PackageIdentifier);
            ContentManager.UpdateFIP(
                PackageIdentifier,
                r);
        }

        private async void ButtonDownload_Click(object sender, EventArgs e)
        {
            var downloadOpt = new DownloadConfiguration()
            {
                BufferBlockSize = 8000,
                Timeout = 1000
            };
            labelStatusAction.Show();
            progressBarDownloaded.Show();
            progressBarDownloaded.Value = 0;
            progressBarDownloaded.Maximum = 100;
            progressBarDownloaded.Style = ProgressBarStyle.Blocks;
            Button button = (Button)sender;
            string fileName = ContentManager.PathTemp + NervePackage.PackageIdentifier;
            string url = button.CommandParameter.ToString();
            var downloader = new DownloadService(downloadOpt);
            downloader.DownloadStarted += Downloader_DownloadStarted;
            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
            downloader.DownloadFileCompleted += Downloader_DownloadFileCompleted;
            await downloader.DownloadFileTaskAsync(url, fileName);
        }


        void T()
        {
            string fileName = ContentManager.PathTemp + NervePackage.PackageIdentifier;

            if (!Directory.Exists(ContentManager.PathContent +
                NervePackage.PackageIdentifier))
            {
                Directory.CreateDirectory(ContentManager.PathContent +
                NervePackage.PackageIdentifier);
            }

            using (ZipArchive zipArchive = ZipFile.Open(fileName, ZipArchiveMode.Update))
            {
                int l = zipArchive.Entries.Count;
                Invoke(() =>
                {
                    progressBarDownloaded.Maximum = l - 1;
                    labelStatusAction.Text = "Rozpakowywanie... (0/" + (l - 1).ToString() + ")";
                });
                for (int i = 0; i < l; i++)
                {
                    try
                    {
                        ZipArchiveEntry entry = zipArchive.Entries[i];
                        string destinationPath = Path.GetFullPath(Path.Combine(ContentManager.PathContent +
                NervePackage.PackageIdentifier + "\\", entry.FullName));
                        // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                        // are case-insensitive.

                        string completeFileName = entry.FullName;
                        int idx = completeFileName.LastIndexOf('/');


                        if (completeFileName.Contains('/'))
                        {
                            string foldername = completeFileName.Substring(0, idx);


                            if (!Directory.Exists(destinationPath + foldername))
                                Directory.CreateDirectory(destinationPath + foldername);
                        }


                        if (destinationPath.StartsWith(ContentManager.PathContent +
                NervePackage.PackageIdentifier, StringComparison.Ordinal))
                        {
                            entry.ExtractToFile(destinationPath, true);
                        }
                        Invoke(() =>
                        {
                            labelStatusAction.Text = "Rozpakowywanie... (" + i + "/" + (l - 1).ToString() + ")";
                            progressBarDownloaded.Value = i;
                        });
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }
                }
            }

            Invoke(() =>
            {
                labelStatusAction.Text = "Zainstalowano!";
                progressBarDownloaded.Hide();
            });

        }

        private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Invoke(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                });
            }

            Invoke(() =>
            {
                labelStatusAction.Text = "Pobrano!";
                //progressBar1.Style = ProgressBarStyle.Marquee;
                progressBarDownloaded.Value = 0;
                panelDowload.Hide();
            });
            T();
            ContentManager.AddToFIP(
                NervePackage);
            CheckStatusLocal();
        }

        private void Downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(() =>
            {
                progressBarDownloaded.Value = (int)e.ProgressPercentage;
                labelStatusAction.Text = "Pobieranie... " + e.ProgressPercentage.ToString("00.00") + "%";
            });
        }

        private void Downloader_DownloadStarted(object sender, DownloadStartedEventArgs e)
        {
            Invoke(() =>
            {
                labelStatusAction.Text = "Pobieranie...";
                progressBarDownloaded.Show();
            });
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            panelManage.Visible = !panelManage.Visible;
        }

        private void buttonViewLocalFile_Click(object sender, EventArgs e)
        {
            if (STATUS == "INSTALED")
            {
                if (NervePackage != null)
                {
                    Process.Start("explorer.exe", ContentManager.PathContent + NervePackage.PackageIdentifier);
                }
            }
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            if (STATUS == "INSTALED")
            {
                if (NervePackage != null)
                {
                    Uninstall();
                }
            }
        }
    }
}
