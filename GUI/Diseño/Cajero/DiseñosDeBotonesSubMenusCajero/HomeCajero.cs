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
    public partial class HomeCajero : Form
    {
        public static HomeCajero instance;
        private HomeCajero()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            
        }

        public static HomeCajero GetInsance()
        {
            if (instance == null)
            {
                instance = new HomeCajero();
            }
            return instance;
        }

        private void HomeCajero_Load(object sender, EventArgs e)
        {

        }
    }
}
