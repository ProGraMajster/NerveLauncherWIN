using System.Diagnostics;

namespace NerveLauncherWIN
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();

            try
            {
                Image image = Image.FromFile("Resources\\Img\\nerve_app_icon.png");
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                Location = new Point(Location.X, Location.Y - 150);
                Process p = null;
#if DEBUG
                p = Process.Start(@"C:\Users\HARDPC\source\repos\NerveLauncherWIN\NerveLauncherWIN.Updater\bin\Debug\net9.0-windows\NerveLauncherWIN.Updater.exe");
#else
                p = Process.Start("NerveLauncherWIN.Updater.exe");
#endif
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Thread thread = new(() =>
            {
                Thread.Sleep(3000);
                this.Invoke(() =>
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    Application.OpenForms[0].Hide();
                });
            });
            //thread.Start();
        }
    }
}
