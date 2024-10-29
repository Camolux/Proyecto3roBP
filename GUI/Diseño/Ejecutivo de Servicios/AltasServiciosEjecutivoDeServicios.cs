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

namespace GUI.Diseño.Ejecutivo_de_Servicios
{
    public partial class AltasServiciosEjecutivoDeServicios : Form
    {
        public static AltasServiciosEjecutivoDeServicios instance;
        private AltasServiciosEjecutivoDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNAltaVehiculoEje.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static AltasServiciosEjecutivoDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AltasServiciosEjecutivoDeServicios();
            }
            return instance;
        }

        private void radioButtonParking_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBAltaServEjeID.Enabled = false;
                TBAltaServEjeIDNeu.Enabled = false;
                TBAltaServEjeNomFuncio.Enabled = false;
                TBAltaServEjeIDCliente.Enabled = false;
                comboBox1.Enabled = false;
                TBAltaServEjeID.BackColor = Color.DarkGray;
                TBAltaServEjeID.BackColor = Color.DarkGray;
                TBAltaServEjeIDNeu.BackColor = Color.DarkGray;
                TBAltaServEjeNomFuncio.BackColor = Color.DarkGray;
                TBAltaServEjeIDCliente.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBAltaServEjeID.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNomFuncio.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                comboBox1.Enabled = true;
                TBAltaServEjeID.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNomFuncio.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void radioButtonLavado_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButtonLavado.Checked)
            {
                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
                mTBAltaServEjeFechaFin.Enabled = false;
                TBAltaServEjeIDNeu.Enabled = false;
                TBAltaServEjeNumPlaza.Enabled = false;
                TBAltaServEjeIDCliente.Enabled = false;
                comboBox1.Enabled = false;
                TBAltaServEjeID.BackColor = Color.DarkGray;
                TBAltaServEjeIDNeu.BackColor = Color.DarkGray;
                TBAltaServEjeNumPlaza.BackColor = Color.DarkGray;
                TBAltaServEjeIDCliente.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado

                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                comboBox1.Enabled = true;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }




        private void radioButtonNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                mTBAltaServEjeFechaFin.Enabled = false;
                TBAltaServEjeID.Enabled = false;
                TBAltaServEjeMatr.Enabled = false;
                TBAltaServEjeNumPlaza.Enabled = false;
                comboBox1.Enabled = false;
                TBAltaServEjeID.BackColor = Color.DarkGray;
                TBAltaServEjeMatr.BackColor = Color.DarkGray;
                TBAltaServEjeNumPlaza.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeID.Enabled = true;
                TBAltaServEjeMatr.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                comboBox1.Enabled = true;
                TBAltaServEjeID.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeMatr.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
            }
        }
        private void radioButtonTaller_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTaller.Checked)
            {
                mTBAltaServEjeFechaFin.Enabled = false;
                TBAltaServEjeIDNeu.Enabled = false;
                TBAltaServEjeNumPlaza.Enabled = false;
                TBAltaServEjeIDCliente.Enabled = false;
                TBAltaServEjeIDNeu.BackColor = Color.DarkGray;
                TBAltaServEjeNumPlaza.BackColor = Color.DarkGray;
                TBAltaServEjeIDCliente.BackColor = Color.DarkGray;
            }
            else
            {
                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void BTNAltaVehiculoEje_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AltasServiciosEjecutivoDeServicios_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNeumaticos_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
        
    }
}