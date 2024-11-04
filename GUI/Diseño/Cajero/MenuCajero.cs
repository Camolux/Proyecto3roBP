using GUI.Diseño.Cajero.DiseñosDeBotonesSubMenusCajero;
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

namespace GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus
{
    public partial class MenuCajero : Form
    {
        public static MenuCajero instance;
        private Controlador.Controlador controlador;
        private MenuCajero()
        {
            InitializeComponent();
            personalizardiseño();
        }

        public static MenuCajero GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MenuCajero();
            }
            return instance;
        }

        public void SetControlador(Controlador.Controlador controlador)
        {
            this.controlador = controlador;
            controlador.formCajero = this;
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

        private void btnEmitirFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(EmitirFacturasServicios.GetInsance());
            //Codigo del boton
            ocultarsubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(EntregaDeVehiculos.GetInsance());
            //Codigo del boton
            ocultarsubmenu();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelServiciosDeCajero);
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

        private void btnhome_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(HomeCajero.GetInsance());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
