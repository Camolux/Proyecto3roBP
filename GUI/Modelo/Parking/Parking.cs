using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class ParkingDTO
    {
        public enum ParaEntregar
        {
            si,
            no
        }

        public int IdParking { get; set; }
        public int Precio { get; set; }
        public ParaEntregar ParaEntregarEstado { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Matricula { get; set; }
        public int NumPlaza { get; set; }
        public string Funcionario { get; set; }

        public ParkingDTO() { }

        public ParkingDTO(int idParking, int precio, ParaEntregar paraEntregarEstado, DateTime fechaSalida, DateTime fechaEntrada, string matricula, int numPlaza, string funcionario)
        {
            IdParking = idParking;
            Precio = precio;
            ParaEntregarEstado = paraEntregarEstado;
            FechaSalida = fechaSalida;
            FechaEntrada = fechaEntrada;
            Matricula = matricula;
            NumPlaza = numPlaza;
            Funcionario = funcionario;
        }
    }
}
