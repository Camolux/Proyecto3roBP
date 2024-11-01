using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GUI.Modelo.Neumatico;
using Repositorios;

namespace GUI.Servicios
{
    public class CompraServicios
    {
        private static CompraServicios instance;
        private CompraRepositorio compraRepositorio;

        public static CompraServicios GetInstance()
        {
            if (instance == null)
            {
                instance = new CompraServicios();
            }
            return instance;
        }

        private CompraServicios()
        {
            compraRepositorio = CompraRepositorio.GetInstance();
        }

        // Método para agregar una compra
        public bool AgregarCompra(CompraDTO compra)
        {
            // Validaciones
            if (compra == null)
            {
                MessageBox.Show("La compra no puede ser nula.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(compra.Funcionario) || string.IsNullOrWhiteSpace(compra.Cliente))
            {
                MessageBox.Show("El funcionario y el cliente no pueden estar vacíos.");
                return false;
            }

            if (compra.FechaVenta < DateTime.Now)
            {
                MessageBox.Show("La fecha de venta no puede ser anterior a la fecha actual.");
                return false;
            }

            // Llamar al repositorio para agregar la compra
            return compraRepositorio.AgregarCompra(compra);
        }

        // Método para modificar una compra
        public bool ModificarCompra(CompraDTO compra)
        {
            // Validaciones
            if (compra == null)
            {
                MessageBox.Show("La compra no puede ser nula.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(compra.Funcionario) || string.IsNullOrWhiteSpace(compra.Cliente))
            {
                MessageBox.Show("El funcionario y el cliente no pueden estar vacíos.");
                return false;
            }

            // Llamar al repositorio para modificar la compra
            return compraRepositorio.ModificarCompra(compra);
        }

        // Método para obtener una compra por ID de neumático y funcionario
        public CompraDTO ObtenerCompra(int idNeumatico, string funcionario)
        {
            // Validaciones
            if (idNeumatico <= 0)
            {
                MessageBox.Show("El ID del neumático debe ser un valor positivo.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(funcionario))
            {
                MessageBox.Show("El nombre del funcionario no puede estar vacío.");
                return null;
            }

            // Llamar al repositorio para obtener la compra
            CompraDTO compra = compraRepositorio.ObtenerCompra(idNeumatico, funcionario);

            if (compra == null)
            {
                MessageBox.Show("No se encontró la compra con los datos proporcionados.");
            }

            return compra;
        }

        // Método para listar todas las compras
        public List<CompraDTO> ListarCompras()
        {
            try
            {
                return compraRepositorio.ListarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las compras: " + ex.Message);
                return new List<CompraDTO>();
            }
        }
        public CompraDTO ObtenerCompraPorClienteYFecha(string ciCliente, DateTime fechaCompra)
        {
            if (string.IsNullOrWhiteSpace(ciCliente))
            {
                throw new ArgumentException("La CI del cliente no puede estar vacía.");
            }

            return compraRepositorio.ObtenerCompraPorClienteYFecha(ciCliente, fechaCompra);
        }
    }
}
