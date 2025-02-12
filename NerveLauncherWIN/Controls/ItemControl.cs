using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NerveLauncher.Data;

namespace NerveLauncherWIN.Controls
{
    public partial class ItemControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ImageLink { get; set; } = String.Empty;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title { get; set; } = String.Empty;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PACKAGE {  get; set; } = string.Empty;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NervePackage NervePackage { get; set; } = null;
        public ItemControl()
        {
            InitializeComponent();
        }
        public ItemControl(string title, string imagelink, string package)
        {
            InitializeComponent();
            try
            {
                if (!string.IsNullOrEmpty(title))
                {
                    Title = title;
                    labelNamePackage.Text = title;
                }
                if (!string.IsNullOrEmpty(package))
                {
                    PACKAGE = package;
                }
                if (!string.IsNullOrEmpty(imagelink))
                {
                    ImageLink = imagelink;
                    pictureBoxImagePackage.ImageLocation = imagelink;
                }
                
            }
            catch(Exception ex)
            {

            }
        }

        public ItemControl(NervePackage package)
        {
            InitializeComponent();
            NervePackage = package;
            try
            {
                if (!string.IsNullOrEmpty(package.Name))
                {
                    Title = package.Name;
                    labelNamePackage.Text = package.Name;
                }
                if (!string.IsNullOrEmpty(package.PackageIdentifier))
                {
                    PACKAGE = package.PackageIdentifier;
                }
                if (!string.IsNullOrEmpty(package.IconLink))
                {
                    ImageLink = package.IconLink;
                    pictureBoxImagePackage.ImageLocation = package.IconLink;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBoxImagePackage_Click(object sender, EventArgs e)
        {
            OpenPage(PACKAGE);
        }

        void OpenPage(string PackageIdentifier)
        {
            if (NervePackage == null)
            {
                NerveLauncherWIN.Pages.PageViewItem pageViewItem = new Pages.PageViewItem(PackageIdentifier);
                pageViewItem.Dock = DockStyle.Fill;
                FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
                if (formMain == null)
                {
                    return;
                }
                formMain.Controls.Add(pageViewItem);
                pageViewItem.BringToFront();
            }
            else
            {
                NerveLauncherWIN.Pages.PageViewItem pageViewItem = new Pages.PageViewItem(NervePackage);
                pageViewItem.Dock = DockStyle.Fill;
                FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
                if (formMain == null)
                {
                    return;
                }
                formMain.Controls.Add(pageViewItem);
                pageViewItem.BringToFront();
            }
        }

        private void ItemControl_Click(object sender, EventArgs e)
        {
            OpenPage(PACKAGE);
        }
    }
}
