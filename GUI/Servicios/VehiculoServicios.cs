using System;
using System.Collections.Generic;
using Vehiculo;
using Repositorios;

namespace Servicios
{
    public class VehiculoServicios
    {
        private static VehiculoServicios instance;
        private VehiculoRepositorio vehiculoRepositorio;

        public static VehiculoServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new VehiculoServicios();
            }
            return instance;
        }

        private VehiculoServicios()
        {
            vehiculoRepositorio = VehiculoRepositorio.GetInstance();
        }

        // Método para agregar un vehículo
        public bool AgregarVehiculo(VehiculoDTO vehiculo)
        {
            try
            {
                // Validaciones
                if (vehiculo == null)
                    throw new ArgumentNullException("El vehículo no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(vehiculo.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                    throw new ArgumentException("La marca no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                    throw new ArgumentException("El modelo no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(vehiculo.Propietario))
                    throw new ArgumentException("El propietario no puede estar vacío.");

                // Validar formato de matrícula (por ejemplo, 7 caracteres)
                if (vehiculo.Matricula.Length != 7)
                    throw new ArgumentException("La matrícula debe tener 7 caracteres.");

                // Validar que el vehículo no exista ya
                VehiculoDTO existente = vehiculoRepositorio.ObtenerVehiculoPorMatricula(vehiculo.Matricula);
                if (existente != null)
                    throw new Exception("Ya existe un vehículo con esa matrícula.");

                // Llamar al repositorio para agregar el vehículo
                return vehiculoRepositorio.AgregarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehículo: " + ex.Message, ex);
            }
        }

        // Método para modificar un vehículo
        public bool ModificarVehiculo(VehiculoDTO vehiculo)
        {
            try
            {
                // Validaciones
                if (vehiculo == null)
                    throw new ArgumentNullException("El vehículo no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(vehiculo.Matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                    throw new ArgumentException("La marca no puede estar vacía.");

                if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                    throw new ArgumentException("El modelo no puede estar vacío.");

                if (string.IsNullOrWhiteSpace(vehiculo.Propietario))
                    throw new ArgumentException("El propietario no puede estar vacío.");

                // Validar formato de matrícula
                if (vehiculo.Matricula.Length != 7)
                    throw new ArgumentException("La matrícula debe tener 7 caracteres.");

                // Validar que el vehículo exista
                VehiculoDTO existente = vehiculoRepositorio.ObtenerVehiculoPorMatricula(vehiculo.Matricula);
                if (existente == null)
                    throw new Exception("No existe un vehículo con esa matrícula.");

                // Llamar al repositorio para modificar el vehículo
                return vehiculoRepositorio.ModificarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el vehículo: " + ex.Message, ex);
            }
        }

        // Método para obtener un vehículo por matrícula
        public VehiculoDTO ObtenerVehiculoPorMatricula(string matricula)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(matricula))
                    throw new ArgumentException("La matrícula no puede estar vacía.");

                // Validar formato de matrícula
                if (matricula.Length != 7)
                    throw new ArgumentException("La matrícula debe tener 7 caracteres.");

                // Llamar al repositorio para obtener el vehículo
                return vehiculoRepositorio.ObtenerVehiculoPorMatricula(matricula);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el vehículo: " + ex.Message, ex);
            }
        }

        // Método para listar todos los vehículos
        public List<VehiculoDTO> ListarVehiculos()
        {
            try
            {
                return vehiculoRepositorio.ListarVehiculos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los vehículos: " + ex.Message, ex);
            }
        }
    }
}
