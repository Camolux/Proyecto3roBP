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
    public partial class AltasClientesJefe : Form
    {
        public static AltasClientesJefe instance;
        private AltasClientesJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarClienteJefe.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasClientesJefe GetInsance()
        {
            if (instance == null)
            {
                instance = new AltasClientesJefe();
            }
            return instance;
        }

        private void btnIngresarClienteJefe_Click(object sender, EventArgs e)
        {

        }
    }
}
