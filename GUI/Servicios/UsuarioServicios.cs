using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioDTO;
using Repositorios;

namespace Servicios
{
    public class UsuariosServicios
    {
        public static UsuariosServicios instance;

        private UsuarioRepositorio usuarioRepositorio;
        public static UsuariosServicios GetInsance()
        {
            if (instance == null)
            {
                instance = new UsuariosServicios();
            }
            return instance;
        }
        private UsuariosServicios()
        {
            usuarioRepositorio = UsuarioRepositorio.GetInstance();
        }

        public Usuario VerificarUsuario(string nombreUsuario, string contraUsuario)
        {
            try
            {
                if (usuarioRepositorio.VerificarUsuario(nombreUsuario, contraUsuario))
                {
                    return usuarioRepositorio.ObtenerUsuario(nombreUsuario, contraUsuario);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar el usuario: " + ex.Message);
                return null;
            }
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario no puede estar vacío.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.contraUsuario))
                {
                    MessageBox.Show("La contraseña no puede estar vacía.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.idTipoUsuario))
                {
                    MessageBox.Show("El tipo de usuario no puede estar vacío.");
                    return false;
                }

                // Validar que el nombre de usuario no exista ya en la base de datos
                if (usuarioRepositorio.VerificarUsuarioExistente(usuario.nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario ya existe.");
                    return false;
                }

                // Llamada al repositorio para agregar el usuario
                return usuarioRepositorio.AgregarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
                return false;
            }
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario no puede estar vacío.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.contraUsuario))
                {
                    MessageBox.Show("La contraseña no puede estar vacía.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.idTipoUsuario))
                {
                    MessageBox.Show("El tipo de usuario no puede estar vacío.");
                    return false;
                }

                // Verificar que el usuario no tenga rol de "gerente"
                var usuarioExistente = usuarioRepositorio.ObtenerUsuarioPorNombre(usuario.nombreUsuario);
                if (usuarioExistente == null)
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                if (usuarioExistente.idTipoUsuario == "gerente")
                {
                    MessageBox.Show("No se permite modificar usuarios con rol de 'gerente'.");
                    return false;
                }

                // Llamada al repositorio para modificar el usuario si no es gerente
                return usuarioRepositorio.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                return false;
            }
        }

        public bool EliminarUsuario(string nombreUsuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario no puede estar vacío.");
                    return false;
                }

                // Validar que el usuario exista antes de eliminarlo
                if (!usuarioRepositorio.VerificarUsuarioExistente(nombreUsuario))
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                // Llamada al repositorio para eliminar el usuario
                return usuarioRepositorio.EliminarUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                return false;
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario no puede estar vacío.");
                    return null;
                }

                return usuarioRepositorio.ObtenerUsuarioPorNombre(nombreUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el usuario: " + ex.Message);
                return null;
            }
        }

        // Método para listar todos los usuarios
        public List<Usuario> ListarTodosLosUsuarios()
        {
            try
            {
                return usuarioRepositorio.ListarTodosLosUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los usuarios: " + ex.Message);
                return new List<Usuario>();
            }
        }

        public bool ModificarUsuarioJefe(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario no puede estar vacío.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.contraUsuario))
                {
                    MessageBox.Show("La contraseña no puede estar vacía.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(usuario.idTipoUsuario))
                {
                    MessageBox.Show("El tipo de usuario no puede estar vacío.");
                    return false;
                }

                // Verificar que el usuario no tenga rol de "jefe" o "gerente"
                var usuarioExistente = usuarioRepositorio.ObtenerUsuarioPorNombre(usuario.nombreUsuario);
                if (usuarioExistente == null)
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                if (usuarioExistente.idTipoUsuario == "jefe" || usuarioExistente.idTipoUsuario == "gerente")
                {
                    MessageBox.Show("No se permite modificar usuarios con rol de 'jefe' o 'gerente'.");
                    return false;
                }

                // Llamada al repositorio para modificar el usuario si no es jefe o gerente
                return usuarioRepositorio.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}