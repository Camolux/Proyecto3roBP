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

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (RBParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBAltaServEjeID.Enabled = false;
                TBAltaServEjeIDNeu.Enabled = false;
                TBAltaServEjeNomFuncio.Enabled = false;
                TBAltaServEjeIDCliente.Enabled = false;
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
                TBAltaServEjeID.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNomFuncio.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {


            if (RBLavado.Checked)
            {
                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
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
                // Habilitarlos si no está seleccionado

                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAlineacion.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
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
                // Habilitarlos si no está seleccionado
                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;


            }
        }

        private void RBBalanceo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBBalanceo.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
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
                // Habilitarlos si no está seleccionado
                mTBAltaServEjeFechaFin.Enabled = true;
                TBAltaServEjeIDNeu.Enabled = true;
                TBAltaServEjeNumPlaza.Enabled = true;
                TBAltaServEjeIDCliente.Enabled = true;
                TBAltaServEjeIDNeu.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeIDCliente.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                mTBAltaServEjeFechaFin.Enabled = false;
                TBAltaServEjeID.Enabled = false;
                TBAltaServEjeMatr.Enabled = false;
                TBAltaServEjeNumPlaza.Enabled = false;
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
                TBAltaServEjeID.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeMatr.BackColor = SystemColors.ActiveCaption;
                TBAltaServEjeNumPlaza.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void BTNAltaVehiculoEje_Click(object sender, EventArgs e)
        {

        }
    }
}
