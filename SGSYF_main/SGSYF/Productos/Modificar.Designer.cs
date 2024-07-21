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
            button2 = new Button();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.None;
            btn_guardar.BackColor = SystemColors.ButtonHighlight;
            btn_guardar.ForeColor = SystemColors.ActiveCaptionText;
            btn_guardar.Location = new Point(408, 375);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 70;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txt_codigo
            // 
            txt_codigo.Anchor = AnchorStyles.None;
            txt_codigo.BackColor = SystemColors.Control;
            txt_codigo.Location = new Point(526, 226);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(120, 23);
            txt_codigo.TabIndex = 69;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(526, 208);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 68;
            label6.Text = "Codigo de Barra";
            // 
            // txt_precio
            // 
            txt_precio.Anchor = AnchorStyles.None;
            txt_precio.BackColor = SystemColors.Control;
            txt_precio.Location = new Point(526, 286);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(120, 23);
            txt_precio.TabIndex = 67;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(526, 268);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 66;
            label2.Text = "Precio";
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.BackColor = SystemColors.Control;
            txt_nombre.Location = new Point(234, 226);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(120, 23);
            txt_nombre.TabIndex = 65;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(234, 268);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 64;
            label1.Text = "Descripcion";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(337, 171);
            label3.Name = "label3";
            label3.Size = new Size(235, 26);
            label3.TabIndex = 63;
            label3.Text = "Cambiar del Producto";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Anchor = AnchorStyles.None;
            txt_descripcion.BackColor = SystemColors.Control;
            txt_descripcion.Location = new Point(234, 286);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(120, 23);
            txt_descripcion.TabIndex = 62;
            // 
            // cmb_seleccionar_producto
            // 
            cmb_seleccionar_producto.Anchor = AnchorStyles.None;
            cmb_seleccionar_producto.BackColor = SystemColors.GradientActiveCaption;
            cmb_seleccionar_producto.ForeColor = SystemColors.WindowText;
            cmb_seleccionar_producto.FormattingEnabled = true;
            cmb_seleccionar_producto.Location = new Point(366, 118);
            cmb_seleccionar_producto.Name = "cmb_seleccionar_producto";
            cmb_seleccionar_producto.Size = new Size(153, 23);
            cmb_seleccionar_producto.TabIndex = 61;
            cmb_seleccionar_producto.SelectedIndexChanged += cmb_seleccionar_producto_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(234, 208);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 60;
            label7.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(337, 74);
            label4.Name = "label4";
            label4.Size = new Size(203, 28);
            label4.TabIndex = 59;
            label4.Text = "Seleccionar Producto";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(810, 30);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 71;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(884, 561);
            Controls.Add(button2);
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
            MinimumSize = new Size(900, 600);
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
        private Button button2;
    }
}