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

namespace SGSYF.Configuracion
{
    public partial class Ajustes_Empresa : Form
    {
        public Ajustes_Empresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }

            string nombre = txt_nombre_e.Text;

            string query = "UPDATE configuracion SET nombre_empresa = '" + nombre + "' where id_config = 2;";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cambiado con exito.");
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
