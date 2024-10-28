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
    public partial class ModificacionesEjecutivoYJefeDeServicios : Form
    {
        public static ModificacionesEjecutivoYJefeDeServicios instance;
        private ModificacionesEjecutivoYJefeDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModFuncionario.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesEjecutivoYJefeDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModificacionesEjecutivoYJefeDeServicios();
            }
            return instance;
        }

        private void btnModFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
