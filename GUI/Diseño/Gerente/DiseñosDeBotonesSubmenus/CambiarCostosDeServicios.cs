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

namespace GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus
{
    public partial class CambiarCostosDeServicios : Form
    {
        public static CambiarCostosDeServicios instance;
        private CambiarCostosDeServicios()
        {
            InitializeComponent();
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();

            BTNModCostServGer.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static CambiarCostosDeServicios GetInsance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CambiarCostosDeServicios();
            }
            return instance;
        }

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (RBParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBCostoServIDServ.Enabled = false;
                TBCostoServIDNeumatico.Enabled = false;

                TBCostoServIDServ.BackColor = Color.DarkGray;
                TBCostoServIDNeumatico.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBCostoServIDServ.Enabled = true;
                TBCostoServIDNeumatico.Enabled = true;
                TBCostoServIDServ.BackColor = SystemColors.ActiveCaption;
                TBCostoServIDNeumatico.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLavado.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBCostoServIDPlaza.Enabled = false;
                TBCostoServIDNeumatico.Enabled = false;

                TBCostoServIDPlaza.BackColor = Color.DarkGray;
                TBCostoServIDNeumatico.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBCostoServIDPlaza.Enabled = true;
                TBCostoServIDNeumatico.Enabled = true;
                TBCostoServIDPlaza.BackColor = SystemColors.ActiveCaption;
                TBCostoServIDNeumatico.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAlineacion.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBCostoServIDPlaza.Enabled = false;
                TBCostoServIDNeumatico.Enabled = false;

                TBCostoServIDPlaza.BackColor = Color.DarkGray;
                TBCostoServIDNeumatico.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBCostoServIDPlaza.Enabled = true;
                TBCostoServIDNeumatico.Enabled = true;
                TBCostoServIDPlaza.BackColor = SystemColors.ActiveCaption;
                TBCostoServIDNeumatico.BackColor = SystemColors.ActiveCaption;

            }
        }

        

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNeumaticos.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                TBCostoServIDPlaza.Enabled = false;
                TBCostoServIDServ.Enabled = false;

                TBCostoServIDPlaza.BackColor = Color.DarkGray;
                TBCostoServIDServ.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                TBCostoServIDPlaza.Enabled = true;
                TBCostoServIDServ.Enabled = true;
                TBCostoServIDPlaza.BackColor = SystemColors.ActiveCaption;
                TBCostoServIDServ.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void BTNModCostServGer_Click(object sender, EventArgs e)
        {

        }
    }

}