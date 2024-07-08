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
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form_Principal form_prin = new Form_Principal();
            form_prin.Show();

            form_prin.StartPosition = FormStartPosition.Manual;
            form_prin.Location = this.Location; //Establece la misma posición que el formulario actual

            this.Hide();
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Verificar_Datos verificar = new Verificar_Datos();

            string usuario = txt_user.Text;
            string contraseña = txt_pass.Text;
            string tipo = "Usuario";

            bool resultado = verificar.Verificar(usuario, contraseña, tipo);

            if (resultado == true)
            {
                //MUESTRA EL FORM ENTERO POR AHORA!!! CUANDO SE CREE EL FORM DE "FACTURAR", CAMBIAR "form_entero" POR "form_facturacion"
                SGSYF_UI form_entero = new SGSYF_UI();
                form_entero.Show();

                form_entero.StartPosition = FormStartPosition.Manual;
                form_entero.Location = this.Location; //Establece la misma posición que el formulario actual

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña invalido");
            }
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
    }
}
