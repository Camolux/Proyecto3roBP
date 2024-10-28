using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Parking;

namespace Repositorios
{
    public class OcupaRepositorio
    {
        private static OcupaRepositorio instance;
        private ConexionBD conexionBD;

        public static OcupaRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new OcupaRepositorio();
            }
            return instance;
        }

        private OcupaRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar una nueva ocupación
        public bool AgregarOcupa(OcupaDTO ocupa)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Ocupa (fechasalida, fechaentrada, matricula, numplaza) VALUES (@fechaSalida, @fechaEntrada, @matricula, @numPlaza)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaSalida", ocupa.FechaSalida);
                cmd.Parameters.AddWithValue("@fechaEntrada", ocupa.FechaEntrada);
                cmd.Parameters.AddWithValue("@matricula", ocupa.Matricula);
                cmd.Parameters.AddWithValue("@numPlaza", ocupa.NumPlaza);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la ocupación", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar una ocupación existente
        public bool ModificarOcupa(OcupaDTO ocupa)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Ocupa SET fechasalida = @fechaSalida, fechaentrada = @fechaEntrada WHERE matricula = @matricula AND numplaza = @numPlaza";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaSalida", ocupa.FechaSalida);
                cmd.Parameters.AddWithValue("@fechaEntrada", ocupa.FechaEntrada);
                cmd.Parameters.AddWithValue("@matricula", ocupa.Matricula);
                cmd.Parameters.AddWithValue("@numPlaza", ocupa.NumPlaza);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la ocupación", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener una ocupación específica
        public OcupaDTO ObtenerOcupa(string matricula, int numPlaza)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Ocupa WHERE matricula = @matricula AND numplaza = @numPlaza";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@numPlaza", numPlaza);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new OcupaDTO
                    {
                        FechaSalida = Convert.ToDateTime(reader["fechasalida"]),
                        FechaEntrada = Convert.ToDateTime(reader["fechaentrada"]),
                        Matricula = reader["matricula"].ToString(),
                        NumPlaza = Convert.ToInt32(reader["numplaza"])
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la ocupación", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todas las ocupaciones
        public List<OcupaDTO> ListarOcupaciones()
        {
            List<OcupaDTO> listaOcupaciones = new List<OcupaDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Ocupa";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaOcupaciones.Add(new OcupaDTO
                    {
                        FechaSalida = Convert.ToDateTime(reader["fechasalida"]),
                        FechaEntrada = Convert.ToDateTime(reader["fechaentrada"]),
                        Matricula = reader["matricula"].ToString(),
                        NumPlaza = Convert.ToInt32(reader["numplaza"])
                    });
                }
                return listaOcupaciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las ocupaciones", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}