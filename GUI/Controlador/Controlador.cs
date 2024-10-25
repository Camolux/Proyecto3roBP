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


namespace Controlador
{
    public class Controlador
    {
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
