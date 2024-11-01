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
        public string ObtenerTipoClientePorMatriculaEnParking(string matricula)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                // Consulta para obtener el tipo de cliente a partir de la matrícula en Parking
                string query = @"
            SELECT v.tipocliente 
            FROM Vehiculo v
            INNER JOIN Parking p ON v.matricula = p.matricula
            WHERE p.matricula = @matricula";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", matricula);

                connection.Open();
                object result = cmd.ExecuteScalar();

                // Verificar si se obtuvo un resultado y retornarlo como string
                return result != null ? result.ToString() : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el tipo de cliente por matrícula en Parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ActualizarPrecioParking(int idParking, int nuevoPrecio)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Parking SET precio = @nuevoPrecio WHERE idparking = @idParking";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                cmd.Parameters.AddWithValue("@idParking", idParking);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el precio de parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public bool CambiarParaEntregar(int idParking)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                // Consulta que cambia 'ParaEntregar' a 'sí' solo si está en 'no'
                string query = @"
                    UPDATE Parking 
                    SET paraentregar = 'sí' 
                    WHERE idparking = @idParking AND paraentregar = 'no';

                    SELECT CASE WHEN ROW_COUNT() > 0 THEN 1 ELSE 0 END;";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idParking", idParking);

                connection.Open();
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                return resultado == 1; // Retorna true si la actualización fue exitosa
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar el estado de 'ParaEntregar'", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public ParkingDTO ObtenerParkingPorMatriculaYFecha(string matricula, DateTime fechaEntrada)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Parking WHERE matricula = @matricula AND DATE(fechaentrada) = DATE(@fechaEntrada)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new ParkingDTO
                    {
                        IdParking = Convert.ToInt32(reader["idparking"]),
                        Precio = Convert.ToInt32(reader["precio"]),
                        FechaEntrada = Convert.ToDateTime(reader["fechaentrada"]),
                        FechaSalida = Convert.ToDateTime(reader["fechasalida"]),
                        ParaEntregarEstado = (ParkingDTO.ParaEntregar)Enum.Parse(typeof(ParkingDTO.ParaEntregar), reader["paraentregar"].ToString()),
                        NumPlaza = Convert.ToInt32(reader["numplaza"]),
                        Funcionario = reader["funcionario"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de Parking", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}