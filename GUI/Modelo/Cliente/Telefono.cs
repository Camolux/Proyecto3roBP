using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class TelefonoDTO
    {
        public int Telefono { get; set; }
        public string CI { get; set; }

        public TelefonoDTO() { }

        public TelefonoDTO(int telefono, string ci)
        {
            Telefono = telefono;
            CI = ci;
        }
    }
}
