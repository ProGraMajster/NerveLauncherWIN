namespace NerveLauncherWIN
{
    partial class FormUpdate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.nerve_app_icon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(0, 476);
            label1.Name = "label1";
            label1.Size = new Size(500, 21);
            label1.TabIndex = 1;
            label1.Text = "Updating...";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 497);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(500, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 520);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar progressBar1;
    }
}
