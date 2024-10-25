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
        public CambiarCostosDeServicios()
        {
            InitializeComponent();
        }

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (RBParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox3.Enabled = false;
                textBox2.Enabled = false;

                textBox3.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox3.Enabled = true;
                textBox2.Enabled = true;
                textBox3.BackColor = SystemColors.ActiveCaption;
                textBox2.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLavado.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox4.Enabled = false;
                textBox2.Enabled = false;

                textBox4.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox2.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAlineacion.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox4.Enabled = false;
                textBox2.Enabled = false;

                textBox4.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox2.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBBalanceo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBBalanceo.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox4.Enabled = false;
                textBox2.Enabled = false;

                textBox4.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox2.BackColor = SystemColors.ActiveCaption;

            }
        }

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNeumaticos.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox4.Enabled = false;
                textBox3.Enabled = false;

                textBox4.BackColor = Color.DarkGray;
                textBox3.BackColor = Color.DarkGray;

            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox4.Enabled = true;
                textBox3.Enabled = true;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox3.BackColor = SystemColors.ActiveCaption;

            }
        }
    }

}