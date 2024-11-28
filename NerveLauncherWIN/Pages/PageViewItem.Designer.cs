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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelEx2 = new Controls.PanelEx();
            buttonReturn = new Controls.ButtonEx();
            panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEx2.SuspendLayout();
            SuspendLayout();
            // 
            // panelEx1
            // 
            panelEx1.Controls.Add(label1);
            panelEx1.Controls.Add(pictureBox1);
            panelEx1.Dock = DockStyle.Top;
            panelEx1.Location = new Point(20, 73);
            panelEx1.Name = "panelEx1";
            panelEx1.Padding = new Padding(20, 0, 0, 0);
            panelEx1.Size = new Size(734, 100);
            panelEx1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(120, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 15, 0, 0);
            label1.Size = new Size(147, 36);
            label1.TabIndex = 1;
            label1.Text = "NAME_PACKAGE";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelEx2
            // 
            panelEx2.Controls.Add(buttonReturn);
            panelEx2.Dock = DockStyle.Top;
            panelEx2.Location = new Point(20, 20);
            panelEx2.Name = "panelEx2";
            panelEx2.Padding = new Padding(0, 0, 0, 15);
            panelEx2.Size = new Size(734, 53);
            panelEx2.TabIndex = 1;
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
            // PageViewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEx2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.PanelEx panelEx1;
        private Label label1;
        private PictureBox pictureBox1;
        private Controls.PanelEx panelEx2;
        private Controls.ButtonEx buttonReturn;
    }
}
