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
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(309, 183);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(148, 23);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar Definitivamente";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // EliminarProductoCompletamente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eliminar);
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
        private Button btn_eliminar;
    }
}