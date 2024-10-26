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

namespace GUI.Diseño.Ejecutivo_de_Servicios
{
    public partial class AltasVehiculosEjecutivoDeServicios : Form
    {
        public static AltasVehiculosEjecutivoDeServicios instance;
        private AltasVehiculosEjecutivoDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarVehiculos.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasVehiculosEjecutivoDeServicios GetInsance()
        {
            if (instance == null)
            {
                instance = new AltasVehiculosEjecutivoDeServicios();
            }
            return instance;
        }

        private void btnIngresarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
