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
    public partial class ListadosEjecutivoYJefeDeServicios : Form
    {
        public static ListadosEjecutivoYJefeDeServicios instance;
        private ListadosEjecutivoYJefeDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnBuscarFuncionariosGer.Click += new EventHandler(controlador.OnButtonClick);
            btnMostrarFuncionariosGer.Click += new EventHandler(controlador.OnButtonClick);

        }

        public static ListadosEjecutivoYJefeDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ListadosEjecutivoYJefeDeServicios();
            }
            return instance;
        }

        private void btnMostrarFuncionariosGer_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFuncionariosGer_Click(object sender, EventArgs e)
        {

        }
    }
}
