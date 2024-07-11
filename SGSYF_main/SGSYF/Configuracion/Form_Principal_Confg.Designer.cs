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
            treeView3 = new TreeView();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView3
            // 
            treeView3.BackColor = Color.WhiteSmoke;
            treeView3.Location = new Point(220, 2);
            treeView3.Name = "treeView3";
            treeView3.Size = new Size(137, 476);
            treeView3.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(239, 86);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 21;
            button1.Text = "Info Personal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Principal_Confg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1117, 476);
            Controls.Add(button1);
            Controls.Add(treeView3);
            Name = "Form_Principal_Confg";
            Text = "Form_Principal_Confg";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView3;
        private Button button1;
    }
}