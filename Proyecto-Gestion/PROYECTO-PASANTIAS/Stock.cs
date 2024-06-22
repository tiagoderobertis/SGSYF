using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PASANTIAS
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            Form1 formi = new Form1();
            formi.Mover();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
