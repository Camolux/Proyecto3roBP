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

namespace GUI.Diseño.Gerente.Clientes
{
    public partial class AltasClientes : Form
    {
        public static AltasClientes instance;
        private AltasClientes()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNAltaClienteGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasClientes GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasClientes();
            }
            return instance;
        }

        private void BTNAltaClienteGer_Click(object sender, EventArgs e)
        {

        }
    }
}
