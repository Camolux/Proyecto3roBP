using System;
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
            try
            {
                if (idServicio <= 0)
                {
                    throw new ArgumentException("El ID del servicio debe ser un número positivo.");
                }

                ServicioDTO servicio = servicioRepositorio.ObtenerServicioPorId(idServicio);

                if (servicio == null)
                {
                    throw new Exception("El servicio con el ID proporcionado no existe.");
                }

                return servicio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el servicio: " + ex.Message, ex);
            }
        }
        public int ObtenerPrecioPorId(int idServicio)
        {
            try
            {
                // Validación del ID
                if (idServicio <= 0)
                {
                    throw new ArgumentException("El ID del servicio debe ser un número positivo.");
                }

                int? precio = servicioRepositorio.ObtenerPrecioPorId(idServicio);

                if (precio == null)
                {
                    throw new Exception("El servicio con el ID proporcionado no existe.");
                }

                return precio.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio del servicio: " + ex.Message, ex);
            }
        }
    }
}