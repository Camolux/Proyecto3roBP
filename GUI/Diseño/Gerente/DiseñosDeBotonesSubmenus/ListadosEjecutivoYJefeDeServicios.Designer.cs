namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class ListadosEjecutivoYJefeDeServicios
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
            btnMostrarFuncionariosGer = new Button();
            dataGridViewFuncionarios = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            TBBuscarFuncionarios = new TextBox();
            label1 = new Label();
            btnBuscarFuncionariosGer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarFuncionariosGer
            // 
            btnMostrarFuncionariosGer.BackColor = SystemColors.ButtonFace;
            btnMostrarFuncionariosGer.FlatAppearance.BorderSize = 0;
            btnMostrarFuncionariosGer.FlatStyle = FlatStyle.Flat;
            btnMostrarFuncionariosGer.Location = new Point(404, 469);
            btnMostrarFuncionariosGer.Name = "btnMostrarFuncionariosGer";
            btnMostrarFuncionariosGer.Size = new Size(204, 38);
            btnMostrarFuncionariosGer.TabIndex = 66;
            btnMostrarFuncionariosGer.Text = "Mostrar";
            btnMostrarFuncionariosGer.UseVisualStyleBackColor = false;
            btnMostrarFuncionariosGer.Click += btnMostrarFuncionariosGer_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(73, 180);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(589, 268);
            dataGridViewFuncionarios.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 41);
            label5.Name = "label5";
            label5.Size = new Size(620, 50);
            label5.TabIndex = 64;
            label5.Text = "Listar Ejecutivo y jefe de Servicios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(268, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 63;
            // 
            // TBBuscarFuncionarios
            // 
            TBBuscarFuncionarios.BackColor = SystemColors.ActiveCaption;
            TBBuscarFuncionarios.BorderStyle = BorderStyle.None;
            TBBuscarFuncionarios.Location = new Point(268, 125);
            TBBuscarFuncionarios.Name = "TBBuscarFuncionarios";
            TBBuscarFuncionarios.Size = new Size(246, 16);
            TBBuscarFuncionarios.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 131);
            label1.Name = "label1";
            label1.Size = new Size(197, 18);
            label1.TabIndex = 61;
            label1.Text = "Ingresar Nombre Del Usuario";
            // 
            // btnBuscarFuncionariosGer
            // 
            btnBuscarFuncionariosGer.BackColor = SystemColors.ButtonFace;
            btnBuscarFuncionariosGer.FlatAppearance.BorderSize = 0;
            btnBuscarFuncionariosGer.FlatStyle = FlatStyle.Flat;
            btnBuscarFuncionariosGer.Location = new Point(121, 469);
            btnBuscarFuncionariosGer.Name = "btnBuscarFuncionariosGer";
            btnBuscarFuncionariosGer.Size = new Size(204, 38);
            btnBuscarFuncionariosGer.TabIndex = 60;
            btnBuscarFuncionariosGer.Text = "Buscar ";
            btnBuscarFuncionariosGer.UseVisualStyleBackColor = false;
            btnBuscarFuncionariosGer.Click += btnBuscarFuncionariosGer_Click;
            // 
            // ListadosEjecutivoYJefeDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(btnMostrarFuncionariosGer);
            Controls.Add(dataGridViewFuncionarios);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(TBBuscarFuncionarios);
            Controls.Add(label1);
            Controls.Add(btnBuscarFuncionariosGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadosEjecutivoYJefeDeServicios";
            Text = "ListadosEjecutivoYJefeDeServicios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarFuncionariosGer;
        private DataGridView dataGridViewFuncionarios;
        private Label label5;
        private Panel panel1;
        private TextBox TBBuscarFuncionarios;
        private Label label1;
        private Button btnBuscarFuncionariosGer;

        public DataGridView DataGridViewFuncionarios { get => dataGridViewFuncionarios; set => dataGridViewFuncionarios = value; }
        public TextBox TBBuscarFuncionarios1 { get => TBBuscarFuncionarios; set => TBBuscarFuncionarios = value; }
        public DataGridView DataGridViewFuncionarios1 { get => dataGridViewFuncionarios; set => dataGridViewFuncionarios = value; }
    }
}