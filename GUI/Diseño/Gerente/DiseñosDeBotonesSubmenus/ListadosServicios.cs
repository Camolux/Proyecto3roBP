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
    public partial class ListadosServicios : Form
    {
        public static ListadosServicios instance;
        private ListadosServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnBuscarServicioGer.Click += new EventHandler(controlador.OnButtonClick);
            btnMostrarServGer.Click += new EventHandler(controlador.OnButtonClick);

        }

        public static ListadosServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ListadosServicios();
            }
            return instance;
        }

        private void btnMostrarServGer_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarServicioGer_Click(object sender, EventArgs e)
        {

        }
    }
}
