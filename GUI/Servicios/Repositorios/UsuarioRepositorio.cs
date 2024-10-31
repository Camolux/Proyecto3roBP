using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDTO;
using MySql.Data.MySqlClient;
using UsuarioDTO;

namespace Repositorios
{
    public class UsuarioRepositorio
    {
        public static UsuarioRepositorio instance;

        private ConexionBD conexionBD;
        public static UsuarioRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioRepositorio();
            }
            return instance;
        }

        private UsuarioRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        public bool VerificarUsuario(string username, string password)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Funcionario WHERE username = @username AND contrasenia = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                MySqlDataReader result = cmd.ExecuteReader();
                bool exists = result.HasRows;
                return exists;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public Usuario ObtenerUsuario(string username, string password)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Funcionario WHERE username = @username AND contrasenia = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                MySqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        nombreUsuario = result["username"].ToString(),
                        contraUsuario = result["contrasenia"].ToString(),
                        idTipoUsuario = result["rol"].ToString()
                    };
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public bool AgregarUsuario(Usuario usuario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "INSERT INTO Funcionario (username, contrasenia, rol) VALUES (@username, @password, @rol)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@password", usuario.contraUsuario);
                cmd.Parameters.AddWithValue("@rol", usuario.idTipoUsuario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si al menos una fila fue afectada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (por ejemplo, clave primaria duplicada)
                throw new Exception("Error al agregar el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Nuevo método para modificar un usuario
        public bool ModificarUsuario(Usuario usuario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "UPDATE Funcionario SET contrasenia = @password, rol = @rol WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@password", usuario.contraUsuario);
                cmd.Parameters.AddWithValue("@rol", usuario.idTipoUsuario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si al menos una fila fue afectada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al modificar el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Nuevo método para eliminar un usuario
        public bool EliminarUsuario(string nombreUsuario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "DELETE FROM Funcionario WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", nombreUsuario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si al menos una fila fue afectada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al eliminar el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public bool VerificarUsuarioExistente(string nombreUsuario)
        {
            nombreUsuario = nombreUsuario.Trim(); // Elimina espacios en blanco
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT COUNT(*) FROM Funcionario WHERE LOWER(username) = LOWER(@username)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", nombreUsuario);

                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine($"Usuario encontrado: {count > 0}");

                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar si el usuario existe", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT username, rol FROM Funcionario WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", nombreUsuario);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        nombreUsuario = reader["username"].ToString(),
                        idTipoUsuario = reader["rol"].ToString()
                    };
                    return usuario;
                }
                else
                {
                    return null; // No se encontró el usuario
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        // Método para listar todos los usuarios
        public List<Usuario> ListarTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT username, rol FROM Funcionario";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        nombreUsuario = reader["username"].ToString(),
                        idTipoUsuario = reader["rol"].ToString()
                        // No incluimos la contraseña por razones de seguridad
                    };
                    listaUsuarios.Add(usuario);
                }
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar todos los usuarios", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ModificarUsuarioJefe(Usuario usuario)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                // Verificar si el usuario no tiene rol de "jefe" o "gerente"
                string verificarRolQuery = "SELECT rol FROM Funcionario WHERE username = @username";
                MySqlCommand verificarCmd = new MySqlCommand(verificarRolQuery, connection);
                verificarCmd.Parameters.AddWithValue("@username", usuario.nombreUsuario);

                connection.Open();
                string rol = verificarCmd.ExecuteScalar()?.ToString();
                connection.Close();

                if (rol == "jefe" || rol == "gerente")
                {
                    // Si el usuario es "jefe" o "gerente", no se permite la modificación
                    throw new Exception("No se permite modificar usuarios con rol de 'jefe' o 'gerente'.");
                }

                // Proceder con la modificación si el rol es diferente de "jefe" o "gerente"
                string query = "UPDATE Funcionario SET contrasenia = @password, rol = @rol WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@password", usuario.contraUsuario);
                cmd.Parameters.AddWithValue("@rol", usuario.idTipoUsuario);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0; // Devuelve true si al menos una fila fue afectada
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al modificar el usuario", ex);
            }
            finally
            {
                connection.Close();
            }
        }



    }

}

