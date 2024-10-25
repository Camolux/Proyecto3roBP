using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioDTO
    {
        public int IdServicio { get; set; }
        public int Precio { get; set; }

        public ServicioDTO() { }

        public ServicioDTO(int idServicio, int precio)
        {
            IdServicio = idServicio;
            Precio = precio;
        }
    }
}
