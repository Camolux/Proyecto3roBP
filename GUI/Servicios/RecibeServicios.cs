using System;
using System.Collections.Generic;
using Servicios;
using Repositorios;

namespace Servicios
{
    public class RecibeServicios
    {
        private static RecibeServicios instance;
        private RecibeRepositorio recibeRepositorio;

        public static RecibeServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new RecibeServicios();
            }
            return instance;
        }

        private RecibeServicios()
        {
            recibeRepositorio = RecibeRepositorio.GetInstance();
        }

        // Método para agregar una nueva entrada en Recibe
        public bool AgregarRecibe(RecibeDTO recibe)
        {
            try
            {
                if (recibe == null)
                    throw new ArgumentNullException("El registro de servicio no puede ser nulo.");

                if (recibe.IdServicio <= 0)
                    throw new ArgumentException("El ID del servicio debe ser positivo.");

                if (string.IsNullOrWhiteSpace(recibe.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(recibe.Funcionario))
                    throw new ArgumentException("El funcionario no puede estar vacío.");

                return recibeRepositorio.AgregarRecibe(recibe);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro de servicio: " + ex.Message, ex);
            }
        }

        // Método para modificar una entrada en Recibe
        public bool ModificarRecibe(RecibeDTO recibe)
        {
            try
            {
                if (recibe == null)
                    throw new ArgumentNullException("El registro de servicio no puede ser nulo.");

                if (recibe.IdServicio <= 0)
                    throw new ArgumentException("El ID del servicio debe ser positivo.");

                if (string.IsNullOrWhiteSpace(recibe.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(recibe.Funcionario))
                    throw new ArgumentException("El funcionario no puede estar vacío.");

                return recibeRepositorio.ModificarRecibe(recibe);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el registro de servicio: " + ex.Message, ex);
            }
        }

        // Método para obtener una entrada en Recibe por IdServicio
        public RecibeDTO ObtenerRecibePorIdServicio(int idServicio)
        {
            try
            {
                if (idServicio <= 0)
                    throw new ArgumentException("El ID del servicio debe ser positivo.");

                return recibeRepositorio.ObtenerRecibePorIdServicio(idServicio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de servicio: " + ex.Message, ex);
            }
        }

        // Método para listar todas las entradas en Recibe
        public List<RecibeDTO> ListarRecibe()
        {
            try
            {
                return recibeRepositorio.ListarRecibe();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los registros de servicio: " + ex.Message, ex);
            }
        }
    }
}