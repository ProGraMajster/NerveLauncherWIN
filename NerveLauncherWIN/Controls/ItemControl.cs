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
        public string ImageLink { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PACKAGE {  get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NervePackage NervePackage { get; set; }
        public ItemControl()
        {
            InitializeComponent();
        }

        public ItemControl(NervePackage package)
        {
            InitializeComponent();
            NervePackage = package;
        }

        private void pictureBoxImagePackage_Click(object sender, EventArgs e)
        {
            OpenPage();
        }

        void OpenPage()
        {
            NerveLauncherWIN.Pages.PageViewItem pageViewItem = new Pages.PageViewItem();
            pageViewItem.Dock = DockStyle.Fill;
            FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (formMain == null)
            {
                return;
            }
            formMain.Controls.Add(pageViewItem);
            pageViewItem.BringToFront();
        }

        private void ItemControl_Click(object sender, EventArgs e)
        {
            OpenPage();
        }
    }
}
