using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class VehiculoDTO
    {
        

        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string TIpoCliente { get; set; }
        public string Propietario { get; set; }

        public VehiculoDTO() { }

        public VehiculoDTO(string matricula, string marca, string modelo, string tipo, string tipoCliente, string propietario)
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
