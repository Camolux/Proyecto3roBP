using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parking;
using Repositorios;

namespace Servicios
{
    public class OcupaServicios
    {
        private static OcupaServicios instance;
        private OcupaRepositorio ocupaRepositorio;

        public static OcupaServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new OcupaServicios();
            }
            return instance;
        }

        private OcupaServicios()
        {
            ocupaRepositorio = OcupaRepositorio.GetInstance();
        }

        // Método para agregar una ocupación
        public bool AgregarOcupa(OcupaDTO ocupa)
        {
            // Validaciones
            if (ocupa == null)
            {
                MessageBox.Show("La ocupación no puede ser nula.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ocupa.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (ocupa.FechaEntrada >= ocupa.FechaSalida)
            {
                MessageBox.Show("La fecha de entrada debe ser anterior a la fecha de salida.");
                return false;
            }

            // Llamar al repositorio para agregar la ocupación
            return ocupaRepositorio.AgregarOcupa(ocupa);
        }

        // Método para modificar una ocupación
        public bool ModificarOcupa(OcupaDTO ocupa)
        {
            // Validaciones
            if (ocupa == null)
            {
                MessageBox.Show("La ocupación no puede ser nula.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ocupa.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (ocupa.FechaEntrada >= ocupa.FechaSalida)
            {
                MessageBox.Show("La fecha de entrada debe ser anterior a la fecha de salida.");
                return false;
            }

            // Llamar al repositorio para modificar la ocupación
            return ocupaRepositorio.ModificarOcupa(ocupa);
        }

        // Método para obtener una ocupación específica
        public OcupaDTO ObtenerOcupa(string matricula, int numPlaza)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return null;
            }

            if (numPlaza <= 0)
            {
                MessageBox.Show("El número de plaza debe ser un valor positivo.");
                return null;
            }

            // Llamar al repositorio para obtener la ocupación
            OcupaDTO ocupa = ocupaRepositorio.ObtenerOcupa(matricula, numPlaza);

            if (ocupa == null)
            {
                MessageBox.Show("No se encontró la ocupación con los datos proporcionados.");
            }

            return ocupa;
        }

        // Método para listar todas las ocupaciones
        public List<OcupaDTO> ListarOcupaciones()
        {
            try
            {
                return ocupaRepositorio.ListarOcupaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las ocupaciones: " + ex.Message);
                return new List<OcupaDTO>();
            }
        }
    }
}
