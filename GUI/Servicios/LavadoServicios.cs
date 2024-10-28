using System;
using System.Collections.Generic;
using Servicios;
using Repositorios;

namespace Servicios
{
    public class LavadoServicios
    {
        private static LavadoServicios instance;
        private LavadoRepositorio lavadoRepositorio;

        public static LavadoServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new LavadoServicios();
            }
            return instance;
        }

        private LavadoServicios()
        {
            lavadoRepositorio = LavadoRepositorio.GetInstance();
        }

        // Método para obtener un Lavado por IdServicio
        public LavadoDTO ObtenerLavadoPorIdServicio(int idServicio)
        {
            try
            {
                if (idServicio <= 0)
                    throw new ArgumentException("El ID del servicio debe ser un valor positivo.");

                return lavadoRepositorio.ObtenerLavadoPorIdServicio(idServicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el servicio de lavado: " + ex.Message, ex);
            }
        }

        // Método para listar Lavados por TipoVehiculo
        public List<LavadoDTO> ListarLavadosPorTipoVehiculo(LavadoDTO.TipoVehiculo tipoVehiculo)
        {
            try
            {
                return lavadoRepositorio.ListarLavadosPorTipoVehiculo(tipoVehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los servicios de lavado por tipo de vehículo: " + ex.Message, ex);
            }
        }
    }
}