namespace SGSYF
{
    partial class Productos
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btn_agregar = new Button();
            cmb_categoria = new ComboBox();
            cmb_subcategoria = new ComboBox();
            txt_nombre = new TextBox();
            txt_preciocompra = new TextBox();
            txt_stock = new TextBox();
            txt_precio = new TextBox();
            txt_descripcion = new TextBox();
            cmb_proveedor = new ComboBox();
            label12 = new Label();
            cmb_unidadmedida = new ComboBox();
            txt_codigobarra = new TextBox();
            label13 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(324, 58);
            label3.Name = "label3";
            label3.Size = new Size(177, 31);
            label3.TabIndex = 19;
            label3.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(761, 58);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 20;
            label2.Text = "Eliminar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(260, 109);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(260, 165);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 22;
            label5.Text = "Sub Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(260, 219);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 23;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(260, 273);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 24;
            label7.Text = "Descripcion (opcional)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(457, 109);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 25;
            label8.Text = "Precio (x unidad)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(457, 165);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 26;
            label9.Text = "Stock Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(457, 273);
            label10.Name = "label10";
            label10.Size = new Size(141, 15);
            label10.TabIndex = 27;
            label10.Text = "Precio compra (x unidad)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(457, 219);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 28;
            label11.Text = "Proveedor";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(374, 400);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(80, 28);
            btn_agregar.TabIndex = 29;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // cmb_categoria
            // 
            cmb_categoria.BackColor = SystemColors.GradientActiveCaption;
            cmb_categoria.ForeColor = SystemColors.WindowText;
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(260, 127);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(104, 23);
            cmb_categoria.TabIndex = 30;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // cmb_subcategoria
            // 
            cmb_subcategoria.BackColor = SystemColors.GradientActiveCaption;
            cmb_subcategoria.FormattingEnabled = true;
            cmb_subcategoria.Location = new Point(260, 183);
            cmb_subcategoria.Name = "cmb_subcategoria";
            cmb_subcategoria.Size = new Size(104, 23);
            cmb_subcategoria.TabIndex = 31;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = SystemColors.GrayText;
            txt_nombre.Location = new Point(260, 237);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(104, 23);
            txt_nombre.TabIndex = 32;
            // 
            // txt_preciocompra
            // 
            txt_preciocompra.BackColor = SystemColors.GrayText;
            txt_preciocompra.Location = new Point(459, 291);
            txt_preciocompra.Name = "txt_preciocompra";
            txt_preciocompra.Size = new Size(103, 23);
            txt_preciocompra.TabIndex = 35;
            // 
            // txt_stock
            // 
            txt_stock.BackColor = SystemColors.GrayText;
            txt_stock.Location = new Point(459, 183);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(103, 23);
            txt_stock.TabIndex = 37;
            // 
            // txt_precio
            // 
            txt_precio.BackColor = SystemColors.GrayText;
            txt_precio.Location = new Point(459, 127);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(103, 23);
            txt_precio.TabIndex = 38;
            // 
            // txt_descripcion
            // 
            txt_descripcion.BackColor = SystemColors.GrayText;
            txt_descripcion.Location = new Point(260, 291);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(104, 23);
            txt_descripcion.TabIndex = 39;
            // 
            // cmb_proveedor
            // 
            cmb_proveedor.BackColor = SystemColors.GradientActiveCaption;
            cmb_proveedor.ForeColor = SystemColors.MenuText;
            cmb_proveedor.FormattingEnabled = true;
            cmb_proveedor.Location = new Point(459, 237);
            cmb_proveedor.Name = "cmb_proveedor";
            cmb_proveedor.Size = new Size(103, 23);
            cmb_proveedor.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(260, 330);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 41;
            label12.Text = "Unidad de Medida";
            // 
            // cmb_unidadmedida
            // 
            cmb_unidadmedida.BackColor = SystemColors.GradientActiveCaption;
            cmb_unidadmedida.ForeColor = SystemColors.Desktop;
            cmb_unidadmedida.FormattingEnabled = true;
            cmb_unidadmedida.Location = new Point(260, 348);
            cmb_unidadmedida.Name = "cmb_unidadmedida";
            cmb_unidadmedida.Size = new Size(104, 23);
            cmb_unidadmedida.TabIndex = 42;
            // 
            // txt_codigobarra
            // 
            txt_codigobarra.BackColor = Color.Gray;
            txt_codigobarra.Location = new Point(459, 359);
            txt_codigobarra.Name = "txt_codigobarra";
            txt_codigobarra.ReadOnly = true;
            txt_codigobarra.Size = new Size(103, 23);
            txt_codigobarra.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(457, 330);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 43;
            label13.Text = "Codigo Barra";
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(651, -1);
            label1.Name = "label1";
            label1.Size = new Size(3, 460);
            label1.TabIndex = 45;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 451);
            Controls.Add(label1);
            Controls.Add(txt_codigobarra);
            Controls.Add(label13);
            Controls.Add(cmb_unidadmedida);
            Controls.Add(label12);
            Controls.Add(cmb_proveedor);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_precio);
            Controls.Add(txt_stock);
            Controls.Add(txt_preciocompra);
            Controls.Add(txt_nombre);
            Controls.Add(cmb_subcategoria);
            Controls.Add(cmb_categoria);
            Controls.Add(btn_agregar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Productos";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btn_agregar;
        private ComboBox cmb_categoria;
        private ComboBox cmb_subcategoria;
        private TextBox txt_nombre;
        private TextBox txt_preciocompra;
        private TextBox txt_stock;
        private TextBox txt_precio;
        private TextBox txt_descripcion;
        private ComboBox cmb_proveedor;
        private Label label12;
        private ComboBox cmb_unidadmedida;
        private TextBox txt_codigobarra;
        private Label label13;
        private Label label1;
    }
}