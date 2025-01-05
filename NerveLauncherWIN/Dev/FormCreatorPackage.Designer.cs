namespace NerveLauncherWIN.Dev
{
    partial class FormCreatorPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBoxDisplayVersion = new TextBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            panelEx1 = new Controls.PanelEx();
            richTextBoxLinkToFile2 = new RichTextBox();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            textBoxScrennshot = new TextBox();
            richTextBoxLinkToFile = new RichTextBox();
            textBoxIconApp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBoxTags = new TextBox();
            label9 = new Label();
            textBoxPackageIdentifier = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelEx1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(213, 23);
            textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Nazwa aplikacji";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Opis aplikacji";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(498, 241);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 4;
            label3.Text = "Wersja wyświetlana";
            // 
            // textBoxDisplayVersion
            // 
            textBoxDisplayVersion.Location = new Point(12, 333);
            textBoxDisplayVersion.Name = "textBoxDisplayVersion";
            textBoxDisplayVersion.Size = new Size(190, 23);
            textBoxDisplayVersion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 315);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Wersja (numer)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(221, 333);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panelEx1
            // 
            panelEx1.Controls.Add(richTextBoxLinkToFile2);
            panelEx1.Controls.Add(button1);
            panelEx1.Controls.Add(label8);
            panelEx1.Controls.Add(label7);
            panelEx1.Controls.Add(textBoxScrennshot);
            panelEx1.Controls.Add(richTextBoxLinkToFile);
            panelEx1.Controls.Add(textBoxIconApp);
            panelEx1.Controls.Add(label6);
            panelEx1.Controls.Add(label5);
            panelEx1.Controls.Add(textBoxTags);
            panelEx1.Location = new Point(12, 368);
            panelEx1.Name = "panelEx1";
            panelEx1.Size = new Size(759, 580);
            panelEx1.TabIndex = 8;
            // 
            // richTextBoxLinkToFile2
            // 
            richTextBoxLinkToFile2.Location = new Point(139, 199);
            richTextBoxLinkToFile2.Name = "richTextBoxLinkToFile2";
            richTextBoxLinkToFile2.Size = new Size(366, 359);
            richTextBoxLinkToFile2.TabIndex = 9;
            richTextBoxLinkToFile2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(525, 535);
            button1.Name = "button1";
            button1.Size = new Size(187, 23);
            button1.TabIndex = 8;
            button1.Text = "Wygeneruj plik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 171);
            label8.Name = "label8";
            label8.Size = new Size(148, 15);
            label8.TabIndex = 7;
            label8.Text = "Bezpośrednie linki do pliku";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 118);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 6;
            label7.Text = "Zrzuty ekranu";
            // 
            // textBoxScrennshot
            // 
            textBoxScrennshot.Location = new Point(9, 136);
            textBoxScrennshot.Name = "textBoxScrennshot";
            textBoxScrennshot.Size = new Size(496, 23);
            textBoxScrennshot.TabIndex = 5;
            // 
            // richTextBoxLinkToFile
            // 
            richTextBoxLinkToFile.Location = new Point(9, 199);
            richTextBoxLinkToFile.Name = "richTextBoxLinkToFile";
            richTextBoxLinkToFile.Size = new Size(124, 359);
            richTextBoxLinkToFile.TabIndex = 4;
            richTextBoxLinkToFile.Text = "";
            // 
            // textBoxIconApp
            // 
            textBoxIconApp.Location = new Point(9, 83);
            textBoxIconApp.Name = "textBoxIconApp";
            textBoxIconApp.Size = new Size(496, 23);
            textBoxIconApp.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 65);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 2;
            label6.Text = "Link do ikony aplikacji";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 5);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 1;
            label5.Text = "Tagi";
            // 
            // textBoxTags
            // 
            textBoxTags.Location = new Point(9, 23);
            textBoxTags.Name = "textBoxTags";
            textBoxTags.Size = new Size(496, 23);
            textBoxTags.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 10);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 9;
            label9.Text = "Indyfikator pakietu";
            // 
            // textBoxPackageIdentifier
            // 
            textBoxPackageIdentifier.Location = new Point(255, 28);
            textBoxPackageIdentifier.Name = "textBoxPackageIdentifier";
            textBoxPackageIdentifier.Size = new Size(255, 23);
            textBoxPackageIdentifier.TabIndex = 10;
            // 
            // FormCreatorPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPackageIdentifier);
            Controls.Add(label9);
            Controls.Add(panelEx1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(textBoxDisplayVersion);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTitle);
            Name = "FormCreatorPackage";
            Text = "FormCreatorPackage";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelEx1.ResumeLayout(false);
            panelEx1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBoxDisplayVersion;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Controls.PanelEx panelEx1;
        private Label label5;
        private TextBox textBoxTags;
        private TextBox textBoxIconApp;
        private Label label6;
        private RichTextBox richTextBoxLinkToFile;
        private Label label7;
        private TextBox textBoxScrennshot;
        private Label label8;
        private Button button1;
        private RichTextBox richTextBoxLinkToFile2;
        private Label label9;
        private TextBox textBoxPackageIdentifier;
    }
}