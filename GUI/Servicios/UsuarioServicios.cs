using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar el usuario");
                return null;
            }
        }
        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío.");
                if (string.IsNullOrWhiteSpace(usuario.contraUsuario))
                    throw new ArgumentException("La contraseña no puede estar vacía.");
                if (string.IsNullOrWhiteSpace(usuario.idTipoUsuario))
                    throw new ArgumentException("El tipo de usuario no puede estar vacío.");

                // Puedes agregar más validaciones según tus reglas de negocio
                // Por ejemplo, validar que el nombre de usuario no exista ya en la base de datos
                if (usuarioRepositorio.VerificarUsuarioExistente(usuario.nombreUsuario))
                    throw new ArgumentException("El nombre de usuario ya existe.");

                // Llamada al repositorio para agregar el usuario
                return usuarioRepositorio.AgregarUsuario(usuario);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                // Puedes registrar el error y/o propagar la excepción
                throw new Exception("Error al agregar el usuario: " + ex.Message, ex);
            }
        }
        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío.");
                if (string.IsNullOrWhiteSpace(usuario.contraUsuario))
                    throw new ArgumentException("La contraseña no puede estar vacía.");
                if (string.IsNullOrWhiteSpace(usuario.idTipoUsuario))
                    throw new ArgumentException("El tipo de usuario no puede estar vacío.");

                // Validar que el usuario exista antes de modificarlo
                if (!usuarioRepositorio.VerificarUsuarioExistente(usuario.nombreUsuario))
                    throw new ArgumentException("El usuario no existe.");

                // Llamada al repositorio para modificar el usuario
                return usuarioRepositorio.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al modificar el usuario: " + ex.Message, ex);
            }
        }
        public bool EliminarUsuario(string nombreUsuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío.");

                // Validar que el usuario exista antes de eliminarlo
                if (!usuarioRepositorio.VerificarUsuarioExistente(nombreUsuario))
                    throw new ArgumentException("El usuario no existe.");

                // Llamada al repositorio para eliminar el usuario
                return usuarioRepositorio.EliminarUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al eliminar el usuario: " + ex.Message, ex);
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(nombreUsuario))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío.");

                return usuarioRepositorio.ObtenerUsuarioPorNombre(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario: " + ex.Message, ex);
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
                throw new Exception("Error al listar los usuarios: " + ex.Message, ex);
            }
        }

    }
}
