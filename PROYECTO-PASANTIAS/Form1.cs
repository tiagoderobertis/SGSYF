namespace PROYECTO_PASANTIAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Conexion conexion = new Conexion();
            conexion.Establecer_Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Validar_Form("Productos") == false)
            {
                Productos productos = new Productos();
                productos.MdiParent = this;
                productos.Show();
            }
        }

        public bool Validar_Form(string nombre)
        {
            foreach (var form_hijo in this.MdiChildren)
            {
                if (form_hijo.Name == nombre)
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

            treeView.Location = nueva_ubi;
        }

        public void Mover()
        {
            MoverTreeViewAbajo(treeView1, 15);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            if (Validar_Form("Stock") == false)
            {
                Stock stock = new Stock();
                stock.MdiParent = this;
                stock.Show();
            }
        }
    }
}
