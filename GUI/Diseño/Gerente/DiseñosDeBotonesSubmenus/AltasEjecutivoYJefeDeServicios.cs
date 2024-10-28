using Controlador;
using Servicios;
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
    public partial class AltasEjecutivoYJefeDeServicios : Form
    {
        public static AltasEjecutivoYJefeDeServicios instance;
        private AltasEjecutivoYJefeDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();
            
            BTNAltaUsuarioGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasEjecutivoYJefeDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasEjecutivoYJefeDeServicios();
            }
            return instance;
        }

        private void btnIngresarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
