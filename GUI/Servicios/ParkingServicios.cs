using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validaciones
            if (parking == null)
            {
                MessageBox.Show("El registro de parking no puede ser nulo.");
                return false;
            }

            if (parking.FechaEntrada >= parking.FechaSalida)
            {
                MessageBox.Show("La fecha de entrada debe ser anterior a la fecha de salida.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(parking.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            // Llamar al repositorio para agregar el registro de parking
            return parkingRepositorio.AgregarParking(parking);
        }

        // Método para modificar un registro de parking
        public bool ModificarParking(ParkingDTO parking)
        {
            // Validaciones
            if (parking == null)
            {
                MessageBox.Show("El registro de parking no puede ser nulo.");
                return false;
            }

            if (parking.FechaEntrada >= parking.FechaSalida)
            {
                MessageBox.Show("La fecha de entrada debe ser anterior a la fecha de salida.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(parking.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            // Llamar al repositorio para modificar el registro de parking
            return parkingRepositorio.ModificarParking(parking);
        }

        // Método para obtener un registro de parking por ID
        public ParkingDTO ObtenerParkingPorId(int idParking)
        {
            // Validación del ID de parking
            if (idParking <= 0)
            {
                MessageBox.Show("El ID de parking debe ser un valor positivo.");
                return null;
            }

            // Llamar al repositorio para obtener el registro de parking
            ParkingDTO parking = parkingRepositorio.ObtenerParkingPorId(idParking);

            if (parking == null)
            {
                MessageBox.Show("No se encontró el registro de parking con el ID proporcionado.");
            }

            return parking;
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
                MessageBox.Show("Error al listar los registros de parking: " + ex.Message);
                return new List<ParkingDTO>();
            }
        }
        public bool ActualizarPrecioParking(int idParking, int nuevoPrecio)
        {
            if (nuevoPrecio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor positivo.");
                return false;
            }

            return parkingRepositorio.ActualizarPrecioParking(idParking, nuevoPrecio);
        }
        public string MarcarParaEntregar(int idParking)
        {
            if (idParking <= 0)
            {
                return "El ID de parking debe ser un valor positivo.";
            }

            bool resultado = parkingRepositorio.CambiarParaEntregar(idParking);
            if (resultado)
            {
                return "El estado de 'Para Entregar' ha sido actualizado a 'sí'.";
            }
            else
            {
                return "El ID no existe o el vehículo ya está marcado para entregar.";
            }
        }
        public ParkingDTO ObtenerParkingPorMatriculaYFecha(string matricula, DateTime fechaEntrada)
        {
            if (string.IsNullOrWhiteSpace(matricula))
            {
                throw new ArgumentException("La matrícula no puede estar vacía.");
            }

            return parkingRepositorio.ObtenerParkingPorMatriculaYFecha(matricula, fechaEntrada);
        }
    }
}
