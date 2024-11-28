namespace NerveLauncherWIN
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
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
            thread.Start();
        }
    }
}
