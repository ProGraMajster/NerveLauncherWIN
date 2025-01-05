using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerveLauncherWIN.Dev
{
    public partial class FormCreatorPackage : Form
    {
        public FormCreatorPackage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NerveLauncher.Data.NervePackage package = new NerveLauncher.Data.NervePackage();
                package.Name = textBoxTitle.Text;
                package.Description = richTextBox1.Text;
                package.DisplayVersion = textBoxDisplayVersion.Text;
                package.Version = (int)numericUpDown1.Value;
                package.PackageIdentifier = textBoxPackageIdentifier.Text;
                package.Tags = textBoxTags.Text.Split(';').ToList();
                package.IconLink = textBoxIconApp.Text;
                package.ScreenshotsLink = textBoxScrennshot.Text.Split(';').ToList();
                string[] names = richTextBoxLinkToFile.Text.Split(";");
                string[] links = richTextBoxLinkToFile2.Text.Split(";");
                package.DirectDownloadLink = new Dictionary<string, string>();
                for (int i = 0; i < names.Length; i++)
                {
                    package.DirectDownloadLink.Add(names[i], links[i]);
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                string json = JsonSerializer.Serialize(package, typeof(NerveLauncher.Data.NervePackage), jsonSerializerOptions);
                SaveFileDialog dialog
                    = new SaveFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, json);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
