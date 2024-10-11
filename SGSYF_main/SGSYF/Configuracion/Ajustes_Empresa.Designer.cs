namespace SGSYF.Configuracion
{
    partial class Ajustes_Empresa
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
            txt_nombre_e = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // txt_nombre_e
            // 
            txt_nombre_e.Anchor = AnchorStyles.None;
            txt_nombre_e.BackColor = Color.FromArgb(232, 245, 233);
            txt_nombre_e.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre_e.Location = new Point(445, 225);
            txt_nombre_e.Name = "txt_nombre_e";
            txt_nombre_e.Size = new Size(122, 23);
            txt_nombre_e.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0,0,0);
            label2.Location = new Point(297, 225);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 6;
            label2.Text = "Nombre Empresa:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(239, 239, 239);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0,0,0);
            button2.Location = new Point(810, 30);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 23;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0,0,0);
            label1.Location = new Point(311, 117);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 24;
            label1.Text = "Ajustes de Empresa";
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.None;
            btn_guardar.BackColor = Color.FromArgb(239, 239, 239);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.ForeColor = Color.FromArgb(0,0,0);
            btn_guardar.Location = new Point(397, 288);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 25;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Ajustes_Empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            ClientSize = new Size(884, 561);
            Controls.Add(btn_guardar);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txt_nombre_e);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Name = "Ajustes_Empresa";
            Text = "Ajustes_Empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre_e;
        private Label label2;
        private Button button2;
        private Label label1;
        private Button btn_guardar;
    }
}