namespace vizsgagyak
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxÜgyfelek = new ListBox();
            listBoxRendelések = new ListBox();
            textBoxÜgyfélSzűrés = new TextBox();
            textBoxÖssz = new TextBox();
            textBoxDarab = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxÜgyfelek
            // 
            listBoxÜgyfelek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxÜgyfelek.FormattingEnabled = true;
            listBoxÜgyfelek.ItemHeight = 32;
            listBoxÜgyfelek.Location = new Point(27, 102);
            listBoxÜgyfelek.Name = "listBoxÜgyfelek";
            listBoxÜgyfelek.Size = new Size(531, 836);
            listBoxÜgyfelek.TabIndex = 0;
            listBoxÜgyfelek.SelectedIndexChanged += listBoxÜgyfelek_SelectedIndexChanged;
            // 
            // listBoxRendelések
            // 
            listBoxRendelések.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxRendelések.FormattingEnabled = true;
            listBoxRendelések.ItemHeight = 32;
            listBoxRendelések.Location = new Point(654, 102);
            listBoxRendelések.Name = "listBoxRendelések";
            listBoxRendelések.Size = new Size(520, 836);
            listBoxRendelések.TabIndex = 1;
            listBoxRendelések.SelectedIndexChanged += listBoxRendelések_SelectedIndexChanged;
            // 
            // textBoxÜgyfélSzűrés
            // 
            textBoxÜgyfélSzűrés.Location = new Point(28, 56);
            textBoxÜgyfélSzűrés.Name = "textBoxÜgyfélSzűrés";
            textBoxÜgyfélSzűrés.Size = new Size(354, 39);
            textBoxÜgyfélSzűrés.TabIndex = 2;
            textBoxÜgyfélSzűrés.TextChanged += textBoxÜgyfélSzűrés_TextChanged;
            // 
            // textBoxÖssz
            // 
            textBoxÖssz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxÖssz.Location = new Point(1278, 560);
            textBoxÖssz.Name = "textBoxÖssz";
            textBoxÖssz.Size = new Size(258, 39);
            textBoxÖssz.TabIndex = 3;
            // 
            // textBoxDarab
            // 
            textBoxDarab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxDarab.Location = new Point(1278, 649);
            textBoxDarab.Name = "textBoxDarab";
            textBoxDarab.Size = new Size(258, 39);
            textBoxDarab.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 5;
            label1.Text = "Ügyfélszűrés:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1274, 520);
            label2.Name = "label2";
            label2.Size = new Size(286, 32);
            label2.TabIndex = 6;
            label2.Text = "Rendelésének összértéke:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1282, 608);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 7;
            label3.Text = "Rendelései (db):";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDarab);
            Controls.Add(textBoxÖssz);
            Controls.Add(textBoxÜgyfélSzűrés);
            Controls.Add(listBoxRendelések);
            Controls.Add(listBoxÜgyfelek);
            Name = "UserControl1";
            Size = new Size(1808, 1326);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxÜgyfelek;
        private ListBox listBoxRendelések;
        private TextBox textBoxÜgyfélSzűrés;
        private TextBox textBoxÖssz;
        private TextBox textBoxDarab;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
