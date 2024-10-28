namespace GUI.Diseño.Jefe_de_Servicios
{
    partial class ListadoEjecutivoYJefeDeServiciosMenuJefe
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
            btnMostrarFuncionariosJefe = new Button();
            dataGridViewFuncionarios = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            TBListadoEje = new TextBox();
            label1 = new Label();
            btnBuscarFuncionariosJefe = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarFuncionariosJefe
            // 
            btnMostrarFuncionariosJefe.BackColor = SystemColors.ButtonFace;
            btnMostrarFuncionariosJefe.FlatAppearance.BorderSize = 0;
            btnMostrarFuncionariosJefe.FlatStyle = FlatStyle.Flat;
            btnMostrarFuncionariosJefe.Location = new Point(407, 464);
            btnMostrarFuncionariosJefe.Name = "btnMostrarFuncionariosJefe";
            btnMostrarFuncionariosJefe.Size = new Size(204, 38);
            btnMostrarFuncionariosJefe.TabIndex = 73;
            btnMostrarFuncionariosJefe.Text = "Mostrar";
            btnMostrarFuncionariosJefe.UseVisualStyleBackColor = false;
            btnMostrarFuncionariosJefe.Click += btnMostrarFuncionariosJefe_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(76, 175);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(589, 268);
            dataGridViewFuncionarios.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 36);
            label5.Name = "label5";
            label5.Size = new Size(389, 50);
            label5.TabIndex = 71;
            label5.Text = "Listado Funcionarios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(271, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 70;
            // 
            // TBListadoEje
            // 
            TBListadoEje.BackColor = SystemColors.ActiveCaption;
            TBListadoEje.BorderStyle = BorderStyle.None;
            TBListadoEje.Location = new Point(271, 120);
            TBListadoEje.Name = "TBListadoEje";
            TBListadoEje.Size = new Size(246, 16);
            TBListadoEje.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 126);
            label1.Name = "label1";
            label1.Size = new Size(197, 18);
            label1.TabIndex = 68;
            label1.Text = "Ingresar Nombre Del Usuario";
            // 
            // btnBuscarFuncionariosJefe
            // 
            btnBuscarFuncionariosJefe.BackColor = SystemColors.ButtonFace;
            btnBuscarFuncionariosJefe.FlatAppearance.BorderSize = 0;
            btnBuscarFuncionariosJefe.FlatStyle = FlatStyle.Flat;
            btnBuscarFuncionariosJefe.Location = new Point(124, 464);
            btnBuscarFuncionariosJefe.Name = "btnBuscarFuncionariosJefe";
            btnBuscarFuncionariosJefe.Size = new Size(204, 38);
            btnBuscarFuncionariosJefe.TabIndex = 67;
            btnBuscarFuncionariosJefe.Text = "Buscar ";
            btnBuscarFuncionariosJefe.UseVisualStyleBackColor = false;
            btnBuscarFuncionariosJefe.Click += btnBuscarFuncionariosJefe_Click;
            // 
            // ListadoEjecutivoYJefeDeServiciosMenuJefe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(btnMostrarFuncionariosJefe);
            Controls.Add(dataGridViewFuncionarios);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(TBListadoEje);
            Controls.Add(label1);
            Controls.Add(btnBuscarFuncionariosJefe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadoEjecutivoYJefeDeServiciosMenuJefe";
            Text = "ListadoEjecutivoYJefeDeServiciosMenuJefe";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarFuncionariosJefe;
        private DataGridView dataGridViewFuncionarios;
        private Label label5;
        private Panel panel1;
        private TextBox TBListadoEje;
        private Label label1;
        private Button btnBuscarFuncionariosJefe;

        public DataGridView DataGridViewFuncionarios { get => dataGridViewFuncionarios; set => dataGridViewFuncionarios = value; }
        public TextBox TBListadoEje1 { get => TBListadoEje; set => TBListadoEje = value; }
    }
}