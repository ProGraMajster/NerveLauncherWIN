namespace NerveLauncherWIN.Pages
{
    partial class PageViewItem
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panelEx1 = new Controls.PanelEx();
            labelVersion = new Label();
            labelTitle = new Label();
            panel1 = new Panel();
            buttonManage = new Button();
            buttonAction = new Button();
            pictureBoxIcon = new PictureBox();
            panelEx2 = new Controls.PanelEx();
            progressBar1 = new ProgressBar();
            buttonReturn = new Controls.ButtonEx();
            label1 = new Label();
            labelDes = new Label();
            panelDowload = new Panel();
            progressBarDownloaded = new ProgressBar();
            labelStatusAction = new Label();
            panelManage = new Panel();
            buttonViewLocalFile = new Button();
            buttonUninstall = new Button();
            panelEx1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelEx2.SuspendLayout();
            panelManage.SuspendLayout();
            SuspendLayout();
            // 
            // panelEx1
            // 
            panelEx1.BackColor = Color.FromArgb(25, 25, 25);
            panelEx1.Controls.Add(labelVersion);
            panelEx1.Controls.Add(labelTitle);
            panelEx1.Controls.Add(panel1);
            panelEx1.Controls.Add(pictureBoxIcon);
            panelEx1.Dock = DockStyle.Top;
            panelEx1.Location = new Point(20, 73);
            panelEx1.Name = "panelEx1";
            panelEx1.Padding = new Padding(20, 0, 0, 0);
            panelEx1.Size = new Size(734, 100);
            panelEx1.TabIndex = 0;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Dock = DockStyle.Top;
            labelVersion.Font = new Font("Segoe UI", 8F);
            labelVersion.Location = new Point(120, 36);
            labelVersion.Name = "labelVersion";
            labelVersion.Padding = new Padding(20, 5, 0, 0);
            labelVersion.Size = new Size(65, 18);
            labelVersion.TabIndex = 2;
            labelVersion.Text = "v0.0.0.0";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 12F);
            labelTitle.Location = new Point(120, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(20, 15, 0, 0);
            labelTitle.Size = new Size(147, 36);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "NAME_PACKAGE";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonManage);
            panel1.Controls.Add(buttonAction);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(555, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 100);
            panel1.TabIndex = 3;
            // 
            // buttonManage
            // 
            buttonManage.BackColor = Color.FromArgb(10, 10, 10);
            buttonManage.Dock = DockStyle.Bottom;
            buttonManage.FlatAppearance.BorderSize = 0;
            buttonManage.FlatStyle = FlatStyle.Flat;
            buttonManage.Location = new Point(0, 36);
            buttonManage.Name = "buttonManage";
            buttonManage.Size = new Size(179, 32);
            buttonManage.TabIndex = 1;
            buttonManage.Text = "Zarządzaj";
            buttonManage.UseVisualStyleBackColor = false;
            buttonManage.Visible = false;
            buttonManage.Click += buttonManage_Click;
            // 
            // buttonAction
            // 
            buttonAction.BackColor = Color.Black;
            buttonAction.Dock = DockStyle.Bottom;
            buttonAction.FlatAppearance.BorderSize = 0;
            buttonAction.FlatStyle = FlatStyle.Flat;
            buttonAction.Location = new Point(0, 68);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(179, 32);
            buttonAction.TabIndex = 0;
            buttonAction.Text = "Pobierz";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Location = new Point(20, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(100, 100);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // panelEx2
            // 
            panelEx2.Controls.Add(progressBar1);
            panelEx2.Controls.Add(buttonReturn);
            panelEx2.Dock = DockStyle.Top;
            panelEx2.Location = new Point(20, 20);
            panelEx2.Name = "panelEx2";
            panelEx2.Padding = new Padding(0, 0, 0, 15);
            panelEx2.Size = new Size(734, 53);
            panelEx2.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(82, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(652, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // buttonReturn
            // 
            buttonReturn.Dock = DockStyle.Left;
            buttonReturn.FlatAppearance.BorderSize = 0;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Segoe UI", 10F);
            buttonReturn.Location = new Point(0, 0);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(82, 38);
            buttonReturn.TabIndex = 0;
            buttonReturn.Text = "⬅️ Powrót";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonEx1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 14F);
            label1.Location = new Point(20, 308);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 20, 0, 0);
            label1.Size = new Size(60, 46);
            label1.TabIndex = 2;
            label1.Text = "Opis";
            // 
            // labelDes
            // 
            labelDes.AutoSize = true;
            labelDes.Dock = DockStyle.Top;
            labelDes.Location = new Point(20, 354);
            labelDes.Name = "labelDes";
            labelDes.Padding = new Padding(0, 10, 0, 0);
            labelDes.Size = new Size(32, 25);
            labelDes.TabIndex = 3;
            labelDes.Text = "TEXT";
            // 
            // panelDowload
            // 
            panelDowload.AutoSize = true;
            panelDowload.Dock = DockStyle.Top;
            panelDowload.Location = new Point(20, 298);
            panelDowload.MinimumSize = new Size(0, 10);
            panelDowload.Name = "panelDowload";
            panelDowload.Padding = new Padding(30, 0, 0, 0);
            panelDowload.Size = new Size(734, 10);
            panelDowload.TabIndex = 4;
            // 
            // progressBarDownloaded
            // 
            progressBarDownloaded.Dock = DockStyle.Top;
            progressBarDownloaded.Location = new Point(20, 188);
            progressBarDownloaded.Name = "progressBarDownloaded";
            progressBarDownloaded.Size = new Size(734, 10);
            progressBarDownloaded.TabIndex = 5;
            progressBarDownloaded.Visible = false;
            // 
            // labelStatusAction
            // 
            labelStatusAction.AutoSize = true;
            labelStatusAction.Dock = DockStyle.Top;
            labelStatusAction.Location = new Point(20, 173);
            labelStatusAction.Name = "labelStatusAction";
            labelStatusAction.Size = new Size(10, 15);
            labelStatusAction.TabIndex = 6;
            labelStatusAction.Text = ".";
            labelStatusAction.Visible = false;
            // 
            // panelManage
            // 
            panelManage.AutoSize = true;
            panelManage.Controls.Add(buttonViewLocalFile);
            panelManage.Controls.Add(buttonUninstall);
            panelManage.Dock = DockStyle.Top;
            panelManage.Location = new Point(20, 198);
            panelManage.MinimumSize = new Size(0, 100);
            panelManage.Name = "panelManage";
            panelManage.Padding = new Padding(30, 0, 0, 0);
            panelManage.Size = new Size(734, 100);
            panelManage.TabIndex = 5;
            panelManage.Visible = false;
            // 
            // buttonViewLocalFile
            // 
            buttonViewLocalFile.BackColor = Color.FromArgb(15, 15, 15);
            buttonViewLocalFile.FlatAppearance.BorderSize = 0;
            buttonViewLocalFile.FlatStyle = FlatStyle.Flat;
            buttonViewLocalFile.Location = new Point(126, 6);
            buttonViewLocalFile.Name = "buttonViewLocalFile";
            buttonViewLocalFile.Size = new Size(160, 33);
            buttonViewLocalFile.TabIndex = 1;
            buttonViewLocalFile.Text = "Przeglądaj pliki lokalne";
            buttonViewLocalFile.UseVisualStyleBackColor = false;
            buttonViewLocalFile.Click += buttonViewLocalFile_Click;
            // 
            // buttonUninstall
            // 
            buttonUninstall.BackColor = Color.FromArgb(15, 15, 15);
            buttonUninstall.FlatAppearance.BorderSize = 0;
            buttonUninstall.FlatStyle = FlatStyle.Flat;
            buttonUninstall.Location = new Point(20, 6);
            buttonUninstall.Name = "buttonUninstall";
            buttonUninstall.Size = new Size(100, 33);
            buttonUninstall.TabIndex = 0;
            buttonUninstall.Text = "Odinstaluj";
            buttonUninstall.UseVisualStyleBackColor = false;
            buttonUninstall.Click += buttonUninstall_Click;
            // 
            // PageViewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(labelDes);
            Controls.Add(label1);
            Controls.Add(panelDowload);
            Controls.Add(panelManage);
            Controls.Add(progressBarDownloaded);
            Controls.Add(labelStatusAction);
            Controls.Add(panelEx1);
            Controls.Add(panelEx2);
            DoubleBuffered = true;
            ForeColor = Color.WhiteSmoke;
            Name = "PageViewItem";
            Padding = new Padding(20);
            Size = new Size(774, 627);
            Load += PageViewItem_Load;
            panelEx1.ResumeLayout(false);
            panelEx1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelEx2.ResumeLayout(false);
            panelManage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.PanelEx panelEx1;
        private Label labelTitle;
        private PictureBox pictureBoxIcon;
        private Controls.PanelEx panelEx2;
        private Controls.ButtonEx buttonReturn;
        private ProgressBar progressBar1;
        private Label label1;
        private Label labelDes;
        private Label labelVersion;
        private Panel panel1;
        private Button buttonAction;
        private Panel panelDowload;
        private ProgressBar progressBarDownloaded;
        private Label labelStatusAction;
        private Button buttonManage;
        private Panel panelManage;
        private Button buttonUninstall;
        private Button buttonViewLocalFile;
    }
}
