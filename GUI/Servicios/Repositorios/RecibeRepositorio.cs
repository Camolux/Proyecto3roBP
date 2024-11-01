using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Servicios;

namespace Repositorios
{
    public class RecibeRepositorio
    {
        private static RecibeRepositorio instance;
        private ConexionBD conexionBD;

        public static RecibeRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new RecibeRepositorio();
            }
            return instance;
        }

        private RecibeRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar una nueva entrada en Recibe
        public bool AgregarRecibe(RecibeDTO recibe)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Recibe (fechaservicio, idservicio, matricula, funcionario) VALUES (@fechaServicio, @idServicio, @matricula, @funcionario)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaServicio", recibe.FechaServicio);
                cmd.Parameters.AddWithValue("@idServicio", recibe.IdServicio);
                cmd.Parameters.AddWithValue("@matricula", recibe.Matricula);
                cmd.Parameters.AddWithValue("@funcionario", recibe.Funcionario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro de servicio", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar una entrada en Recibe
        public bool ModificarRecibe(RecibeDTO recibe)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Recibe SET funcionario = @funcionario WHERE fechaservicio = @fechaServicio AND idservicio = @idServicio AND matricula = @matricula";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaServicio", recibe.FechaServicio);
                cmd.Parameters.AddWithValue("@idServicio", recibe.IdServicio);
                cmd.Parameters.AddWithValue("@matricula", recibe.Matricula);
                cmd.Parameters.AddWithValue("@funcionario", recibe.Funcionario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el registro de servicio", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener una entrada en Recibe por IdServicio
        public RecibeDTO ObtenerRecibePorIdServicio(int idServicio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Recibe WHERE idservicio = @idServicio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idServicio", idServicio);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new RecibeDTO
                    {
                        FechaServicio = Convert.ToDateTime(reader["fechaservicio"]),
                        IdServicio = Convert.ToInt32(reader["idservicio"]),
                        Matricula = reader["matricula"].ToString(),
                        Funcionario = reader["funcionario"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de servicio", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todas las entradas en Recibe
        public List<RecibeDTO> ListarRecibe()
        {
            List<RecibeDTO> listaRecibe = new List<RecibeDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Recibe";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaRecibe.Add(new RecibeDTO
                    {
                        FechaServicio = Convert.ToDateTime(reader["fechaservicio"]),
                        IdServicio = Convert.ToInt32(reader["idservicio"]),
                        Matricula = reader["matricula"].ToString(),
                        Funcionario = reader["funcionario"].ToString()
                    });
                }
                return listaRecibe;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los registros de servicio", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public RecibeDTO ObtenerRecibePorMatriculaYFecha(string matricula, DateTime fechaServicio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Recibe WHERE matricula = @matricula AND DATE(fechaservicio) = DATE(@fechaServicio)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@fechaServicio", fechaServicio);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new RecibeDTO
                    {
                        FechaServicio = Convert.ToDateTime(reader["fechaservicio"]),
                        IdServicio = Convert.ToInt32(reader["idservicio"]),
                        Matricula = reader["matricula"].ToString(),
                        Funcionario = reader["funcionario"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de Recibe", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}