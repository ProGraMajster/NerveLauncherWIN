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
    public partial class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            TextChanged += UserControl2_OnTextChanged;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var backgroundBrush = new SolidBrush(BackColor);
            Graphics g = e.Graphics;
            g.FillRectangle(backgroundBrush, 0, 0, this.Width, this.Height);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), new PointF(((this.Width / 2) - TextLength), 0), StringFormat.GenericDefault);
        }

        public void UserControl2_OnTextChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
