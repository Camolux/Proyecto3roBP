using Cliente;
using GUI.Servicios.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                if (telefono == null)
                    throw new ArgumentNullException("El teléfono no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(telefono.CI))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                if (telefono.Telefono < 10000000 || telefono.Telefono > 999999999)
                    throw new ArgumentException("El número de teléfono debe tener 9 dígitos.");

                // Validar que el teléfono no exista ya para el cliente
                TelefonoDTO existente = telefonoRepositorio.ObtenerTelefonoPorCIyNumero(telefono.CI, telefono.Telefono);
                if (existente != null)
                    throw new Exception("Ya existe un teléfono con ese número para el cliente.");

                return telefonoRepositorio.AgregarTelefono(telefono);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el teléfono: " + ex.Message, ex);
            }
        }

        // Método para modificar un teléfono
        public bool ModificarTelefono(TelefonoDTO telefono)
        {
            try
            {
                if (telefono == null)
                    throw new ArgumentNullException("El teléfono no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(telefono.CI))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                if (telefono.Telefono < 10000000 || telefono.Telefono > 999999999)
                    throw new ArgumentException("El número de teléfono debe tener 9 dígitos.");

                

                return telefonoRepositorio.ModificarTelefono(telefono);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el teléfono: " + ex.Message, ex);
            }
        }

        // Método para obtener un teléfono por CI y número
        public TelefonoDTO ObtenerTelefonoPorCIyNumero(string ci, int telefono)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ci))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                if (telefono < 10000000 || telefono > 999999999)
                    throw new ArgumentException("El número de teléfono debe tener 9 dígitos.");

                return telefonoRepositorio.ObtenerTelefonoPorCIyNumero(ci, telefono);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el teléfono: " + ex.Message, ex);
            }
        }

        // Método para listar todos los teléfonos de un cliente
        public List<TelefonoDTO> ListarTelefonosPorCI(string ci)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ci))
                    throw new ArgumentException("La cédula de identidad no puede estar vacía.");

                return telefonoRepositorio.ListarTelefonosPorCI(ci);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los teléfonos: " + ex.Message, ex);
            }
        }
    }
}
