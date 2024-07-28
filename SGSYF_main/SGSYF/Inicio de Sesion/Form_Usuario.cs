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
using SGSYF;

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
            this.Close();
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
                
                form_entero.StartPosition = FormStartPosition.Manual;
                form_entero.Location = this.Location; //Establece la misma posición que el formulario actual
                Guardar_datos gd = new Guardar_datos();
                gd.Nombre_usuario = usuario;
                AbrirFormulariosInicioSesion abrir = new AbrirFormulariosInicioSesion();
                //abrir.AbrirFormulario(FORM VENTAS,this);
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
            FormManager abrir = new FormManager(pnl_contenedor);
            abrir.AbrirFormHijo(new Form_CrearCuentaUsuario());
            
        }
    }
}
