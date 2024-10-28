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
    public partial class AltasEjecutivoYJefeDeServiciosMenuJefe : Form
    {
        public static AltasEjecutivoYJefeDeServiciosMenuJefe instance;
        private AltasEjecutivoYJefeDeServiciosMenuJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarFuncionarioGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasEjecutivoYJefeDeServiciosMenuJefe GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasEjecutivoYJefeDeServiciosMenuJefe();
            }
            return instance;
        }

        private void btnIngresarFuncionarioGer_Click(object sender, EventArgs e)
        {

        }
    }
}
