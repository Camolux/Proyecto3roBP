namespace GUI
{
    partial class ListadosVehiculos
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
            panel1 = new Panel();
            TBBuscarVehiculo = new TextBox();
            label1 = new Label();
            btnBuscarVehiculosGer = new Button();
            label5 = new Label();
            dataGridViewVehiculos = new DataGridView();
            btnMostrarVehiculosGer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(255, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 47;
            // 
            // TBBuscarVehiculo
            // 
            TBBuscarVehiculo.BackColor = SystemColors.ActiveCaption;
            TBBuscarVehiculo.BorderStyle = BorderStyle.None;
            TBBuscarVehiculo.Location = new Point(255, 144);
            TBBuscarVehiculo.Name = "TBBuscarVehiculo";
            TBBuscarVehiculo.Size = new Size(246, 16);
            TBBuscarVehiculo.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 142);
            label1.Name = "label1";
            label1.Size = new Size(202, 18);
            label1.TabIndex = 39;
            label1.Text = "Buscar Vehiculo por Matricula";
            // 
            // btnBuscarVehiculosGer
            // 
            btnBuscarVehiculosGer.BackColor = SystemColors.ButtonFace;
            btnBuscarVehiculosGer.FlatAppearance.BorderSize = 0;
            btnBuscarVehiculosGer.FlatStyle = FlatStyle.Flat;
            btnBuscarVehiculosGer.Location = new Point(113, 473);
            btnBuscarVehiculosGer.Name = "btnBuscarVehiculosGer";
            btnBuscarVehiculosGer.Size = new Size(204, 38);
            btnBuscarVehiculosGer.TabIndex = 38;
            btnBuscarVehiculosGer.Text = "Buscar";
            btnBuscarVehiculosGer.UseVisualStyleBackColor = false;
            btnBuscarVehiculosGer.Click += btnBuscarVehiculosGer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(214, 36);
            label5.Name = "label5";
            label5.Size = new Size(301, 50);
            label5.TabIndex = 51;
            label5.Text = "Listar Vehiculos";
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(62, 184);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.RowTemplate.Height = 25;
            dataGridViewVehiculos.Size = new Size(589, 268);
            dataGridViewVehiculos.TabIndex = 52;
            // 
            // btnMostrarVehiculosGer
            // 
            btnMostrarVehiculosGer.BackColor = SystemColors.ButtonFace;
            btnMostrarVehiculosGer.FlatAppearance.BorderSize = 0;
            btnMostrarVehiculosGer.FlatStyle = FlatStyle.Flat;
            btnMostrarVehiculosGer.Location = new Point(390, 473);
            btnMostrarVehiculosGer.Name = "btnMostrarVehiculosGer";
            btnMostrarVehiculosGer.Size = new Size(204, 38);
            btnMostrarVehiculosGer.TabIndex = 60;
            btnMostrarVehiculosGer.Text = "Mostrar";
            btnMostrarVehiculosGer.UseVisualStyleBackColor = false;
            btnMostrarVehiculosGer.Click += btnMostrarVehiculosGer_Click;
            // 
            // ListadosVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(btnMostrarVehiculosGer);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(TBBuscarVehiculo);
            Controls.Add(label1);
            Controls.Add(btnBuscarVehiculosGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadosVehiculos";
            Text = "  ";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox TBBuscarVehiculo;
        private Label label1;
        private Button btnBuscarVehiculosGer;
        private Label label5;
        private DataGridView dataGridViewVehiculos;
        private Button btnMostrarVehiculosGer;

        public TextBox TBBuscarVehiculo1 { get => TBBuscarVehiculo; set => TBBuscarVehiculo = value; }
        public DataGridView DataGridViewVehiculos { get => dataGridViewVehiculos; set => dataGridViewVehiculos = value; }
    }
}