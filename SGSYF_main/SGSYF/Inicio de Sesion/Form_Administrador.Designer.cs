namespace SGSYF.Inicio_de_Sesion
{
    partial class Form_Administrador
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
            btn_volver = new Button();
            btn_iniciar = new Button();
            label5 = new Label();
            txt_pass = new TextBox();
            label4 = new Label();
            txt_user = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.BackColor = SystemColors.HighlightText;
            btn_volver.Location = new Point(12, 12);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(68, 23);
            btn_volver.TabIndex = 4;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = SystemColors.HighlightText;
            btn_iniciar.Location = new Point(219, 277);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(68, 23);
            btn_iniciar.TabIndex = 22;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // label5
            // 
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(147, 238);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 21;
            label5.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(260, 237);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 20;
            // 
            // label4
            // 
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(147, 195);
            label4.Name = "label4";
            label4.Size = new Size(83, 26);
            label4.TabIndex = 19;
            label4.Text = "Usuario:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(260, 194);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(176, 102);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 17;
            label3.Text = "Iniciar Sesion";
            // 
            // Form_Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(511, 437);
            Controls.Add(btn_iniciar);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(btn_volver);
            Name = "Form_Administrador";
            Text = "Form_Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_volver;
        private Button btn_iniciar;
        private Label label5;
        private TextBox txt_pass;
        private Label label4;
        private TextBox txt_user;
        private Label label3;
    }
}