using Controlador;

namespace GUI
{
    public partial class Login : Form
    {
        public static Login instance;


        private Login()
        {
            InitializeComponent();
            RedondearBoton(BTNConfirmar, 30);

            // Get the singleton instance of Controlador
            Controlador.Controlador controlador = Controlador.Controlador.GetInstance();
            controlador.formLogin = this;

            BTNConfirmar.Click += new EventHandler(controlador.OnButtonClick);
        }

        public static Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void RedondearBoton(Button button, int borderRadius)
        {
            // Ajustar el radio para que sea más redondeado
            int radius = Math.Min(borderRadius, button.Height / 2);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90);
            path.AddArc(new Rectangle(button.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddArc(new Rectangle(button.Width - radius * 2, button.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddArc(new Rectangle(0, button.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }


    }
}
