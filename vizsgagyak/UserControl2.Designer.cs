namespace vizsgagyak
{
    partial class UserControl2
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
            dataGridView1 = new DataGridView();
            buttonUjUgyfel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1273, 824);
            dataGridView1.TabIndex = 0;
            // 
            // buttonUjUgyfel
            // 
            buttonUjUgyfel.BackColor = Color.CadetBlue;
            buttonUjUgyfel.Location = new Point(32, 449);
            buttonUjUgyfel.Name = "buttonUjUgyfel";
            buttonUjUgyfel.Size = new Size(209, 162);
            buttonUjUgyfel.TabIndex = 1;
            buttonUjUgyfel.Text = "Új ügyfél hozzáadása";
            buttonUjUgyfel.UseVisualStyleBackColor = false;
            buttonUjUgyfel.Click += buttonUjUgyfel_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(buttonUjUgyfel);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(1814, 1391);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonUjUgyfel;
    }
}
