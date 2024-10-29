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
    public partial class ModificacionesServicios : Form
    {
        public static ModificacionesServicios instance;
        private ModificacionesServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            btnModServGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static ModificacionesServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ModificacionesServicios();
            }
            return instance;
        }

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBModServIDServ.Enabled = false;
                TBModServIDNeumatico.Enabled = false;
                TBModServFuncionario.Enabled = false;
                TBModServIDClientes.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBModServIDServ.BackColor = Color.DarkGray;
                TBModServIDNeumatico.BackColor = Color.DarkGray;
                TBModServFuncionario.BackColor = Color.DarkGray;
                TBModServIDClientes.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBModServIDServ.Enabled = true;
                TBModServIDNeumatico.Enabled = true;
                TBModServFuncionario.Enabled = true;
                TBModServIDClientes.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBModServIDServ.BackColor = SystemColors.ActiveCaption;
                TBModServIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBModServFuncionario.BackColor = SystemColors.ActiveCaption;
                TBModServIDClientes.BackColor = SystemColors.ActiveCaption;
            }
        }







        private void RBBalanceo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTaller.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
                mTBModServFechaFin.Enabled = false;
                TBModServIDNeumatico.Enabled = false;
                TBModServNumPlaza.Enabled = false;
                TBModServIDClientes.Enabled = false;
                TBModServIDNeumatico.BackColor = Color.DarkGray;
                TBModServNumPlaza.BackColor = Color.DarkGray;
                TBModServIDClientes.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBModServFechaFin.Enabled = true;
                TBModServIDNeumatico.Enabled = true;
                TBModServNumPlaza.Enabled = true;
                TBModServIDClientes.Enabled = true;
                TBModServIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBModServNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBModServIDClientes.BackColor = SystemColors.ActiveCaption;
            }

        }








        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButtonLavado.Checked)
            {
                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
                mTBModServFechaFin.Enabled = false;
                TBModServIDNeumatico.Enabled = false;
                TBModServNumPlaza.Enabled = false;
                TBModServIDClientes.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBModServIDNeumatico.BackColor = Color.DarkGray;
                TBModServNumPlaza.BackColor = Color.DarkGray;
                TBModServIDClientes.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado

                mTBModServFechaFin.Enabled = true;
                TBModServIDNeumatico.Enabled = true;
                TBModServNumPlaza.Enabled = true;
                TBModServIDClientes.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBModServIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBModServNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBModServIDClientes.BackColor = SystemColors.ActiveCaption;
            }


        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButtonTaller.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
                mTBModServFechaFin.Enabled = false;
                TBModServIDNeumatico.Enabled = false;
                TBModServNumPlaza.Enabled = false;
                TBModServIDClientes.Enabled = false;
                TBModServIDNeumatico.BackColor = Color.DarkGray;
                TBModServNumPlaza.BackColor = Color.DarkGray;
                TBModServIDClientes.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBModServFechaFin.Enabled = true;
                TBModServIDNeumatico.Enabled = true;
                TBModServNumPlaza.Enabled = true;
                TBModServIDClientes.Enabled = true;
                TBModServIDNeumatico.BackColor = SystemColors.ActiveCaption;
                TBModServNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBModServIDClientes.BackColor = SystemColors.ActiveCaption;


            }
        }

        

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                mTBModServFechaFin.Enabled = false;
                TBModServIDServ.Enabled = false;
                TBModServMatr.Enabled = false;
                TBModServNumPlaza.Enabled = false;
                comboBoxServicio.Enabled = false;
                TBModServIDServ.BackColor = Color.DarkGray;
                TBModServMatr.BackColor = Color.DarkGray;
                TBModServNumPlaza.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBModServFechaFin.Enabled = true;
                TBModServIDServ.Enabled = true;
                TBModServMatr.Enabled = true;
                TBModServNumPlaza.Enabled = true;
                comboBoxServicio.Enabled = true;
                TBModServIDServ.BackColor = SystemColors.ActiveCaption;
                TBModServMatr.BackColor = SystemColors.ActiveCaption;
                TBModServNumPlaza.BackColor = SystemColors.ActiveCaption;
            }


        }

        private void btnModServGer_Click(object sender, EventArgs e)
        {

        }
    }
}
