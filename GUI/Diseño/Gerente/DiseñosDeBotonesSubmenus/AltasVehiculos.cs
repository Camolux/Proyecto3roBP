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

namespace GUI
{
    public partial class AltasVehiculos : Form
    {
        public static AltasVehiculos instance;
        private AltasVehiculos()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarVehiculosGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasVehiculos GetInsance()
        {
            if (instance == null)
            {
                instance = new AltasVehiculos();
            }
            return instance;
        }

        private void btnIngresarVehiculosGer_Click(object sender, EventArgs e)
        {

        }
    }
}
