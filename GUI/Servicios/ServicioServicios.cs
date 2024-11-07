using System;
using System.Windows.Forms;
using Servicios;
using Repositorios;

namespace Servicios
{
    public class ServiciosServicios
    {
        private static ServiciosServicios instance;
        private ServicioRepositorio servicioRepositorio;

        public static ServiciosServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiciosServicios();
            }
            return instance;
        }

        private ServiciosServicios()
        {
            servicioRepositorio = ServicioRepositorio.GetInstance();
        }

        // Método para obtener un servicio por su Id
        public ServicioDTO ObtenerServicioPorId(int idServicio)
        {
            // Validación del ID
            if (idServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser un número positivo.");
                return null;
            }

            // Obtener el servicio desde el repositorio
            ServicioDTO servicio = servicioRepositorio.ObtenerServicioPorId(idServicio);

            if (servicio == null)
            {
                MessageBox.Show("El servicio con el ID proporcionado no existe.");
                return null;
            }

            return servicio;
        }

        // Método para obtener el precio del servicio por su Id
        public int? ObtenerPrecioPorId(int idServicio)
        {
            // Validación del ID
            if (idServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser un número positivo.");
                return null;
            }

            // Obtener el precio del servicio desde el repositorio
            int? precio = servicioRepositorio.ObtenerPrecioPorId(idServicio);

            if (precio == null)
            {
                MessageBox.Show("El servicio con el ID proporcionado no existe.");
                return null;
            }

            return precio;
        }
        public bool ActualizarPrecioServicio(int idServicio, int nuevoPrecio)
        {
            // Validación del precio
            if (nuevoPrecio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor positivo.");
                return false;
            }

            // Validaciones del ID de servicio
            if (idServicio >= 1 && idServicio <= 5)
            {
                // Es un servicio de lavado
                MessageBox.Show("Actualizando precio del servicio de lavado.");
            }
            else if (idServicio >= 6 && idServicio <= 12)
            {
                // Es un servicio de taller
                MessageBox.Show("Actualizando precio del servicio de taller.");
            }
            else
            {
                MessageBox.Show("El ID de servicio no es válido. Debe estar entre 1-5 para lavado o 6-12 para taller.");
                return false;
            }

            // Realizar la actualización en la base de datos a través del repositorio
            return servicioRepositorio.ActualizarPrecioServicio(idServicio, nuevoPrecio);
        }
    }
}
