using System;
using System.Collections.Generic;
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
            try
            {
                if (idNeumatico <= 0)
                    throw new ArgumentException("El ID del neumático debe ser un valor positivo.");

                return neumaticoRepositorio.ObtenerNeumaticoPorId(idNeumatico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el neumático: " + ex.Message, ex);
            }
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
                throw new Exception("Error al listar los neumáticos: " + ex.Message, ex);
            }
        }
        public int ObtenerPrecioPorId(int idNeumatico)
        {
            try
            {
                // Validación de ID
                if (idNeumatico <= 0)
                {
                    throw new ArgumentException("El ID del neumático debe ser un valor positivo.");
                }

                int? precio = neumaticoRepositorio.ObtenerPrecioPorId(idNeumatico);

                if (precio == null)
                {
                    throw new Exception("El neumático con el ID proporcionado no existe.");
                }

                return precio.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio del neumático: " + ex.Message, ex);
            }
        }
    }
}