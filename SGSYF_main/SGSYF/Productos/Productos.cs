using MySql.Data.MySqlClient;
using SGSYF_clases;
using SGSYF_conexion;

namespace SGSYF;

public partial class Productos : Form
{
    public Productos()
    {
        InitializeComponent();
        SGSYF_UI formi = new SGSYF_UI();
        formi.Mover();
    }

    private void Productos_Load(object sender, EventArgs e)
    {
        LlenarComboBoxCategorias();
        LlenarComboBoxSubCategorias();
    }

    private void LlenarComboBoxCategorias()
    {
        Conexion conexion = new Conexion();
        MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

        if (mySqlConnection == null)
        {
            MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            return;
        }

        string query = "SELECT * FROM categorias";
        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

        try
        {
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_categoria.Items.Add(reader["nombre"].ToString());
            }
            reader.Close();
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

    private void LlenarComboBoxSubCategorias()
    {
        Conexion conexion = new Conexion();
        MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

        if (mySqlConnection == null)
        {
            MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            return;
        }

        string query = "SELECT * FROM subcategorias";
        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

        try
        {
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_subcategoria.Items.Add(reader["nombre"].ToString());
            }
            reader.Close();
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

    private void btn_agregar_Click(object sender, EventArgs e)
    {

        ProductosControlador productosControlador = new ProductosControlador

            (
            txt_codigobarra.Text,
            cmb_categoria.Text,
            cmb_subcategoria.Text,
            txt_nombre.Text,
            txt_descripcion.Text,
            txt_precio.Text,
            cmb_unidadmedida.Text,
            txt_preciocompra.Text,
            txt_stock.Text
            //cmb_proveedor.Text
            );


        

        // - AGREGAR PRODUCTOS A LA BASE DE DATOS
        Conexion conexion = new Conexion();
        MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

        if (mySqlConnection == null)
        {
            MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            return;
        }

        

        // VERIFICADORES DE CAMPOS

        if (string.IsNullOrEmpty(cmb_categoria.Text) ||
            string.IsNullOrEmpty(cmb_subcategoria.Text)||
            string.IsNullOrEmpty(txt_nombre.Text) ||
            string.IsNullOrEmpty(cmb_unidadmedida.Text) ||
            string.IsNullOrEmpty(txt_precio.Text) ||
            string.IsNullOrEmpty(txt_stock.Text) ||
            string.IsNullOrEmpty(txt_preciocompra.Text) ||
            string.IsNullOrEmpty(txt_codigobarra.Text)
            )
        {

            MessageBox.Show("Completa el o los campos vacios");

        } else {  
            int codigoBarra = Convert.ToInt32(productosControlador.Codigo_barra);
            string categoria = productosControlador.Categoria;
            string subCategoria = productosControlador.Subcategoria;
            string nombre = productosControlador.Nombre;
            string descripcion = productosControlador.Descripcion;
            int precio = Convert.ToInt32(productosControlador.Precio);
            string unidadMedida = productosControlador.Unidad_medida;
            int precioCompra = Convert.ToInt32(productosControlador.Precio_compra);
            int stock = Convert.ToInt32(productosControlador.Stock_total);
            //string proveedor = productosControlador.Proveedores;

            string query = "INSERT INTO productos (codigo_barra, categoria, subcategoria, nombre, descripcion, precio, unidad_medida, precio_compra, stock_total) " +
               "VALUES (" + codigoBarra + ", '" + categoria + "', '" + subCategoria + "', '" + nombre + "', '" + descripcion + "', " + precio + ", '" + unidadMedida + "', " + precioCompra + ", " + stock + ");";



            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto agregado exitosamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
    

    


    private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
