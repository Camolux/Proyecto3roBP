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
    public partial class ModificacionesVehiculos : Form
    {
        public static ModificacionesVehiculos instance;
        private ModificacionesVehiculos()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModificarVehiculosGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesVehiculos GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModificacionesVehiculos();
            }
            return instance;
        }

        private void btnModificarVehiculosGer_Click(object sender, EventArgs e)
        {

        }
    }
}
