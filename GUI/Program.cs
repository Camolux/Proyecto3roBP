using GUI.Dise�o.Ejecutivo_de_Servicios;
using GUI.Dise�o.Gerente.Dise�osDeBotonesSubmenus;
using GUI.Dise�o.Jefe_de_Servicios;
using GUI.Dise�o;
namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Login.Instance);
        }
    }
}