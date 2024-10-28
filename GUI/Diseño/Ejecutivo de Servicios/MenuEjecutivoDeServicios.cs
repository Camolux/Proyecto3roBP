using GUI.Diseño.Gerente.Clientes;
using GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus;
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
    public partial class MenuEjecutivoDeServicios : Form
    {
        public static MenuEjecutivoDeServicios instance;
        private Controlador.Controlador controlador;
        private MenuEjecutivoDeServicios()
        {
            InitializeComponent();
            personalizardiseño();
        }

        public static MenuEjecutivoDeServicios GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MenuEjecutivoDeServicios();
            }
            return instance;
        }

        public void SetControlador(Controlador.Controlador controlador)
        {
            this.controlador = controlador;
            controlador.formEjecutivo = this;
            this.FormClosing += new FormClosingEventHandler(controlador.FormGerente_FormClosing);

        }


        private void personalizardiseño()
        {
            panelServiciosDeCajero.Visible = false;



        }
        private void ocultarsubmenu()
        {
            if (panelServiciosDeCajero.Visible == true)
                panelServiciosDeCajero.Visible = false;




        }
        private void mostrarsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarsubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void AbrirFormulariohijo(Form FormularioHijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Hide();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelContenedordesubmenusHome.Controls.Add(FormularioHijo);
            panelContenedordesubmenusHome.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }
        private Form FormularioActivo = null;

        private void btnEmitirFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(AltasClientesEjecutivoDeServicios.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnAltasServiciosEjecutivoDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(AltasServiciosEjecutivoDeServicios.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnAltasVehiculosEjecutivoDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(AltasVehiculosEjecutivoDeServicios.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelServiciosDeCajero);
        }

        private void btnModificacionesClientesMenuEjecutivoDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(ModificacionesDeClientesMenuEjecutivoDeServicios.GetInsance());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(HomeEjecutivoDeServicios.GetInsance());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
