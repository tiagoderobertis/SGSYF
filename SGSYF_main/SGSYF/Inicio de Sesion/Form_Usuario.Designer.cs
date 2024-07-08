namespace SGSYF.Inicio_de_Sesion
{
    partial class Form_Usuario
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txt_user = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_pass = new TextBox();
            btn_iniciar = new Button();
            button1 = new Button();
            label6 = new Label();
            txt_contrseña = new TextBox();
            label7 = new Label();
            txt_usuario = new TextBox();
            label8 = new Label();
            txt_palabra = new TextBox();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.BackColor = SystemColors.HighlightText;
            btn_volver.Location = new Point(12, 12);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(68, 23);
            btn_volver.TabIndex = 3;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // label2
            // 
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(342, 90);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 11;
            label2.Text = "Crear Cuenta";
            // 
            // label3
            // 
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(55, 90);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 10;
            label3.Text = "Iniciar Sesion";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(270, 68);
            label1.Name = "label1";
            label1.Size = new Size(10, 384);
            label1.TabIndex = 9;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(139, 182);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 12;
            // 
            // label4
            // 
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(26, 183);
            label4.Name = "label4";
            label4.Size = new Size(83, 26);
            label4.TabIndex = 13;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 226);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 15;
            label5.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(139, 225);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 14;
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = SystemColors.HighlightText;
            btn_iniciar.Location = new Point(98, 265);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(68, 23);
            btn_iniciar.TabIndex = 16;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Location = new Point(379, 324);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 21;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(313, 226);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 20;
            label6.Text = "Contraseña:";
            // 
            // txt_contrseña
            // 
            txt_contrseña.Location = new Point(426, 225);
            txt_contrseña.Name = "txt_contrseña";
            txt_contrseña.PasswordChar = '*';
            txt_contrseña.Size = new Size(100, 23);
            txt_contrseña.TabIndex = 19;
            // 
            // label7
            // 
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(313, 183);
            label7.Name = "label7";
            label7.Size = new Size(83, 26);
            label7.TabIndex = 18;
            label7.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(426, 182);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 17;
            // 
            // label8
            // 
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(313, 266);
            label8.Name = "label8";
            label8.Size = new Size(107, 37);
            label8.TabIndex = 23;
            label8.Text = "Palabra de Admin:";
            // 
            // txt_palabra
            // 
            txt_palabra.Location = new Point(426, 277);
            txt_palabra.Name = "txt_palabra";
            txt_palabra.PasswordChar = '*';
            txt_palabra.Size = new Size(100, 23);
            txt_palabra.TabIndex = 22;
            // 
            // Form_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(560, 450);
            Controls.Add(label8);
            Controls.Add(txt_palabra);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txt_contrseña);
            Controls.Add(label7);
            Controls.Add(txt_usuario);
            Controls.Add(btn_iniciar);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_volver);
            Name = "Form_Usuario";
            Text = "Form_Usuario";
            Load += Form_Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_volver;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txt_user;
        private Label label4;
        private Label label5;
        private TextBox txt_pass;
        private Button btn_iniciar;
        private Button button1;
        private Label label6;
        private TextBox txt_contrseña;
        private Label label7;
        private TextBox txt_usuario;
        private Label label8;
        private TextBox txt_palabra;
    }
}