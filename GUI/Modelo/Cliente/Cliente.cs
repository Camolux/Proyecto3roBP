using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class ClienteDTO
    {
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public ClienteDTO() { }

        public ClienteDTO(string ci, string nombre, string apellido)
        {
            CI = ci;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
