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

namespace SGSYF.Inicio_de_Sesion
{
    public partial class Form_Administrador : Form
    {

        public Form_Administrador()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form_Principal form_prin = new Form_Principal();
            form_prin.Show();

            form_prin.StartPosition = FormStartPosition.Manual;
            form_prin.Location = this.Location; //Pone el form en la misma posición que el formulario actual

            this.Hide();

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Verificar_Datos verificar = new Verificar_Datos();

            string usuario = txt_user.Text;
            string contraseña = txt_pass.Text;
            string tipo = "Administrador";

            bool resultado = verificar.Verificar(usuario, contraseña, tipo);

            if (resultado == true)
            {
                // Generar el token JWT
                var tokenService = new TokenService();
                var token = tokenService.GenerateToken(usuario, tipo);

                // Guardar el token en algún lugar para su uso posterior
                Properties.Settings.Default.UserToken = token;
                Properties.Settings.Default.Save();

                Form_Principal fp = new Form_Principal();
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

        private void Form_Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
