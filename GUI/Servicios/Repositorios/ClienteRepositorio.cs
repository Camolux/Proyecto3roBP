using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;
using MySql.Data.MySqlClient;


namespace Repositorios
{
    public class ClienteRepositorio
    {
        public static ClienteRepositorio instance;

        private ConexionBD conexionBD;

        public static ClienteRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new ClienteRepositorio();
            }
            return instance;
        }



        private ClienteRepositorio() {

            conexionBD = ConexionBD.GetInstance();


        }

        public bool AgregarCliente(ClienteDTO cliente)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Cliente (ci, nombre, apellido) VALUES (@ci, @nombre, @apellido)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ci", cliente.CI);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si se insertó al menos una fila
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (por ejemplo, clave primaria duplicada)
                throw new Exception("Error al agregar el cliente", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para modificar un cliente
        public bool ModificarCliente(ClienteDTO cliente)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido WHERE ci = @ci";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ci", cliente.CI);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si se actualizó al menos una fila
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener un cliente por su CI
        public ClienteDTO ObtenerClientePorCI(string ci)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Cliente WHERE ci = @ci";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ci", ci);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ClienteDTO cliente = new ClienteDTO
                    {
                        CI = reader["ci"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString()
                    };
                    return cliente;
                }
                else
                {
                    return null; // No se encontró el cliente
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar todos los clientes
        public List<ClienteDTO> ListarClientes()
        {
            List<ClienteDTO> listaClientes = new List<ClienteDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Cliente";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClienteDTO cliente = new ClienteDTO
                    {
                        CI = reader["ci"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString()
                    };
                    listaClientes.Add(cliente);
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes", ex);
            }
            finally
            {
                connection.Close();
            }
        }



    }
}
