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
    public partial class HomeJefe : Form
    {
        public static HomeJefe instance;
        private HomeJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

        }

        public static HomeJefe GetInsance()
        {
            if (instance == null)
            {
                instance = new HomeJefe();
            }
            return instance;
        }

        private void HomeJefe_Load(object sender, EventArgs e)
        {

        }
    }
}
