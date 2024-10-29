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
using Cliente;
using GUI.Modelo.Neumatico;
using Neumatico;
using Parking;
using Vehiculo;
using GUI.Servicios;


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
        ClienteDTO clienteDTO;
        TelefonoDTO telefonoDTO;
        CompraDTO compraDTO;
        NeumaticoDTO neumaticoDTO;
        OcupaDTO ocupaDTO;
        ParkingDTO parkingDTO;
        PlazaDTO plazaDTO;
        LavadoDTO lavadoDTO;
        RecibeDTO recibeDTO;
        ServicioDTO servicioDTO;
        TallerDTO tallerDTO;
        VehiculoDTO vehiculoDTO;






        public static Controlador instance; // Singleton instance
        public MenuGerente formGerente;
        public AltasEjecutivoYJefeDeServicios altasEjecutivoYJefeDeServicios;


        private UsuariosServicios usuariosServicios;
        private ClienteServicios clienteServicios;
        private LavadoServicios lavadoServicios;
        private NeumaticoServicios neumaticoServicios;
        private OcupaServicios ocupaServicios;
        private ParkingServicios parkingServicios;
        private PlazaServicios plazaServicios;
        private RecibeServicios recibeServicios;
        private ServiciosServicios serviciosServicios;
        private TallerServicios tallerServicios;
        private TelefonoServicios telefonoServicios;
        private VehiculoServicios vehiculoServicios;

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
            altasEjecutivoYJefeDeServicios = AltasEjecutivoYJefeDeServicios.GetInsance();
            
            
            
            clienteServicios = ClienteServicios.GetInstance();
            lavadoServicios = LavadoServicios.GetInstance();
            neumaticoServicios = NeumaticoServicios.GetInstance();
            ocupaServicios = OcupaServicios.GetInstance();
            parkingServicios = ParkingServicios.GetInstance();
            plazaServicios = PlazaServicios.GetInstance();
            recibeServicios = RecibeServicios.GetInstance();
            serviciosServicios = ServiciosServicios.GetInstance();
            tallerServicios = TallerServicios.GetInstance();
            telefonoServicios = TelefonoServicios.GetInstance();
            vehiculoServicios = VehiculoServicios.GetInstance();

            usuarioLogeado = new Usuario();
            usuarioDTO = new Usuario();
            clienteDTO = new ClienteDTO();
            telefonoDTO = new TelefonoDTO();
            compraDTO = new CompraDTO();
            neumaticoDTO = new NeumaticoDTO();
            ocupaDTO = new OcupaDTO();
            parkingDTO = new ParkingDTO();
            plazaDTO = new PlazaDTO();
            lavadoDTO = new LavadoDTO();
            recibeDTO = new RecibeDTO();
            servicioDTO = new ServicioDTO();
            tallerDTO = new TallerDTO();
            vehiculoDTO = new VehiculoDTO();



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
                    case "BTNImprimirFactura":

                        break;
                    case "btnEntregarVehiculos":

                        break;
                    case "BTNIngresarClienteEje":

                        break;
                    case "BTNAltaVehiculoEje":

                        break;
                    case "btnIngresarVehiculos":

                        break;
                    case "btnModificarClientesEje":

                        break;
                    case "btnIngresarClienteJefe":

                        break;
                    case "btnIngresarFuncionarioGer":

                        break;
                    case "btnIngresarServicios":

                        break;
                    case "btnIngresarVehiculosJefe":

                        break;
                    case "btnBajaFuncionario":

                        break;
                    case "btnBuscarFuncionariosJefe":

                        break;
                    case "btnMostrarFuncionariosJefe":

                        break;
                    case "btnModificarClientesJefe":

                        break;
                    case "btnModFuncionarioJefe":

                        break;
                    case "BTNAltaClienteGer":
                        clienteDTO.CI = altasClientes.TBAltaClienteGerCI1.Text;
                        clienteDTO.Nombre = altasClientes.TBAltaClienteGerNom1.Text;
                        clienteDTO.Apellido = altasClientes.TBAltaClienteGerApe1.Text;
                        telefonoDTO.CI = altasClientes.TBAltaClienteGerCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientes.TBAltaClienteGerTel1.Text);
                        MessageBox.Show("Cliente Ingresado Con exito");
                        clienteServicios.AgregarCliente(clienteDTO);
                        telefonoServicios.AgregarTelefono(telefonoDTO);
                        altasClientes.TBAltaClienteGerApe1.Clear();
                        altasClientes.TBAltaClienteGerCI1.Clear();
                        altasClientes.TBAltaClienteGerNom1.Clear();
                        altasClientes.TBAltaClienteGerTel1.Clear();
                        break;
                    case "BTNAltaUsuarioGer":

                        usuarioDTO.nombreUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Text;
                        usuarioDTO.contraUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Text;
                        usuarioDTO.idTipoUsuario = altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.Text;
                        MessageBox.Show("Usuario Ingresado Correctamente");
                        usuariosServicios.AgregarUsuario(usuarioDTO);
                        altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Clear();
                        altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Clear();
                        altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.Items.Clear();

                        break;
                    case "BTNAltaServGer":
                        
                        break;
                    case "btnIngresarVehiculosGer":
                        vehiculoDTO.Propietario = altasVehiculos.TBAltaVehiculoCICliente1.Text;
                        vehiculoDTO.Matricula = altasVehiculos.TBAltaVehiculoMatr1.Text;
                        vehiculoDTO.Marca = altasVehiculos.TBAltaVehiculoMarca1.Text;
                        vehiculoDTO.Modelo = altasVehiculos.TBAltaVehiculoModelo1.Text;
                        vehiculoDTO.Tipo = altasVehiculos.CBTipoVehiculo.Text;
                        vehiculoDTO.TIpoCliente = altasVehiculos.CBTipoCliente.Text;
                        MessageBox.Show("Vehiculo Ingresado Correctamente");
                        vehiculoServicios.AgregarVehiculo(vehiculoDTO);
                        altasVehiculos.TBAltaVehiculoCICliente1.Clear();
                        altasVehiculos.TBAltaVehiculoMatr1.Clear();
                        altasVehiculos.TBAltaVehiculoMarca1.Clear();
                        altasVehiculos.TBAltaVehiculoModelo1.Clear();
                        altasVehiculos.CBTipoVehiculo.Items.Clear();
                        altasVehiculos.CBTipoCliente.Items.Clear();
                        break;
                    case "BTNEliminarFunciGer":
                        string nombreUsuario= bajasEjecutivoYJefeDeServicios.TBNomBorrarFunci1.Text;
                        MessageBox.Show("Funcionario Eliminado Correctamente" + nombreUsuario);
                        usuariosServicios.EliminarUsuario(nombreUsuario);
                        bajasEjecutivoYJefeDeServicios.TBNomBorrarFunci1.Clear();
                        break;
                    case "BTNModCostServGer":

                        break;
                    case "BTNBuscarClientesGer":

                        break;
                    case "BTNMostrarClientesGer":

                        break;
                    case "btnBuscarFuncionariosGer":

                        break;
                    case "btnMostrarFuncionariosGer":

                        break;
                    case "btnBuscarServicioGer":

                        break;
                    case "btnMostrarServGer":

                        break;
                    case "btnBuscarVehiculosGer":

                        break;
                    case "btnMostrarVehiculosGer":

                        break;
                    case "btnModificarClientesGer":

                        break;
                    case "btnModFuncionario":
                        usuarioDTO.nombreUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Text;
                        usuarioDTO.contraUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Text;
                        usuarioDTO.idTipoUsuario = modificacionesEjecutivoYJefeDeServicios.CBModFuncionarioRol.Text;
                        usuariosServicios.ModificarUsuario(usuarioDTO);
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Clear(); 
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Clear();
                        modificacionesEjecutivoYJefeDeServicios.CBModFuncionarioRol.Items.Clear();
                        break;
                    case "btnModServGer":

                        break;
                    case "btnModificarVehiculosGer":

                        break;
                    default:
                        MessageBox.Show("¡Botón incorrecto presionado!");
                        break;
                }
            }
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
