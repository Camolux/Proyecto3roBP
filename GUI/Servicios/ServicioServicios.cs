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
            if (nuevoPrecio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor positivo.");
                return false;
            }

            return servicioRepositorio.ActualizarPrecioServicio(idServicio, nuevoPrecio);
        }
    }
}
