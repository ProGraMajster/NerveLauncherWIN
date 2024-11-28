using NerveLauncher.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerveLauncherWIN.Pages
{
    public partial class PageViewItem : UserControl
    {
        NervePackage NervePackage { get; set; }
        public PageViewItem()
        {
            InitializeComponent();
        }
        public PageViewItem(NervePackage package)
        {
            InitializeComponent();
            NervePackage = package;
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void PageViewItem_Load(object sender, EventArgs e)
        {
            if(NervePackage == null)
            {
                return;
            }
        }
    }
}
