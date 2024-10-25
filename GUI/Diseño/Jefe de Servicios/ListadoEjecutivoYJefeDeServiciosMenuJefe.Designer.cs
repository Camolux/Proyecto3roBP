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
            button1 = new Button();
            dataGridViewVehiculos = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            btnIngresarVehiculos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(407, 464);
            button1.Name = "button1";
            button1.Size = new Size(204, 38);
            button1.TabIndex = 73;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(76, 175);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.RowTemplate.Height = 25;
            dataGridViewVehiculos.Size = new Size(589, 268);
            dataGridViewVehiculos.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 36);
            label5.Name = "label5";
            label5.Size = new Size(620, 50);
            label5.TabIndex = 71;
            label5.Text = "Listar Ejecutivo y jefe de Servicios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(271, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 70;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(271, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 16);
            textBox1.TabIndex = 69;
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
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(124, 464);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 67;
            btnIngresarVehiculos.Text = "Buscar ";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // ListadoEjecutivoYJefeDeServiciosMenuJefe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(button1);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadoEjecutivoYJefeDeServiciosMenuJefe";
            Text = "ListadoEjecutivoYJefeDeServiciosMenuJefe";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public DataGridView dataGridViewVehiculos;
        private Label label5;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button btnIngresarVehiculos;
    }
}