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
            lbl_titleStock = new Label();
            button2 = new Button();
            txt_searchByName = new TextBox();
            lbl_searchByName = new Label();
            btn_searchByName = new Button();
            btn_orderByAsc = new Button();
            btn_orderByDesc = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_orderByNombreAsc = new Button();
            btn_orderByNombreDesc = new Button();
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(65, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 233);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_titleStock
            // 
            lbl_titleStock.Anchor = AnchorStyles.Top;
            lbl_titleStock.AutoSize = true;
            lbl_titleStock.Font = new Font("Segoe UI", 30F);
            lbl_titleStock.ForeColor = Color.FromArgb(0, 0, 0);
            lbl_titleStock.Location = new Point(401, 30);
            lbl_titleStock.Name = "lbl_titleStock";
            lbl_titleStock.Size = new Size(118, 54);
            lbl_titleStock.TabIndex = 1;
            lbl_titleStock.Text = "Stock\r\n";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(239, 239, 239);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 0, 0);
            button2.Location = new Point(810, 30);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 24;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_searchByName
            // 
            txt_searchByName.Location = new Point(111, 144);
            txt_searchByName.Name = "txt_searchByName";
            txt_searchByName.PlaceholderText = "Nombre de producto";
            txt_searchByName.Size = new Size(129, 23);
            txt_searchByName.TabIndex = 25;
            // 
            // lbl_searchByName
            // 
            lbl_searchByName.AutoSize = true;
            lbl_searchByName.Font = new Font("Segoe UI", 10F);
            lbl_searchByName.Location = new Point(111, 110);
            lbl_searchByName.Name = "lbl_searchByName";
            lbl_searchByName.Size = new Size(129, 19);
            lbl_searchByName.TabIndex = 26;
            lbl_searchByName.Text = "Buscar por nombre:";
            // 
            // btn_searchByName
            // 
            btn_searchByName.FlatStyle = FlatStyle.Flat;
            btn_searchByName.Location = new Point(137, 185);
            btn_searchByName.Name = "btn_searchByName";
            btn_searchByName.Size = new Size(72, 25);
            btn_searchByName.TabIndex = 27;
            btn_searchByName.Text = "Buscar";
            btn_searchByName.UseVisualStyleBackColor = true;
            btn_searchByName.Click += btn_searchByName_Click;
            // 
            // btn_orderByAsc
            // 
            btn_orderByAsc.FlatStyle = FlatStyle.Flat;
            btn_orderByAsc.Location = new Point(296, 143);
            btn_orderByAsc.Name = "btn_orderByAsc";
            btn_orderByAsc.Size = new Size(141, 23);
            btn_orderByAsc.TabIndex = 28;
            btn_orderByAsc.Text = "Ascendentemente";
            btn_orderByAsc.UseVisualStyleBackColor = true;
            btn_orderByAsc.Click += btn_orderByAsc_Click;
            // 
            // btn_orderByDesc
            // 
            btn_orderByDesc.FlatStyle = FlatStyle.Flat;
            btn_orderByDesc.Location = new Point(296, 187);
            btn_orderByDesc.Name = "btn_orderByDesc";
            btn_orderByDesc.Size = new Size(141, 23);
            btn_orderByDesc.TabIndex = 29;
            btn_orderByDesc.Text = "Descendentemente";
            btn_orderByDesc.UseVisualStyleBackColor = true;
            btn_orderByDesc.Click += btn_orderByDesc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 110);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 30;
            label1.Text = "Ordenar todos los productos por precio:";
            // 
            // label2
            // 
            label2.Location = new Point(534, 110);
            label2.Name = "label2";
            label2.Size = new Size(230, 33);
            label2.TabIndex = 30;
            label2.Text = "Ordenar todos los productos por nombre:\r\n";
            // 
            // btn_orderByNombreAsc
            // 
            btn_orderByNombreAsc.Location = new Point(537, 153);
            btn_orderByNombreAsc.Name = "btn_orderByNombreAsc";
            btn_orderByNombreAsc.Size = new Size(75, 23);
            btn_orderByNombreAsc.TabIndex = 31;
            btn_orderByNombreAsc.Text = "button1";
            btn_orderByNombreAsc.UseVisualStyleBackColor = true;
            // 
            // btn_orderByNombreDesc
            // 
            btn_orderByNombreDesc.Location = new Point(539, 187);
            btn_orderByNombreDesc.Name = "btn_orderByNombreDesc";
            btn_orderByNombreDesc.Size = new Size(75, 23);
            btn_orderByNombreDesc.TabIndex = 32;
            btn_orderByNombreDesc.Text = "button3";
            btn_orderByNombreDesc.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(884, 561);
            Controls.Add(btn_orderByNombreDesc);
            Controls.Add(btn_orderByNombreAsc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_orderByDesc);
            Controls.Add(btn_orderByAsc);
            Controls.Add(btn_searchByName);
            Controls.Add(lbl_searchByName);
            Controls.Add(txt_searchByName);
            Controls.Add(button2);
            Controls.Add(lbl_titleStock);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
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
        private Label lbl_titleStock;
        private Button button2;
        private TextBox txt_searchByName;
        private Label lbl_searchByName;
        private Button btn_searchByName;
        private Button btn_orderByAsc;
        private Button btn_orderByDesc;
        private Label label1;
        private Label label2;
        private Button btn_orderByNombreAsc;
        private Button btn_orderByNombreDesc;
    }
}