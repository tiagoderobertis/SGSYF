namespace SGSYF
{
    partial class Stock
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 233);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(0,0,0);
            label1.Location = new Point(65, 70);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista de productos completa:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(239, 239, 239);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0,0,0);
            button2.Location = new Point(810, 30);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 24;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(884, 561);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(900, 600);
            Name = "Stock";
            Text = "Stock";
            WindowState = FormWindowState.Maximized;
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
    }
}