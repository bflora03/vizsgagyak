namespace vizsgagyak
{
    partial class UserControl3
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
            components = new System.ComponentModel.Container();
            textBoxUgyfelSzuro = new TextBox();
            listBoxUgyfelek = new ListBox();
            listBoxSorszamok = new ListBox();
            dataGridView1 = new DataGridView();
            textBoxTetelSzuro = new TextBox();
            listBoxTetelek = new ListBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonPlusz = new Button();
            buttonMinusz = new Button();
            tetelDetailBindingSource = new BindingSource(components);
            termékkódDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            megnevezésDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egységárDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiségDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            megységDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tetelDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxUgyfelSzuro
            // 
            textBoxUgyfelSzuro.Location = new Point(30, 14);
            textBoxUgyfelSzuro.Name = "textBoxUgyfelSzuro";
            textBoxUgyfelSzuro.Size = new Size(200, 39);
            textBoxUgyfelSzuro.TabIndex = 0;
            textBoxUgyfelSzuro.TextChanged += textBoxUgyfelSzuro_TextChanged;
            // 
            // listBoxUgyfelek
            // 
            listBoxUgyfelek.FormattingEnabled = true;
            listBoxUgyfelek.ItemHeight = 32;
            listBoxUgyfelek.Location = new Point(30, 64);
            listBoxUgyfelek.Name = "listBoxUgyfelek";
            listBoxUgyfelek.Size = new Size(390, 708);
            listBoxUgyfelek.TabIndex = 1;
            listBoxUgyfelek.SelectedIndexChanged += listBoxUgyfelek_SelectedIndexChanged;
            // 
            // listBoxSorszamok
            // 
            listBoxSorszamok.FormattingEnabled = true;
            listBoxSorszamok.ItemHeight = 32;
            listBoxSorszamok.Location = new Point(569, 64);
            listBoxSorszamok.Name = "listBoxSorszamok";
            listBoxSorszamok.Size = new Size(392, 708);
            listBoxSorszamok.TabIndex = 2;
            listBoxSorszamok.SelectedIndexChanged += listBoxSorszamok_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { termékkódDataGridViewTextBoxColumn, megnevezésDataGridViewTextBoxColumn, egységárDataGridViewTextBoxColumn, mennyiségDataGridViewTextBoxColumn, megységDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tetelDetailBindingSource;
            dataGridView1.Location = new Point(1004, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(731, 703);
            dataGridView1.TabIndex = 3;
            // 
            // textBoxTetelSzuro
            // 
            textBoxTetelSzuro.Location = new Point(408, 789);
            textBoxTetelSzuro.Name = "textBoxTetelSzuro";
            textBoxTetelSzuro.Size = new Size(200, 39);
            textBoxTetelSzuro.TabIndex = 4;
            textBoxTetelSzuro.TextChanged += textBoxTetelSzuro_TextChanged;
            // 
            // listBoxTetelek
            // 
            listBoxTetelek.FormattingEnabled = true;
            listBoxTetelek.ItemHeight = 32;
            listBoxTetelek.Location = new Point(408, 846);
            listBoxTetelek.Name = "listBoxTetelek";
            listBoxTetelek.Size = new Size(393, 356);
            listBoxTetelek.TabIndex = 5;
            listBoxTetelek.SelectedIndexChanged += listBoxTetelek_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(941, 836);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(941, 902);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1147, 839);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1157, 905);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 9;
            label2.Text = "Ft";
            // 
            // buttonPlusz
            // 
            buttonPlusz.Location = new Point(1046, 751);
            buttonPlusz.Name = "buttonPlusz";
            buttonPlusz.Size = new Size(115, 64);
            buttonPlusz.TabIndex = 10;
            buttonPlusz.Text = "+";
            buttonPlusz.UseVisualStyleBackColor = true;
            buttonPlusz.Click += buttonPlusz_Click;
            // 
            // buttonMinusz
            // 
            buttonMinusz.Location = new Point(1206, 751);
            buttonMinusz.Name = "buttonMinusz";
            buttonMinusz.Size = new Size(112, 64);
            buttonMinusz.TabIndex = 11;
            buttonMinusz.Text = "-";
            buttonMinusz.UseVisualStyleBackColor = true;
            buttonMinusz.Click += buttonMinusz_Click;
            // 
            // tetelDetailBindingSource
            // 
            tetelDetailBindingSource.DataSource = typeof(TetelDetail);
            // 
            // termékkódDataGridViewTextBoxColumn
            // 
            termékkódDataGridViewTextBoxColumn.DataPropertyName = "Termékkód";
            termékkódDataGridViewTextBoxColumn.HeaderText = "Termékkód";
            termékkódDataGridViewTextBoxColumn.MinimumWidth = 10;
            termékkódDataGridViewTextBoxColumn.Name = "termékkódDataGridViewTextBoxColumn";
            termékkódDataGridViewTextBoxColumn.Width = 200;
            // 
            // megnevezésDataGridViewTextBoxColumn
            // 
            megnevezésDataGridViewTextBoxColumn.DataPropertyName = "Megnevezés";
            megnevezésDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            megnevezésDataGridViewTextBoxColumn.MinimumWidth = 10;
            megnevezésDataGridViewTextBoxColumn.Name = "megnevezésDataGridViewTextBoxColumn";
            megnevezésDataGridViewTextBoxColumn.Width = 200;
            // 
            // egységárDataGridViewTextBoxColumn
            // 
            egységárDataGridViewTextBoxColumn.DataPropertyName = "Egységár";
            egységárDataGridViewTextBoxColumn.HeaderText = "Egységár";
            egységárDataGridViewTextBoxColumn.MinimumWidth = 10;
            egységárDataGridViewTextBoxColumn.Name = "egységárDataGridViewTextBoxColumn";
            egységárDataGridViewTextBoxColumn.Width = 200;
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            mennyiségDataGridViewTextBoxColumn.MinimumWidth = 10;
            mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            mennyiségDataGridViewTextBoxColumn.Width = 200;
            // 
            // megységDataGridViewTextBoxColumn
            // 
            megységDataGridViewTextBoxColumn.DataPropertyName = "Megység";
            megységDataGridViewTextBoxColumn.HeaderText = "Megység";
            megységDataGridViewTextBoxColumn.MinimumWidth = 10;
            megységDataGridViewTextBoxColumn.Name = "megységDataGridViewTextBoxColumn";
            megységDataGridViewTextBoxColumn.Width = 200;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(buttonMinusz);
            Controls.Add(buttonPlusz);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(listBoxTetelek);
            Controls.Add(textBoxTetelSzuro);
            Controls.Add(dataGridView1);
            Controls.Add(listBoxSorszamok);
            Controls.Add(listBoxUgyfelek);
            Controls.Add(textBoxUgyfelSzuro);
            Name = "UserControl3";
            Size = new Size(1848, 1398);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tetelDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUgyfelSzuro;
        private ListBox listBoxUgyfelek;
        private ListBox listBoxSorszamok;
        private DataGridView dataGridView1;
        private TextBox textBoxTetelSzuro;
        private ListBox listBoxTetelek;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Button buttonPlusz;
        private Button buttonMinusz;
        private DataGridViewTextBoxColumn termékkódDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megnevezésDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységárDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megységDataGridViewTextBoxColumn;
        private BindingSource tetelDetailBindingSource;
    }
}
