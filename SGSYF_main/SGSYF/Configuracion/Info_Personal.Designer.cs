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
            txt_nombre_u = new TextBox();
            label5 = new Label();
            btn_guardar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 125, 50);
            label1.Location = new Point(307, 110);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 1;
            label1.Text = "Informacion Personal";
            // 
            // txt_nombre_u
            // 
            txt_nombre_u.Anchor = AnchorStyles.None;
            txt_nombre_u.BackColor = Color.FromArgb(232, 245, 233);
            txt_nombre_u.Location = new Point(500, 222);
            txt_nombre_u.Name = "txt_nombre_u";
            txt_nombre_u.Size = new Size(108, 23);
            txt_nombre_u.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(46, 125, 50);
            label5.Location = new Point(246, 222);
            label5.Name = "label5";
            label5.Size = new Size(248, 28);
            label5.TabIndex = 6;
            label5.Text = "Cambiar nombre de Usuario:";
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.None;
            btn_guardar.BackColor = Color.FromArgb(165, 214, 167);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(419, 304);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 10;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(165, 214, 167);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(46, 125, 50);
            button2.Location = new Point(810, 30);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 23;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Info_Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(884, 561);
            Controls.Add(button2);
            Controls.Add(btn_guardar);
            Controls.Add(txt_nombre_u);
            Controls.Add(label5);
            Controls.Add(label1);
            MinimumSize = new Size(900, 600);
            Name = "Info_Personal";
            Text = "Info_Personal";
            Load += Info_Personal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nombre_u;
        private Label label5;
        private Button btn_guardar;
        private Button button2;
    }
}