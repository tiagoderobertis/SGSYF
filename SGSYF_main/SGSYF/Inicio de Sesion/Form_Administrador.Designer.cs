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
            btn_volver.BackColor = Color.FromArgb(165, 214, 167);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.ForeColor = Color.FromArgb(46, 125, 50);
            btn_volver.Location = new Point(810, 30);
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
            btn_iniciar.BackColor = Color.FromArgb(165, 214, 167);
            btn_iniciar.FlatStyle = FlatStyle.Flat;
            btn_iniciar.ForeColor = Color.FromArgb(46, 125, 50);
            btn_iniciar.Location = new Point(406, 328);
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
            label5.ForeColor = Color.FromArgb(46, 125, 50);
            label5.Location = new Point(334, 273);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 21;
            label5.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(447, 272);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 125, 50);
            label4.Location = new Point(334, 230);
            label4.Name = "label4";
            label4.Size = new Size(83, 26);
            label4.TabIndex = 19;
            label4.Text = "Usuario:";
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.None;
            txt_user.Location = new Point(447, 229);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(46, 125, 50);
            label3.Location = new Point(363, 164);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 17;
            label3.Text = "Iniciar Sesion";
            // 
            // Form_Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(884, 561);
            Controls.Add(btn_iniciar);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(btn_volver);
            MinimumSize = new Size(900, 600);
            Name = "Form_Administrador";
            Text = "Form_Administrador";
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