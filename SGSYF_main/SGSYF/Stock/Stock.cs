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

namespace SGSYF
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();

            dataGridView1.ReadOnly = true;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }


            string query = "SELECT * FROM Productos;";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            DataTable dt = new DataTable(); //Tabla en memoria

            MySqlDataReader resultado; //  se crea una variable llamada resultado tipo "MySqlDataReader" que es una manera de leer datos, que se usa para leer datos sql devueltos


            try
            {
                resultado = cmd.ExecuteReader(); // se ejecuta el comando cmd, y se guarda la informacion el resultado
                dt.Load(resultado); // carga en la tabla, el resultado guardado del comando
                dataGridView1.DataSource = dt; //asigna el datatable al dgv
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
