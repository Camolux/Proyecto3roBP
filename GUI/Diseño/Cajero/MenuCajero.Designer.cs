namespace GUI.Diseño.Gerente.DiseñosDeBotonesSubmenus
{
    partial class MenuCajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCajero));
            panel1 = new Panel();
            panelServiciosDeCajero = new Panel();
            button1 = new Button();
            btnEmitirFacturas = new Button();
            btnVehiculos = new Button();
            btnhome = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedordesubmenusHome = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panelServiciosDeCajero.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedordesubmenusHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(panelServiciosDeCajero);
            panel1.Controls.Add(btnVehiculos);
            panel1.Controls.Add(btnhome);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 580);
            panel1.TabIndex = 1;
            // 
            // panelServiciosDeCajero
            // 
            panelServiciosDeCajero.Controls.Add(button1);
            panelServiciosDeCajero.Controls.Add(btnEmitirFacturas);
            panelServiciosDeCajero.Dock = DockStyle.Top;
            panelServiciosDeCajero.Location = new Point(0, 258);
            panelServiciosDeCajero.Name = "panelServiciosDeCajero";
            panelServiciosDeCajero.Size = new Size(272, 80);
            panelServiciosDeCajero.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 40);
            button1.Name = "button1";
            button1.Padding = new Padding(40, 0, 0, 0);
            button1.Size = new Size(272, 40);
            button1.TabIndex = 17;
            button1.Text = "Entrega De Vehiculo";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEmitirFacturas
            // 
            btnEmitirFacturas.BackColor = SystemColors.ControlDark;
            btnEmitirFacturas.Dock = DockStyle.Top;
            btnEmitirFacturas.FlatAppearance.BorderSize = 0;
            btnEmitirFacturas.FlatStyle = FlatStyle.Flat;
            btnEmitirFacturas.Location = new Point(0, 0);
            btnEmitirFacturas.Name = "btnEmitirFacturas";
            btnEmitirFacturas.Padding = new Padding(40, 0, 0, 0);
            btnEmitirFacturas.Size = new Size(272, 40);
            btnEmitirFacturas.TabIndex = 16;
            btnEmitirFacturas.Text = "Emitir Facturas";
            btnEmitirFacturas.TextAlign = ContentAlignment.MiddleLeft;
            btnEmitirFacturas.UseVisualStyleBackColor = false;
            btnEmitirFacturas.Click += btnEmitirFacturas_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = SystemColors.Window;
            btnVehiculos.Dock = DockStyle.Top;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Image = Properties.Resources.cuenta;
            btnVehiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehiculos.Location = new Point(0, 218);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(272, 40);
            btnVehiculos.TabIndex = 5;
            btnVehiculos.Text = "Servicios De Cajero";
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnhome
            // 
            btnhome.BackColor = SystemColors.Window;
            btnhome.Dock = DockStyle.Top;
            btnhome.FlatAppearance.BorderSize = 0;
            btnhome.FlatStyle = FlatStyle.Flat;
            btnhome.Image = Properties.Resources.casa;
            btnhome.ImageAlign = ContentAlignment.MiddleLeft;
            btnhome.Location = new Point(0, 178);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(272, 40);
            btnhome.TabIndex = 21;
            btnhome.Text = "Home";
            btnhome.UseVisualStyleBackColor = false;
            btnhome.Click += btnhome_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 178);
            panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 177);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelContenedordesubmenusHome
            // 
            panelContenedordesubmenusHome.BackColor = SystemColors.ActiveCaption;
            panelContenedordesubmenusHome.Controls.Add(pictureBox2);
            panelContenedordesubmenusHome.Dock = DockStyle.Fill;
            panelContenedordesubmenusHome.Location = new Point(272, 0);
            panelContenedordesubmenusHome.Name = "panelContenedordesubmenusHome";
            panelContenedordesubmenusHome.Size = new Size(691, 580);
            panelContenedordesubmenusHome.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 177);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // MenuCajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 580);
            Controls.Add(panelContenedordesubmenusHome);
            Controls.Add(panel1);
            Name = "MenuCajero";
            Text = "MenuCajero";
            panel1.ResumeLayout(false);
            panelServiciosDeCajero.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedordesubmenusHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnCambiarcostosdeservicios;
        private Panel panelEjecutivoyjefedeserviciosmenu;
        private Button btnListadoEjecutivoYJefeDeServicios;
        private Button btnModificacionesEjecutivoYJefe;
        private Button btnBajasEjecutivoYJefe;
        private Button btnAltasEjecutivoYJefe;
        private Button btnEjecutivoyjefedeServicios;
        private Panel panelServiciosmenu;
        private Button BtnEmitirFacturaServicios;
        private Button btnListadoServicios;
        private Button btnModificacionesservicios;
        private Button btnAltasservicios;
        private Button BtnServicos;
        private Panel panelClientesmenu;
        private Button btnListadoClientes;
        private Button btnModificacionesclientes;
        private Button btnAltasclientes;
        private Button btnClientes;
        private Panel panelServiciosDeCajero;
        private Button btnListadoVehiculos;
        private Button btnEmitirFacturas;
        private Button btnAltasvehiculos;
        private Button btnVehiculos;
        private Button btnhome;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panelContenedordesubmenusHome;
        private PictureBox pictureBox2;
        private Button button1;
    }
}