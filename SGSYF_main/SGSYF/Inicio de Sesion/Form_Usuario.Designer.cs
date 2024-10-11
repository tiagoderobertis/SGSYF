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
            label3 = new Label();
            txt_user = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_pass = new TextBox();
            btn_iniciar = new Button();
            button2 = new Button();
            pnl_contenedor = new Panel();
            pnl_contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_volver.BackColor = Color.FromArgb(239, 239, 239);
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.ForeColor = Color.FromArgb(0,0,0);
            btn_volver.Location = new Point(810, 30);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(45, 45);
            btn_volver.TabIndex = 3;
            btn_volver.Text = "X";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0,0,0);
            label3.Location = new Point(373, 140);
            label3.Name = "label3";
            label3.Size = new Size(164, 26);
            label3.TabIndex = 10;
            label3.Text = "Iniciar Sesion";
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.None;
            txt_user.Location = new Point(465, 201);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0,0,0);
            label4.Location = new Point(352, 202);
            label4.Name = "label4";
            label4.Size = new Size(83, 26);
            label4.TabIndex = 13;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0,0,0);
            label5.Location = new Point(352, 245);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 15;
            label5.Text = "Contraseña:";
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Location = new Point(465, 244);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 14;
            // 
            // btn_iniciar
            // 
            btn_iniciar.Anchor = AnchorStyles.None;
            btn_iniciar.BackColor = Color.FromArgb(239, 239, 239);
            btn_iniciar.FlatStyle = FlatStyle.Flat;
            btn_iniciar.ForeColor = Color.FromArgb(0,0,0);
            btn_iniciar.Location = new Point(417, 305);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(79, 33);
            btn_iniciar.TabIndex = 16;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(239, 239, 239);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0,0,0);
            button2.Location = new Point(406, 387);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 17;
            button2.Text = "Crear cuenta de usuario nueva";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnl_contenedor
            // 
            pnl_contenedor.BackColor = Color.FromArgb(249, 249, 249);
            pnl_contenedor.Controls.Add(btn_volver);
            pnl_contenedor.Controls.Add(label3);
            pnl_contenedor.Controls.Add(button2);
            pnl_contenedor.Controls.Add(txt_user);
            pnl_contenedor.Controls.Add(btn_iniciar);
            pnl_contenedor.Controls.Add(label4);
            pnl_contenedor.Controls.Add(label5);
            pnl_contenedor.Controls.Add(txt_pass);
            pnl_contenedor.Dock = DockStyle.Fill;
            pnl_contenedor.ForeColor = Color.FromArgb(0,0,0);
            pnl_contenedor.Location = new Point(0, 0);
            pnl_contenedor.Name = "pnl_contenedor";
            pnl_contenedor.Size = new Size(884, 561);
            pnl_contenedor.TabIndex = 18;
            // 
            // Form_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(884, 561);
            Controls.Add(pnl_contenedor);
            MinimumSize = new Size(900, 600);
            Name = "Form_Usuario";
            Text = "Form_Usuario";
            Load += Form_Usuario_Load;
            pnl_contenedor.ResumeLayout(false);
            pnl_contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_volver;
        private Label label3;
        private TextBox txt_user;
        private Label label4;
        private Label label5;
        private TextBox txt_pass;
        private Button btn_iniciar;
        private Button button2;
        private Panel pnl_contenedor;
    }
}