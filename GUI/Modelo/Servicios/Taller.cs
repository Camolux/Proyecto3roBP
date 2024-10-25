using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class TallerDTO
    {
        public enum NombreServicioTaller
        {
            montaje_neumatico,
            alineacion_1_tren,
            alineacion,
            balanceo_auto_valvula,
            alineacion_2_trenes,
            pack_alineacion,
            balanceo_camioneta_valvula
        }

        public NombreServicioTaller Nombre { get; set; }
        public int IdServicio { get; set; }

        public TallerDTO() { }

        public TallerDTO(NombreServicioTaller nombre, int idServicio)
        {
            Nombre = nombre;
            IdServicio = idServicio;
        }
    }
}
