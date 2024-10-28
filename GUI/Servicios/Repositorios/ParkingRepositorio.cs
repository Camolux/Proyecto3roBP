using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Parking;

namespace Repositorios
{
    public class ParkingRepositorio
    {
        private static ParkingRepositorio instance;
        private ConexionBD conexionBD;

        public static ParkingRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new ParkingRepositorio();
            }
            return instance;
        }

        private ParkingRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar un nuevo registro de parking
        public bool AgregarParking(ParkingDTO parking)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Parking (precio, paraentregar, fechasalida, fechaentrada, matricula, numplaza, funcionario) " +
                               "VALUES (@precio, @paraEntregar, @fechaSalida, @fechaEntrada, @matricula, @numPlaza, @funcionario)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@precio", parking.Precio);
                cmd.Parameters.AddWithValue("@paraEntregar", parking.ParaEntregarEstado.ToString());
                cmd.Parameters.AddWithValue("@fechaSalida", parking.FechaSalida);
                cmd.Parameters.AddWithValue("@fechaEntrada", parking.FechaEntrada);
                cmd.Parameters.AddWithValue("@matricula", parking.Matricula);
                cmd.Parameters.AddWithValue("@numPlaza", parking.NumPlaza);
                cmd.Parameters.AddWithValue("@funcionario", parking.Funcionario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro de parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar un registro de parking existente
        public bool ModificarParking(ParkingDTO parking)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Parking SET precio = @precio, paraentregar = @paraEntregar, fechasalida = @fechaSalida, " +
                               "fechaentrada = @fechaEntrada, matricula = @matricula, numplaza = @numPlaza, funcionario = @funcionario " +
                               "WHERE idparking = @idParking";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idParking", parking.IdParking);
                cmd.Parameters.AddWithValue("@precio", parking.Precio);
                cmd.Parameters.AddWithValue("@paraEntregar", parking.ParaEntregarEstado.ToString());
                cmd.Parameters.AddWithValue("@fechaSalida", parking.FechaSalida);
                cmd.Parameters.AddWithValue("@fechaEntrada", parking.FechaEntrada);
                cmd.Parameters.AddWithValue("@matricula", parking.Matricula);
                cmd.Parameters.AddWithValue("@numPlaza", parking.NumPlaza);
                cmd.Parameters.AddWithValue("@funcionario", parking.Funcionario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el registro de parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener un registro de parking específico por ID
        public ParkingDTO ObtenerParkingPorId(int idParking)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Parking WHERE idparking = @idParking";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idParking", idParking);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new ParkingDTO
                    {
                        IdParking = Convert.ToInt32(reader["idparking"]),
                        Precio = Convert.ToInt32(reader["precio"]),
                        ParaEntregarEstado = (ParkingDTO.ParaEntregar)Enum.Parse(typeof(ParkingDTO.ParaEntregar), reader["paraentregar"].ToString()),
                        FechaSalida = Convert.ToDateTime(reader["fechasalida"]),
                        FechaEntrada = Convert.ToDateTime(reader["fechaentrada"]),
                        Matricula = reader["matricula"].ToString(),
                        NumPlaza = Convert.ToInt32(reader["numplaza"]),
                        Funcionario = reader["funcionario"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los registros de parking
        public List<ParkingDTO> ListarParking()
        {
            List<ParkingDTO> listaParking = new List<ParkingDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Parking";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaParking.Add(new ParkingDTO
                    {
                        IdParking = Convert.ToInt32(reader["idparking"]),
                        Precio = Convert.ToInt32(reader["precio"]),
                        ParaEntregarEstado = (ParkingDTO.ParaEntregar)Enum.Parse(typeof(ParkingDTO.ParaEntregar), reader["paraentregar"].ToString()),
                        FechaSalida = Convert.ToDateTime(reader["fechasalida"]),
                        FechaEntrada = Convert.ToDateTime(reader["fechaentrada"]),
                        Matricula = reader["matricula"].ToString(),
                        NumPlaza = Convert.ToInt32(reader["numplaza"]),
                        Funcionario = reader["funcionario"].ToString()
                    });
                }
                return listaParking;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los registros de parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}