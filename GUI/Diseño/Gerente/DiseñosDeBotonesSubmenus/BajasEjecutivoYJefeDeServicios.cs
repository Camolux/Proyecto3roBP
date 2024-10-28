using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Diseño.Gerente.Vehiculos
{
    public partial class BajasEjecutivoYJefeDeServicios : Form
    {
        public static BajasEjecutivoYJefeDeServicios instance;
        private BajasEjecutivoYJefeDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNEliminarFunciGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static BajasEjecutivoYJefeDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BajasEjecutivoYJefeDeServicios();
            }
            return instance;
        }

        private void btnIngresarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
