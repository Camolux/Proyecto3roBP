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
    public partial class BajasEjecutivoYJefeDeServiciosMenuJefe : Form
    {
        public static BajasEjecutivoYJefeDeServiciosMenuJefe instance;
        private BajasEjecutivoYJefeDeServiciosMenuJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnBajaFuncionario.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static BajasEjecutivoYJefeDeServiciosMenuJefe GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BajasEjecutivoYJefeDeServiciosMenuJefe();
            }
            return instance;
        }

        private void btnBajaFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
