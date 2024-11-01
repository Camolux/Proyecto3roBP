using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            // Validaciones
            if (vehiculo == null)
            {
                MessageBox.Show("El vehículo no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
            {
                MessageBox.Show("La marca no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
            {
                MessageBox.Show("El modelo no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Propietario))
            {
                MessageBox.Show("El propietario no puede estar vacío.");
                return false;
            }

            // Validar formato de matrícula (por ejemplo, 7 caracteres)
            if (vehiculo.Matricula.Length != 7)
            {
                MessageBox.Show("La matrícula debe tener 7 caracteres.");
                return false;
            }

            // Validar que el vehículo no exista ya
            VehiculoDTO existente = vehiculoRepositorio.ObtenerVehiculoPorMatricula(vehiculo.Matricula);
            if (existente != null)
            {
                MessageBox.Show("Ya existe un vehículo con esa matrícula.");
                return false;
            }

            // Llamar al repositorio para agregar el vehículo
            return vehiculoRepositorio.AgregarVehiculo(vehiculo);
        }

        // Método para modificar un vehículo
        public bool ModificarVehiculo(VehiculoDTO vehiculo)
        {
            // Validaciones
            if (vehiculo == null)
            {
                MessageBox.Show("El vehículo no puede ser nulo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
            {
                MessageBox.Show("La marca no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
            {
                MessageBox.Show("El modelo no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Propietario))
            {
                MessageBox.Show("El propietario no puede estar vacío.");
                return false;
            }

            // Validar formato de matrícula
            if (vehiculo.Matricula.Length != 7)
            {
                MessageBox.Show("La matrícula debe tener 7 caracteres.");
                return false;
            }

            // Validar que el vehículo exista
            VehiculoDTO existente = vehiculoRepositorio.ObtenerVehiculoPorMatricula(vehiculo.Matricula);
            if (existente == null)
            {
                MessageBox.Show("No existe un vehículo con esa matrícula.");
                return false;
            }

            // Llamar al repositorio para modificar el vehículo
            return vehiculoRepositorio.ModificarVehiculo(vehiculo);
        }

        // Método para obtener un vehículo por matrícula
        public VehiculoDTO ObtenerVehiculoPorMatricula(string matricula)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("La matrícula no puede estar vacía.");
                return null;
            }

            // Validar formato de matrícula
            if (matricula.Length != 7)
            {
                MessageBox.Show("La matrícula debe tener 7 caracteres.");
                return null;
            }

            // Llamar al repositorio para obtener el vehículo
            return vehiculoRepositorio.ObtenerVehiculoPorMatricula(matricula);
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
                MessageBox.Show("Error al listar los vehículos: " + ex.Message);
                return new List<VehiculoDTO>();
            }
        }
    }
}
