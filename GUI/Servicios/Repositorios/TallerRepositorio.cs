using System;
using System.Collections.Generic;
using Servicios;
using MySql.Data.MySqlClient;

namespace Repositorios
{
    public class TallerRepositorio
    {
        private static TallerRepositorio instance;
        private ConexionBD conexionBD;

        public static TallerRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new TallerRepositorio();
            }
            return instance;
        }

        private TallerRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para obtener un taller por ID de servicio
        public TallerDTO ObtenerTallerPorId(int idServicio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Taller WHERE idservicio = @idservicio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idservicio", idServicio);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TallerDTO.NombreServicioTaller nombreServicio = Enum.Parse<TallerDTO.NombreServicioTaller>(reader["nombre"].ToString());
                    return new TallerDTO(nombreServicio, idServicio);
                }
                return null; // No se encontró el taller
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el taller", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los talleres
        public List<TallerDTO> ListarTalleres()
        {
            List<TallerDTO> listaTalleres = new List<TallerDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Taller";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TallerDTO.NombreServicioTaller nombreServicio = Enum.Parse<TallerDTO.NombreServicioTaller>(reader["nombre"].ToString());
                    int idServicio = Convert.ToInt32(reader["idservicio"]);
                    listaTalleres.Add(new TallerDTO(nombreServicio, idServicio));
                }
                return listaTalleres;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los talleres", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}