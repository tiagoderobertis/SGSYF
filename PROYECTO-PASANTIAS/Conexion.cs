using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PASANTIAS
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "gestor_stock";
        static string usuario = "root";
        static string password = "";
        static string puerto= "3306";

        string cadena_conexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection Establecer_Conexion()
        {
            try 
            { 
                conex.ConnectionString = cadena_conexion;
                conex.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conex;
        }
    }
}
