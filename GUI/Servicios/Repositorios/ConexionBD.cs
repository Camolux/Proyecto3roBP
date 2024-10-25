using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDTO;
using MySql.Data.MySqlClient;

namespace Repositorios
{
    public class ConexionBD
    {
        private static string server = "localhost";
        private static string port = "3306";
        private static string database = "aioparking";
        private static string uid = "LoginBD"; // Reemplaza con tu usuario de base de datos
        private static string pwd = "1234";    // Reemplaza con tu contraseña de base de datos
        private static string connectionString = $"server={server};port={port};database={database};uid={uid};pwd={pwd};";

        private static ConexionBD instance = null;

        public static ConexionBD GetInstance()
        {
            if (instance == null)
            {
                instance = new ConexionBD();
            }
            return instance;
        }

        private ConexionBD() { }

        public MySqlConnection ConnectToDataBase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (MySqlException e)
            {
                throw new Exception($"Error al intentar conectar a la base de datos: {database}. Error: {e.Message}");
            }
        }
    }
}
