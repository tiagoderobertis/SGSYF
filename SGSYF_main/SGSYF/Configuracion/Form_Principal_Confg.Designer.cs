namespace SGSYF.Configuracion
{
    partial class Form_Principal_Confg
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 214, 167);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(46, 125, 50);
            button1.Location = new Point(147, 165);
            button1.Name = "button1";
            button1.Size = new Size(84, 74);
            button1.TabIndex = 21;
            button1.Text = "Ajustes de Informacion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.TabIndex = 22;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(165, 214, 167);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(46, 125, 50);
            button3.Location = new Point(274, 165);
            button3.Name = "button3";
            button3.Size = new Size(84, 74);
            button3.TabIndex = 23;
            button3.Text = "Ajustes de empresa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form_Principal_Confg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(884, 561);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MinimumSize = new Size(900, 600);
            Name = "Form_Principal_Confg";
            Text = "Form_Principal_Confg";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
    }
}