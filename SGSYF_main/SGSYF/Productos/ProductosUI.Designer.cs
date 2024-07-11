namespace SGSYF
{
    partial class ProductosUI
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
            btn_agregarProducto = new Button();
            button1 = new Button();
            btn_modificarproducto = new Button();
            SuspendLayout();
            // 
            // btn_agregarProducto
            // 
            btn_agregarProducto.Location = new Point(266, 109);
            btn_agregarProducto.Name = "btn_agregarProducto";
            btn_agregarProducto.Size = new Size(169, 23);
            btn_agregarProducto.TabIndex = 46;
            btn_agregarProducto.Text = "Agegar Producto Nuevo";
            btn_agregarProducto.UseVisualStyleBackColor = true;
            btn_agregarProducto.Click += btn_agregarProducto_Click;
            // 
            // button1
            // 
            button1.Location = new Point(294, 154);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 48;
            button1.Text = "Eliminar Producto Completamente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_modificarproducto
            // 
            btn_modificarproducto.Location = new Point(266, 215);
            btn_modificarproducto.Name = "btn_modificarproducto";
            btn_modificarproducto.Size = new Size(169, 23);
            btn_modificarproducto.TabIndex = 49;
            btn_modificarproducto.Text = "Modificar Producto";
            btn_modificarproducto.UseVisualStyleBackColor = true;
            // 
            // ProductosUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(997, 451);
            Controls.Add(btn_modificarproducto);
            Controls.Add(button1);
            Controls.Add(btn_agregarProducto);
            Name = "ProductosUI";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_agregarProducto;
        private Button button1;
        private Button btn_modificarproducto;
    }
}