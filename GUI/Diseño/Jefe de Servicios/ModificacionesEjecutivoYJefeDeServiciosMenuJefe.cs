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
    public partial class ModificacionesEjecutivoYJefeDeServiciosMenuJefe : Form
    {
        public static ModificacionesEjecutivoYJefeDeServiciosMenuJefe instance;
        private ModificacionesEjecutivoYJefeDeServiciosMenuJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModFuncionarioJefe.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesEjecutivoYJefeDeServiciosMenuJefe GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModificacionesEjecutivoYJefeDeServiciosMenuJefe();
            }
            return instance;
        }

        private void btnModFuncionarioJefe_Click(object sender, EventArgs e)
        {

        }
    }
}
