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
using SGSYF.Inicio_de_Sesion;
using SGSYF_clases;
using SGSYF_conexion;

namespace SGSYF.Configuracion
{
    public partial class Info_Personal : Form
    {
        public Info_Personal()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre_u = txt_nombre_u.Text;

            List<string> actualizar = new List<string>();

            if (!string.IsNullOrWhiteSpace(nombre_u))
            {
                actualizar.Add("usuario = '" + nombre_u + "'");
            }

            if (actualizar.Count == 0)
            {
                MessageBox.Show("No se especificó ningún cambio.");
                return;
            }

            // Recuperar el token almacenado
            var token = Properties.Settings.Default.UserToken;
            var tokenService = new TokenService();
            var usuario = tokenService.GetUsernameFromToken(token);

            if (usuario == null)
            {
                MessageBox.Show("No se pudo recuperar el nombre de usuario desde el token.");
                return;
            }

            string query = "UPDATE usuario SET " + string.Join(", ", actualizar) + " WHERE usuario = '" + usuario + "';";

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
                MessageBox.Show("Guardado con éxito");
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

        private void Info_Personal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

