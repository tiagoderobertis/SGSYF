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
            label2 = new Label();
            btn_administador = new Button();
            btn_usuario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(123, 89);
            label1.Name = "label1";
            label1.Size = new Size(299, 28);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido/a a SGSYF!";
            // 
            // label2
            // 
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(213, 184);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 1;
            label2.Text = "Eres...?";
            // 
            // btn_administador
            // 
            btn_administador.BackColor = SystemColors.HighlightText;
            btn_administador.Location = new Point(123, 273);
            btn_administador.Name = "btn_administador";
            btn_administador.Size = new Size(96, 22);
            btn_administador.TabIndex = 2;
            btn_administador.Text = "Administrador";
            btn_administador.UseVisualStyleBackColor = false;
            btn_administador.Click += btn_administador_Click;
            // 
            // btn_usuario
            // 
            btn_usuario.BackColor = SystemColors.HighlightText;
            btn_usuario.Location = new Point(330, 272);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(92, 23);
            btn_usuario.TabIndex = 3;
            btn_usuario.Text = "Usuario";
            btn_usuario.UseVisualStyleBackColor = false;
            btn_usuario.Click += btn_usuario_Click;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(532, 443);
            Controls.Add(btn_usuario);
            Controls.Add(btn_administador);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Principal";
            Text = "Form_Principal";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_administador;
        private Button btn_usuario;
    }
}