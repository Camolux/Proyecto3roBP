using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class OcupaDTO
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Matricula { get; set; }
        public int NumPlaza { get; set; }

        public OcupaDTO() { }

        public OcupaDTO(DateTime fechaSalida, DateTime fechaEntrada, string matricula, int numPlaza)
        {
            FechaSalida = fechaSalida;
            FechaEntrada = fechaEntrada;
            Matricula = matricula;
            NumPlaza = numPlaza;
        }
    }
}
