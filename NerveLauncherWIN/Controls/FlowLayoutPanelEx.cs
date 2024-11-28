using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerveLauncherWIN.Controls
{
    public partial class FlowLayoutPanelEx : FlowLayoutPanel
    {
        public FlowLayoutPanelEx()
        {
            InitializeComponent();
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            this.DoubleBuffered = true;
            this.Scroll += NewFlowLayoutPanel_Scroll;
        }

        private void NewFlowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            Application.DoEvents();
            this.Invalidate();
            base.OnScroll(se);
        }
    }
}
