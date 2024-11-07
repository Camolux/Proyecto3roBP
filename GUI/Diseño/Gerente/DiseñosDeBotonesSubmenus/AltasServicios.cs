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

namespace GUI.Diseño.Gerente.Vehiculos
{
    public partial class AltasServicios : Form
    {
        public static AltasServicios instance;
        private AltasServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNAltaServGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasServicios();
            }
            return instance;
        }

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (RBParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBAltaServGerID.Enabled = false;
                TBAltaServGerIDNeum.Enabled = false;
                TBAltaServGerIDCliente.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServGerID.BackColor = Color.DarkGray;
                TBAltaServGerIDNeum.BackColor = Color.DarkGray;
                TBAltaServGerIDCliente.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBAltaServGerID.Enabled = true;
                TBAltaServGerIDNeum.Enabled = true;
                TBAltaServGerIDCliente.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServGerID.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerIDNeum.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerNomFuncionario.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLavado.Checked)
            {
                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
                mTBAltaServGerFechaFin.Enabled = false;
                TBAltaServGerIDNeum.Enabled = false;
                TBAltaServGerNumPlaza.Enabled = false;
                TBAltaServGerIDCliente.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServGerIDNeum.BackColor = Color.DarkGray;
                TBAltaServGerNumPlaza.BackColor = Color.DarkGray;
                TBAltaServGerIDCliente.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado

                mTBAltaServGerFechaFin.Enabled = true;
                TBAltaServGerIDNeum.Enabled = true;
                TBAltaServGerNumPlaza.Enabled = true;
                TBAltaServGerIDCliente.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServGerIDNeum.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAlineacion.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
                TBAltaServGerID.Enabled = false;
                mTBAltaServGerFechaFin.Enabled = false;
                TBAltaServGerIDNeum.Enabled = false;
                TBAltaServGerNumPlaza.Enabled = false;
                TBAltaServGerIDCliente.Enabled = false;
                TBAltaServGerIDNeum.BackColor = Color.DarkGray;
                TBAltaServGerNumPlaza.BackColor = Color.DarkGray;
                TBAltaServGerIDCliente.BackColor = Color.DarkGray;
                TBAltaServGerID.BackColor = Color.DarkGray; 
            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBAltaServGerID.Enabled = true;
                mTBAltaServGerFechaFin.Enabled = true;
                TBAltaServGerIDNeum.Enabled = true;
                TBAltaServGerNumPlaza.Enabled = true;
                TBAltaServGerIDCliente.Enabled = true;
                TBAltaServGerIDNeum.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerIDCliente.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerID.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                mTBAltaServGerFechaFin.Enabled = false;
                TBAltaServGerID.Enabled = false;
                TBAltaServGerMatr.Enabled = false;
                TBAltaServGerNumPlaza.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBAltaServGerID.BackColor = Color.DarkGray;
                TBAltaServGerMatr.BackColor = Color.DarkGray;
                TBAltaServGerNumPlaza.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBAltaServGerFechaFin.Enabled = true;
                TBAltaServGerID.Enabled = true;
                TBAltaServGerMatr.Enabled = true;
                TBAltaServGerNumPlaza.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBAltaServGerID.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerMatr.BackColor = SystemColors.ActiveCaption;
                TBAltaServGerNumPlaza.BackColor = SystemColors.ActiveCaption;
            }
        }

        

        private void BTNAltaServGer_Click(object sender, EventArgs e)
        {

        }
    }
}
