using System;
using System.Collections.Generic;
using Servicios;
using Repositorios;

namespace Servicios
{
    public class TallerServicios
    {
        private static TallerServicios instance;
        private TallerRepositorio tallerRepositorio;

        public static TallerServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new TallerServicios();
            }
            return instance;
        }

        private TallerServicios()
        {
            tallerRepositorio = TallerRepositorio.GetInstance();
        }

        // Método para obtener un taller por ID de servicio
        public TallerDTO ObtenerTallerPorId(int idServicio)
        {
            try
            {
                if (idServicio <= 0)
                    throw new ArgumentException("El ID de servicio debe ser un número positivo.");

                TallerDTO taller = tallerRepositorio.ObtenerTallerPorId(idServicio);

                if (taller == null)
                    throw new Exception("No se encontró el taller con el ID de servicio proporcionado.");

                return taller;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el taller: " + ex.Message, ex);
            }
        }

        // Método para listar todos los talleres
        public List<TallerDTO> ListarTalleres()
        {
            try
            {
                return tallerRepositorio.ListarTalleres();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los talleres: " + ex.Message, ex);
            }
        }
    }
}