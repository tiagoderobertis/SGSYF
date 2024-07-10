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
            Info_Personal inper = new Info_Personal();
            inper.Show();

            inper.StartPosition = FormStartPosition.Manual;
            inper.Location = this.Location; //Establece la misma posición que el formulario actual

            this.Hide();
        }
    }
}
