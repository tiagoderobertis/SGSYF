namespace SGSYF
{
    partial class Categorias
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
            label1 = new Label();
            txt_descripcioncategoria = new TextBox();
            txt_nombrecategoria = new TextBox();
            btn_agregarcategoria = new Button();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_subdescripcion = new TextBox();
            txt_nombresub = new TextBox();
            btn_agregarsub = new Button();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmb_categoria_asociada = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(659, 37);
            label1.Name = "label1";
            label1.Size = new Size(3, 460);
            label1.TabIndex = 69;
            // 
            // txt_descripcioncategoria
            // 
            txt_descripcioncategoria.Location = new Point(455, 159);
            txt_descripcioncategoria.Name = "txt_descripcioncategoria";
            txt_descripcioncategoria.Size = new Size(104, 23);
            txt_descripcioncategoria.TabIndex = 63;
            // 
            // txt_nombrecategoria
            // 
            txt_nombrecategoria.Location = new Point(455, 104);
            txt_nombrecategoria.Name = "txt_nombrecategoria";
            txt_nombrecategoria.Size = new Size(104, 23);
            txt_nombrecategoria.TabIndex = 59;
            txt_nombrecategoria.TextChanged += txt_nombrecategoria_TextChanged;
            // 
            // btn_agregarcategoria
            // 
            btn_agregarcategoria.Location = new Point(383, 202);
            btn_agregarcategoria.Name = "btn_agregarcategoria";
            btn_agregarcategoria.Size = new Size(80, 28);
            btn_agregarcategoria.TabIndex = 56;
            btn_agregarcategoria.Text = "Agregar";
            btn_agregarcategoria.UseVisualStyleBackColor = true;
            btn_agregarcategoria.Click += btn_agregarcategoria_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(287, 162);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 51;
            label7.Text = "Descripcion (opcional)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(287, 107);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 48;
            label4.Text = "Nueva Categoria";
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(793, 54);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 47;
            label2.Text = "Eliminar Producto";
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 54);
            label3.Name = "label3";
            label3.Size = new Size(186, 31);
            label3.TabIndex = 46;
            label3.Text = "Agregar Categoria";
            // 
            // txt_subdescripcion
            // 
            txt_subdescripcion.Location = new Point(455, 384);
            txt_subdescripcion.Name = "txt_subdescripcion";
            txt_subdescripcion.Size = new Size(104, 23);
            txt_subdescripcion.TabIndex = 75;
            // 
            // txt_nombresub
            // 
            txt_nombresub.Location = new Point(455, 334);
            txt_nombresub.Name = "txt_nombresub";
            txt_nombresub.Size = new Size(104, 23);
            txt_nombresub.TabIndex = 74;
            // 
            // btn_agregarsub
            // 
            btn_agregarsub.Location = new Point(383, 422);
            btn_agregarsub.Name = "btn_agregarsub";
            btn_agregarsub.Size = new Size(80, 28);
            btn_agregarsub.TabIndex = 73;
            btn_agregarsub.Text = "Agregar";
            btn_agregarsub.UseVisualStyleBackColor = true;
            btn_agregarsub.Click += btn_agregarsub_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 387);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 72;
            label5.Text = "Descripcion (opcional)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 295);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 71;
            label6.Text = "Categoria Asociada";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(287, 337);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 76;
            label9.Text = "Nueva SubCategoria";
            // 
            // label10
            // 
            label10.BackColor = Color.WhiteSmoke;
            label10.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 248);
            label10.Name = "label10";
            label10.Size = new Size(228, 31);
            label10.TabIndex = 77;
            label10.Text = "Agregar Sub Categoria";
            // 
            // cmb_categoria_asociada
            // 
            cmb_categoria_asociada.FormattingEnabled = true;
            cmb_categoria_asociada.Location = new Point(455, 292);
            cmb_categoria_asociada.Name = "cmb_categoria_asociada";
            cmb_categoria_asociada.Size = new Size(104, 23);
            cmb_categoria_asociada.TabIndex = 78;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1090, 456);
            Controls.Add(cmb_categoria_asociada);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_subdescripcion);
            Controls.Add(txt_nombresub);
            Controls.Add(btn_agregarsub);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txt_descripcioncategoria);
            Controls.Add(txt_nombrecategoria);
            Controls.Add(btn_agregarcategoria);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Categorias";
            Text = "Categorias";
            WindowState = FormWindowState.Maximized;
            Load += Categorias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_descripcioncategoria;
        private TextBox txt_nombrecategoria;
        private Button btn_agregarcategoria;
        private Label label7;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txt_subdescripcion;
        private TextBox txt_nombresub;
        private Button btn_agregarsub;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private ComboBox cmb_categoria_asociada;
    }
}