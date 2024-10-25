using GUI.Diseño.Gerente.Clientes;
using GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus;
using GUI.Diseño.Gerente.Vehiculos;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;

namespace GUI
{
    public partial class MenuGerente : Form
    {
        public static MenuGerente instance;
        private Controlador.Controlador controlador;

        private MenuGerente()
        {
            InitializeComponent();
            personalizardiseño();
        }

        public static MenuGerente GetInstance()
        {
            if (instance == null)
            {
                instance = new MenuGerente();
            }
            return instance;
        }

        public void SetControlador(Controlador.Controlador controlador)
        {
            this.controlador = controlador;
            controlador.formGerente = this;
            this.FormClosing += new FormClosingEventHandler(controlador.FormGerente_FormClosing);

            // BTNIngresarClientes.Click += new EventHandler(controlador.OnButtonClick);
            // BTNMostrarClientes.Click += new EventHandler(controlador.OnButtonClick);
            // BTNMostrarVehiculos.Click += new EventHandler(controlador.OnButtonClick);
        }


        private void personalizardiseño()
        {
            panelVehiculosmenu.Visible = false;
            panelClientesmenu.Visible = false;
            panelServiciosmenu.Visible = false;
            panelEjecutivoyjefedeserviciosmenu.Visible = false;


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
        private Form FormularioActivo = null;
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

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(new ModificacionesServicios());
            //codigo
            ocultarsubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo( AltasEjecutivoYJefeDeServicios.GetInsance());
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

        }

        private void btnBajasCambiarCostosDeServicios_Click(object sender, EventArgs e)
        {

        }

        private void btnModificacionesCambiarCostosDeServicios_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

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
            AbrirFormulariohijo(new CambiarCostosDeServicios());
        }



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

        private void panelContenedordesubmenusHome_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}