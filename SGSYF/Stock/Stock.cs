using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGSYF
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            SGSYF_UI formi = new SGSYF_UI();
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
