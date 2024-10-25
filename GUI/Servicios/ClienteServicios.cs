using System;
using System.Collections.Generic;
using Cliente;
using Repositorios;

namespace Servicios
{
    public class ClienteServicios
    {
        private static ClienteServicios instance;

        private ClienteRepositorio clienteRepositorio;

        public static ClienteServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new ClienteServicios();
            }
            return instance;
        }

        private ClienteServicios()
        {
            clienteRepositorio = ClienteRepositorio.GetInstance();
        }

        // Método para agregar un cliente
        public bool AgregarCliente(ClienteDTO cliente)
        {
            try
            {
                // Validaciones
                if (cliente == null)
                    throw new ArgumentNullException("El cliente no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(cliente.CI))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(cliente.Apellido))
                    throw new ArgumentException("El apellido no puede estar vacío.");

                // Validar que el CI tenga un formato válido (por ejemplo, longitud específica)
                if (cliente.CI.Length != 8)
                    throw new ArgumentException("La cédula de identidad debe tener 8 dígitos.");

                // Validar que el cliente no exista ya
                ClienteDTO existente = clienteRepositorio.ObtenerClientePorCI(cliente.CI);
                if (existente != null)
                    throw new Exception("Ya existe un cliente con esa cédula de identidad.");

                // Llamar al repositorio para agregar el cliente
                return clienteRepositorio.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message, ex);
            }
        }

        // Método para modificar un cliente
        public bool ModificarCliente(ClienteDTO cliente)
        {
            try
            {
                // Validaciones
                if (cliente == null)
                    throw new ArgumentNullException("El cliente no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(cliente.CI))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(cliente.Apellido))
                    throw new ArgumentException("El apellido no puede estar vacío.");

                // Validar que el CI tenga un formato válido
                if (cliente.CI.Length != 8)
                    throw new ArgumentException("La cédula de identidad debe tener 8 dígitos.");

                // Validar que el cliente exista
                ClienteDTO existente = clienteRepositorio.ObtenerClientePorCI(cliente.CI);
                if (existente == null)
                    throw new Exception("No existe un cliente con esa cédula de identidad.");

                // Llamar al repositorio para modificar el cliente
                return clienteRepositorio.ModificarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente: " + ex.Message, ex);
            }
        }

        // Método para obtener un cliente por CI
        public ClienteDTO ObtenerClientePorCI(string ci)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(ci))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                // Validar que el CI tenga un formato válido
                if (ci.Length != 8)
                    throw new ArgumentException("La cédula de identidad debe tener 8 dígitos.");

                // Llamar al repositorio para obtener el cliente
                return clienteRepositorio.ObtenerClientePorCI(ci);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente: " + ex.Message, ex);
            }
        }

        // Método para listar todos los clientes
        public List<ClienteDTO> ListarClientes()
        {
            try
            {
                return clienteRepositorio.ListarClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes: " + ex.Message, ex);
            }
        }
        
    }
}
