using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Neumatico;

namespace Repositorios
{
    public class NeumaticoRepositorio
    {
        private static NeumaticoRepositorio instance;
        private ConexionBD conexionBD;

        public static NeumaticoRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new NeumaticoRepositorio();
            }
            return instance;
        }

        private NeumaticoRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para obtener un neumático por su ID
        public NeumaticoDTO ObtenerNeumaticoPorId(int idNeumatico)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Neumatico WHERE idneumatico = @idNeumatico";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idNeumatico", idNeumatico);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new NeumaticoDTO
                    {
                        IdNeumatico = Convert.ToInt32(reader["idneumatico"]),
                        Precio = Convert.ToInt32(reader["precio"]),
                        Marca = Enum.Parse<NeumaticoDTO.MarcaNeumatico>(reader["marca"].ToString()),
                        Descripcion = reader["descripcion"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el neumático", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los neumáticos
        public List<NeumaticoDTO> ListarNeumaticos()
        {
            List<NeumaticoDTO> listaNeumaticos = new List<NeumaticoDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Neumatico";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaNeumaticos.Add(new NeumaticoDTO
                    {
                        IdNeumatico = Convert.ToInt32(reader["idneumatico"]),
                        Precio = Convert.ToInt32(reader["precio"]),
                        Marca = Enum.Parse<NeumaticoDTO.MarcaNeumatico>(reader["marca"].ToString()),
                        Descripcion = reader["descripcion"].ToString()
                    });
                }
                return listaNeumaticos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los neumáticos", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public int? ObtenerPrecioPorId(int idNeumatico)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT precio FROM Neumatico WHERE idneumatico = @idNeumatico";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idNeumatico", idNeumatico);

                connection.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : (int?)null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio del neumático", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ActualizarPrecioNeumatico(int idNeumatico, int nuevoPrecio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Neumatico SET precio = @nuevoPrecio WHERE idneumatico = @idNeumatico";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                cmd.Parameters.AddWithValue("@idNeumatico", idNeumatico);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el precio del neumático", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}