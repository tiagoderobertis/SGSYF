using MySql.Data.MySqlClient;
using SGSYF_conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGSYF_clases;

namespace SGSYF.Productos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
            llenar();

        }
        public void llenar()
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }
            string query = "select nombre from productos;";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> Nombres = new List<string>();

                while (reader.Read())
                {
                    Nombres.Add(reader.GetString("nombre")); // Lee el nombre de cada fila y lo agrega a la lista
                }
                cmb_seleccionar_producto.Items.AddRange(Nombres.Cast<object>().ToArray());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cmb_seleccionar_producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ProductoActualizado produ_actu = new ProductoActualizado(txt_nombre.Text, txt_descripcion.Text, txt_stock.Text, txt_codigo.Text);

            List<string> camposParaActualizar = new List<string>();

            if (!string.IsNullOrWhiteSpace(produ_actu.Nombre_ac))
            {
                camposParaActualizar.Add("nombre = '" + produ_actu.Nombre_ac + "'");
            }
            if (!string.IsNullOrWhiteSpace(produ_actu.Descripcion_ac))                              //si esta vacio, o es nulo, o tiene espacion en blanco, devuelve false y no se agrega
            {
                camposParaActualizar.Add("descripcion = '" + produ_actu.Descripcion_ac + "'");
            }
            if (!string.IsNullOrWhiteSpace(produ_actu.Stock_ac))
            {
                camposParaActualizar.Add("stock_total = '" + produ_actu.Stock_ac + "'");
            }
            if (!string.IsNullOrWhiteSpace(produ_actu.Codigobarra_ac))
            {
                camposParaActualizar.Add("codigo_barra = '" + produ_actu.Codigobarra_ac + "'");
            }

            if (camposParaActualizar.Count == 0)
            {
                MessageBox.Show("No se especificó ningún cambio.");
                return;
            }

            string query = "UPDATE productos SET " + string.Join(", ", camposParaActualizar) +                  //se concatena la lista y ademas se agrega el separador
                           " WHERE nombre = '" + cmb_seleccionar_producto.SelectedItem.ToString() + "';";

            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto cambiado con éxito.");
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
    }
}
