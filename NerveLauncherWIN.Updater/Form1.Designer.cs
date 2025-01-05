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
            labelStatus = new Label();
            panelB = new Panel();
            labelB2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panelB.SuspendLayout();
            panel1.SuspendLayout();
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
            progressBar1.Location = new Point(0, 63);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(380, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Location = new Point(0, 86);
            labelStatus.Name = "labelStatus";
            labelStatus.Padding = new Padding(10, 0, 0, 0);
            labelStatus.Size = new Size(211, 15);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Sprawdzanie dostępności aktualizacji";
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelB
            // 
            panelB.AutoSize = true;
            panelB.Controls.Add(labelB2);
            panelB.Controls.Add(button2);
            panelB.Controls.Add(button3);
            panelB.Controls.Add(button1);
            panelB.Dock = DockStyle.Fill;
            panelB.Location = new Point(0, 0);
            panelB.Name = "panelB";
            panelB.Size = new Size(380, 101);
            panelB.TabIndex = 10;
            panelB.Visible = false;
            // 
            // labelB2
            // 
            labelB2.Dock = DockStyle.Top;
            labelB2.Font = new Font("Segoe UI", 9F);
            labelB2.Location = new Point(0, 0);
            labelB2.Name = "labelB2";
            labelB2.Size = new Size(380, 29);
            labelB2.TabIndex = 3;
            labelB2.Text = "NerveLauncher";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 32);
            button2.Name = "button2";
            button2.Size = new Size(380, 23);
            button2.TabIndex = 1;
            button2.Text = "Spróbuj ponownie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(0, 55);
            button3.Name = "button3";
            button3.Size = new Size(380, 23);
            button3.TabIndex = 2;
            button3.Text = "Uruchom lokalną wersję aplikacji";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 78);
            button1.Name = "button1";
            button1.Size = new Size(380, 23);
            button1.TabIndex = 0;
            button1.Text = "Zamknij";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(labelStatus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 101);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 101);
            Controls.Add(panelB);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelB.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label labelStatus;
        private Panel panelB;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel1;
        private Label labelB2;
    }
}
