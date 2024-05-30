using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_PASANTIAS
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            Form1 formi = new Form1();
            formi.Mover();
        }
        
        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
