namespace SGSYF
{
    partial class SGSYF_UI
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
            treeView1 = new TreeView();
            btn_compra = new Button();
            btn_categorias = new Button();
            button5 = new Button();
            btn_stock = new Button();
            treeView2 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.WindowFrame;
            treeView1.Location = new Point(1, 43);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(124, 618);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // btn_compra
            // 
            btn_compra.BackColor = SystemColors.WindowFrame;
            btn_compra.FlatAppearance.BorderColor = Color.White;
            btn_compra.FlatAppearance.BorderSize = 0;
            btn_compra.FlatStyle = FlatStyle.Flat;
            btn_compra.Location = new Point(12, 227);
            btn_compra.Name = "btn_compra";
            btn_compra.Size = new Size(104, 59);
            btn_compra.TabIndex = 12;
            btn_compra.Text = "Compra de productos";
            btn_compra.UseVisualStyleBackColor = false;
            btn_compra.Click += btn_compra_Click;
            // 
            // btn_categorias
            // 
            btn_categorias.BackColor = SystemColors.WindowFrame;
            btn_categorias.FlatAppearance.BorderColor = Color.White;
            btn_categorias.FlatAppearance.BorderSize = 0;
            btn_categorias.FlatStyle = FlatStyle.Flat;
            btn_categorias.Location = new Point(10, 292);
            btn_categorias.Name = "btn_categorias";
            btn_categorias.Size = new Size(104, 59);
            btn_categorias.TabIndex = 13;
            btn_categorias.Text = "Categorias";
            btn_categorias.UseVisualStyleBackColor = false;
            btn_categorias.Click += btn_categorias_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 162);
            button5.Name = "button5";
            button5.Size = new Size(104, 59);
            button5.TabIndex = 15;
            button5.Text = "Facturacion";
            button5.UseVisualStyleBackColor = false;
            // 
            // btn_stock
            // 
            btn_stock.BackColor = SystemColors.WindowFrame;
            btn_stock.FlatAppearance.BorderColor = Color.White;
            btn_stock.FlatAppearance.BorderSize = 0;
            btn_stock.FlatStyle = FlatStyle.Flat;
            btn_stock.Location = new Point(12, 110);
            btn_stock.Name = "btn_stock";
            btn_stock.Size = new Size(102, 46);
            btn_stock.TabIndex = 16;
            btn_stock.Text = "Stock";
            btn_stock.UseVisualStyleBackColor = false;
            btn_stock.Click += btn_stock_Click;
            // 
            // treeView2
            // 
            treeView2.BackColor = Color.WhiteSmoke;
            treeView2.Location = new Point(1, -1);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(1293, 48);
            treeView2.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 18;
            label1.Text = "Nombre Empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Location = new Point(16, 19);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "logo";
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(578, 9);
            label3.Name = "label3";
            label3.Size = new Size(234, 31);
            label3.TabIndex = 20;
            label3.Text = "..... BUSCADOR ......";
            // 
            // label5
            // 
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1091, 9);
            label5.Name = "label5";
            label5.Size = new Size(141, 31);
            label5.TabIndex = 22;
            label5.Text = "Nombre del usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Location = new Point(1248, 12);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 23;
            label6.Text = "foto";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.WindowFrame;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(12, 53);
            button6.Name = "button6";
            button6.Size = new Size(102, 51);
            button6.TabIndex = 24;
            button6.Text = "Productos";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // SGSYF_UI
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1293, 659);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView2);
            Controls.Add(btn_stock);
            Controls.Add(button5);
            Controls.Add(btn_categorias);
            Controls.Add(btn_compra);
            Controls.Add(treeView1);
            Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "SGSYF_UI";
            Text = "DataStocker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button btn_compra;
        private Button btn_categorias;
        private Button button5;
        private Button btn_stock;
        private TreeView treeView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button6;
    }
}
