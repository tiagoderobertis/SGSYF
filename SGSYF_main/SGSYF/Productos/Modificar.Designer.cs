namespace SGSYF.Productos
{
    partial class Modificar
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
            btn_guardar = new Button();
            txt_codigo = new TextBox();
            label6 = new Label();
            txt_precio = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txt_descripcion = new TextBox();
            cmb_seleccionar_producto = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = SystemColors.ButtonHighlight;
            btn_guardar.ForeColor = SystemColors.ActiveCaptionText;
            btn_guardar.Location = new Point(502, 294);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 70;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txt_codigo
            // 
            txt_codigo.BackColor = SystemColors.Control;
            txt_codigo.Location = new Point(619, 178);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(120, 23);
            txt_codigo.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(619, 160);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 68;
            label6.Text = "Codigo de Barra";
            // 
            // txt_precio
            // 
            txt_precio.BackColor = SystemColors.Control;
            txt_precio.Location = new Point(619, 238);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(120, 23);
            txt_precio.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(619, 220);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 66;
            label2.Text = "Precio";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = SystemColors.Control;
            txt_nombre.Location = new Point(327, 178);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(120, 23);
            txt_nombre.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(327, 220);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 64;
            label1.Text = "Descripcion";
            // 
            // label3
            // 
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(430, 123);
            label3.Name = "label3";
            label3.Size = new Size(235, 26);
            label3.TabIndex = 63;
            label3.Text = "Cambiar del Producto";
            // 
            // txt_descripcion
            // 
            txt_descripcion.BackColor = SystemColors.Control;
            txt_descripcion.Location = new Point(327, 238);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(120, 23);
            txt_descripcion.TabIndex = 62;
            // 
            // cmb_seleccionar_producto
            // 
            cmb_seleccionar_producto.BackColor = SystemColors.GradientActiveCaption;
            cmb_seleccionar_producto.ForeColor = SystemColors.WindowText;
            cmb_seleccionar_producto.FormattingEnabled = true;
            cmb_seleccionar_producto.Location = new Point(484, 55);
            cmb_seleccionar_producto.Name = "cmb_seleccionar_producto";
            cmb_seleccionar_producto.Size = new Size(120, 23);
            cmb_seleccionar_producto.TabIndex = 61;
            cmb_seleccionar_producto.SelectedIndexChanged += cmb_seleccionar_producto_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(327, 160);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 60;
            label7.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(484, 37);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 59;
            label4.Text = "Seleccionar Producto";
            // 
            // Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1070, 465);
            Controls.Add(btn_guardar);
            Controls.Add(txt_codigo);
            Controls.Add(label6);
            Controls.Add(txt_precio);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txt_descripcion);
            Controls.Add(cmb_seleccionar_producto);
            Controls.Add(label7);
            Controls.Add(label4);
            Name = "Modificar";
            Text = "Modificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private TextBox txt_codigo;
        private Label label6;
        private TextBox txt_precio;
        private Label label2;
        private TextBox txt_nombre;
        private Label label1;
        private Label label3;
        private TextBox txt_descripcion;
        private ComboBox cmb_seleccionar_producto;
        private Label label7;
        private Label label4;
    }
}