namespace SGSYF
{
    partial class Productos
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
            label2 = new Label();
            btn_agregarProducto = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Red;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 150);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 20;
            label2.Text = "Eliminar Producto";
            // 
            // btn_agregarProducto
            // 
            btn_agregarProducto.Location = new Point(266, 109);
            btn_agregarProducto.Name = "btn_agregarProducto";
            btn_agregarProducto.Size = new Size(169, 23);
            btn_agregarProducto.TabIndex = 46;
            btn_agregarProducto.Text = "Agegar Producto Nuevo";
            btn_agregarProducto.UseVisualStyleBackColor = true;
            btn_agregarProducto.Click += btn_agregarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(266, 63);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 47;
            label1.Text = "Agregar Producto Nuevo";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(997, 451);
            Controls.Add(label1);
            Controls.Add(btn_agregarProducto);
            Controls.Add(label2);
            Name = "Productos";
            Text = "Productos";
            WindowState = FormWindowState.Maximized;
            Load += Productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_agregarProducto;
        private Label label1;
    }
}