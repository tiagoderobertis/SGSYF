using MySql.Data.MySqlClient;
using SGSYF_clases;
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

namespace SGSYF.Inicio_de_Sesion
{
    public partial class Form_CrearCuentaUsuario : Form
    {
        public Form_CrearCuentaUsuario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_CrearCuentaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contraseña = txt_contrseña.Text;
            string palabra = txt_palabra.Text;

            Verificar_Datos verificar = new Verificar_Datos();
            bool resultado = verificar.Verificar_Para_Crear(palabra);

            if (resultado == true)
            {
                Conexion conexion = new Conexion();
                MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

                if (mySqlConnection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }


                string query = "INSERT INTO usuario (usuario, contraseña, tipo_usuario)  VALUES ('" + usuario + "', '" + contraseña + "', 'Usuario');";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado exitosamente");
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
            else
            {
                MessageBox.Show("Palabra de aministrador incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
