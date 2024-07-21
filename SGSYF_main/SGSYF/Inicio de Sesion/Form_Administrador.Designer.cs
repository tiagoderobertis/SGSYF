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
            btn_volver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_volver.BackColor = Color.Black;
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.ForeColor = Color.White;
            btn_volver.Location = new Point(940, 23);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.TabIndex = 4;
            btn_volver.Text = "X";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_iniciar
            // 
            btn_iniciar.Anchor = AnchorStyles.None;
            btn_iniciar.BackColor = Color.Black;
            btn_iniciar.ForeColor = Color.White;
            btn_iniciar.Location = new Point(468, 412);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(79, 33);
            btn_iniciar.TabIndex = 22;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(396, 357);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 21;
            label5.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(509, 356);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(396, 314);
            label4.Name = "label4";
            label4.Size = new Size(83, 26);
            label4.TabIndex = 19;
            label4.Text = "Usuario:";
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.None;
            txt_user.Location = new Point(509, 313);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(425, 248);
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
            ClientSize = new Size(1008, 729);
            Controls.Add(btn_iniciar);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(btn_volver);
            MinimumSize = new Size(1024, 768);
            Name = "Form_Administrador";
            Text = "Form_Administrador";
            WindowState = FormWindowState.Maximized;
            Load += Form_Administrador_Load;
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