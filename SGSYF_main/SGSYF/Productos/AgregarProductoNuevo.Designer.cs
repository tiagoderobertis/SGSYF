namespace SGSYF
{
    partial class AgregarProductoNuevo
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            btn_agregar = new Button();
            cmb_categoria = new ComboBox();
            cmb_subcategoria = new ComboBox();
            txt_nombre = new TextBox();
            txt_stock = new TextBox();
            txt_descripcion = new TextBox();
            cmb_proveedor = new ComboBox();
            label12 = new Label();
            cmb_unidadmedida = new ComboBox();
            txt_codigobarra = new TextBox();
            label13 = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(249, 249, 249);
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label3.Location = new Point(333, 68);
            label3.Name = "label3";
            label3.Size = new Size(255, 31);
            label3.TabIndex = 19;
            label3.Text = "Agregar Producto Nuevo\r\n";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label4.Location = new Point(279, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
            label5.Location = new Point(280, 252);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 22;
            label5.Text = "Sub Categoria";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 0);
            label6.Location = new Point(278, 115);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 23;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label7.Location = new Point(278, 325);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 24;
            label7.Text = "Descripcion (opcional)";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label9.Location = new Point(484, 115);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 26;
            label9.Text = "Stock Total";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label11.Location = new Point(483, 325);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 28;
            label11.Text = "Proveedor";
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.None;
            btn_agregar.BackColor = Color.FromArgb(239, 239, 239);
            btn_agregar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.ForeColor = Color.FromArgb(0, 0, 0);
            btn_agregar.Location = new Point(398, 406);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(100, 42);
            btn_agregar.TabIndex = 29;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // cmb_categoria
            // 
            cmb_categoria.Anchor = AnchorStyles.None;
            cmb_categoria.BackColor = Color.FromArgb(232, 245, 233);
            cmb_categoria.ForeColor = SystemColors.WindowText;
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(279, 205);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(140, 23);
            cmb_categoria.TabIndex = 30;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // cmb_subcategoria
            // 
            cmb_subcategoria.Anchor = AnchorStyles.None;
            cmb_subcategoria.BackColor = Color.FromArgb(232, 245, 233);
            cmb_subcategoria.FormattingEnabled = true;
            cmb_subcategoria.Location = new Point(280, 270);
            cmb_subcategoria.Name = "cmb_subcategoria";
            cmb_subcategoria.Size = new Size(140, 23);
            cmb_subcategoria.TabIndex = 31;
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.BackColor = Color.FromArgb(232, 245, 233);
            txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre.Location = new Point(278, 145);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(140, 23);
            txt_nombre.TabIndex = 32;
            // 
            // txt_stock
            // 
            txt_stock.Anchor = AnchorStyles.None;
            txt_stock.BackColor = Color.FromArgb(232, 245, 233);
            txt_stock.BorderStyle = BorderStyle.FixedSingle;
            txt_stock.Location = new Point(484, 145);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(140, 23);
            txt_stock.TabIndex = 37;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Anchor = AnchorStyles.None;
            txt_descripcion.BackColor = Color.FromArgb(232, 245, 233);
            txt_descripcion.BorderStyle = BorderStyle.FixedSingle;
            txt_descripcion.Location = new Point(280, 343);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(140, 23);
            txt_descripcion.TabIndex = 39;
            // 
            // cmb_proveedor
            // 
            cmb_proveedor.Anchor = AnchorStyles.None;
            cmb_proveedor.BackColor = Color.FromArgb(232, 245, 233);
            cmb_proveedor.ForeColor = SystemColors.MenuText;
            cmb_proveedor.FormattingEnabled = true;
            cmb_proveedor.Location = new Point(484, 343);
            cmb_proveedor.Name = "cmb_proveedor";
            cmb_proveedor.Size = new Size(140, 23);
            cmb_proveedor.TabIndex = 40;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 0, 0);
            label12.Location = new Point(484, 252);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 41;
            label12.Text = "Unidad de Medida";
            // 
            // cmb_unidadmedida
            // 
            cmb_unidadmedida.Anchor = AnchorStyles.None;
            cmb_unidadmedida.BackColor = Color.FromArgb(232, 245, 233);
            cmb_unidadmedida.ForeColor = SystemColors.Desktop;
            cmb_unidadmedida.FormattingEnabled = true;
            cmb_unidadmedida.Location = new Point(484, 270);
            cmb_unidadmedida.Name = "cmb_unidadmedida";
            cmb_unidadmedida.Size = new Size(140, 23);
            cmb_unidadmedida.TabIndex = 42;
            // 
            // txt_codigobarra
            // 
            txt_codigobarra.Anchor = AnchorStyles.None;
            txt_codigobarra.BackColor = Color.FromArgb(232, 245, 233);
            txt_codigobarra.BorderStyle = BorderStyle.FixedSingle;
            txt_codigobarra.Location = new Point(484, 205);
            txt_codigobarra.Name = "txt_codigobarra";
            txt_codigobarra.Size = new Size(140, 23);
            txt_codigobarra.TabIndex = 44;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(0, 0, 0);
            label13.Location = new Point(484, 187);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 43;
            label13.Text = "Codigo Barra";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(239, 239, 239);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(0, 0, 0);
            button1.Location = new Point(810, 30);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 45;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(243, 45);
            label1.Name = "label1";
            label1.Size = new Size(432, 15);
            label1.TabIndex = 46;
            label1.Text = "No olvide añadir una categoria y una subcategoria antes de agregar su producto.";
            // 
            // AgregarProductoNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(884, 561);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_codigobarra);
            Controls.Add(label13);
            Controls.Add(cmb_unidadmedida);
            Controls.Add(label12);
            Controls.Add(cmb_proveedor);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_stock);
            Controls.Add(txt_nombre);
            Controls.Add(cmb_subcategoria);
            Controls.Add(cmb_categoria);
            Controls.Add(btn_agregar);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.FromArgb(0, 0, 0);
            MinimumSize = new Size(900, 600);
            Name = "AgregarProductoNuevo";
            Text = "Productos";
            Load += Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label11;
        private Button btn_agregar;
        private ComboBox cmb_categoria;
        private ComboBox cmb_subcategoria;
        private TextBox txt_nombre;
        private TextBox txt_stock;
        private TextBox txt_descripcion;
        private ComboBox cmb_proveedor;
        private Label label12;
        private ComboBox cmb_unidadmedida;
        private TextBox txt_codigobarra;
        private Label label13;
        private Button button1;
        private Label label1;
    }
}