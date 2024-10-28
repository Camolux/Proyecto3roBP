using Cliente;
using MySql.Data.MySqlClient;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Servicios.Repositorios
{
    public class TelefonoRepositorio
    {
        private static TelefonoRepositorio instance;
        private ConexionBD conexionBD;

        public static TelefonoRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new TelefonoRepositorio();
            }
            return instance;
        }

        private TelefonoRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar un teléfono
        public bool AgregarTelefono(TelefonoDTO telefono)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Telefono (telefono, ci) VALUES (@telefono, @ci)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@telefono", telefono.Telefono);
                cmd.Parameters.AddWithValue("@ci", telefono.CI);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el teléfono", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar un teléfono
        public bool ModificarTelefono(TelefonoDTO telefono)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Telefono SET telefono = @telefono WHERE ci = @ci AND telefono = @telefono";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@telefono", telefono.Telefono);
                cmd.Parameters.AddWithValue("@ci", telefono.CI);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el teléfono", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener un teléfono específico por CI y teléfono
        public TelefonoDTO ObtenerTelefonoPorCIyNumero(string ci, int telefono)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Telefono WHERE ci = @ci AND telefono = @telefono";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ci", ci);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new TelefonoDTO
                    {
                        CI = reader["ci"].ToString(),
                        Telefono = Convert.ToInt32(reader["telefono"])
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el teléfono", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los teléfonos de un cliente
        public List<TelefonoDTO> ListarTelefonosPorCI(string ci)
        {
            List<TelefonoDTO> listaTelefonos = new List<TelefonoDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Telefono WHERE ci = @ci";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ci", ci);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaTelefonos.Add(new TelefonoDTO
                    {
                        CI = reader["ci"].ToString(),
                        Telefono = Convert.ToInt32(reader["telefono"])
                    });
                }
                return listaTelefonos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los teléfonos", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
