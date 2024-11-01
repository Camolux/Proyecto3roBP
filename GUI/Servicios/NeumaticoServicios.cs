using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Neumatico;
using Repositorios;

namespace Servicios
{
    public class NeumaticoServicios
    {
        private static NeumaticoServicios instance;
        private NeumaticoRepositorio neumaticoRepositorio;

        public static NeumaticoServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new NeumaticoServicios();
            }
            return instance;
        }

        private NeumaticoServicios()
        {
            neumaticoRepositorio = NeumaticoRepositorio.GetInstance();
        }

        // Método para obtener un neumático por su ID
        public NeumaticoDTO ObtenerNeumaticoPorId(int idNeumatico)
        {
            // Validación del ID del neumático
            if (idNeumatico <= 0)
            {
                MessageBox.Show("El ID del neumático debe ser un valor positivo.");
                return null;
            }

            // Llamar al repositorio para obtener el neumático
            NeumaticoDTO neumatico = neumaticoRepositorio.ObtenerNeumaticoPorId(idNeumatico);

            if (neumatico == null)
            {
                MessageBox.Show("El neumático con el ID proporcionado no existe.");
            }

            return neumatico;
        }

        // Método para listar todos los neumáticos
        public List<NeumaticoDTO> ListarNeumaticos()
        {
            try
            {
                return neumaticoRepositorio.ListarNeumaticos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los neumáticos: " + ex.Message);
                return new List<NeumaticoDTO>();
            }
        }

        // Método para obtener el precio de un neumático por su ID
        public int? ObtenerPrecioPorId(int idNeumatico)
        {
            // Validación del ID
            if (idNeumatico <= 0)
            {
                MessageBox.Show("El ID del neumático debe ser un valor positivo.");
                return null;
            }

            // Obtener el precio del neumático desde el repositorio
            int? precio = neumaticoRepositorio.ObtenerPrecioPorId(idNeumatico);

            if (precio == null)
            {
                MessageBox.Show("El neumático con el ID proporcionado no existe.");
                return null;
            }

            return precio;
        }
        public bool ActualizarPrecioNeumatico(int idNeumatico, int nuevoPrecio)
        {
            if (nuevoPrecio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor positivo.");
                return false;
            }

            return neumaticoRepositorio.ActualizarPrecioNeumatico(idNeumatico, nuevoPrecio);
        }
    }
}
