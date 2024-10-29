using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Vehiculo;

namespace Repositorios
{
    public class VehiculoRepositorio
    {
        private static VehiculoRepositorio instance;
        private ConexionBD conexionBD;

        public static VehiculoRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new VehiculoRepositorio();
            }
            return instance;
        }

        private VehiculoRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar un vehículo
        public bool AgregarVehiculo(VehiculoDTO vehiculo)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = @"INSERT INTO Vehiculo (matricula, marca, modelo, tipo, tipoCliente, propietario)
                                 VALUES (@matricula, @marca, @modelo, @tipo, @tipoCliente, @propietario)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@tipo", vehiculo.Tipo.ToString());
                cmd.Parameters.AddWithValue("@tipoCliente", vehiculo.TIpoCliente.ToString());
                cmd.Parameters.AddWithValue("@propietario", vehiculo.Propietario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si se insertó al menos una fila
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar un vehículo
        public bool ModificarVehiculo(VehiculoDTO vehiculo)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = @"UPDATE Vehiculo SET marca = @marca, modelo = @modelo, tipo = @tipo,
                                 tipoCliente = @tipoCliente, propietario = @propietario WHERE matricula = @matricula";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                cmd.Parameters.AddWithValue("@marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@tipo", vehiculo.Tipo.ToString());
                cmd.Parameters.AddWithValue("@tipoCliente", vehiculo.TIpoCliente.ToString());
                cmd.Parameters.AddWithValue("@propietario", vehiculo.Propietario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si se actualizó al menos una fila
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el vehículo", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener un vehículo por matrícula
        public VehiculoDTO ObtenerVehiculoPorMatricula(string matricula)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Vehiculo WHERE matricula = @matricula";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", matricula);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    VehiculoDTO vehiculo = new VehiculoDTO
                    {
                        Matricula = reader["matricula"].ToString(),
                        Marca = reader["marca"].ToString(),
                        Modelo = reader["modelo"].ToString(),
                        Tipo = reader["tipo"].ToString(),
                        TIpoCliente = reader["tipoCliente"].ToString(),
                        Propietario = reader["propietario"].ToString()
                    };
                    return vehiculo;
                }
                else
                {
                    return null; // No se encontró el vehículo
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el vehículo", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los vehículos
        public List<VehiculoDTO> ListarVehiculos()
        {
            List<VehiculoDTO> listaVehiculos = new List<VehiculoDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Vehiculo";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VehiculoDTO vehiculo = new VehiculoDTO
                    {
                        Matricula = reader["matricula"].ToString(),
                        Marca = reader["marca"].ToString(),
                        Modelo = reader["modelo"].ToString(),
                        Tipo = reader["tipo"].ToString(),
                        TIpoCliente = reader["tipoCliente"].ToString(),
                        Propietario = reader["propietario"].ToString()
                    };
                    listaVehiculos.Add(vehiculo);
                }
                return listaVehiculos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los vehículos", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
