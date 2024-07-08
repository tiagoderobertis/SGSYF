using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SGSYF_clases;
using SGSYF_conexion;

namespace SGSYF
{
    public partial class EliminarProductoCompletamente : Form
    {
        public EliminarProductoCompletamente()
        {
            InitializeComponent();
            LlenarComboBox llenar = new LlenarComboBox();
            llenar.llenarComboBoxProductos(cmb_eliminarProducto);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }
            string nombre_producto = cmb_eliminarProducto.SelectedItem.ToString();
            string query = "DELETE FROM Productos WHERE nombre = '" + nombre_producto +"';";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado exitosamente.");
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
