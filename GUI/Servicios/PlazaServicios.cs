using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validación del ID de plaza
            if (idPlaza <= 0)
            {
                MessageBox.Show("El ID de plaza debe ser un valor positivo.");
                return null;
            }

            // Llamar al repositorio para obtener la plaza
            PlazaDTO plaza = plazaRepositorio.ObtenerPlazaPorId(idPlaza);

            if (plaza == null)
            {
                MessageBox.Show("No se encontró la plaza con el ID proporcionado.");
                return null;
            }

            return plaza;
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
                MessageBox.Show("Error al listar las plazas por tipo: " + ex.Message);
                return new List<PlazaDTO>();
            }
        }
    }
}
