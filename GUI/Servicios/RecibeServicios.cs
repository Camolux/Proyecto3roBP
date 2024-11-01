using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validaciones
            if (recibe == null)
            {
                MessageBox.Show("El registro de servicio no puede ser nulo.");
                return false;
            }

            if (recibe.IdServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser positivo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(recibe.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(recibe.Funcionario))
            {
                MessageBox.Show("El funcionario no puede estar vacío.");
                return false;
            }

            // Llamar al repositorio para agregar la entrada en Recibe
            return recibeRepositorio.AgregarRecibe(recibe);
        }

        // Método para modificar una entrada en Recibe
        public bool ModificarRecibe(RecibeDTO recibe)
        {
            // Validaciones
            if (recibe == null)
            {
                MessageBox.Show("El registro de servicio no puede ser nulo.");
                return false;
            }

            if (recibe.IdServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser positivo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(recibe.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(recibe.Funcionario))
            {
                MessageBox.Show("El funcionario no puede estar vacío.");
                return false;
            }

            // Llamar al repositorio para modificar la entrada en Recibe
            return recibeRepositorio.ModificarRecibe(recibe);
        }

        // Método para obtener una entrada en Recibe por IdServicio
        public RecibeDTO ObtenerRecibePorIdServicio(int idServicio)
        {
            // Validación del ID de servicio
            if (idServicio <= 0)
            {
                MessageBox.Show("El ID del servicio debe ser positivo.");
                return null;
            }

            // Llamar al repositorio para obtener la entrada en Recibe
            return recibeRepositorio.ObtenerRecibePorIdServicio(idServicio);
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
                MessageBox.Show("Error al listar los registros de servicio: " + ex.Message);
                return new List<RecibeDTO>();
            }
        }
        public RecibeDTO ObtenerRecibePorMatriculaYFecha(string matricula, DateTime fechaServicio)
        {
            if (string.IsNullOrWhiteSpace(matricula))
            {
                throw new ArgumentException("La matrícula no puede estar vacía.");
            }

            return recibeRepositorio.ObtenerRecibePorMatriculaYFecha(matricula, fechaServicio);
        }
    }
}
