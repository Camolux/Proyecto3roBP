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
    public partial class ModificacionesClientes : Form
    {
        public static ModificacionesClientes instance;
        private ModificacionesClientes()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModificarClientesGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesClientes GetInsance()
        {
            if (instance == null)
            {
                instance = new ModificacionesClientes();
            }
            return instance;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarClientesGer_Click(object sender, EventArgs e)
        {

        }
    }
}
