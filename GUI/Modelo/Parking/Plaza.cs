using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class PlazaDTO
    {
        public enum TipoPlaza
        {
            moto,
            auto
        }

        public int IdPlaza { get; set; }
        public TipoPlaza Tipo { get; set; }

        public PlazaDTO() { }

        public PlazaDTO(int idPlaza, TipoPlaza tipo)
        {
            IdPlaza = idPlaza;
            Tipo = tipo;
        }
    }
}
