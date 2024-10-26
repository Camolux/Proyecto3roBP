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

namespace GUI.Diseño.Cajero.DiseñosDeBotonesSubMenusCajero
{
    public partial class EntregaDeVehiculos : Form
    {
        public static EntregaDeVehiculos instance;
        private EntregaDeVehiculos()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnEntregarVehiculos.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static EntregaDeVehiculos GetInsance()
        {
            if (instance == null)
            {
                instance = new EntregaDeVehiculos();
            }
            return instance;
        }

        private void btnEntregarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
