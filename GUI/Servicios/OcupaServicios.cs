using System;
using System.Collections.Generic;
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
            try
            {
                if (ocupa == null)
                    throw new ArgumentNullException("La ocupación no puede ser nula.");

                if (string.IsNullOrWhiteSpace(ocupa.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (ocupa.FechaEntrada >= ocupa.FechaSalida)
                    throw new ArgumentException("La fecha de entrada debe ser anterior a la fecha de salida.");

                return ocupaRepositorio.AgregarOcupa(ocupa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la ocupación: " + ex.Message, ex);
            }
        }

        // Método para modificar una ocupación
        public bool ModificarOcupa(OcupaDTO ocupa)
        {
            try
            {
                if (ocupa == null)
                    throw new ArgumentNullException("La ocupación no puede ser nula.");

                if (string.IsNullOrWhiteSpace(ocupa.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (ocupa.FechaEntrada >= ocupa.FechaSalida)
                    throw new ArgumentException("La fecha de entrada debe ser anterior a la fecha de salida.");

                return ocupaRepositorio.ModificarOcupa(ocupa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la ocupación: " + ex.Message, ex);
            }
        }

        // Método para obtener una ocupación específica
        public OcupaDTO ObtenerOcupa(string matricula, int numPlaza)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (numPlaza <= 0)
                    throw new ArgumentException("El número de plaza debe ser un valor positivo.");

                return ocupaRepositorio.ObtenerOcupa(matricula, numPlaza);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la ocupación: " + ex.Message, ex);
            }
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
                throw new Exception("Error al listar las ocupaciones: " + ex.Message, ex);
            }
        }
    }
}