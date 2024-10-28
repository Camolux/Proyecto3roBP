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
    public partial class HomeEjecutivoDeServicios : Form
    {
        public static HomeEjecutivoDeServicios instance;
        private HomeEjecutivoDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

        }

        public static HomeEjecutivoDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HomeEjecutivoDeServicios();
            }
            return instance;
        }

        private void HomeEjecutivoDeServicios_Load(object sender, EventArgs e)
        {

        }
    }
}
