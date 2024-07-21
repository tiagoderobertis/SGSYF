namespace SGSYF.Inicio_de_Sesion
{
    partial class Form_CrearCuentaUsuario
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
            label8 = new Label();
            txt_palabra = new TextBox();
            button1 = new Button();
            label6 = new Label();
            txt_contrseña = new TextBox();
            label7 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(418, 379);
            label8.Name = "label8";
            label8.Size = new Size(107, 37);
            label8.TabIndex = 31;
            label8.Text = "Palabra de Admin:";
            // 
            // txt_palabra
            // 
            txt_palabra.Anchor = AnchorStyles.None;
            txt_palabra.Location = new Point(531, 390);
            txt_palabra.Name = "txt_palabra";
            txt_palabra.PasswordChar = '*';
            txt_palabra.Size = new Size(100, 23);
            txt_palabra.TabIndex = 30;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Location = new Point(477, 436);
            button1.Name = "button1";
            button1.Size = new Size(79, 33);
            button1.TabIndex = 29;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(418, 339);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 28;
            label6.Text = "Contraseña:";
            // 
            // txt_contrseña
            // 
            txt_contrseña.Anchor = AnchorStyles.None;
            txt_contrseña.Location = new Point(531, 338);
            txt_contrseña.Name = "txt_contrseña";
            txt_contrseña.PasswordChar = '*';
            txt_contrseña.Size = new Size(100, 23);
            txt_contrseña.TabIndex = 27;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(418, 296);
            label7.Name = "label7";
            label7.Size = new Size(83, 26);
            label7.TabIndex = 26;
            label7.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.None;
            txt_usuario.Location = new Point(531, 295);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(445, 243);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 24;
            label2.Text = "Crear Cuenta";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(940, 23);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 32;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form_CrearCuentaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1008, 729);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(txt_palabra);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txt_contrseña);
            Controls.Add(label7);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            ForeColor = Color.White;
            MinimumSize = new Size(1024, 768);
            Name = "Form_CrearCuentaUsuario";
            Text = "Form_CrearCuentaUsuario";
            Load += Form_CrearCuentaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txt_palabra;
        private Button button1;
        private Label label6;
        private TextBox txt_contrseña;
        private Label label7;
        private TextBox txt_usuario;
        private Label label2;
        private Button button2;
    }
}