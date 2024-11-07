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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Diseño.Jefe_de_Servicios
{
    public partial class AltasServiciosJefe : Form
    {
        public static AltasServiciosJefe instance;
        private AltasServiciosJefe()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnIngresarServicios.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasServiciosJefe GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasServiciosJefe();
            }
            return instance;
        }





        private void btnIngresarServicios_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonParking_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBAltaServicioID.Enabled = false;
                TBAltaServicioIDNeumatico.Enabled = false;
                TBAltaServicioIDClientes.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServicioID.BackColor = Color.DarkGray;
                TBAltaServicioIDNeumatico.BackColor = Color.DarkGray;
                TBAltaServicioIDClientes.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBAltaServicioID.Enabled = true;
                TBAltaServicioIDNeumatico.Enabled = true;
                TBAltaServicioNomFuncionario.Enabled = true;
                TBAltaServicioIDClientes.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServicioID.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioNomFuncionario.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioIDClientes.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void radioButtonTaller_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonLavado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                mTBAltaServicioFechaFin.Enabled = false;
                TBAltaServicioID.Enabled = false;
                TBAltaServicioMatr.Enabled = false;
                TBAltaServicioNumPlaza.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServicioID.BackColor = Color.DarkGray;
                TBAltaServicioMatr.BackColor = Color.DarkGray;
                TBAltaServicioNumPlaza.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBAltaServicioFechaFin.Enabled = true;
                TBAltaServicioID.Enabled = true;
                TBAltaServicioMatr.Enabled = true;
                TBAltaServicioNumPlaza.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServicioID.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioMatr.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioNumPlaza.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void radioButtonLavado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonLavado.Checked)
            {

                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
                mTBAltaServicioFechaFin.Enabled = false;
                TBAltaServicioIDNeumatico.Enabled = false;
                TBAltaServicioNumPlaza.Enabled = false;
                TBAltaServicioIDClientes.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServicioIDClientes.BackColor = Color.DarkGray;
                TBAltaServicioIDNeumatico.BackColor = Color.DarkGray;
                TBAltaServicioNumPlaza.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado

                mTBAltaServicioFechaFin.Enabled = true;
                TBAltaServicioIDNeumatico.Enabled = true;
                TBAltaServicioNumPlaza.Enabled = true;
                TBAltaServicioIDClientes.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServicioIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServicioIDClientes.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void radioButtonTaller_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
