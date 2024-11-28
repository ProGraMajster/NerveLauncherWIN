namespace NerveLauncherWIN.Updater
{
    partial class Form1
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
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 12F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 57);
            label1.TabIndex = 0;
            label1.Text = "NerveLauncher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 78);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(380, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 63);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 0, 0);
            label2.Size = new Size(211, 15);
            label2.TabIndex = 4;
            label2.Text = "Sprawdzanie dostępności aktualizacji";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 101);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
    }
}
