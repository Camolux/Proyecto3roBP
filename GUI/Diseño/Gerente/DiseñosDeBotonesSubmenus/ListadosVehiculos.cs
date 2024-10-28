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
    public partial class ListadosVehiculos : Form
    {
        public static ListadosVehiculos instance;
        private ListadosVehiculos()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnBuscarVehiculosGer.Click += new EventHandler(controlador.OnButtonClick);
            btnMostrarVehiculosGer.Click += new EventHandler(controlador.OnButtonClick);

        }

        public static ListadosVehiculos GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ListadosVehiculos();
            }
            return instance;
        }

        private void btnBuscarVehiculosGer_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarVehiculosGer_Click(object sender, EventArgs e)
        {

        }
    }
}
