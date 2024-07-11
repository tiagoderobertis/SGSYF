using MySql.Data.MySqlClient;
using SGSYF_conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGSYF_clases
{
    public class Verificar_Datos
    {
        private string usuario;
        private string contraseña;
        private string tipo_u;
        private string palabra;

        //public Verificar_Datos(string u, string c, string t)
        //{
        //    usuario = u;
        //    contraseña = c;
        //    tipo_u = t;
        //}

        public string Usuario
        {
            get {  return usuario; }
            set { usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Tipo
        {
            get { return tipo_u; }
            set { tipo_u = value; }
        }

        public bool Verificar(string usuario, string contraseña, string tipo)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }


            string query = "select usuario, contraseña, tipo_usuario from usuario where usuario = '" + usuario + "' AND contraseña = '" + contraseña + "' AND tipo_usuario = '" + tipo + "';";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            bool coincidencias = false;

            try
            {
                MySqlDataReader lector = cmd.ExecuteReader(); //se usa para leer los resultados de la consulta
                if (lector.HasRows) //significa que se encontraron registros que coinciden con los dstos y el método devuelve true
                {

                    return coincidencias = true; 
                }
                else
                {
                    return coincidencias = false; 
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return coincidencias;
        }

        public bool Verificar_Para_Crear(string palabra)
        {
            Conexion conexion = new Conexion();
            MySqlConnection mySqlConnection = conexion.Establecer_Conexion();

            if (mySqlConnection == null)
            {
                MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
            }


            string query = "select palabra from usuario where palabra = '" + palabra +"';";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            bool coincidencia = false;

            try
            {
                MySqlDataReader lector = cmd.ExecuteReader(); //se usa para leer los resultados de la consulta
                if (lector.HasRows) //significa que se encontraron registros que coinciden con los dstos y el método devuelve true
                {
                    return coincidencia = true;
                }
                else
                {
                    return coincidencia = false;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return coincidencia;
        }
    }
}
