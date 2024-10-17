using GUI.Diseño.Gerente.Clientes;
using GUI.Diseño.Gerente.Vehiculos;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuGerente : Form
    {
        public MenuGerente()
        {
            InitializeComponent();
            personalizardiseño();
        }
        private void personalizardiseño()
        {
            panelVehiculosmenu.Visible = false;
            panelClientesmenu.Visible = false;
            panelServiciosmenu.Visible = false;
            panelEjecutivoyjefedeserviciosmenu.Visible = false;
            panelCambiarCostosDeServicios.Visible = false;

        }
        private void ocultarsubmenu()
        {
            if (panelVehiculosmenu.Visible == true)
                panelVehiculosmenu.Visible = false;
            if (panelClientesmenu.Visible == true)
                panelClientesmenu.Visible = false;
            if (panelServiciosmenu.Visible == true)
                panelServiciosmenu.Visible = false;
            if (panelEjecutivoyjefedeserviciosmenu.Visible == true)
                panelEjecutivoyjefedeserviciosmenu.Visible = false;
            if (panelCambiarCostosDeServicios.Visible == true)
                panelCambiarCostosDeServicios.Visible = false;

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
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelContenedordesubmenusHome.Controls.Add(FormularioHijo);
            panelContenedordesubmenusHome.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuGerente_Load(object sender, EventArgs e)
        {

        }


        private void btnAltasvehiculos_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            ocultarsubmenu();
        }

        private void btnBajasvehiculos_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            ocultarsubmenu();
        }

        private void btnModificacionesvehiculos_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            ocultarsubmenu();
        }

        private void Menubar_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculos_Click_1(object sender, EventArgs e)
        {
            mostrarsubmenu(panelVehiculosmenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelServiciosmenu);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAltasvehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new AltasVehiculos());
            //codigo
            ocultarsubmenu();
        }

        private void btnBajasvehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new BajasVehiculos());
            //codigo
            ocultarsubmenu();
        }

        private void btnModificacionesvehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesVehiculos());
            //codigo
            ocultarsubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new AltasClientes());
            //codigo
            ocultarsubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new BajasClientes());
            //codigo
            ocultarsubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesClientes());
            //codigo
            ocultarsubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new AltasServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new BajasServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new AltasEjecutivoYJefeDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new BajasEjecutivoYJefeDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesEjecutivoYJefeDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelClientesmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelEjecutivoyjefedeserviciosmenu);
        }

        private void btnAltasCambiarCostoDeServicio_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new AltasCambiarCostosDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void btnBajasCambiarCostosDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new BajasCambiarCostosDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void btnModificacionesCambiarCostosDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesCambiarCostosDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ListadosCambiarCostosDeServicios());
            //codigo
            ocultarsubmenu();
        }

        private void btnListadoServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ListadosServicios());
            //codigo
            ocultarsubmenu();
        }

        private void btnListadoVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ListadosVehiculos());
            //codigo
            ocultarsubmenu();
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ListadosClientes());
            //codigo
            ocultarsubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelCambiarCostosDeServicios);
        }
        private Form FormularioActivo = null;


        private void btnhome_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new Home());
        }

        private void panelContenedordesubmenusHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEmitirFacturaServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new EmitirFacturasServicios());
            //codigo
            ocultarsubmenu();
        }

        private void btnListadoEjecutivoYJefeDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ListadosEjecutivoYJefeDeServicios());
            //codigo
            ocultarsubmenu();
        }
    }
}