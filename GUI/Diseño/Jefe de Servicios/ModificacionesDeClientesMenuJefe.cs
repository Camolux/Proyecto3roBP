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
    public partial class ModificacionesDeClientesMenuJefe : Form
    {
        public static ModificacionesDeClientesMenuJefe instance;
        private ModificacionesDeClientesMenuJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModificarClientesJefe.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesDeClientesMenuJefe GetInsance()
        {
            if (instance == null)
            {
                instance = new ModificacionesDeClientesMenuJefe();
            }
            return instance;
        }

        private void btnModificarClientesJefe_Click(object sender, EventArgs e)
        {

        }
    }
}
