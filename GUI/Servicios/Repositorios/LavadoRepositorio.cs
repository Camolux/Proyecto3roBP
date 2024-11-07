using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Servicios;

namespace Repositorios
{
    public class LavadoRepositorio
    {
        private static LavadoRepositorio instance;
        private ConexionBD conexionBD;

        public static LavadoRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new LavadoRepositorio();
            }
            return instance;
        }

        private LavadoRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para buscar Lavado por IdServicio
        public LavadoDTO ObtenerLavadoPorIdServicio(int idServicio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Lavado WHERE idservicio = @idServicio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idServicio", idServicio);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new LavadoDTO
                    {
                        IdServicio = Convert.ToInt32(reader["idservicio"]),
                        TipoVehiculoLavado = (LavadoDTO.TipoVehiculo)Enum.Parse(typeof(LavadoDTO.TipoVehiculo), reader["tipovehiculo"].ToString().Replace(" ", "_"))
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el lavado", ex);
            }
            finally
            {
                connection.Close();
            }
        }



        // Método para listar Lavados por TipoVehiculo
        public List<LavadoDTO> ListarLavadosPorTipoVehiculo(LavadoDTO.TipoVehiculo tipoVehiculo)
        {
            List<LavadoDTO> listaLavados = new List<LavadoDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Lavado WHERE tipovehiculo = @tipoVehiculo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tipoVehiculo", tipoVehiculo.ToString().Replace("_", " "));

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaLavados.Add(new LavadoDTO
                    {
                        IdServicio = Convert.ToInt32(reader["idservicio"]),
                        TipoVehiculoLavado = (LavadoDTO.TipoVehiculo)Enum.Parse(typeof(LavadoDTO.TipoVehiculo), reader["tipovehiculo"].ToString().Replace(" ", "_"))
                    });
                }
                return listaLavados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar lavados por tipo de vehículo", ex);
            }
            finally
            {
                connection.Close();
            }
        }



        public bool ActualizarPrecioLavado(int idServicio, int nuevoPrecio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Lavado SET precio = @nuevoPrecio WHERE idservicio = @idServicio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                cmd.Parameters.AddWithValue("@idServicio", idServicio);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el precio del servicio de lavado", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        }
}