using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Modelo.Neumatico
{
    public class CompraDTO
    {
        public DateTime FechaVenta { get; set; }
        public int IdNeumatico { get; set; }
        public string Funcionario { get; set; }
        public string Cliente { get; set; }

        public CompraDTO() { }

        public CompraDTO(DateTime fechaVenta, int idNeumatico, string funcionario, string cliente)
        {
            FechaVenta = fechaVenta;
            IdNeumatico = idNeumatico;
            Funcionario = funcionario;
            Cliente = cliente;
        }
    }
}
