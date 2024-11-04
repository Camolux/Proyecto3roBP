using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
            // Validaciones
            if (cliente == null)
            {
                MessageBox.Show("El cliente no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.CI))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
                return false;
            }

            // Validar que el CI tenga un formato válido (por ejemplo, longitud específica)
            if (cliente.CI.Length != 8)
            {
                MessageBox.Show("La cédula de identidad debe tener 8 dígitos.");
                return false;
            }
            if ( ! Regex.IsMatch(cliente.CI, @"^\d+$"))
            {
                MessageBox.Show("La CI no puede contener letras");
                return false;
            }
            // Validar que el cliente no exista ya
            ClienteDTO existente = clienteRepositorio.ObtenerClientePorCI(cliente.CI);
            if (existente != null)
            {
                MessageBox.Show("Ya existe un cliente con esa cédula de identidad.");
                return false;
            }

            // Llamar al repositorio para agregar el cliente
            return clienteRepositorio.AgregarCliente(cliente);
        }

        // Método para modificar un cliente
        public bool ModificarCliente(ClienteDTO cliente)
        {
            // Validaciones
            if (cliente == null)
            {
                MessageBox.Show("El cliente no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.CI))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
                return false;
            }

            // Validar que el CI tenga un formato válido
            if (cliente.CI.Length != 8)
            {
                MessageBox.Show("La cédula de identidad debe tener 8 dígitos.");
                return false;
            }
            if (!Regex.IsMatch(cliente.CI, @"^\d+$"))
            {
                MessageBox.Show("La CI no puede contener letras");
                return false;
            }
            // Validar que el cliente exista
            ClienteDTO existente = clienteRepositorio.ObtenerClientePorCI(cliente.CI);
            if (existente == null)
            {
                MessageBox.Show("No existe un cliente con esa cédula de identidad.");
                return false;
            }

            // Llamar al repositorio para modificar el cliente
            return clienteRepositorio.ModificarCliente(cliente);
        }

        // Método para obtener un cliente por CI
        public ClienteDTO ObtenerClientePorCI(string ci)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(ci))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return null;
            }

            // Validar que el CI tenga un formato válido
            if (ci.Length != 8)
            {
                MessageBox.Show("La cédula de identidad debe tener 8 dígitos.");
                return null;
            }
            if (!Regex.IsMatch(ci, @"^\d+$"))
            {
                MessageBox.Show("La CI no puede contener letras");
                return null;
            }
            // Llamar al repositorio para obtener el cliente
            ClienteDTO cliente = clienteRepositorio.ObtenerClientePorCI(ci);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró el cliente con la cédula de identidad proporcionada.");
            }

            return cliente;
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
                MessageBox.Show("Error al listar los clientes: " + ex.Message);
                return new List<ClienteDTO>();
            }
        }
    }
}
