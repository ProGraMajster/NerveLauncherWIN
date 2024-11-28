using NerveLauncherWIN.Dev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Input;

namespace NerveLauncherWIN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            ContentManager.Init();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Shift && e.KeyCode == Keys.F12)
            {
                FormCreatorPackage formCreatorPackage = new FormCreatorPackage();
                formCreatorPackage.Show();
            }
        }
    }
}
