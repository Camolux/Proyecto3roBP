using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validación del ID de servicio
            if (idServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser un valor positivo.");
                return null;
            }

            // Llamar al repositorio para obtener el servicio de lavado
            LavadoDTO lavado = lavadoRepositorio.ObtenerLavadoPorIdServicio(idServicio);

            if (lavado == null)
            {
                MessageBox.Show("No se encontró el servicio de lavado con el ID proporcionado.");
            }

            return lavado;
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
                MessageBox.Show("Error al listar los servicios de lavado por tipo de vehículo: " + ex.Message);
                return new List<LavadoDTO>();
            }
        }
    }
}
