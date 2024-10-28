using System;
using System.Collections.Generic;
using Parking;
using Repositorios;

namespace Servicios
{
    public class PlazaServicios
    {
        private static PlazaServicios instance;
        private PlazaRepositorio plazaRepositorio;

        public static PlazaServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new PlazaServicios();
            }
            return instance;
        }

        private PlazaServicios()
        {
            plazaRepositorio = PlazaRepositorio.GetInstance();
        }

        // Método para obtener una plaza por Id
        public PlazaDTO ObtenerPlazaPorId(int idPlaza)
        {
            try
            {
                if (idPlaza <= 0)
                    throw new ArgumentException("El ID de plaza debe ser un valor positivo.");

                return plazaRepositorio.ObtenerPlazaPorId(idPlaza);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la plaza: " + ex.Message, ex);
            }
        }

        // Método para listar plazas por tipo
        public List<PlazaDTO> ListarPlazasPorTipo(PlazaDTO.TipoPlaza tipoPlaza)
        {
            try
            {
                return plazaRepositorio.ListarPlazasPorTipo(tipoPlaza);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las plazas por tipo: " + ex.Message, ex);
            }
        }
    }
}