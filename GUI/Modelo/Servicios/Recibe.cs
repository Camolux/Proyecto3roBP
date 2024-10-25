using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class RecibeDTO
    {
        public DateTime FechaServicio { get; set; }
        public int IdServicio { get; set; }
        public string Matricula { get; set; }
        public string Funcionario { get; set; }

        public RecibeDTO() { }

        public RecibeDTO(DateTime fechaServicio, int idServicio, string matricula, string funcionario)
        {
            FechaServicio = fechaServicio;
            IdServicio = idServicio;
            Matricula = matricula;
            Funcionario = funcionario;
        }
    }
}
