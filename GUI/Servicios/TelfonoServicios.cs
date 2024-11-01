using Cliente;
using GUI.Servicios.Repositorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Servicios
{
    public class TelefonoServicios
    {
        private static TelefonoServicios instance;
        private TelefonoRepositorio telefonoRepositorio;

        public static TelefonoServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new TelefonoServicios();
            }
            return instance;
        }

        private TelefonoServicios()
        {
            telefonoRepositorio = TelefonoRepositorio.GetInstance();
        }

        // Método para agregar un teléfono
        public bool AgregarTelefono(TelefonoDTO telefono)
        {
            // Validaciones
            if (telefono == null)
            {
                MessageBox.Show("El teléfono no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono.CI))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return false;
            }

            if (telefono.Telefono < 10000000 || telefono.Telefono > 999999999)
            {
                MessageBox.Show("El número de teléfono debe tener 9 dígitos.");
                return false;
            }

            // Validar que el teléfono no exista ya para el cliente
            TelefonoDTO existente = telefonoRepositorio.ObtenerTelefonoPorCIyNumero(telefono.CI, telefono.Telefono);
            if (existente != null)
            {
                MessageBox.Show("Ya existe un teléfono con ese número para el cliente.");
                return false;
            }

            // Llamar al repositorio para agregar el teléfono
            return telefonoRepositorio.AgregarTelefono(telefono);
        }

        // Método para modificar un teléfono
        public bool ModificarTelefono(TelefonoDTO telefono)
        {
            // Validaciones
            if (telefono == null)
            {
                MessageBox.Show("El teléfono no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono.CI))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return false;
            }

            if (telefono.Telefono < 10000000 || telefono.Telefono > 999999999)
            {
                MessageBox.Show("El número de teléfono debe tener 9 dígitos.");
                return false;
            }

            // Llamar al repositorio para modificar el teléfono
            return telefonoRepositorio.ModificarTelefono(telefono);
        }

        // Método para obtener un teléfono por CI y número
        public TelefonoDTO ObtenerTelefonoPorCIyNumero(string ci, int telefono)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(ci))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return null;
            }

            if (telefono < 10000000 || telefono > 999999999)
            {
                MessageBox.Show("El número de teléfono debe tener 9 dígitos.");
                return null;
            }

            // Llamar al repositorio para obtener el teléfono
            return telefonoRepositorio.ObtenerTelefonoPorCIyNumero(ci, telefono);
        }

        // Método para listar todos los teléfonos de un cliente
        public List<TelefonoDTO> ListarTelefonosPorCI(string ci)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(ci))
            {
                MessageBox.Show("La cédula de identidad no puede estar vacía.");
                return new List<TelefonoDTO>();
            }

            // Llamar al repositorio para listar los teléfonos
            return telefonoRepositorio.ListarTelefonosPorCI(ci);
        }
    }
}
