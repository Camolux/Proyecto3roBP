﻿using GUI.Diseño.Ejecutivo_de_Servicios;
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

namespace GUI.Diseño.Jefe_de_Servicios
{
    public partial class MenuJefe : Form
    {
        public static MenuJefe instance;
        private Controlador.Controlador controlador;
        private MenuJefe()
        {
            InitializeComponent();
            personalizardiseño();
        }


        public static MenuJefe GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MenuJefe();
            }
            return instance;
        }

        public void SetControlador(Controlador.Controlador controlador)
        {
            this.controlador = controlador;
            controlador.formJefeServicios = this;
            this.FormClosing += new FormClosingEventHandler(controlador.FormGerente_FormClosing);

        }







        private void personalizardiseño()
        {
            panelEjecutivoyjefedeserviciosmenuJefe.Visible = false;
            panelServiciosMenuJefe.Visible = false;



        }
        private void ocultarsubmenu()
        {
            if (panelEjecutivoyjefedeserviciosmenuJefe.Visible == true)
                panelEjecutivoyjefedeserviciosmenuJefe.Visible = false;
            if (panelServiciosMenuJefe.Visible == true)
                panelServiciosMenuJefe.Visible = false;




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

        private void btnAltasClientesEjecutivoDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(AltasClientesJefe.GetInsance());
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

        private void btnModificacionesClientesMenuEjecutivoDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(ModificacionesDeClientesMenuJefe.GetInsance());
        }

        private void btnEjecutivoyjefedeServicios_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelEjecutivoyjefedeserviciosmenuJefe);
        }

        private void btnAltasEjecutivoYJefe_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(AltasEjecutivoYJefeDeServiciosMenuJefe.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnBajasEjecutivoYJefe_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(BajasEjecutivoYJefeDeServiciosMenuJefe.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnModificacionesEjecutivoYJefe_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(ModificacionesEjecutivoYJefeDeServiciosMenuJefe.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnListadoEjecutivoYJefeDeServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(ListadoEjecutivoYJefeDeServiciosMenuJefe.GetInsance());
            //codigo
            ocultarsubmenu();
        }

        private void btnAltasMenuJefe_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelServiciosMenuJefe);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AbrirFormulariohijo(HomeJefe.GetInsance());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
