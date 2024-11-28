namespace NerveLauncherWIN.Controls
{
    partial class ItemControl
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
            panelEx1 = new PanelEx();
            pictureBoxImagePackage = new PictureBox();
            labelNamePackage = new Label();
            panelEx2 = new PanelEx();
            panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagePackage).BeginInit();
            SuspendLayout();
            // 
            // panelEx1
            // 
            panelEx1.Controls.Add(pictureBoxImagePackage);
            panelEx1.Controls.Add(labelNamePackage);
            panelEx1.Dock = DockStyle.Fill;
            panelEx1.Location = new Point(0, 0);
            panelEx1.Name = "panelEx1";
            panelEx1.Size = new Size(100, 120);
            panelEx1.TabIndex = 0;
            // 
            // pictureBoxImagePackage
            // 
            pictureBoxImagePackage.Dock = DockStyle.Fill;
            pictureBoxImagePackage.Location = new Point(0, 0);
            pictureBoxImagePackage.Name = "pictureBoxImagePackage";
            pictureBoxImagePackage.Size = new Size(100, 92);
            pictureBoxImagePackage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagePackage.TabIndex = 2;
            pictureBoxImagePackage.TabStop = false;
            pictureBoxImagePackage.Click += pictureBoxImagePackage_Click;
            // 
            // labelNamePackage
            // 
            labelNamePackage.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelNamePackage.Dock = DockStyle.Bottom;
            labelNamePackage.Font = new Font("Segoe UI", 8F);
            labelNamePackage.Location = new Point(0, 92);
            labelNamePackage.Name = "labelNamePackage";
            labelNamePackage.Size = new Size(100, 28);
            labelNamePackage.TabIndex = 1;
            labelNamePackage.Text = "NAME_PACKAGE";
            labelNamePackage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEx2
            // 
            panelEx2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelEx2.Dock = DockStyle.Bottom;
            panelEx2.Location = new Point(0, 13);
            panelEx2.Name = "panelEx2";
            panelEx2.Size = new Size(100, 107);
            panelEx2.TabIndex = 3;
            panelEx2.Visible = false;
            // 
            // ItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            Controls.Add(panelEx2);
            Controls.Add(panelEx1);
            ForeColor = Color.WhiteSmoke;
            Name = "ItemControl";
            Size = new Size(100, 120);
            Click += ItemControl_Click;
            panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagePackage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelEx panelEx1;
        private PictureBox pictureBoxImagePackage;
        private Label labelNamePackage;
        private PanelEx panelEx2;
    }
}
