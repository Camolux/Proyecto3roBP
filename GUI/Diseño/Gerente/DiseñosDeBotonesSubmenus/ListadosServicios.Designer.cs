namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class ListadosServicios
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
            btnMostrarServGer = new Button();
            dataGridViewServicio = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            TBBuscarServicio = new TextBox();
            label1 = new Label();
            btnBuscarServicioGer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarServGer
            // 
            btnMostrarServGer.BackColor = SystemColors.ButtonFace;
            btnMostrarServGer.FlatAppearance.BorderSize = 0;
            btnMostrarServGer.FlatStyle = FlatStyle.Flat;
            btnMostrarServGer.Location = new Point(404, 469);
            btnMostrarServGer.Name = "btnMostrarServGer";
            btnMostrarServGer.Size = new Size(204, 38);
            btnMostrarServGer.TabIndex = 66;
            btnMostrarServGer.Text = "Mostrar";
            btnMostrarServGer.UseVisualStyleBackColor = false;
            btnMostrarServGer.Click += btnMostrarServGer_Click;
            // 
            // dataGridViewServicio
            // 
            dataGridViewServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicio.Location = new Point(73, 180);
            dataGridViewServicio.Name = "dataGridViewServicio";
            dataGridViewServicio.RowTemplate.Height = 25;
            dataGridViewServicio.Size = new Size(589, 268);
            dataGridViewServicio.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(225, 32);
            label5.Name = "label5";
            label5.Size = new Size(292, 50);
            label5.TabIndex = 64;
            label5.Text = "Listar Servicios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(266, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 63;
            // 
            // TBBuscarServicio
            // 
            TBBuscarServicio.BackColor = SystemColors.ActiveCaption;
            TBBuscarServicio.BorderStyle = BorderStyle.None;
            TBBuscarServicio.Location = new Point(266, 140);
            TBBuscarServicio.Name = "TBBuscarServicio";
            TBBuscarServicio.Size = new Size(246, 16);
            TBBuscarServicio.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 138);
            label1.Name = "label1";
            label1.Size = new Size(175, 18);
            label1.TabIndex = 61;
            label1.Text = "Buscar por ID del Servicio";
            // 
            // btnBuscarServicioGer
            // 
            btnBuscarServicioGer.BackColor = SystemColors.ButtonFace;
            btnBuscarServicioGer.FlatAppearance.BorderSize = 0;
            btnBuscarServicioGer.FlatStyle = FlatStyle.Flat;
            btnBuscarServicioGer.Location = new Point(121, 469);
            btnBuscarServicioGer.Name = "btnBuscarServicioGer";
            btnBuscarServicioGer.Size = new Size(204, 38);
            btnBuscarServicioGer.TabIndex = 60;
            btnBuscarServicioGer.Text = "Buscar ";
            btnBuscarServicioGer.UseVisualStyleBackColor = false;
            btnBuscarServicioGer.Click += btnBuscarServicioGer_Click;
            // 
            // ListadosServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(btnMostrarServGer);
            Controls.Add(dataGridViewServicio);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(TBBuscarServicio);
            Controls.Add(label1);
            Controls.Add(btnBuscarServicioGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadosServicios";
            Text = "ListadosServicios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarServGer;
        private DataGridView dataGridViewServicio;
        private Label label5;
        private Panel panel1;
        private TextBox TBBuscarServicio;
        private Label label1;
        private Button btnBuscarServicioGer;

        public DataGridView DataGridViewServicio { get => dataGridViewServicio; set => dataGridViewServicio = value; }
        public TextBox TBBuscarServicio1 { get => TBBuscarServicio; set => TBBuscarServicio = value; }
    }
}