using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDTO;
using Servicios;
using GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus;
using GUI.Diseño.Ejecutivo_de_Servicios;
using GUI;
using GUI.Diseño.Jefe_de_Servicios;
using GUI.Diseño.Gerente.Vehiculos;
using GUI.Diseño.Cajero.DiseñosDeBotonesSubMenusCajero;
using GUI.Diseño.Gerente.Clientes;


namespace Controlador
{
    public class Controlador
    {
        public EmitirFacturasServicios emitirFacturasServicios;
        public EntregaDeVehiculos entregaDeVehiculos;
        public AltasClientesEjecutivoDeServicios altasClientesEjecutivoDeServicios;
        public AltasServiciosEjecutivoDeServicios altasServiciosEjecutivoDeServicios;
        public AltasVehiculosEjecutivoDeServicios altasVehiculosEjecutivoDeServicios;
        public ModificacionesDeClientesMenuEjecutivoDeServicios modificacionesDeClientesMenuEjecutivoDeServicios;
        public AltasClientes altasClientes;
        public AltasServicios altasServicios;
        public AltasVehiculos altasVehiculos;
        public BajasEjecutivoYJefeDeServicios bajasEjecutivoYJefeDeServicios;
        public CambiarCostosDeServicios cambiarCostosDeServicios;
        public ListadosClientes listadosClientes;
        public ListadosEjecutivoYJefeDeServicios listadosEjecutivoYJefeDeServicios;
        public ListadosServicios listadosServicios;
        public ListadosVehiculos listadosVehiculos;
        public ModificacionesClientes modificacionesClientes;
        public ModificacionesEjecutivoYJefeDeServicios modificacionesEjecutivoYJefeDeServicios;
        public ModificacionesServicios modificacionesServicios;
        public ModificacionesVehiculos modificacionesVehiculos;
        public AltasClientesJefe altasClientesJefe;
        public AltasEjecutivoYJefeDeServiciosMenuJefe altasEjecutivoYJefeDeServiciosMenuJefe; 
        public AltasServiciosJefe altasServiciosJefe;
        public AltasVehiculosJefe altasVehiculosJefe;
        public BajasEjecutivoYJefeDeServiciosMenuJefe bajasEjecutivoYJefeDeServiciosMenuJefe;
        public ListadoEjecutivoYJefeDeServiciosMenuJefe listadoEjecutivoYJefeDeServiciosMenuJefe;
        public ModificacionesDeClientesMenuJefe modificacionesDeClientesMenuJefe;
        public ModificacionesEjecutivoYJefeDeServiciosMenuJefe modificacionesEjecutivoYJefeDeServiciosMenuJefe;



        Usuario usuarioLogeado;
        Usuario usuarioDTO;
        public static Controlador instance; // Singleton instance
        public MenuGerente formGerente;
        public AltasEjecutivoYJefeDeServicios altasEjecutivoYJefeDeServicios;
        private UsuariosServicios usuariosServicios;
        public Login formLogin;
        public MenuCajero formCajero;
        public MenuEjecutivoDeServicios formEjecutivo;
        public MenuJefe formJefeServicios;

        private Controlador()
        {
            instance = this;
            modificacionesVehiculos = ModificacionesVehiculos.GetInsance();
            modificacionesServicios = ModificacionesServicios.GetInsance();
            modificacionesEjecutivoYJefeDeServicios = ModificacionesEjecutivoYJefeDeServicios.GetInsance();
            modificacionesClientes = ModificacionesClientes.GetInsance();
            listadosVehiculos = ListadosVehiculos.GetInsance();
            listadosServicios = ListadosServicios.GetInsance();
            listadosEjecutivoYJefeDeServicios = ListadosEjecutivoYJefeDeServicios.GetInsance();
            listadosClientes = ListadosClientes.GetInsance();
            cambiarCostosDeServicios = CambiarCostosDeServicios.GetInsance();
            bajasEjecutivoYJefeDeServicios = BajasEjecutivoYJefeDeServicios.GetInsance();
            altasVehiculos = AltasVehiculos.GetInsance();
            altasServicios = AltasServicios.GetInsance();
            altasClientes = AltasClientes.GetInsance();
            modificacionesDeClientesMenuEjecutivoDeServicios = ModificacionesDeClientesMenuEjecutivoDeServicios.GetInsance();
            altasVehiculosEjecutivoDeServicios = AltasVehiculosEjecutivoDeServicios.GetInsance();
            altasServiciosEjecutivoDeServicios = AltasServiciosEjecutivoDeServicios.GetInsance();
            altasClientesEjecutivoDeServicios = AltasClientesEjecutivoDeServicios.GetInsance();
            entregaDeVehiculos = EntregaDeVehiculos.GetInsance();
            emitirFacturasServicios = EmitirFacturasServicios.GetInsance();
            altasClientesJefe = AltasClientesJefe.GetInsance();
            altasEjecutivoYJefeDeServiciosMenuJefe = AltasEjecutivoYJefeDeServiciosMenuJefe.GetInsance();
            altasServiciosJefe = AltasServiciosJefe.GetInsance();
            altasVehiculosJefe = AltasVehiculosJefe.GetInsance();
            altasVehiculosJefe = AltasVehiculosJefe.GetInsance();
            listadoEjecutivoYJefeDeServiciosMenuJefe = ListadoEjecutivoYJefeDeServiciosMenuJefe.GetInsance();
            modificacionesDeClientesMenuJefe = ModificacionesDeClientesMenuJefe.GetInsance();
            modificacionesEjecutivoYJefeDeServiciosMenuJefe = ModificacionesEjecutivoYJefeDeServiciosMenuJefe.GetInsance();


            usuariosServicios = UsuariosServicios.GetInsance();
            usuarioLogeado = new Usuario();
            altasEjecutivoYJefeDeServicios = AltasEjecutivoYJefeDeServicios.GetInsance();
            // Create forms but delay showing them
            usuarioDTO = new Usuario();
            
            formEjecutivo = MenuEjecutivoDeServicios.GetInstance();
            formEjecutivo.SetControlador(this);
            
            formJefeServicios = MenuJefe.GetInstance();
            formJefeServicios.SetControlador(this);

            // Initialize formGerente and set controlador
            formCajero = MenuCajero.GetInstance();
            formCajero.SetControlador(this);
            formGerente = MenuGerente.GetInstance();
            formGerente.SetControlador(this);
        }

        public static Controlador GetInstance()
        {
            if (instance == null)
            {
                instance = new Controlador();
            }
            return instance;
        }




        public void OnButtonClick(object sender, EventArgs e) // escucha eventos botones
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "BTNConfirmar":
                        usuarioLogeado = usuariosServicios.VerificarUsuario(formLogin.TBNomUsu1.Text, formLogin.TBPass1.Text);

                        if (usuarioLogeado != null)
                        {
                            formLogin.Hide();
                            switch (usuarioLogeado.idTipoUsuario)
                            {
                                case "gerente":
                                    
                                    formGerente.Show();

                                    break;
                                case "jefe":
                                    formJefeServicios.Show();
                                    break;
                                case "cajero":
                                    formCajero.Show();
                                    break;
                                case "ejecutivo":
                                    formEjecutivo.Show();
                                    break;
                                default:
                                    MessageBox.Show("Tipo de usuario no válido.");
                                    LimpiarLBL();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña estan mal");

                            LimpiarLBL();
                        }
                        //Aca escondo la ventana de Login y muestro la ventana siguiente

                        break;





                    case "BTNAltaUsuarioGer":

                        AltaUsuGer();

                        break;
                    default:
                        MessageBox.Show("¡Botón incorrecto presionado!");
                        break;
                }
            }
        }

        private void AltaUsuGer()
        {
            usuarioDTO.nombreUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Text;
            usuarioDTO.contraUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Text;
            usuarioDTO.idTipoUsuario = altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.Text;
            MessageBox.Show("Usuario Ingresado Correctamente");
            MessageBox.Show("Usuario Ingresado Correctamente");
            usuariosServicios.AgregarUsuario(usuarioDTO);
            altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Clear();
            altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Clear();
            altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.Items.Clear();
        }

        private void LimpiarLBL()
        {
            formLogin.TBPass1.Clear();// Limpia el TextBox TBPass
            formLogin.TBNomUsu1.Clear();// Limpia el TextBox TBNomUsu
        }
        public void FormGerente_FormClosing(object sender, FormClosingEventArgs e)
        { // Aquí puedes preguntar al usuario si realmente desea salir, por ejemplo
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // Cancela el cierre si el usuario selecciona "No"
                e.Cancel = true;

            }
            else if (result == DialogResult.Yes)
            {
                //Buscar una solucion sin exit

                Application.ExitThread();

            }


        }
        


    }
}
