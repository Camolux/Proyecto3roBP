using System;
using System.Collections.Generic;
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
            try
            {
                if (compra == null)
                    throw new ArgumentNullException("La compra no puede ser nula.");

                if (string.IsNullOrWhiteSpace(compra.Funcionario) || string.IsNullOrWhiteSpace(compra.Cliente))
                    throw new ArgumentException("El funcionario y el cliente no pueden estar vacíos.");

                if (compra.FechaVenta < DateTime.Now)
                    throw new ArgumentException("La fecha de venta no puede ser anterior a la fecha actual.");

                return compraRepositorio.AgregarCompra(compra);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la compra: " + ex.Message, ex);
            }
        }

        // Método para modificar una compra
        public bool ModificarCompra(CompraDTO compra)
        {
            try
            {
                if (compra == null)
                    throw new ArgumentNullException("La compra no puede ser nula.");

                if (string.IsNullOrWhiteSpace(compra.Funcionario) || string.IsNullOrWhiteSpace(compra.Cliente))
                    throw new ArgumentException("El funcionario y el cliente no pueden estar vacíos.");

                return compraRepositorio.ModificarCompra(compra);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la compra: " + ex.Message, ex);
            }
        }

        // Método para obtener una compra por ID de neumático y funcionario
        public CompraDTO ObtenerCompra(int idNeumatico, string funcionario)
        {
            try
            {
                if (idNeumatico <= 0)
                    throw new ArgumentException("El ID del neumático debe ser un valor positivo.");

                if (string.IsNullOrWhiteSpace(funcionario))
                    throw new ArgumentException("El nombre del funcionario no puede estar vacío.");

                return compraRepositorio.ObtenerCompra(idNeumatico, funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la compra: " + ex.Message, ex);
            }
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
                throw new Exception("Error al listar las compras: " + ex.Message, ex);
            }
        }
    }
}