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
    public partial class Form_Principal_Confg : Form
    {
        public Form_Principal_Confg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Info_Personal uiInfo = new Info_Personal();
            uiInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Ajustes_Empresa a_e = new Ajustes_Empresa();
            a_e.Show();
        }
    }
}
