using System;
using Servicios;
using MySql.Data.MySqlClient;

namespace Repositorios
{
    public class ServicioRepositorio
    {
        private static ServicioRepositorio instance;
        private ConexionBD conexionBD;

        public static ServicioRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new ServicioRepositorio();
            }
            return instance;
        }

        private ServicioRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para obtener un servicio por IdServicio
        public ServicioDTO ObtenerServicioPorId(int idServicio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Servicio WHERE idservicio = @idServicio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idServicio", idServicio);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ServicioDTO servicio = new ServicioDTO
                    {
                        IdServicio = reader.GetInt32("idservicio"),
                        Precio = reader.GetInt32("precio")
                    };
                    return servicio;
                }
                else
                {
                    return null; // Si no se encuentra el servicio
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el servicio", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}