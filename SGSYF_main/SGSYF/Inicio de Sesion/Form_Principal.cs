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
using SGSYF_conex;

namespace SGSYF.Inicio_de_Sesion
{
    public partial class Form_Principal : Form
    {

        public static Form_Principal Instance { get; private set; }
        public Form_Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Instance = this;
        }

        private void btn_administador_Click(object sender, EventArgs e)
        {
            FormManager abrir = new FormManager(pnl_contenedor);
            abrir.AbrirFormHijo(new Form_Administrador());
            
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            FormManager abrir = new FormManager(pnl_contenedor);
            abrir.AbrirFormHijo(new Form_Usuario());
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
