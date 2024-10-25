using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class LavadoDTO
    {
        public enum TipoVehiculo
        {
            moto,
            auto,
            camioneta,
            pequeño_camion,
            pequeño_utilitario
        }

        public TipoVehiculo TipoVehiculoLavado { get; set; }
        public int IdServicio { get; set; }

        public LavadoDTO() { }

        public LavadoDTO(TipoVehiculo tipoVehiculoLavado, int idServicio)
        {
            TipoVehiculoLavado = tipoVehiculoLavado;
            IdServicio = idServicio;
        }
    }
}
