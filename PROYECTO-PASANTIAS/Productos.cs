using MySql.Data.MySqlClient;
using PROYECTO_PASANTIAS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_PASANTIAS
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            Form1 formi = new Form1();
            formi.Mover();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }

            string nombre = txt_nombre.Text;
            int codigo_barra = int.Parse(txt_codigobarra.Text);
            string descripcion = txt_descripcion.Text;
            string categoria = cmb_categoria.Text;
            string sub_categoria = cmb_subcategoria.Text;
            string unidad_medida = cmb_unidadmedida.Text;
            string proveedor = cmb_proveedor.Text;
            int precio = int.Parse(txt_precio.Text);
            int precio_compra = int.Parse(txt_preciocompra.Text);
            int stock = int.Parse(txt_stock.Text);

            string query = "INSERT INTO productos (codigo_barra, categoria, subcategoria, nombre, descripcion, precio, unidad_medida, precio_compra, stock_total, proveedor) " +
                   "VALUES (" + codigo_barra + ", '" + categoria + "', '" + sub_categoria + "', '" + nombre + "', '" + descripcion + "', " + precio + ", '" + unidad_medida + "', " + precio_compra + ", " + stock + ", '" + proveedor + "');";

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
}
