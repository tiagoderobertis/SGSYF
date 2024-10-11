namespace SGSYF.Inicio_de_Sesion
{
    partial class Form_Principal
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
            btn_administador = new Button();
            btn_usuario = new Button();
            label2 = new Label();
            label3 = new Label();
            pnl_contenedor = new Panel();
            pnl_contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0,0,0);
            label1.Location = new Point(358, 247);
            label1.Name = "label1";
            label1.Size = new Size(299, 28);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido/a a SGSYF!";
            // 
            // btn_administador
            // 
            btn_administador.Anchor = AnchorStyles.None;
            btn_administador.BackColor = Color.FromArgb(239, 239, 239);
            btn_administador.FlatStyle = FlatStyle.Flat;
            btn_administador.ForeColor = Color.FromArgb(0,0,0);
            btn_administador.Location = new Point(457, 362);
            btn_administador.Name = "btn_administador";
            btn_administador.Size = new Size(100, 50);
            btn_administador.TabIndex = 2;
            btn_administador.Text = "Administrador";
            btn_administador.UseVisualStyleBackColor = false;
            btn_administador.Click += btn_administador_Click;
            // 
            // btn_usuario
            // 
            btn_usuario.Anchor = AnchorStyles.None;
            btn_usuario.BackColor = Color.FromArgb(239, 239, 239);
            btn_usuario.FlatStyle = FlatStyle.Flat;
            btn_usuario.ForeColor = Color.FromArgb(0,0,0);
            btn_usuario.Location = new Point(457, 435);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(100, 50);
            btn_usuario.TabIndex = 3;
            btn_usuario.Text = "Usuario";
            btn_usuario.UseVisualStyleBackColor = false;
            btn_usuario.Click += btn_usuario_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(0,0,0);
            label2.Location = new Point(446, 303);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 5;
            label2.Text = "Iniciar sesion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 260);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // pnl_contenedor
            // 
            pnl_contenedor.BackColor = Color.FromArgb(249, 249, 249);
            pnl_contenedor.Controls.Add(label1);
            pnl_contenedor.Controls.Add(label3);
            pnl_contenedor.Controls.Add(btn_administador);
            pnl_contenedor.Controls.Add(label2);
            pnl_contenedor.Controls.Add(btn_usuario);
            pnl_contenedor.Dock = DockStyle.Fill;
            pnl_contenedor.Location = new Point(0, 0);
            pnl_contenedor.Name = "pnl_contenedor";
            pnl_contenedor.Size = new Size(1008, 729);
            pnl_contenedor.TabIndex = 7;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(pnl_contenedor);
            ForeColor = Color.FromArgb(0,0,0);
            MinimumSize = new Size(1024, 768);
            Name = "Form_Principal";
            Text = "Form_Principal";
            Load += Form_Principal_Load;
            pnl_contenedor.ResumeLayout(false);
            pnl_contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_administador;
        private Button btn_usuario;
        private Label label2;
        private Label label3;
        private Panel pnl_contenedor;
    }
}