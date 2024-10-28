using System;
using System.Collections.Generic;
using Parking;
using Repositorios;

namespace Servicios
{
    public class ParkingServicios
    {
        private static ParkingServicios instance;
        private ParkingRepositorio parkingRepositorio;

        public static ParkingServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new ParkingServicios();
            }
            return instance;
        }

        private ParkingServicios()
        {
            parkingRepositorio = ParkingRepositorio.GetInstance();
        }

        // Método para agregar un registro de parking
        public bool AgregarParking(ParkingDTO parking)
        {
            try
            {
                if (parking == null)
                    throw new ArgumentNullException("El registro de parking no puede ser nulo.");

                if (parking.FechaEntrada >= parking.FechaSalida)
                    throw new ArgumentException("La fecha de entrada debe ser anterior a la fecha de salida.");

                if (string.IsNullOrWhiteSpace(parking.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                return parkingRepositorio.AgregarParking(parking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro de parking: " + ex.Message, ex);
            }
        }

        // Método para modificar un registro de parking
        public bool ModificarParking(ParkingDTO parking)
        {
            try
            {
                if (parking == null)
                    throw new ArgumentNullException("El registro de parking no puede ser nulo.");

                if (parking.FechaEntrada >= parking.FechaSalida)
                    throw new ArgumentException("La fecha de entrada debe ser anterior a la fecha de salida.");

                if (string.IsNullOrWhiteSpace(parking.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                return parkingRepositorio.ModificarParking(parking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el registro de parking: " + ex.Message, ex);
            }
        }

        // Método para obtener un registro de parking por ID
        public ParkingDTO ObtenerParkingPorId(int idParking)
        {
            try
            {
                if (idParking <= 0)
                    throw new ArgumentException("El ID de parking debe ser un valor positivo.");

                return parkingRepositorio.ObtenerParkingPorId(idParking);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el registro de parking: " + ex.Message, ex);
            }
        }

        // Método para listar todos los registros de parking
        public List<ParkingDTO> ListarParking()
        {
            try
            {
                return parkingRepositorio.ListarParking();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los registros de parking: " + ex.Message, ex);
            }
        }
    }
}