namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            RedondearBoton(button1, 30); // Redondear el botón al iniciar el formulario
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
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
