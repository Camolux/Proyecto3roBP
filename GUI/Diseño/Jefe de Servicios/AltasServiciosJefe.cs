using GUI.Diseño.Gerente.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Diseño.Jefe_de_Servicios
{
    public partial class AltasServiciosJefe : Form
    {
        public static AltasServiciosJefe instance;
        private AltasServiciosJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarServicios.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasServiciosJefe GetInsance()
        {
            if (instance == null)
            {
                instance = new AltasServiciosJefe();
            }
            return instance;
        }

        private void btnIngresarServicios_Click(object sender, EventArgs e)
        {

        }
    }
}
