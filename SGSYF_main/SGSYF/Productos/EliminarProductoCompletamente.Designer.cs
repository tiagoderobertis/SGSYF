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
            button1 = new Button();
            SuspendLayout();
            // 
            // cmb_eliminarProducto
            // 
            cmb_eliminarProducto.FormattingEnabled = true;
            cmb_eliminarProducto.Location = new Point(296, 154);
            cmb_eliminarProducto.Name = "cmb_eliminarProducto";
            cmb_eliminarProducto.Size = new Size(172, 23);
            cmb_eliminarProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 126);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 1;
            label1.Text = "¿Que producto deseas eliminar?";
            // 
            // button1
            // 
            button1.Location = new Point(343, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // EliminarProductoCompletamente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cmb_eliminarProducto);
            Name = "EliminarProductoCompletamente";
            Text = "EliminarProductoCompletamente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_eliminarProducto;
        private Label label1;
        private Button button1;
    }
}