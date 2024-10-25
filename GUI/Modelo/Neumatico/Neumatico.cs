using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumatico
{
    public class NeumaticoDTO
    {
        public enum MarcaNeumatico
        {
            pirelli,
            michelin,
            bridgeston
        }

        public int IdNeumatico { get; set; }
        public int Precio { get; set; }
        public MarcaNeumatico Marca { get; set; }
        public string Descripcion { get; set; }

        public NeumaticoDTO() { }

        public NeumaticoDTO(int idNeumatico, int precio, MarcaNeumatico marca, string descripcion)
        {
            IdNeumatico = idNeumatico;
            Precio = precio;
            Marca = marca;
            Descripcion = descripcion;
        }
    }
}
