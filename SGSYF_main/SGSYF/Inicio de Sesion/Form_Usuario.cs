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
                var tokenService = new TokenService();
                var token = tokenService.GenerateToken(usuario, tipo);

                // Guardar el token en algún lugar para su uso posterior
                Properties.Settings.Default.UserToken = token;
                Properties.Settings.Default.Save();

                //MUESTRA EL FORM ENTERO POR AHORA!!! CUANDO SE CREE EL FORM DE "FACTURAR", CAMBIAR "form_entero" POR "form_facturacion"
                SGSYF_UI form_entero = new SGSYF_UI();
                form_entero.Show();

                form_entero.StartPosition = FormStartPosition.Manual;
                form_entero.Location = this.Location; //Establece la misma posición que el formulario actual
                Guardar_datos gd = new Guardar_datos();
                gd.Nombre_usuario = usuario;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña invalido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_CrearCuentaUsuario form_us = new Form_CrearCuentaUsuario();
            form_us.Show();

            form_us.StartPosition = FormStartPosition.Manual;
            form_us.Location = this.Location;
            this.Close();
        }
    }
}
