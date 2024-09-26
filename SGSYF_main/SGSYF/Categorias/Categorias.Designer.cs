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
            txt_descripcioncategoria = new TextBox();
            txt_nombrecategoria = new TextBox();
            btn_agregarcategoria = new Button();
            label7 = new Label();
            label4 = new Label();
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
            // txt_descripcioncategoria
            // 
            txt_descripcioncategoria.Anchor = AnchorStyles.None;
            txt_descripcioncategoria.BackColor = Color.FromArgb(232, 245, 233);
            txt_descripcioncategoria.Location = new Point(281, 289);
            txt_descripcioncategoria.Name = "txt_descripcioncategoria";
            txt_descripcioncategoria.Size = new Size(104, 23);
            txt_descripcioncategoria.TabIndex = 63;
            // 
            // txt_nombrecategoria
            // 
            txt_nombrecategoria.Anchor = AnchorStyles.None;
            txt_nombrecategoria.BackColor = Color.FromArgb(232, 245, 233);
            txt_nombrecategoria.Location = new Point(281, 234);
            txt_nombrecategoria.Name = "txt_nombrecategoria";
            txt_nombrecategoria.Size = new Size(104, 23);
            txt_nombrecategoria.TabIndex = 59;
            txt_nombrecategoria.TextChanged += txt_nombrecategoria_TextChanged;
            // 
            // btn_agregarcategoria
            // 
            btn_agregarcategoria.Anchor = AnchorStyles.None;
            btn_agregarcategoria.BackColor = Color.FromArgb(165, 214, 167);
            btn_agregarcategoria.FlatStyle = FlatStyle.Flat;
            btn_agregarcategoria.ForeColor = Color.FromArgb(46, 125, 50);
            btn_agregarcategoria.Location = new Point(209, 332);
            btn_agregarcategoria.Name = "btn_agregarcategoria";
            btn_agregarcategoria.Size = new Size(80, 28);
            btn_agregarcategoria.TabIndex = 56;
            btn_agregarcategoria.Text = "Agregar";
            btn_agregarcategoria.UseVisualStyleBackColor = false;
            btn_agregarcategoria.Click += btn_agregarcategoria_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 125, 50);
            label7.Location = new Point(113, 292);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 51;
            label7.Text = "Descripcion (opcional)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 125, 50);
            label4.Location = new Point(113, 237);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 48;
            label4.Text = "Nueva Categoria";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(200, 230, 201);
            label3.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(46, 125, 50);
            label3.Location = new Point(158, 184);
            label3.Name = "label3";
            label3.Size = new Size(186, 31);
            label3.TabIndex = 46;
            label3.Text = "Agregar Categoria";
            // 
            // txt_subdescripcion
            // 
            txt_subdescripcion.Anchor = AnchorStyles.None;
            txt_subdescripcion.BackColor = Color.FromArgb(232, 245, 233);
            txt_subdescripcion.Location = new Point(688, 320);
            txt_subdescripcion.Name = "txt_subdescripcion";
            txt_subdescripcion.Size = new Size(104, 23);
            txt_subdescripcion.TabIndex = 75;
            // 
            // txt_nombresub
            // 
            txt_nombresub.Anchor = AnchorStyles.None;
            txt_nombresub.BackColor = Color.FromArgb(232, 245, 233);
            txt_nombresub.Location = new Point(688, 270);
            txt_nombresub.Name = "txt_nombresub";
            txt_nombresub.Size = new Size(104, 23);
            txt_nombresub.TabIndex = 74;
            // 
            // btn_agregarsub
            // 
            btn_agregarsub.Anchor = AnchorStyles.None;
            btn_agregarsub.BackColor = Color.FromArgb(165, 214, 167);
            btn_agregarsub.FlatStyle = FlatStyle.Flat;
            btn_agregarsub.ForeColor = Color.FromArgb(46, 125, 50);
            btn_agregarsub.Location = new Point(616, 358);
            btn_agregarsub.Name = "btn_agregarsub";
            btn_agregarsub.Size = new Size(80, 28);
            btn_agregarsub.TabIndex = 73;
            btn_agregarsub.Text = "Agregar";
            btn_agregarsub.UseVisualStyleBackColor = false;
            btn_agregarsub.Click += btn_agregarsub_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(46, 125, 50);
            label5.Location = new Point(520, 323);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 72;
            label5.Text = "Descripcion (opcional)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 125, 50);
            label6.Location = new Point(520, 231);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 71;
            label6.Text = "Categoria Asociada";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(46, 125, 50);
            label9.Location = new Point(520, 273);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 76;
            label9.Text = "Nueva SubCategoria";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.BackColor = Color.FromArgb(200, 230, 201);
            label10.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(46, 125, 50);
            label10.Location = new Point(545, 184);
            label10.Name = "label10";
            label10.Size = new Size(228, 31);
            label10.TabIndex = 77;
            label10.Text = "Agregar Sub Categoria";
            label10.Click += label10_Click;
            // 
            // cmb_categoria_asociada
            // 
            cmb_categoria_asociada.Anchor = AnchorStyles.None;
            cmb_categoria_asociada.BackColor = Color.FromArgb(232, 245, 233);
            cmb_categoria_asociada.FormattingEnabled = true;
            cmb_categoria_asociada.Location = new Point(688, 228);
            cmb_categoria_asociada.Name = "cmb_categoria_asociada";
            cmb_categoria_asociada.Size = new Size(104, 23);
            cmb_categoria_asociada.TabIndex = 78;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(884, 561);
            Controls.Add(cmb_categoria_asociada);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_subdescripcion);
            Controls.Add(txt_nombresub);
            Controls.Add(btn_agregarsub);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txt_descripcioncategoria);
            Controls.Add(txt_nombrecategoria);
            Controls.Add(btn_agregarcategoria);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.White;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(900, 600);
            Name = "Categorias";
            Text = "Categorias";
            Load += Categorias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_descripcioncategoria;
        private TextBox txt_nombrecategoria;
        private Button btn_agregarcategoria;
        private Label label7;
        private Label label4;
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