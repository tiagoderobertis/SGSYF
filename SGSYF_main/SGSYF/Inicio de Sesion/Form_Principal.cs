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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void btn_administador_Click(object sender, EventArgs e)
        {
            Form_Administrador form_ad = new Form_Administrador();
            form_ad.Show();

            form_ad.StartPosition = FormStartPosition.Manual;
            form_ad.Location = this.Location; //Establece la misma posición que el formulario actual

            this.Hide();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Form_Usuario form_us = new Form_Usuario();
            form_us.Show();

            form_us.StartPosition = FormStartPosition.Manual;
            form_us.Location = this.Location;
            this.Hide();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
