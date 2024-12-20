﻿using GUI;
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
using static Servicios.LavadoDTO;
using Repositorios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GUI.Diseño.Cajero.DiseñosDeBotonesSubMenusCajero;
using System.IO;

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

        public CompraServicios compraServicios;
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
            compraServicios = CompraServicios.GetInstance();
            cambiarCostosDeServicios = CambiarCostosDeServicios.GetInsance();
            
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
            string servicioSeleccionado;
            string matricula;
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
            bool ingresoCliente = true;
            if (sender is Button button)
            {
                string matricula;
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
                        
                        EmitirFactura();
                        break;
                    case "btnEntregarVehiculos":
                        EntregarVehiculo();
                        break;//Fin CAJERO



                    case "BTNIngresarClienteEje"://Ejecutivo
                        clienteDTO.CI = altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Text;
                        clienteDTO.Nombre = altasClientesEjecutivoDeServicios.TBAltaClienteEjeNom1.Text;
                        clienteDTO.Apellido = altasClientesEjecutivoDeServicios.TBAltaClienteEjeApe1.Text;
                        telefonoDTO.CI = altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientesEjecutivoDeServicios.TBAltaClienteEjeTel1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        ingresoCliente = clienteServicios.AgregarCliente(clienteDTO);
                        if (ingresoCliente)
                        {
                            telefonoServicios.AgregarTelefono(telefonoDTO);
                            altasClientesEjecutivoDeServicios.TBAltaClienteEjeCI1.Clear();
                            altasClientesEjecutivoDeServicios.TBAltaClienteEjeNom1.Clear();
                            altasClientesEjecutivoDeServicios.TBAltaClienteEjeApe1.Clear();
                            altasClientesEjecutivoDeServicios.TBAltaClienteEjeTel1.Clear();
                        }
                        break;
                    case "BTNAltaVehiculoEje"://es el alta de servicios




                        ProcesarAltaServicioEjecutivo();







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
                        altasVehiculosEjecutivoDeServicios.CBAltaVehiculoTipoVehiculo1.SelectedIndex = -1;
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculo1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMatr1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoMarca1.Clear();
                        altasVehiculosEjecutivoDeServicios.TBAltaVehiculoModelo1.Clear();
                        
                        break;
                    case "btnModificarClientesEje":
                        clienteDTO.CI = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Text;
                        clienteDTO.Nombre = modificacionesDeClientesMenuEjecutivoDeServicios.TbModClienteNomEje1.Text;
                        clienteDTO.Apellido = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteApeEje1.Text;
                        telefonoDTO.CI = modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteTelEje1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        ingresoCliente = clienteServicios.ModificarCliente(clienteDTO);
                        if (ingresoCliente) {
                            telefonoServicios.ModificarTelefono(telefonoDTO);
                            modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteCIEje1.Clear();
                            modificacionesDeClientesMenuEjecutivoDeServicios.TbModClienteNomEje1.Clear();
                            modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteApeEje1.Clear();
                            modificacionesDeClientesMenuEjecutivoDeServicios.TBModClienteTelEje1.Clear();
                        }
                        break;//Fin Ejecutivo
                    case "btnIngresarClienteJefe"://Jefe
                        clienteDTO.CI = altasClientesJefe.TBAltaClienteCI1.Text;
                        clienteDTO.Nombre = altasClientesJefe.TBAltaClienteNom1.Text;
                        clienteDTO.Apellido = altasClientesJefe.TBAltaClienteApe1.Text;
                        telefonoDTO.CI = altasClientesJefe.TBAltaClienteCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientesJefe.TBAltaClienteTel1.Text);
                        MessageBox.Show("Cliente Ingresado");
                        ingresoCliente = clienteServicios.AgregarCliente(clienteDTO);
                        if (ingresoCliente)
                        {
                            telefonoServicios.AgregarTelefono(telefonoDTO);
                            altasClientesJefe.TBAltaClienteCI1.Clear();
                            altasClientesJefe.TBAltaClienteNom1.Clear();
                            altasClientesJefe.TBAltaClienteApe1.Clear();
                            altasClientesJefe.TBAltaClienteTel1.Clear();
                        }
                        break;
                    case "btnIngresarFuncionarioGer"://AltaUsuario Jefe de servicios
                        usuarioDTO.nombreUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioNom1.Text;
                        usuarioDTO.contraUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioContra1.Text;
                        usuarioDTO.idTipoUsuario = altasEjecutivoYJefeDeServiciosMenuJefe.CBAltaFuncionarioRol.Text;
                        MessageBox.Show("Usuario Ingresado Correctamente");
                        usuariosServicios.AgregarUsuario(usuarioDTO);
                        altasEjecutivoYJefeDeServiciosMenuJefe.CBAltaFuncionarioRol.SelectedIndex = -1;
                        altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioNom1.Clear();
                        altasEjecutivoYJefeDeServiciosMenuJefe.TBAltaFuncionarioContra1.Clear();
                        
                        break;
                    case "btnIngresarServicios":




                        ProcesarAltaServicioJefe();






                        break;
                    case "btnIngresarVehiculosJefe":
                        vehiculoDTO.Propietario = altasVehiculosJefe.TBIngresoVehiculoCICliente1.Text;
                        vehiculoDTO.Matricula = altasVehiculosJefe.TBIngresoVehiculoMatr1.Text;
                        vehiculoDTO.Marca = altasVehiculosJefe.TBIngresoVehiculoMarca1.Text;
                        vehiculoDTO.Modelo = altasVehiculosJefe.TBIngresoVehiculoModelo1.Text;
                        vehiculoDTO.Tipo = altasVehiculosJefe.CBTipoVehiculo.Text;
                        vehiculoDTO.TIpoCliente = altasVehiculosJefe.CBTipoCliente.Text;
                        MessageBox.Show("Vehiculo Ingresado Correctamente");
                        altasVehiculosJefe.CBTipoCliente.SelectedIndex = -1;
                        altasVehiculosJefe.CBTipoVehiculo.SelectedIndex = -1;
                        vehiculoServicios.AgregarVehiculo(vehiculoDTO);
                        altasVehiculosJefe.TBIngresoVehiculoCICliente1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoMatr1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoMarca1.Clear();
                        altasVehiculosJefe.TBIngresoVehiculoModelo1.Clear();
                        
                        break;
                    case "btnBajaFuncionario":
                        string nomUsuad = bajasEjecutivoYJefeDeServiciosMenuJefe.TBBajaUsuNom1.Text;

                        MessageBox.Show("Baja Confirmada"+ nomUsuad);
                        usuariosServicios.EliminarEjecutivoOperadorCajero(nomUsuad);
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
                        ingresoCliente = clienteServicios.ModificarCliente(clienteDTO);
                        if (ingresoCliente)
                        {
                            telefonoServicios.ModificarTelefono(telefonoDTO);
                            modificacionesDeClientesMenuJefe.TBModClientesNom1.Clear();
                            modificacionesDeClientesMenuJefe.TBModClientesApe1.Clear();
                            modificacionesDeClientesMenuJefe.TBModClientesCI1.Clear();
                            modificacionesDeClientesMenuJefe.TBModClientesTel1.Clear();
                        }
                        break;
                    case "btnModFuncionarioJefe": //Fin Jefe
                        usuarioDTO.nombreUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosUsu1.Text;
                        usuarioDTO.contraUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosContra1.Text;
                        usuarioDTO.idTipoUsuario = modificacionesEjecutivoYJefeDeServiciosMenuJefe.CBModFuncionariosRol.Text;
                        MessageBox.Show("Modificacion Correcta");
                        usuariosServicios.ModificarUsuarioJefe(usuarioDTO);
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosUsu1.Clear();
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.TBModFuncionariosContra1.Clear();
                        modificacionesEjecutivoYJefeDeServiciosMenuJefe.CBModFuncionariosRol.SelectedIndex = 0;


                        break;
                    case "BTNAltaClienteGer": //Gerente
                        
                        clienteDTO.CI = altasClientes.TBAltaClienteGerCI1.Text;
                        clienteDTO.Nombre = altasClientes.TBAltaClienteGerNom1.Text;
                        clienteDTO.Apellido = altasClientes.TBAltaClienteGerApe1.Text;
                        telefonoDTO.CI = altasClientes.TBAltaClienteGerCI1.Text;
                        telefonoDTO.Telefono = Convert.ToInt32(altasClientes.TBAltaClienteGerTel1.Text);
                        MessageBox.Show("Cliente Ingresado Con exito");
                        ingresoCliente = clienteServicios.AgregarCliente(clienteDTO);
                        if (ingresoCliente) {
                            telefonoServicios.AgregarTelefono(telefonoDTO);
                            altasClientes.TBAltaClienteGerApe1.Clear();
                            altasClientes.TBAltaClienteGerCI1.Clear();
                            altasClientes.TBAltaClienteGerNom1.Clear();
                            altasClientes.TBAltaClienteGerTel1.Clear();
                        }
                        break;
                    case "BTNAltaUsuarioGer":

                        usuarioDTO.nombreUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Text;
                        usuarioDTO.contraUsuario = altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Text;
                        usuarioDTO.idTipoUsuario = altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.Text;
                        MessageBox.Show("Usuario Ingresado Correctamente");
                        altasEjecutivoYJefeDeServicios.CBAltaTipoUsu1.SelectedIndex = -1;
                        usuariosServicios.AgregarUsuario(usuarioDTO);
                        altasEjecutivoYJefeDeServicios.TBAltaUsuNom1.Clear();
                        altasEjecutivoYJefeDeServicios.TBAltaUsuPass1.Clear();
                        

                        break;
                    case "BTNAltaServGer":
                        ProcesarAltaServicioGerente();

                        break;
                    case "btnIngresarVehiculosGer":
                        vehiculoDTO.Propietario = altasVehiculos.TBAltaVehiculoCICliente1.Text;
                        vehiculoDTO.Matricula = altasVehiculos.TBAltaVehiculoMatr1.Text;
                        vehiculoDTO.Marca = altasVehiculos.TBAltaVehiculoMarca1.Text;
                        vehiculoDTO.Modelo = altasVehiculos.TBAltaVehiculoModelo1.Text;
                        vehiculoDTO.Tipo = altasVehiculos.CBTipoVehiculo.Text;
                        vehiculoDTO.TIpoCliente = altasVehiculos.CBTipoCliente.Text;
                        MessageBox.Show("Vehiculo Ingresado Correctamente");
                        altasVehiculos.CBTipoCliente.SelectedIndex = -1;
                        altasVehiculos.CBTipoCliente.SelectedIndex = -1;
                        vehiculoServicios.AgregarVehiculo(vehiculoDTO);
                        altasVehiculos.TBAltaVehiculoCICliente1.Clear();
                        altasVehiculos.TBAltaVehiculoMatr1.Clear();
                        altasVehiculos.TBAltaVehiculoMarca1.Clear();
                        altasVehiculos.TBAltaVehiculoModelo1.Clear();
                        
                        break;
                    case "BTNEliminarFunciGer":
                        string nombreUsuario= bajasEjecutivoYJefeDeServicios.TBNomBorrarFunci1.Text;
                        MessageBox.Show("Funcionario Eliminado Correctamente: " + nombreUsuario);
                        usuariosServicios.EliminarUsuario(nombreUsuario);
                        bajasEjecutivoYJefeDeServicios.TBNomBorrarFunci1.Clear();
                        break;
                    case "BTNModCostServGer":



                        if (cambiarCostosDeServicios == null)
                        {
                            MessageBox.Show("cambiarCostosDeServicios no está inicializado.");
                            return;
                        }

                        int nuevoPrecio;
                        int id = 0;

                        // Validar el precio ingresado
                        if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDCosto1.Text, out nuevoPrecio) || nuevoPrecio <= 0)
                        {
                            MessageBox.Show("Ingrese un valor válido para el precio.");
                            return;
                        }

                        string tipoServicio = "";

                        // Asignar tipo de servicio en función de los radio buttons seleccionados
                        if (cambiarCostosDeServicios.RBParking.Checked)
                        {
                            tipoServicio = "parking";
                            if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDServ1.Text, out id) || id <= 0)
                            {
                                MessageBox.Show("Ingrese un valor válido para el ID de servicio de parking.");
                                return;
                            }
                        }
                        else if (cambiarCostosDeServicios.RBLavado.Checked)
                        {
                            tipoServicio = "lavado";
                            if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDServ1.Text, out id) || id < 1 || id > 5)
                            {
                                MessageBox.Show("El ID de servicio para Lavado debe estar entre 1 y 5.");
                                return;
                            }
                        }
                        else if (cambiarCostosDeServicios.RBAlineacion.Checked)  // Asegúrate de que el RadioButton "Taller" esté nombrado correctamente aquí.
                        {
                            tipoServicio = "taller";

                            string servicioSeleccionado = cambiarCostosDeServicios.ComboBoxServicio.SelectedItem?.ToString();
                            id = ObtenerIdServicioTaller(servicioSeleccionado);

                            if (id == 0)
                            {
                                MessageBox.Show("Por favor, seleccione un tipo de servicio de taller válido.");
                                return;
                            }

                            // Reflejar el ID calculado en el campo del formulario para que el usuario lo vea
                            cambiarCostosDeServicios.TBCostoServIDServ1.Text = id.ToString();
                        }
                        else if (cambiarCostosDeServicios.RBNeumaticos.Checked)
                        {
                            tipoServicio = "neumatico";
                            if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDNeumatico1.Text, out id) || id < 1 || id > 9)
                            {
                                MessageBox.Show("El ID de neumático debe estar entre 1 y 9.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione un tipo de servicio.");
                            return;
                        }

                        // Llamar al método en el Controlador para actualizar el costo del servicio
                        if (Controlador.GetInstance().ActualizarCostoServicio(tipoServicio, id, nuevoPrecio))
                        {
                            MessageBox.Show("Precio actualizado correctamente.");
                            // Limpia los campos después de actualizar el precio
                            cambiarCostosDeServicios.TBCostoServIDServ1.Clear();
                            cambiarCostosDeServicios.TBCostoServIDCosto1.Clear();
                            cambiarCostosDeServicios.TBCostoServIDNeumatico1.Clear();
                            cambiarCostosDeServicios.TBCostoServIDPlaza1.Clear();

                            // Restablece el ComboBox
                            cambiarCostosDeServicios.ComboBoxServicio.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el precio. Verifique los datos ingresados.");
                        }



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



                        ProcesarBusquedaServicio();












                        break;
                    case "btnMostrarServGer":





                        ProcesarListadoServicios();








                        break;
                    case "btnBuscarVehiculosGer":
                        try
                        {
                            matricula = listadosVehiculos.TBBuscarVehiculo1.Text;
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
                        ingresoCliente = clienteServicios.ModificarCliente(clienteDTO);
                        if (ingresoCliente) {
                            telefonoServicios.ModificarTelefono(telefonoDTO);
                            modificacionesClientes.TBModClienteCI1.Clear();
                            modificacionesClientes.TBModClienteNom1.Clear();
                            modificacionesClientes.TBModClienteApe1.Clear();
                            modificacionesClientes.TBModClienteTel1.Clear();
                        }
                        break;
                    case "btnModFuncionario":
                        usuarioDTO.nombreUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Text;
                        usuarioDTO.contraUsuario = modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Text;
                        usuarioDTO.idTipoUsuario = modificacionesEjecutivoYJefeDeServicios.CBModFuncionarioRol.Text;
                        MessageBox.Show("Modificacion Correcta");
                        usuariosServicios.ModificarUsuario(usuarioDTO);
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioNom1.Clear(); 
                        modificacionesEjecutivoYJefeDeServicios.TBModFuncionarioContra1.Clear();
                        
                        break;
                    case "btnModServGer":


                        ProcesarModificacionServicio();








                        break;
                    case "btnModificarVehiculosGer":
                        ModificarVehiculosGer();

                        break;
                    default:
                        MessageBox.Show("¡Botón incorrecto presionado!");
                        break; //Fin Gerente
                }
            }
        }

        private void ModificarVehiculosGer()
        {
            vehiculoDTO.Propietario = modificacionesVehiculos.TBModVehiculosCIClientes1.Text;
            vehiculoDTO.Matricula = modificacionesVehiculos.TBModVehiculosMatricula1.Text;
            vehiculoDTO.Marca = modificacionesVehiculos.TBModVehiculosMarca1.Text;
            vehiculoDTO.Modelo = modificacionesVehiculos.TBModVehiculosModelo1.Text;
            vehiculoDTO.Tipo = modificacionesVehiculos.CBTipoVehiculo.Text;
            vehiculoDTO.TIpoCliente = modificacionesVehiculos.CBTipoCliente.Text;
            MessageBox.Show("Modificacion Correcta");
            vehiculoServicios.ModificarVehiculo(vehiculoDTO);

            modificacionesVehiculos.TBModVehiculosModelo1.Clear();
            modificacionesVehiculos.TBModVehiculosMarca1.Clear();
            modificacionesVehiculos.TBModVehiculosMatricula1.Clear();
            modificacionesVehiculos.TBModVehiculosCIClientes1.Clear();
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
        private void ProcesarAltaServicioGerente()
        {
            RegistrarServicio(altasServicios, "gerente");
        }

        private void ProcesarAltaServicioJefe()
        {
            RegistrarServicio(altasServiciosJefe, "jefe");
        }

        private void ProcesarAltaServicioEjecutivo()
        {
            RegistrarServicio(altasServiciosEjecutivoDeServicios, "ejecutivo");
            
        }

        // Método general para registrar un servicio
        // Método general para registrar un servicio
        private void RegistrarServicio(dynamic formulario, string rol)
        {
            string tipoServicio = ObtenerTipoServicioSeleccionado(formulario);
            
            if (string.IsNullOrEmpty(tipoServicio))
            {
                MessageBox.Show("Por favor, seleccione un tipo de servicio.");
                return;
            }

            // Obtener datos comunes del formulario
            string matricula = formulario.TBAltaServGerMatr1.Text;
            string fechaInicioTexto = formulario.MTBAltaServGerFechaInicio.Text;
            string nombreFuncionario = formulario.TBAltaServGerNomFuncionario1.Text;

            // Validaciones comunes
            if (string.IsNullOrWhiteSpace(fechaInicioTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if (!DateTime.TryParseExact(fechaInicioTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaInicio))
            {
                MessageBox.Show("La fecha de inicio es inválida. Formato correcto: dd/MM/yyyy HH:mm");
                return;
            }

            // Verificar si el servicio requiere fecha de fin
            DateTime fechaFin = fechaInicio;
            if (tipoServicio == "parking") // Solo requerimos la fecha de fin para el servicio de parking
            {
                string fechaFinTexto = formulario.MTBAltaServGerFechaFin.Text;

                if (string.IsNullOrWhiteSpace(fechaFinTexto))
                {
                    MessageBox.Show("Por favor, ingrese la fecha de fin para el servicio de parking.");
                    return;
                }

                if (!DateTime.TryParseExact(fechaFinTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFinParsed))
                {
                    MessageBox.Show("La fecha de fin es inválida. Formato correcto: dd/MM/yyyy HH:mm");
                    return;
                }

                if (fechaFinParsed <= fechaInicio)
                {
                    MessageBox.Show("La fecha de fin debe ser mayor que la fecha de inicio.");
                    return;
                }

                fechaFin = fechaFinParsed;
            }

            // Obtener el vehículo por matrícula
            

            decimal precioBase = 0m;
            decimal precioFinal = 0m;

            switch (tipoServicio)
            {
                case "parking":
                    vehiculoDTO = vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);
                    if (vehiculoDTO == null)
                    {
                        MessageBox.Show("No se encontró un vehículo con la matrícula proporcionada.");
                        return;
                    }
                    string numPlazaTexto = formulario.TBAltaServGerNumPlaza1.Text;

                    if (string.IsNullOrWhiteSpace(matricula) || string.IsNullOrWhiteSpace(numPlazaTexto))
                    {
                        MessageBox.Show("Por favor, complete el número de plaza.");
                        return;
                    }

                    if (!int.TryParse(numPlazaTexto, out int numPlaza))
                    {
                        MessageBox.Show("El número de plaza debe ser un número entero.");
                        return;
                    }

                    // Calcular precio base
                    precioBase = CalcularPrecioBaseServicio("parking", vehiculoDTO.Tipo, fechaInicio, fechaFin);

                    // Calcular precio final con descuentos
                    precioFinal = CalcularPrecioConDescuento(precioBase, vehiculoDTO.TIpoCliente, "parking", fechaInicio, fechaFin, matricula, vehiculoDTO.Tipo);

                    // Registrar en Ocupa
                    OcupaDTO ocupaDTO = new OcupaDTO
                    {
                        Matricula = matricula,
                        FechaEntrada = fechaInicio,
                        FechaSalida = fechaFin,
                        NumPlaza = numPlaza
                    };

                    bool ocupaAgregado = ocupaServicios.AgregarOcupa(ocupaDTO);

                    if (ocupaAgregado)
                    {
                        // Registrar en Parking
                        ParkingDTO parkingDTO = new ParkingDTO
                        {
                            Precio = (int)Math.Round(precioFinal),
                            ParaEntregarEstado = ParkingDTO.ParaEntregar.no,
                            FechaEntrada = fechaInicio,
                            FechaSalida = fechaFin,
                            Matricula = matricula,
                            NumPlaza = numPlaza,
                            Funcionario = nombreFuncionario
                        };

                        bool parkingAgregado = parkingServicios.AgregarParking(parkingDTO);

                        if (parkingAgregado)
                        {
                            MessageBox.Show($"Servicio de parking agregado correctamente. Precio: {precioFinal:C}");
                            LimpiarCamposAltas(formulario);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el servicio de parking.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la ocupación de la plaza.");
                    }
                    break;

                case "lavado":
                    vehiculoDTO = vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);
                    if (vehiculoDTO == null)
                    {
                        MessageBox.Show("No se encontró un vehículo con la matrícula proporcionada.");
                        return;
                    }
                    if ( ! string.IsNullOrWhiteSpace(matricula)) {
                        // Registrar servicio de lavado en Recibe
                        RecibeDTO recibeDTO = new RecibeDTO
                        {
                            Matricula = matricula,
                            FechaServicio = fechaInicio,
                            Funcionario = nombreFuncionario,
                            IdServicio = ObtenerIdServicioLavado(vehiculoDTO.Tipo)
                        };

                        bool lavadoAgregado = recibeServicios.AgregarRecibe(recibeDTO);

                        if (lavadoAgregado)
                        {
                            MessageBox.Show($"Servicio de lavado agregado correctamente.");
                            LimpiarCamposAltas(formulario);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el servicio de lavado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los campos solicitados");
                    }
                    break;

                case "taller":
                    vehiculoDTO = vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);
                    if (vehiculoDTO == null)
                    {
                        MessageBox.Show("No se encontró un vehículo con la matrícula proporcionada.");
                        return;
                    }
                    // Obtener el tipo de servicio seleccionado en el ComboBox y asignar el ID automáticamente
                    string servicioSeleccionado = formulario.ComboBoxServicio.SelectedItem?.ToString();
                    int idServicio = ObtenerIdServicioTaller(servicioSeleccionado);
                    if ( ! string.IsNullOrWhiteSpace(matricula)) {
                        if (idServicio == 0)
                        {
                            MessageBox.Show("Por favor, seleccione un tipo de servicio de taller válido.");
                            return;
                        }

                        // Calcular precio base
                        precioBase = CalcularPrecioBaseServicio("taller", vehiculoDTO.Tipo, fechaInicio, fechaFin, idServicio);

                        // Calcular precio final con descuentos
                        precioFinal = CalcularPrecioConDescuento(precioBase, vehiculoDTO.TIpoCliente, "taller", fechaInicio, fechaFin, matricula, vehiculoDTO.Tipo);

                        // Registrar servicio de taller en Recibe
                        RecibeDTO recibeDTOTaller = new RecibeDTO
                        {
                            Matricula = matricula,
                            FechaServicio = fechaInicio,
                            Funcionario = nombreFuncionario,
                            IdServicio = idServicio
                        };

                        bool tallerAgregado = recibeServicios.AgregarRecibe(recibeDTOTaller);

                        if (tallerAgregado)
                        {
                            MessageBox.Show($"Servicio de taller '{servicioSeleccionado}' agregado correctamente.");
                            LimpiarCamposAltas(formulario);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el servicio de taller.");
                        }
                    }
                    break;

                case "compra_neumaticos":
                    
                    string idNeumaticoTexto = formulario.TBAltaServGerIDNeum1.Text;
                    string idCliente = formulario.TBAltaServGerIDCliente1.Text;

                    

                    if (string.IsNullOrWhiteSpace(idNeumaticoTexto) || string.IsNullOrWhiteSpace(idCliente))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }

                    if (!int.TryParse(idNeumaticoTexto, out int idNeumatico))
                    {
                        MessageBox.Show("El ID del neumático debe ser un número entero.");
                        return;
                    }

                    // Obtener precio base del neumático
                    NeumaticoDTO neumaticoDTO = neumaticoServicios.ObtenerNeumaticoPorId(idNeumatico);
                    if (neumaticoDTO == null)
                    {
                        MessageBox.Show("No se encontró un neumático con el ID proporcionado.");
                        return;
                    }

                    

                    // Registrar compra
                    CompraDTO compraDTO = new CompraDTO
                    {
                        FechaVenta = fechaInicio,
                        IdNeumatico = idNeumatico,
                        Funcionario = nombreFuncionario,
                        Cliente = idCliente
                    };

                    bool compraAgregada = compraServicios.AgregarCompra(compraDTO);

                    if (compraAgregada)
                    {
                        MessageBox.Show($"Compra de neumático agregada correctamente.");
                        LimpiarCamposAltas(formulario);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la compra de neumático.");
                    }
                    break;

                default:
                    MessageBox.Show("Tipo de servicio no reconocido.");
                    break;
            }
        }


        private int ObtenerIdServicioTaller(string servicioSeleccionado)
        {
            if (string.IsNullOrWhiteSpace(servicioSeleccionado))
            {
                return 0; // Devuelve 0 si la selección está vacía
            }

            // Normalizamos el texto a minúsculas y eliminamos espacios extra
            servicioSeleccionado = servicioSeleccionado.Trim().ToLower();

            switch (servicioSeleccionado)
            {
                case "montaje neumatico":
                    return 6;
                case "alineacion 1 tren":
                    return 7;
                case "alineacion":
                    return 8;
                case "balanceo auto + valvula":
                    return 9;
                case "alineacion 2 trenes":
                    return 10;
                case "pack alineacion":
                    return 11;
                case "balanceo camioneta + valvula":
                    return 12;
                default:
                    return 0; // Si el valor no coincide con ninguno, devuelve 0
            }
        }

        // Método auxiliar para obtener el tipo de servicio seleccionado en los formularios
        private string ObtenerTipoServicioSeleccionado(dynamic formulario)
        {
            if (formulario.RBParking.Checked)
            {
                return "parking";
            }
            else if (formulario.RBLavado.Checked)
            {
                return "lavado";
            }
            else if (formulario.RBAlineacion.Checked)
            {
                return "taller";
            }
            else if (formulario.RBNeumaticos.Checked)
            {
                return "compra_neumaticos";
            }
            else
            {
                return null;
            }
        }

        // Método para limpiar los campos del formulario de altas
        private void LimpiarCamposAltas(dynamic formulario)
        {
            formulario.TBAltaServGerMatr1.Clear();
            formulario.MTBAltaServGerFechaInicio.Clear();
            formulario.MTBAltaServGerFechaFin.Clear();
            formulario.TBAltaServGerNumPlaza1.Clear();
            formulario.TBAltaServGerNomFuncionario1.Clear();
            formulario.TBAltaServGerID1.Clear();
            formulario.TBAltaServGerIDNeum1.Clear();
            formulario.TBAltaServGerIDCliente1.Clear();
            formulario.ComboBoxServicio.SelectedIndex = -1;
        }


        // Método para calcular el precio base del servicio
        private decimal CalcularPrecioBaseServicio(string tipoServicio, string tipoVehiculo, DateTime fechaInicio, DateTime fechaFin, int idServicio = 0)
        {
            decimal precioBase = 0m;

            if (tipoServicio.ToLower() == "parking")
            {
                decimal precioPorHora = ObtenerPrecioPorHora(tipoVehiculo);
                double horasEstancia = (fechaFin - fechaInicio).TotalHours;
                precioBase = precioPorHora * (decimal)horasEstancia;
            }
            else if (tipoServicio.ToLower() == "lavado")
            {
                precioBase = ObtenerPrecioBaseLavado(tipoVehiculo);
            }
            else if (tipoServicio.ToLower() == "taller")
            {
                precioBase = ObtenerPrecioServicioTaller(idServicio);
            }
            else if (tipoServicio.ToLower() == "compra_neumaticos")
            {
                // El precio base ya fue obtenido anteriormente
            }

            return precioBase;
        }

        // Método para calcular el precio con descuento
        private decimal CalcularPrecioConDescuento(decimal precioBase, string tipoCliente, string tipoServicio, DateTime fechaInicio, DateTime fechaFin, string matricula, string tipoVehiculo)
        {
            decimal precioFinal = precioBase;

            if (tipoServicio == "parking")
            {
                if (tipoCliente == "mensual")
                {
                    // Descuento del 10% para clientes mensuales
                    precioFinal *= 0.9m;

                    // Descuento adicional del 20% si la duración es de 10 o más días sin uso
                    TimeSpan duracion = fechaFin - fechaInicio;
                    if (duracion.TotalDays >= 10)
                    {
                        precioFinal *= 0.8m;
                    }
                }
                else if (tipoCliente == "sistematico")
                {
                    // Descuento del 7% para clientes sistemáticos
                    precioFinal *= 0.93m;
                }
            }

            return precioFinal;
        }

        // Método para calcular el precio por hora según el tipo de vehículo
        private decimal ObtenerPrecioPorHora(string tipoVehiculo)
        {
            switch (tipoVehiculo.ToLower())
            {
                case "moto":
                    return 50m;
                case "auto":
                    return 100m;
                case "camioneta":
                    return 120m;
                case "pequeño camion":
                case "pequeño utilitario":
                    return 150m;
                default:
                    return 0m;
            }
        }

        // Método para obtener el precio base del lavado según el tipo de vehículo
        private decimal ObtenerPrecioBaseLavado(string tipoVehiculo)
        {
            switch (tipoVehiculo.ToLower())
            {
                case "moto":
                    return 200m;
                case "auto":
                    return 500m;
                case "camioneta":
                case "pequeño camion":
                case "pequeño utilitario":
                    return 700m;
                default:
                    return 0m;
            }
        }

        // Método para obtener el precio del servicio de taller según el ID del servicio
        private decimal ObtenerPrecioServicioTaller(int idServicio)
        {
            
            return 1000m;
        }

        // Método para obtener el ID del servicio de lavado según el tipo de vehículo
        private int ObtenerIdServicioLavado(string tipoVehiculo)
        {
            
            return 1;
        }

        // Método para calcular los días no usados por el cliente
        private int CalcularDiasNoUsados(DateTime fechaInicio, DateTime fechaFin, string matricula, string tipoServicio)
        {
            
            return 0;
        }

        // Método para verificar si el cliente ya recibió el lavado gratis del mes
        private bool VerificarLavadoGratis(string matricula, DateTime fecha)
        {
            
            return false;
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            altasServicios.TBAltaServGerMatr1.Clear();
            altasServicios.MTBAltaServGerFechaInicio.Clear();
            altasServicios.MTBAltaServGerFechaFin.Clear();
            altasServicios.TBAltaServGerNumPlaza1.Clear();
            altasServicios.TBAltaServGerNomFuncionario1.Clear();
            altasServicios.TBAltaServGerID1.Clear();
            altasServicios.TBAltaServGerIDNeum1.Clear();
            altasServicios.TBAltaServGerIDCliente1.Clear();
        }
        // Método para procesar la modificación de servicios
        private void ProcesarModificacionServicio()
        {
            if (modificacionesServicios == null)
            {
                MessageBox.Show("El formulario de modificaciones no está inicializado.");
                return;
            }

            // Verificar cada control individual antes de acceder a sus valores
            if (modificacionesServicios.RBParking == null || modificacionesServicios.RBLavado == null ||
                modificacionesServicios.RBAlineacion == null || modificacionesServicios.RBNeumaticos == null)
            {
                MessageBox.Show("Algunos controles de tipo de servicio no están inicializados.");
                return;
            }

            if (modificacionesServicios.RBParking.Checked)
            {
                ModificarServicio("parking");
            }
            else if (modificacionesServicios.RBLavado.Checked)
            {
                ModificarServicio("lavado");
            }
            else if (modificacionesServicios.RBAlineacion.Checked)
            {
                ModificarServicio("taller");
            }
            else if (modificacionesServicios.RBNeumaticos.Checked)
            {
                ModificarServicio("compra_neumaticos");
            }
            // ... otros servicios ...
        }

        // Método para modificar un servicio
        private void ModificarServicio(string tipoServicio)
        {
            // Obtener datos comunes del formulario
            string matricula = modificacionesServicios.TBModServMatr1.Text;
            string fechaTexto = modificacionesServicios.MTBModServFechaInicio.Text;
            string nombreFuncionario = modificacionesServicios.TBModServFuncionario1.Text;

            // Validaciones comunes
            if (tipoServicio != "compra_neumaticos" && string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("Por favor, ingrese la matrícula del vehículo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(fechaTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios para modificar.");
                return;
            }

            if (!DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaServicio))
            {
                MessageBox.Show("La fecha es inválida. Formato correcto: dd/MM/yyyy HH:mm");
                return;
            }

            switch (tipoServicio)
            {
                case "parking":
                    int idParking = Convert.ToInt32(modificacionesServicios.TextBoxIDParking.Text);
                    string fechaFinTexto = modificacionesServicios.MTBModServFechaFin.Text;

                    if (string.IsNullOrWhiteSpace(fechaFinTexto) ||
                        !DateTime.TryParseExact(fechaFinTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFin))
                    {
                        MessageBox.Show("La fecha de fin es inválida. Formato correcto: dd/MM/yyyy HH:mm");
                        return;
                    }

                    // Verificar si el vehículo existe
                    vehiculoDTO = vehiculoServicios.ObtenerVehiculoPorMatricula(matricula);
                    if (vehiculoDTO == null)
                    {
                        MessageBox.Show("No se encontró un vehículo con la matrícula proporcionada.");
                        return;
                    }

                    // Calcular el precio automáticamente
                    decimal precioBase = CalcularPrecioBaseServicio("parking", vehiculoDTO.Tipo, fechaServicio, fechaFin);
                    int numPlaza = Convert.ToInt32(modificacionesServicios.TBModServNumPlaza1.Text);
                    ParkingDTO parkingDTO = new ParkingDTO
                    {
                        IdParking = idParking,
                        Matricula = matricula,
                        FechaEntrada = fechaServicio,
                        FechaSalida = fechaFin,
                        NumPlaza = numPlaza,
                        Precio = (int)Math.Round(precioBase),
                        ParaEntregarEstado = ParkingDTO.ParaEntregar.no, // Mantener 'ParaEntregar' en 'no'
                        Funcionario = nombreFuncionario
                    };

                    bool parkingModificado = parkingServicios.ModificarParking(parkingDTO);

                    if (parkingModificado)
                    {
                        MessageBox.Show("Servicio de parking modificado correctamente.");
                        LimpiarCamposModificaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el servicio de parking.");
                    }
                    break;

                case "lavado":

                    string idServicioLavado = modificacionesServicios.TBModServIDServ1.Text;
                    if (Convert.ToInt32(idServicioLavado) < 1 || Convert.ToInt32(idServicioLavado) > 5)
                    {
                        MessageBox.Show("El ID de servicio para Lavado debe estar entre 1 y 5.");
                        return;
                    }
                    RecibeDTO recibeDTO = new RecibeDTO
                    {
                        IdServicio = Convert.ToInt32(idServicioLavado),
                        Matricula = matricula,
                        FechaServicio = fechaServicio,
                        Funcionario = nombreFuncionario
                    };

                    bool lavadoModificado = recibeServicios.ModificarRecibe(recibeDTO);

                    if (lavadoModificado)
                    {
                        MessageBox.Show("Servicio de lavado modificado correctamente.");
                        LimpiarCamposModificaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el servicio de lavado.");
                    }
                    break;

                case "taller":
                    string servicioSeleccionado = modificacionesServicios.ComboBoxServicio.SelectedItem?.ToString();
                    int idServicio = ObtenerIdServicioTaller(servicioSeleccionado);

                    RecibeDTO tallerDTO = new RecibeDTO
                    {
                        IdServicio = Convert.ToInt32(idServicio),
                        Matricula = matricula,
                        FechaServicio = fechaServicio,
                        Funcionario = nombreFuncionario
                    };

                    bool tallerModificado = recibeServicios.ModificarRecibe(tallerDTO);

                    if (tallerModificado)
                    {
                        MessageBox.Show("Servicio de taller modificado correctamente.");
                        LimpiarCamposModificaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el servicio de taller.");
                    }
                    break;

                case "compra_neumaticos":
                    string idNeumaticoTexto = modificacionesServicios.TBModServIDNeumatico1.Text;
                    string idCliente = modificacionesServicios.TBModServIDClientes1.Text;

                    if (string.IsNullOrWhiteSpace(idNeumaticoTexto) || string.IsNullOrWhiteSpace(idCliente))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios para modificar.");
                        return;
                    }

                    CompraDTO compraDTO = new CompraDTO
                    {
                        FechaVenta = fechaServicio,
                        IdNeumatico = Convert.ToInt32(idNeumaticoTexto),
                        Funcionario = nombreFuncionario,
                        Cliente = idCliente
                    };

                    bool compraModificada = compraServicios.ModificarCompra(compraDTO);

                    if (compraModificada)
                    {
                        MessageBox.Show("Compra de neumáticos modificada correctamente.");
                        LimpiarCamposModificaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la compra de neumáticos.");
                    }
                    break;

                default:
                    MessageBox.Show("Tipo de servicio no reconocido para modificación.");
                    break;
            }
        }

        // Método para procesar la búsqueda de servicios
        private void ProcesarBusquedaServicio()
        {
            string idServicioTexto = listadosServicios.TBBuscarServicio1.Text;

            if (string.IsNullOrWhiteSpace(idServicioTexto))
            {
                MessageBox.Show("Por favor, ingrese el ID del servicio para buscar.");
                return;
            }

            if (!int.TryParse(idServicioTexto, out int idServicio))
            {
                MessageBox.Show("El ID del servicio debe ser un número entero.");
                return;
            }

            // Asumiendo que se selecciona el tipo de servicio desde algún control en el formulario
            string tipoServicio = "parking"; // Por ejemplo

            BuscarServicio(tipoServicio, idServicio);
        }

        // Método para buscar un servicio
        private void BuscarServicio(string tipoServicio, int idServicio)
        {
            switch (tipoServicio)
            {
                case "parking":
                    ParkingDTO parkingDTO = parkingServicios.ObtenerParkingPorId(idServicio);
                    if (parkingDTO != null)
                    {
                        // Mostrar los datos en el DataGridView
                        listadosServicios.DataGridViewServicio.DataSource = new List<ParkingDTO> { parkingDTO };
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un servicio de parking con ese ID.");
                    }
                    break;

                case "lavado":
                    RecibeDTO recibeDTO = recibeServicios.ObtenerRecibePorIdServicio(idServicio);
                    if (recibeDTO != null)
                    {
                        listadosServicios.DataGridViewServicio.DataSource = new List<RecibeDTO> { recibeDTO };
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un servicio de lavado con ese ID.");
                    }
                    break;

                // ... otros casos ...

                default:
                    MessageBox.Show("Tipo de servicio no reconocido para búsqueda.");
                    break;
            }
        }

        // Método para procesar el listado de servicios
        private void ProcesarListadoServicios()
        {
            // Asumiendo que se selecciona el tipo de servicio desde algún control en el formulario
            string tipoServicio = "parking"; // Por ejemplo

            ListarServicios(tipoServicio);
        }

        // Método para listar servicios
        private void ListarServicios(string tipoServicio)
        {
            switch (tipoServicio)
            {
                case "parking":
                    var listaParking = parkingServicios.ListarParking();
                    listadosServicios.DataGridViewServicio.DataSource = listaParking;
                    break;

                case "lavado":
                    var listaLavado = recibeServicios.ListarRecibe();
                    listadosServicios.DataGridViewServicio.DataSource = listaLavado;
                    break;

                // ... otros casos ...

                default:
                    MessageBox.Show("Tipo de servicio no reconocido para listado.");
                    break;
            }
        }
        private void LimpiarCamposModificaciones()
        {
            modificacionesServicios.TBModServMatr1.Clear();
            modificacionesServicios.MTBModServFechaInicio.Clear();
            modificacionesServicios.MTBModServFechaFin.Clear();
            modificacionesServicios.TBModServNumPlaza1.Clear();
            modificacionesServicios.TBModServFuncionario1.Clear();
            modificacionesServicios.TBModServIDServ1.Clear();
            modificacionesServicios.TBModServIDNeumatico1.Clear();
            modificacionesServicios.TBModServIDClientes1.Clear();
            modificacionesServicios.ComboBoxServicio.SelectedIndex = -1;
        }
        public void ModificarPrecioServicio()
        {
            if (cambiarCostosDeServicios == null)
            {
                MessageBox.Show("El formulario para cambiar costos de servicios no está inicializado.");
                return;
            }

            int id = 0;
            int nuevoPrecio;

            // Validar el valor de nuevo precio ingresado en el formulario
            if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDCosto1.Text, out nuevoPrecio) || nuevoPrecio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.");
                return;
            }

            // Obtener el tipo de servicio seleccionado
            string tipoServicio = ObtenerTipoServicioSeleccionado(cambiarCostosDeServicios);

            if (string.IsNullOrEmpty(tipoServicio))
            {
                MessageBox.Show("Por favor, seleccione un tipo de servicio.");
                return;
            }

            // Asignación y validación de ID según el tipo de servicio
            switch (tipoServicio.ToLower())
            {
                case "lavado":
                    // Validar ID de servicio para Lavado (debe estar entre 1 y 5)
                    if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDServ1.Text, out id) || id < 1 || id > 5)
                    {
                        MessageBox.Show("El ID de servicio para Lavado debe estar entre 1 y 5.");
                        return;
                    }
                    break;

                case "taller":
                    // Obtener el ID del servicio de taller automáticamente desde el ComboBox
                    string servicioSeleccionado = cambiarCostosDeServicios.ComboBoxServicio.SelectedItem?.ToString();
                    id = ObtenerIdServicioTaller(servicioSeleccionado);

                    if (id == 0)
                    {
                        MessageBox.Show("Por favor, seleccione un tipo de servicio de taller válido.");
                        return;
                    }

                    // Mostrar el ID calculado en el campo del formulario para referencia
                    cambiarCostosDeServicios.TBCostoServIDServ1.Text = id.ToString();
                    break;

                case "neumatico":
                    // Validar el ID de Neumático (debe estar entre 1 y 9)
                    if (!int.TryParse(cambiarCostosDeServicios.TBCostoServIDNeumatico1.Text, out id) || id < 1 || id > 9)
                    {
                        MessageBox.Show("El ID de Neumático debe estar entre 1 y 9.");
                        return;
                    }

                    // Actualizar precio de neumático
                    if (ActualizarPrecioNeumatico(id, nuevoPrecio))
                    {
                        MessageBox.Show("Precio del neumático actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el precio del neumático. Verifique los datos ingresados.");
                    }
                    return;

                case "parking":
                    MessageBox.Show("Parking no está relacionado con Servicio.");
                    return;

                default:
                    MessageBox.Show("Tipo de servicio no reconocido.");
                    return;
            }

            // Actualizar precio del servicio (Lavado o Taller)
            if (ActualizarPrecioServicio(id, nuevoPrecio))
            {
                MessageBox.Show("Precio del servicio actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el precio del servicio. Verifique los datos ingresados.");
            }
        }

        public bool ActualizarPrecioServicio(int idServicio, int nuevoPrecio)
        {
            return ServiciosServicios.GetInstance().ActualizarPrecioServicio(idServicio, nuevoPrecio);
        }

        public bool ActualizarPrecioNeumatico(int idNeumatico, int nuevoPrecio)
        {
            return NeumaticoServicios.GetInstance().ActualizarPrecioNeumatico(idNeumatico, nuevoPrecio);
        }
        public bool ActualizarCostoServicio(string tipoServicio, int id, int nuevoPrecio)
        {
            bool resultado = false;

            switch (tipoServicio.ToLower())
            {
                case "parking":
                    resultado = ParkingServicios.GetInstance().ActualizarPrecioParking(id, nuevoPrecio);
                    break;
                case "lavado":
                    resultado = ServiciosServicios.GetInstance().ActualizarPrecioServicio(id, nuevoPrecio);
                    break;
                case "taller":
                    resultado = ServiciosServicios.GetInstance().ActualizarPrecioServicio(id, nuevoPrecio);
                    break;
                case "neumatico":
                    resultado = NeumaticoServicios.GetInstance().ActualizarPrecioNeumatico(id, nuevoPrecio);
                    break;
                default:
                    MessageBox.Show("Tipo de servicio no reconocido.");
                    break;
            }

            return resultado;
        }
        private bool ValidarRangoIdLavado(int idServicio)
        {
            return idServicio >= 1 && idServicio <= 5;
        }
        private void EntregarVehiculo()
        {
            // Obtener el ID de Parking ingresado en el campo de texto
            string idParkingTexto = entregaDeVehiculos.TbEntregaMatr.Text.Trim();

            if (!int.TryParse(idParkingTexto, out int idParking))
            {
                MessageBox.Show("El ID de Parking ingresado no es válido. Debe ser un número entero.");
                return;
            }

            // Llamar al servicio para actualizar el estado de ParaEntregar
            string resultado = ParkingServicios.GetInstance().MarcarParaEntregar(idParking);

            // Mostrar el resultado de la operación al usuario
            MessageBox.Show(resultado);

            // Limpiar el campo de texto después de la operación
            entregaDeVehiculos.TbEntregaMatr.Clear();
        }
        public void EmitirFactura()
        {
            // Validación de campos
            string matricula = emitirFacturasServicios.TBFacturaMatr1.Text.Trim();
            string ciCliente = emitirFacturasServicios.TBFacturaCI1.Text.Trim();
            if (!DateTime.TryParseExact(emitirFacturasServicios.MTBFacturaFecha.Text, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime fechaServicio))
            {
                MessageBox.Show("Fecha de servicio inválida. Formato correcto: dd/MM/yyyy HH:mm");
                return;
            }

            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(ciCliente))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            GenerarFacturaPDF(matricula, ciCliente, fechaServicio);
        }

        public void GenerarFacturaPDF(string matricula, string ciCliente, DateTime fechaServicio)
        {
            var parking = ParkingServicios.GetInstance().ObtenerParkingPorMatriculaYFecha(matricula, fechaServicio);
            var recibe = RecibeServicios.GetInstance().ObtenerRecibePorMatriculaYFecha(matricula, fechaServicio);
            var compra = CompraServicios.GetInstance().ObtenerCompraPorClienteYFecha(ciCliente, fechaServicio);

            if (parking == null && recibe == null && compra == null)
            {
                MessageBox.Show("No se encontraron servicios para esta factura.");
                return;
            }

            // Mostrar el cuadro de diálogo de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar factura como",
                FileName = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return; // Salir si el usuario cancela el guardado
            }

            string filePath = saveFileDialog.FileName;

            Document doc = new Document();

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, stream);
                doc.Open();

                doc.Add(new Paragraph("Factura de Servicios"));
                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                doc.Add(new Paragraph("------------------------------------------------------"));

                decimal total = 0;

                if (parking != null)
                {
                    decimal precioParking = parking.Precio;
                    doc.Add(new Paragraph("Servicio de Parking:"));
                    doc.Add(new Paragraph($"Matrícula: {parking.Matricula}"));
                    doc.Add(new Paragraph($"Fecha Entrada: {parking.FechaEntrada}"));
                    doc.Add(new Paragraph($"Fecha Salida: {parking.FechaSalida}"));
                    doc.Add(new Paragraph($"Precio: ${precioParking}"));
                    total += precioParking;
                    doc.Add(new Paragraph("------------------------------------------------------"));
                }

                if (recibe != null)
                {
                    decimal precioRecibe = Convert.ToDecimal(serviciosServicios.ObtenerPrecioPorId(recibe.IdServicio));
                    doc.Add(new Paragraph("Servicio de Lavado / Taller:"));
                    doc.Add(new Paragraph($"Matrícula: {recibe.Matricula}"));
                    doc.Add(new Paragraph($"Fecha del Servicio: {recibe.FechaServicio}"));
                    doc.Add(new Paragraph($"ID Servicio: {recibe.IdServicio}"));
                    doc.Add(new Paragraph($"Precio: ${precioRecibe}"));
                    total += precioRecibe;
                    doc.Add(new Paragraph("------------------------------------------------------"));
                }

                if (compra != null)
                {
                    decimal precioNeumatico = Convert.ToDecimal(neumaticoServicios.ObtenerPrecioPorId(compra.IdNeumatico));
                    doc.Add(new Paragraph("Compra de Neumáticos:"));
                    doc.Add(new Paragraph($"ID Neumático: {compra.IdNeumatico}"));
                    doc.Add(new Paragraph($"Fecha de Venta: {compra.FechaVenta}"));
                    doc.Add(new Paragraph($"Precio: ${precioNeumatico}"));
                    total += precioNeumatico;
                    doc.Add(new Paragraph("------------------------------------------------------"));
                }

                doc.Add(new Paragraph($"Total: ${total}"));
                doc.Close();
            }

            MessageBox.Show($"Factura generada con éxito en: {filePath}");
        }
    }
}
