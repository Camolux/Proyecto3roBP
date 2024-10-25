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
        public AltasServiciosEjecutivoDeServicios()
        {
            InitializeComponent();
        }

        private void RBParking_CheckedChanged(object sender, EventArgs e)
        {
            if (RBParking.Checked)
            {
                // Si se selecciona RBParking, deshabilitar TextBox1 y TextBox2
                textBox1.Enabled = false;
                textBox8.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox1.BackColor = Color.DarkGray;
                textBox8.BackColor = Color.DarkGray;
                textBox6.BackColor = Color.DarkGray;
                textBox7.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                textBox1.Enabled = true;
                textBox8.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox1.BackColor = SystemColors.ActiveCaption;
                textBox8.BackColor = SystemColors.ActiveCaption;
                textBox6.BackColor = SystemColors.ActiveCaption;
                textBox7.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBLavado_CheckedChanged(object sender, EventArgs e)
        {


            if (RBLavado.Checked)
            {
                // Si se selecciona RBLavado, deshabilitar TextBox1 y TextBox2
                maskedTextBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
                textBox8.BackColor = Color.DarkGray;
                textBox4.BackColor = Color.DarkGray;
                textBox7.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado

                maskedTextBox4.Enabled = true;
                textBox8.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                textBox8.BackColor = SystemColors.ActiveCaption;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox7.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBAlineacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAlineacion.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
                maskedTextBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
                textBox8.BackColor = Color.DarkGray;
                textBox4.BackColor = Color.DarkGray;
                textBox7.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                maskedTextBox4.Enabled = true;
                textBox8.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                textBox8.BackColor = SystemColors.ActiveCaption;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox7.BackColor = SystemColors.ActiveCaption;


            }
        }

        private void RBBalanceo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBBalanceo.Checked)
            {
                // Si se selecciona RBTaller, deshabilitar TextBox1 y TextBox2
                maskedTextBox4.Enabled = false;
                textBox8.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
                textBox8.BackColor = Color.DarkGray;
                textBox4.BackColor = Color.DarkGray;
                textBox7.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                maskedTextBox4.Enabled = true;
                textBox8.Enabled = true;
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                textBox8.BackColor = SystemColors.ActiveCaption;
                textBox4.BackColor = SystemColors.ActiveCaption;
                textBox7.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void RBNeumaticos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNeumaticos.Checked)
            {
                // Si se selecciona RBNeumaticos, deshabilitar TextBox1 y TextBox2
                maskedTextBox4.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                textBox1.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;
                textBox4.BackColor = Color.DarkGray;
            }
            else
            {
                // Habilitarlos si no está seleccionado
                maskedTextBox4.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox4.Enabled = true;
                textBox1.BackColor = SystemColors.ActiveCaption;
                textBox2.BackColor = SystemColors.ActiveCaption;
                textBox4.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
