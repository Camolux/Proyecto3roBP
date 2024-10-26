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
    public partial class AltasClientesEjecutivoDeServicios : Form
    {
        public static AltasClientesEjecutivoDeServicios instance;
        private AltasClientesEjecutivoDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNIngresarClienteEje.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasClientesEjecutivoDeServicios GetInsance()
        {
            if (instance == null)
            {
                instance = new AltasClientesEjecutivoDeServicios();
            }
            return instance;
        }

        private void BTNIngresarClienteEje_Click(object sender, EventArgs e)
        {

        }
    }
}
