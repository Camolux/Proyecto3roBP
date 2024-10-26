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
    public partial class EmitirFacturasServicios : Form
    {
        public static EmitirFacturasServicios instance;
        public EmitirFacturasServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();
            BTNImprimirFactura.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static EmitirFacturasServicios GetInsance()
        {
            if (instance == null)
            {
                instance = new EmitirFacturasServicios();
            }
            return instance;
        }



        private void BTNImprimirFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
