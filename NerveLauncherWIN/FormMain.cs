using NerveLauncherWIN.Controls;
using NerveLauncherWIN.Dev;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;

namespace NerveLauncherWIN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            client = new GitHubClient(new ProductHeaderValue("NerveLauncherWIN"));
            ContentManager.InstalledPackageChanged += ((s, e) =>
            {
                flowLayoutPanelExInstalled.Controls.Clear();
                foreach (var item in ContentManager.InstalledPackage.Packages)
                {
                    ItemControl itemControl = new ItemControl(item);
                    this.Invoke(() =>
                    {
                        flowLayoutPanelExInstalled.Controls.Add(itemControl);
                    });
                }
            });
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        // Paint background with underlying graphics from other controls
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;

            if (Parent != null)
            {
                // Take each control in turn
                int index = Parent.Controls.GetChildIndex(this);
                for (int i = Parent.Controls.Count - 1; i > index; i--)
                {
                    Control c = Parent.Controls[i];

                    // Check it's visible and overlaps this control
                    if (c.Bounds.IntersectsWith(Bounds) && c.Visible)
                    {
                        // Load appearance of underlying control and redraw it on this background
                        Bitmap bmp = new Bitmap(c.Width, c.Height, g);
                        c.DrawToBitmap(bmp, c.ClientRectangle);
                        g.TranslateTransform(c.Left - Left, c.Top - Top);
                        g.DrawImageUnscaled(bmp, Point.Empty);
                        g.TranslateTransform(Left - c.Left, Top - c.Top);
                        bmp.Dispose();
                    }
                }
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            //panel1.Hide();
            this.SuspendLayout();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            // panel1.Show();  
            this.ResumeLayout();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FormUpdate formUpdate = Application.OpenForms.OfType<FormUpdate>().FirstOrDefault();
                if (formUpdate != null)
                {
                    formUpdate.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        GitHubClient client;
        Octokit.Repository repo;
        private void FormMain_Load(object sender, EventArgs e)
        {
            progressBar1.Show();
            ContentManager.Init();
            foreach (var item in ContentManager.InstalledPackage.Packages)
            {
                ItemControl itemControl = new ItemControl(item);
                flowLayoutPanelExInstalled.Controls.Add(itemControl);
            }


            /*

            ItemControl itemControl = new ItemControl("AniApp",
                "https://raw.githubusercontent.com/ProGraMajster/AniAppProject/refs/heads/master/AniAppProject/Resources/AppIcon/aniappprojecticon.png",
                "com.programajster.aniappproject");

            flowLayoutPanelContentApp.Controls.Add(itemControl);

            */


            repo = client.Repository.Get("ProGraMajster", "NerveLauncher.DataContent").Result;
            if (repo == null)
            {
                Debug.WriteLine("Repository not found");
            }
            else
            {
                Debug.WriteLine("Repository found");
            }
            var list = client.Repository.Content.GetAllContents("ProGraMajster", "NerveLauncher.DataContent", "NerveLauncher.DataContent/PackageList").Result;
            HttpClient httpClient = new HttpClient();
            List<string> strings = new List<string>();
            foreach (var item in list)
            {
                string r = httpClient.GetStringAsync(item.DownloadUrl).Result;
                if (r != null)
                {
                    strings.Add(r);
                }
            }

            Thread thread = new(() =>
            {
                try
                {
                    var list = SerializePackaged(strings);
                    if(list == null)
                    {
                        return;
                    }
                    foreach (var item in list)
                    {
                        this.Invoke(() =>
                        {
                            NerveLauncherWIN.Controls.ItemControl itemControl = new NerveLauncherWIN.Controls.ItemControl(item);
                            flowLayoutPanelContentApp.Controls.Add(itemControl);
                            progressBar1.Hide();
                        });
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            });
            thread.Start();
        }

        List<NerveLauncher.Data.NervePackage> SerializePackaged(List<string> strings)
        {
            List<NerveLauncher.Data.NervePackage> nervePackages = new List<NerveLauncher.Data.NervePackage>();
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            foreach (var item in strings)
            {
                NerveLauncher.Data.NervePackage np = JsonSerializer.Deserialize<NerveLauncher.Data.NervePackage>(item, jsonSerializerOptions);
                nervePackages.Add(np);
            }
            return nervePackages;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreatorPackage formCreatorPackage = new FormCreatorPackage();
            formCreatorPackage.Show();
        }
    }
}
