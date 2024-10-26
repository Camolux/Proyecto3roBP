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
    public partial class ListadoEjecutivoYJefeDeServiciosMenuJefe : Form
    {
        public static ListadoEjecutivoYJefeDeServiciosMenuJefe instance;
        private ListadoEjecutivoYJefeDeServiciosMenuJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnBuscarFuncionariosJefe.Click += new EventHandler(controlador.OnButtonClick);
            btnMostrarFuncionariosJefe.Click += new EventHandler(controlador.OnButtonClick);

        }

        public static ListadoEjecutivoYJefeDeServiciosMenuJefe GetInsance()
        {
            if (instance == null)
            {
                instance = new ListadoEjecutivoYJefeDeServiciosMenuJefe();
            }
            return instance;
        }

        private void btnMostrarFuncionariosJefe_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFuncionariosJefe_Click(object sender, EventArgs e)
        {

        }
    }
}
