using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GUI.Modelo.Neumatico;

namespace Repositorios
{
    public class CompraRepositorio
    {
        private static CompraRepositorio instance;
        private ConexionBD conexionBD;

        public static CompraRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new CompraRepositorio();
            }
            return instance;
        }

        private CompraRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para agregar una nueva compra
        public bool AgregarCompra(CompraDTO compra)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Compra (fechaventa, idneumatico, funcionario, cliente) VALUES (@fechaVenta, @idNeumatico, @funcionario, @cliente)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaVenta", compra.FechaVenta);
                cmd.Parameters.AddWithValue("@idNeumatico", compra.IdNeumatico);
                cmd.Parameters.AddWithValue("@funcionario", compra.Funcionario);
                cmd.Parameters.AddWithValue("@cliente", compra.Cliente);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la compra", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar una compra
        public bool ModificarCompra(CompraDTO compra)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Compra SET fechaventa = @fechaVenta, funcionario = @funcionario, cliente = @cliente WHERE idneumatico = @idNeumatico";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fechaVenta", compra.FechaVenta);
                cmd.Parameters.AddWithValue("@idNeumatico", compra.IdNeumatico);
                cmd.Parameters.AddWithValue("@funcionario", compra.Funcionario);
                cmd.Parameters.AddWithValue("@cliente", compra.Cliente);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la compra", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener una compra por ID de neumático y funcionario
        public CompraDTO ObtenerCompra(int idNeumatico, string funcionario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Compra WHERE idneumatico = @idNeumatico AND funcionario = @funcionario";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idNeumatico", idNeumatico);
                cmd.Parameters.AddWithValue("@funcionario", funcionario);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new CompraDTO
                    {
                        FechaVenta = Convert.ToDateTime(reader["fechaventa"]),
                        IdNeumatico = Convert.ToInt32(reader["idneumatico"]),
                        Funcionario = reader["funcionario"].ToString(),
                        Cliente = reader["cliente"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la compra", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todas las compras
        public List<CompraDTO> ListarCompras()
        {
            List<CompraDTO> listaCompras = new List<CompraDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Compra";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaCompras.Add(new CompraDTO
                    {
                        FechaVenta = Convert.ToDateTime(reader["fechaventa"]),
                        IdNeumatico = Convert.ToInt32(reader["idneumatico"]),
                        Funcionario = reader["funcionario"].ToString(),
                        Cliente = reader["cliente"].ToString()
                    });
                }
                return listaCompras;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las compras", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}