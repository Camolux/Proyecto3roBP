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
    public partial class AltasVehiculosJefe : Form
    {
        public static AltasVehiculosJefe instance;
        private AltasVehiculosJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarVehiculosJefe.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasVehiculosJefe GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasVehiculosJefe();
            }
            return instance;
        }

        private void btnIngresarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
