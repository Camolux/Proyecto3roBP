using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validación del ID de servicio
            if (idServicio <= 0)
            {
                MessageBox.Show("El ID de servicio debe ser un número positivo.");
                return null;
            }

            // Obtener el taller desde el repositorio
            TallerDTO taller = tallerRepositorio.ObtenerTallerPorId(idServicio);

            if (taller == null)
            {
                MessageBox.Show("No se encontró el taller con el ID de servicio proporcionado.");
                return null;
            }

            return taller;
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
                MessageBox.Show("Error al listar los talleres: " + ex.Message);
                return new List<TallerDTO>();
            }
        }
    }
}
