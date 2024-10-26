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
    public partial class ListadosClientes : Form
    {
        public static ListadosClientes instance;
        private ListadosClientes()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNBuscarClientesGer.Click += new EventHandler(controlador.OnButtonClick);
            BTNMostrarClientesGer.Click += new EventHandler(controlador.OnButtonClick);

        }

        public static ListadosClientes GetInsance()
        {
            if (instance == null)
            {
                instance = new ListadosClientes();
            }
            return instance;
        }

        private void BTNMostrarClientesGer_Click(object sender, EventArgs e)
        {

        }

        private void BTNBuscarClientesGer_Click(object sender, EventArgs e)
        {

        }
    }
}
