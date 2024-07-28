using SGSYF_conexion; 
using SGSYF;
using MySql.Data.MySqlClient;
using SGSYF.Inicio_de_Sesion;


namespace SGSYF
{
    public partial class SGSYF_UI : Form
    {

        public SGSYF_UI()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.Establecer_Conexion();
            CambiarNombreEmpresa();


        }

        public void CambiarNombreEmpresa()
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }
            string query = "select nombre_empresa from configuracion where id_config = 2;";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            try
            {
                object nombre_sql = cmd.ExecuteScalar();
                string nombre = nombre_sql.ToString();
                lbl_nom.Text = nombre;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void SGSYF_UI_Shown(object sender, EventArgs e)
        {

        }

        private void SGSYF_UI_Load(object sender, EventArgs e)
        {

        }
        private Form formActivo = null;



        public void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            // Configura el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Añade el formulario hijo al panel padre
            this.pnl_contenedor.Controls.Add(formHijo);
            this.pnl_contenedor.Tag = formHijo;

            // Muestra el formulario hijo
            formHijo.BringToFront();
            formHijo.Show();
        }

        // Metodo para esconder SubMenus
        #region metodoEsconderSubMenus
        private void esconderSubMenu(int esconder)
        {
            switch (esconder)
            {
                case 0: subpnl_stock.Visible = false; break;
                case 1: subpnl_productos.Visible = false; break;
            }
        }
        #endregion

        // Metodo para mostrar SubMenus, en cada evento click correspondiente
        #region Metodo Mostrar SubMenu
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu(0);
                esconderSubMenu(1);
                esconderSubMenu(2);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region ClickAbrirSubMenus
        // Evento click del panel Productos
        private void btn_pnl_Productos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subpnl_productos);
        }


        // Evento click del panel Stock
        private void btn_pnl_Stock_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subpnl_stock);
        }
        #endregion

        // Eventos click de botones en subMenus
        #region ClickBotonesSubMenus
        private void btn_agregarProductos_Productos_Click(object sender, EventArgs e)
        {

            abrirFormHijo(new AgregarProductoNuevo());
            pnl_menuLateral.Visible = false;
            esconderSubMenu(1);
        }

        private void btn_eliminarProductos_Productos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EliminarProductoCompletamente());
            pnl_menuLateral.Visible = false;
            esconderSubMenu(1);
        }

        private void btn_editarProductos_Productos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Productos.Modificar());
            esconderSubMenu(1);
            pnl_menuLateral.Visible = false;
        }

        private void btn_listaProductos_Stock_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Stock());
            pnl_menuLateral.Visible = false;
            esconderSubMenu(0);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_pnl_Productos.Visible == false)
            {
                pnl_menuLateral.Visible = true;
                btn_desplegarMenuLateral.Text = "<";
            }
            else
            {
                pnl_menuLateral.Visible = false;
                btn_desplegarMenuLateral.Text = ">";
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Configuracion.Form_Principal_Confg());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Configuracion.Form_Principal_Confg());
            pnl_menuLateral.Visible = false;
        }

        private void SGSYF_UI_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SGSYF_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Principal.Instance.Close();
        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            abrirFormHijo(categorias);
            pnl_menuLateral.Visible = false;
        }

        private void pnl_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }







        // CODIGO OBSOLETO
        /*private void button6_Click(object sender, EventArgs e)
        {
            if (Validar_Form("Productos") == false)
            {
                ProductosUI productos = new ProductosUI();
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

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if (Validar_Form("Compra") == false)
            {
                *//*Compra compra = new Compra();
                compra.MdiParent = this;
                compra.Show();*//*
            }
        }


        private void btn_categorias_Click_1(object sender, EventArgs e)
        {
            if (Validar_Form("Categorias") == false)
            {
                Categorias categorias = new Categorias();
                categorias.MdiParent = this;
                categorias.Show();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }*/
    }
}
