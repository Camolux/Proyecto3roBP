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
            bajasEjecutivoYJefeDeServiciosMenuJefe = BajasEjecutivoYJefeDeServiciosMenuJefe.GetInsance();
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
                List<Usuario> listaUsuarios = usuariosServicios.ListarTodosLosUsuarios();
                string ci;
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
                    case "BTNImprimirFactura"://Cajero

                        break;
                    case "btnEntregarVehiculos":

                        break;//Fin CAJERO



                    case "BTNIngresarClienteEje"://Ejecutivo
                        clienteDTO.CI = altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Text;
                        clienteDTO.Nombre = altasClientesEjecutivoDeServicios.TBAltaClienteEjeNom1.Text;
                        clienteDTO.Apellido = altasClientesEjecutivoDeServicios.TBAltaClienteEjeApe1.Text;
                        telefonoDTO.CI = altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientesEjecutivoDeServicios.TBAltaClienteEjeTel1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        clienteServicios.AgregarCliente(clienteDTO);
                        telefonoServicios.AgregarTelefono(telefonoDTO);
                        altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Clear();
                        altasClientesEjecutivoDeServicios.TBAltaClienteEjeNom1.Clear();
                        altasClientesEjecutivoDeServicios.TBAltaClienteEjeApe1.Clear();
                        altasClientesEjecutivoDeServicios.TBAltaClienteEjeTel1.Clear();
                        break;
                    case "BTNAltaVehiculoEje"://es el alta de servicios












                        break;
                    case "btnIngresarVehiculos":
                        vehiculoDTO.Propietario = altasVehiculosEjecutivoDeServicios.TBAltaVehiculo1.Text;
                        vehiculoDTO.Matricula = altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMatr1.Text;
                        vehiculoDTO.Marca = altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMarca1.Text;
                        vehiculoDTO.Modelo = altasVehiculosEjecutivoDeServicios.TBAltaVehiculoModelo1.Text;
                        vehiculoDTO.Tipo = altasVehiculosEjecutivoDeServicios.CBAltaVehiculoTipoVehiculo1.Text;
                        vehiculoDTO.TIpoCliente = altasVehiculosEjecutivoDeServicios.CBAltaVehiculoTipoCliente1.Text;
                        MessageBox.Show("Vehiculo Ingresado Correctamente");
                        vehiculoServicios.AgregarVehiculo(vehiculoDTO);
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculo1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMatr1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMarca1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoModelo1.Clear();
                        altasVehiculosEjecutivoDeServicios.CBAltaVehiculoTipoVehiculo1.Items.Clear();
                        altasVehiculosEjecutivoDeServicios.CBAltaVehiculoTipoCliente1.Items.Clear();
                        break;
                    case "btnModificarClientesEje":
                        clienteDTO.CI = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Text;
                        clienteDTO.Nombre = modificacionesDeClientesMenuEjecutivoDeServicios.TbModClienteNomEje1.Text;
                        clienteDTO.Apellido = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteApeEje1.Text;
                        telefonoDTO.CI = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteTelEje1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        clienteServicios.ModificarCliente(clienteDTO);
                        telefonoServicios.ModificarTelefono(telefonoDTO);
                        modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Clear();
                        modificacionesDeClientesMenuEjecutivoDeServicios.TbModClienteNomEje1.Clear();
                        modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteApeEje1.Clear();
                        modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteTelEje1.Clear();
                        break;//Fin Ejecutivo
                    case "btnIngresarClienteJefe"://Jefe
                        clienteDTO.CI = altasClientesJefe.TBAltaClienteCI1.Text;
                        clienteDTO.Nombre = altasClientesJefe.TBAltaClienteNom1.Text;
                        clienteDTO.Apellido = altasClientesJefe.TBAltaClienteApe1.Text;
                        telefonoDTO.CI = altasClientesJefe.TBAltaClienteCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientesJefe.TBAltaClienteTel1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        clienteServicios.AgregarCliente(clienteDTO);
                        telefonoServicios.AgregarTelefono(telefonoDTO);
                        altasClientesJefe.TBAltaClienteCI1.Clear();
                        altasClientesJefe.TBAltaClienteNom1.Clear();
                        altasClientesJefe.TBAltaClienteApe1.Clear();
                        altasClientesJefe.TBAltaClienteTel1.Clear();
                        break;
                    case "btnIngresarFuncionarioGer"://AltaUsuario Jefe de servicios
                        usuarioDTO.nombreUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioNom1.Text;
                        usuarioDTO.contraUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioContra1.Text;
                        usuarioDTO.idTipoUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.CBAltaFuncionarioRol.Text;
                        MessageBox.Show("Usuario Ingresado Correctamente");
                        usuariosServicios.AgregarUsuario(usuarioDTO);
                        altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioNom1.Clear();
                        altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioContra1.Clear();
                        altasEjecutivoYJefeDeServiciosMenuJefe.CBAltaFuncionarioRol.Items.Clear();
                        break;
                    case "btnIngresarServicios":











                        break;
                    case "btnIngresarVehiculosJefe":
                        vehiculoDTO.Propietario = altasVehiculosJefe.TBIngresoVehiculoCICliente1.Text;
                        vehiculoDTO.Matricula = altasVehiculosJefe.TBIngresoVehiculoMatr1.Text;
                        vehiculoDTO.Marca = altasVehiculosJefe.TBIngresoVehiculoMarca1.Text;
                        vehiculoDTO.Modelo = altasVehiculosJefe.TBIngresoVehiculoModelo1.Text;
                        vehiculoDTO.Tipo = altasVehiculosJefe.CBTipoVehiculo.Text;
                        vehiculoDTO.TIpoCliente = altasVehiculosJefe.CBTipoCliente.Text;
                        MessageBox.Show("Vehiculo Ingresado Correctamente");
                        vehiculoServicios.AgregarVehiculo(vehiculoDTO);
                        altasVehiculosJefe.TBIngresoVehiculoCICliente1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoMatr1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoMarca1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoModelo1.Clear();
                        altasVehiculosJefe.CBTipoVehiculo.Items.Clear();
                        altasVehiculosJefe.CBTipoCliente.Items.Clear();
                        break;
                    case "btnBajaFuncionario":
                        string nomUsuad = bajasEjecutivoYJefeDeServiciosMenuJefe.TBBajaUsuNom1.Text;

                        MessageBox.Show("Baja Confirmada"+ nomUsuad);
                        usuariosServicios.EliminarUsuario(nomUsuad);
                        bajasEjecutivoYJefeDeServiciosMenuJefe.TBBajaUsuNom1.Clear();
                        break;
                    case "btnBuscarFuncionariosJefe":
                        try
                        {
                            ci = listadoEjecutivoYJefeDeServiciosMenuJefe.TBListadoEje1.Text;
                            usuariosServicios.ObtenerUsuarioPorNombre(ci);
                            // Llama al método de búsqueda en ClienteServicios
                            usuarioDTO = usuariosServicios.ObtenerUsuarioPorNombre(ci);

                            if (usuarioDTO != null)
                            {
                                // Muestra el resultado en el DataGridView
                                listadoEjecutivoYJefeDeServiciosMenuJefe.DataGridViewFuncionarios.DataSource = new List<Usuario> { usuarioDTO };
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado");
                                listadoEjecutivoYJefeDeServiciosMenuJefe.DataGridViewFuncionarios.DataSource = null; // Limpia el DataGridView si no se encuentra
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                        }
                        break;
                    case "btnMostrarFuncionariosJefe":
                        
                        listadoEjecutivoYJefeDeServiciosMenuJefe.DataGridViewFuncionarios.DataSource = listaUsuarios;
                        break;
                    case "btnModificarClientesJefe":
                        clienteDTO.CI = modificacionesDeClientesMenuJefe.TBModClientesCI1.Text;
                        clienteDTO.Nombre = modificacionesDeClientesMenuJefe.TBModClientesNom1.Text;
                        clienteDTO.Apellido = modificacionesDeClientesMenuJefe.TBModClientesApe1.Text;
                        telefonoDTO.CI = modificacionesDeClientesMenuJefe.TBModClientesCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(modificacionesDeClientesMenuJefe.TBModClientesTel1.Text);
                        MessageBox.Show("ModificacionCorrecta");
                        clienteServicios.ModificarCliente(clienteDTO);
                        telefonoServicios.ModificarTelefono(telefonoDTO);
                        modificacionesDeClientesMenuJefe.TBModClientesNom1.Clear();
                        modificacionesDeClientesMenuJefe.TBModClientesApe1.Clear();
                        modificacionesDeClientesMenuJefe.TBModClientesCI1.Clear();
                        modificacionesDeClientesMenuJefe.TBModClientesTel1.Clear();
                        break;
                    case "btnModFuncionarioJefe": //Fin Jefe
                        usuarioDTO.nombreUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosUsu1.Text;
                        usuarioDTO.contraUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosContra1.Text;
                        usuarioDTO.idTipoUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.CBModFuncionariosRol.Text;
                        MessageBox.Show("Modificacion Correcta");
                        usuariosServicios.ModificarUsuario(usuarioDTO);
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosUsu1.Clear();
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosContra1.Clear();
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.CBModFuncionariosRol.Items.Clear();
                        break;
                    case "BTNAltaClienteGer": //Gerente
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
                        try
                        {
                            ci = listadosClientes.TBBuscarClienteCI1.Text;
                            clienteServicios.ObtenerClientePorCI(ci);
                            // Llama al método de búsqueda en ClienteServicios
                            clienteDTO = clienteServicios.ObtenerClientePorCI(ci);

                            if (clienteDTO != null)
                            {
                                // Muestra el resultado en el DataGridView
                                listadosClientes.DataGridViewClientes.DataSource = new List<ClienteDTO> { clienteDTO };
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado");
                                listadosClientes.DataGridViewClientes.DataSource = null; // Limpia el DataGridView si no se encuentra
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                        }
                        break;
                    case "BTNMostrarClientesGer":
                        // Llama al método ListarClientes para obtener la lista de clientes
                        List<ClienteDTO> listaClientes = clienteServicios.ListarClientes();

                        // Asigna la lista al DataGridView
                        listadosClientes.DataGridViewClientes.DataSource = listaClientes;
                        break;
                    case "btnBuscarFuncionariosGer":
                        try
                        {
                            string nomUsu = listadosEjecutivoYJefeDeServicios.TBBuscarFuncionarios1.Text;
                            usuariosServicios.ObtenerUsuarioPorNombre(nomUsu);
                            // Llama al método de búsqueda en ClienteServicios
                            usuarioDTO = usuariosServicios.ObtenerUsuarioPorNombre(nomUsu);

                            if (usuarioDTO != null)
                            {
                                // Muestra el resultado en el DataGridView
                                listadosEjecutivoYJefeDeServicios.DataGridViewFuncionarios.DataSource = new List<Usuario> { usuarioDTO };
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado");
                                listadosEjecutivoYJefeDeServicios.DataGridViewFuncionarios.DataSource = null; // Limpia el DataGridView si no se encuentra
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar el Usuario: " + ex.Message);
                        }
                        break;
                    case "btnMostrarFuncionariosGer":
                        
                        listadosEjecutivoYJefeDeServicios.DataGridViewFuncionarios.DataSource = listaUsuarios;
                        break;
                    case "btnBuscarServicioGer":
















                        break;
                    case "btnMostrarServGer":
                        













                        break;
                    case "btnBuscarVehiculosGer":
                        try
                        {
                            string matricula = listadosVehiculos.TBBuscarVehiculo1.Text;
                            vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);
                            // Llama al método de búsqueda en ClienteServicios
                            vehiculoDTO = vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);

                            if (vehiculoDTO != null)
                            {
                                // Muestra el resultado en el DataGridView
                                listadosVehiculos.DataGridViewVehiculos.DataSource = new List<VehiculoDTO> { vehiculoDTO };
                            }
                            else
                            {
                                MessageBox.Show("Vehiculo no encontrado");
                                listadosVehiculos.DataGridViewVehiculos.DataSource = null; // Limpia el DataGridView si no se encuentra
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar el Vehiculo: " + ex.Message);
                        }
                        break;
                    case "btnMostrarVehiculosGer":
                        List<VehiculoDTO> listaVehiculos = vehiculoServicios.ListarVehiculos();
                        listadosVehiculos.DataGridViewVehiculos.DataSource = listaVehiculos;
                        break;
                    case "btnModificarClientesGer":
                        clienteDTO.CI = modificacionesClientes.TBModClienteCI1.Text;
                        clienteDTO.Nombre = modificacionesClientes.TBModClienteNom1.Text;
                        clienteDTO.Apellido = modificacionesClientes.TBModClienteApe1.Text;
                        telefonoDTO.CI = modificacionesClientes.TBModClienteCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(modificacionesClientes.TBModClienteTel1.Text);
                        MessageBox.Show("ModificacionCorrecta");
                        clienteServicios.ModificarCliente(clienteDTO);
                        telefonoServicios.ModificarTelefono(telefonoDTO);
                        modificacionesClientes.TBModClienteCI1.Clear();
                        modificacionesClientes.TBModClienteNom1.Clear();
                        modificacionesClientes.TBModClienteApe1.Clear();
                        modificacionesClientes.TBModClienteTel1.Clear();
                        break;
                    case "btnModFuncionario":
                        usuarioDTO.nombreUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Text;
                        usuarioDTO.contraUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Text;
                        usuarioDTO.idTipoUsuario = modificacionesEjecutivoYJefeDeServicios.CBModFuncionarioRol.Text;
                        MessageBox.Show("Modificacion Correcta");
                        usuariosServicios.ModificarUsuario(usuarioDTO);
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Clear(); 
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Clear();
                        modificacionesEjecutivoYJefeDeServicios.CBModFuncionarioRol.Items.Clear();
                        break;
                    case "btnModServGer":











                        break;
                    case "btnModificarVehiculosGer":
                        vehiculoDTO.Propietario = modificacionesVehiculos.TBModVehiculosCIClientes1.Text;
                        vehiculoDTO.Matricula = modificacionesVehiculos.TBModVehiculosMatricula1.Text;
                        vehiculoDTO.Marca = modificacionesVehiculos.TBModVehiculosMarca1.Text;
                        vehiculoDTO.Modelo = modificacionesVehiculos.TBModVehiculosModelo1.Text;
                        vehiculoDTO.Tipo = modificacionesVehiculos.CBTipoVehiculo.Text;
                        vehiculoDTO.TIpoCliente = modificacionesVehiculos.CBTipoCliente.Text;
                        MessageBox.Show("Modificacion Correcta");
                        vehiculoServicios.ModificarVehiculo(vehiculoDTO);
                        modificacionesVehiculos.CBTipoCliente.Items.Clear();
                        modificacionesVehiculos.CBTipoVehiculo.Items.Clear();
                        modificacionesVehiculos.TBModVehiculosModelo1.Clear();
                        modificacionesVehiculos.TBModVehiculosMarca1.Clear();
                        modificacionesVehiculos.TBModVehiculosMatricula1.Clear();
                        modificacionesVehiculos.TBModVehiculosCIClientes1.Clear();

                        break;
                    default:
                        MessageBox.Show("¡Botón incorrecto presionado!");
                        break; //Fin Gerente
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
