using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class VehiculoDTO
    {
        public enum TipoVehiculo
        {
            moto,
            auto,
            camioneta,
            pequeño_camion,
            pequeño_utilitario
        }

        public enum TipoCliente
        {
            mensual,
            sistematico,
            eventual,
            extraordinario
        }

        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoVehiculo Tipo { get; set; }
        public TipoCliente TIpoCliente { get; set; }
        public string Propietario { get; set; }

        public VehiculoDTO() { }

        public VehiculoDTO(string matricula, string marca, string modelo, TipoVehiculo tipo, TipoCliente tipoCliente, string propietario)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Tipo = tipo;
            TIpoCliente = tipoCliente;
            Propietario = propietario;
        }
    }
}
