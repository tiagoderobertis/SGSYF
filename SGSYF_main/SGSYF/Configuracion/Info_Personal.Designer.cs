namespace SGSYF.Configuracion
{
    partial class Info_Personal
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(239, 37);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 1;
            label1.Text = "Informacion Personal";
            // 
            // label2
            // 
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(53, 138);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre Empresa:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(53, 195);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 4;
            label3.Text = "Logo Empresa:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(603, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(455, 194);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 8;
            label4.Text = "Foto de Perfil:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(603, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(382, 137);
            label5.Name = "label5";
            label5.Size = new Size(215, 28);
            label5.TabIndex = 6;
            label5.Text = "Cambiar Nombre Usuario:";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = SystemColors.ControlLightLight;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(363, 273);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 10;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Info_Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(769, 360);
            Controls.Add(btn_guardar);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Info_Personal";
            Text = "Info_Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button btn_guardar;
    }
}