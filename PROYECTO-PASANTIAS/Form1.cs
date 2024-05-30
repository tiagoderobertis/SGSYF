namespace PROYECTO_PASANTIAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarBotonTransparente();
            this.IsMdiContainer = true;
        }

        private void ConfigurarBotonTransparente()
        {

        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, Color.Transparent, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Validar_Form("Productos") == false)
            {
                Productos productos = new Productos();
                productos.MdiParent = this;
                productos.Show();
            }
        }

        public bool Validar_Form (string nombre)
        {
            foreach(var form_hijo in this.MdiChildren)
            {
                if(form_hijo.Name == nombre)
                {
                    form_hijo.BringToFront();
                    return true;
                }
                return false;
            }
            return false;
        }

        public void MoverTreeViewAbajo(TreeView treeView, int pixels)
        {
            TreeView treeView1 = new TreeView();

            var obtener_ubi = treeView.Location;

            var nueva_ubi = new Point(obtener_ubi.X, obtener_ubi.Y + pixels);

            // Establecer la nueva ubicación del TreeView
            treeView.Location = nueva_ubi;
        }

        public void Mover()
        {
            MoverTreeViewAbajo(treeView1, 15);
        }


    }
}
