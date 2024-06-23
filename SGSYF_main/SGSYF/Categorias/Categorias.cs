using MySql.Data.MySqlClient;
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
using SGSYF_conexion;

namespace SGSYF
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            SGSYF_UI formi = new SGSYF_UI();
            formi.Mover();
            CategoriaDevolver();
        }
        public void CategoriaDevolver()
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();
            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }
            string query = "select nombre from categorias;";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> Nombres = new List<string>();

                while (reader.Read())
                {
                    Nombres.Add(reader.GetString("nombre")); // Lee el nombre de cada fila y lo agrega a la lista
                }
                cmb_categoria_asociada.Items.AddRange(Nombres.Cast<object>().ToArray());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_agregarcategoria_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }


            if (txt_nombrecategoria.Text == "")
            {
                MessageBox.Show("No puede estar vacio el nombre");
            }
            else
            {
                string nombre_cat = txt_nombrecategoria.Text;
                string descripcion = txt_descripcioncategoria.Text;


                string query = "INSERT INTO categorias (nombre, descripcion) VALUES ('" + nombre_cat + "', '" + descripcion + "');";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria agregado exitosamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btn_agregarsub_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                return;
            }


            if (txt_nombresub.Text == "")
            {
                MessageBox.Show("No puede estar vacio el nombre");
            }
            else
            {
                string nombre_subcat = txt_nombresub.Text;
                string subdescripcion = txt_subdescripcion.Text;


                string query = "INSERT INTO categorias (nombre, descripcion) VALUES ('" + nombre_subcat + "', '" + subdescripcion + "');";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sub Categoria agregada exitosamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txt_nombrecategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
