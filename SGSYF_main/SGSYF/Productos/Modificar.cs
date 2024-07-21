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

namespace SGSYF.Productos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();

        }

        private void cmb_seleccionar_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }
            string query = "select nombre from categorias;";

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
