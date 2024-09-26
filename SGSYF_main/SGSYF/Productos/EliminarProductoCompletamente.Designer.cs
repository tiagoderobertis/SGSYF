namespace SGSYF
{
    partial class EliminarProductoCompletamente
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
            cmb_eliminarProducto = new ComboBox();
            label1 = new Label();
            btn_eliminar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cmb_eliminarProducto
            // 
            cmb_eliminarProducto.Anchor = AnchorStyles.None;
            cmb_eliminarProducto.BackColor = Color.FromArgb(232, 245, 233);
            cmb_eliminarProducto.FormattingEnabled = true;
            cmb_eliminarProducto.Location = new Point(314, 236);
            cmb_eliminarProducto.Name = "cmb_eliminarProducto";
            cmb_eliminarProducto.Size = new Size(281, 23);
            cmb_eliminarProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(46, 125, 50);
            label1.Location = new Point(255, 174);
            label1.Name = "label1";
            label1.Size = new Size(396, 37);
            label1.TabIndex = 1;
            label1.Text = "¿Que producto deseas eliminar?";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom;
            btn_eliminar.BackColor = Color.FromArgb(165, 214, 167);
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.ForeColor = Color.FromArgb(46, 125, 50);
            btn_eliminar.Location = new Point(355, 286);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(197, 48);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar Definitivamente";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
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
            button2.TabIndex = 24;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EliminarProductoCompletamente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(884, 561);
            Controls.Add(button2);
            Controls.Add(btn_eliminar);
            Controls.Add(label1);
            Controls.Add(cmb_eliminarProducto);
            ForeColor = Color.FromArgb(46, 125, 50);
            MinimumSize = new Size(900, 600);
            Name = "EliminarProductoCompletamente";
            Text = "EliminarProductoCompletamente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_eliminarProducto;
        private Label label1;
        private Button btn_eliminar;
        private Button button2;
    }
}