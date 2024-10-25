namespace GUI.Diseño.Ejecutivo_de_Servicios
{
    partial class AltasServiciosEjecutivoDeServicios
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
            RBBalanceo = new RadioButton();
            label24 = new Label();
            RBNeumaticos = new RadioButton();
            RBAlineacion = new RadioButton();
            RBLavado = new RadioButton();
            RBParking = new RadioButton();
            label10 = new Label();
            label8 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            panel5 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            textBox8 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label11 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnIngresarVehiculos = new Button();
            SuspendLayout();
            // 
            // RBBalanceo
            // 
            RBBalanceo.AutoSize = true;
            RBBalanceo.Location = new Point(504, 290);
            RBBalanceo.Name = "RBBalanceo";
            RBBalanceo.Size = new Size(73, 19);
            RBBalanceo.TabIndex = 171;
            RBBalanceo.TabStop = true;
            RBBalanceo.Text = "Balanceo";
            RBBalanceo.UseVisualStyleBackColor = true;
            RBBalanceo.CheckedChanged += RBBalanceo_CheckedChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(489, 112);
            label24.Name = "label24";
            label24.Size = new Size(196, 18);
            label24.TabIndex = 170;
            label24.Text = "Seleccione el tipo de Servicio";
            // 
            // RBNeumaticos
            // 
            RBNeumaticos.AutoSize = true;
            RBNeumaticos.Location = new Point(504, 335);
            RBNeumaticos.Name = "RBNeumaticos";
            RBNeumaticos.Size = new Size(149, 19);
            RBNeumaticos.TabIndex = 169;
            RBNeumaticos.TabStop = true;
            RBNeumaticos.Text = "Compra de neumaticos";
            RBNeumaticos.UseVisualStyleBackColor = true;
            RBNeumaticos.CheckedChanged += RBNeumaticos_CheckedChanged;
            // 
            // RBAlineacion
            // 
            RBAlineacion.AutoSize = true;
            RBAlineacion.Location = new Point(504, 244);
            RBAlineacion.Name = "RBAlineacion";
            RBAlineacion.Size = new Size(81, 19);
            RBAlineacion.TabIndex = 168;
            RBAlineacion.TabStop = true;
            RBAlineacion.Text = "Alineacion";
            RBAlineacion.UseVisualStyleBackColor = true;
            RBAlineacion.CheckedChanged += RBAlineacion_CheckedChanged;
            // 
            // RBLavado
            // 
            RBLavado.AutoSize = true;
            RBLavado.Location = new Point(504, 200);
            RBLavado.Name = "RBLavado";
            RBLavado.Size = new Size(63, 19);
            RBLavado.TabIndex = 167;
            RBLavado.TabStop = true;
            RBLavado.Text = "Lavado";
            RBLavado.UseVisualStyleBackColor = true;
            RBLavado.CheckedChanged += RBLavado_CheckedChanged;
            // 
            // RBParking
            // 
            RBParking.AutoSize = true;
            RBParking.Location = new Point(506, 151);
            RBParking.Name = "RBParking";
            RBParking.Size = new Size(65, 19);
            RBParking.TabIndex = 166;
            RBParking.TabStop = true;
            RBParking.Text = "Parking";
            RBParking.UseVisualStyleBackColor = true;
            RBParking.CheckedChanged += RBParking_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(26, 430);
            label10.Name = "label10";
            label10.Size = new Size(270, 18);
            label10.TabIndex = 165;
            label10.Text = "Ingrese Fecha De finalizacion de servicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(42, 392);
            label8.Name = "label8";
            label8.Size = new Size(230, 18);
            label8.TabIndex = 164;
            label8.Text = "Ingrese Fecha De inicio se servicio";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(302, 425);
            maskedTextBox4.Mask = "00/00/0000 00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(230, 23);
            maskedTextBox4.TabIndex = 163;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(303, 387);
            maskedTextBox2.Mask = "00/00/0000 00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(230, 23);
            maskedTextBox2.TabIndex = 162;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ActiveCaption;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(242, 315);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(230, 16);
            textBox7.TabIndex = 161;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(242, 272);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 16);
            textBox6.TabIndex = 160;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(242, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 2);
            panel5.TabIndex = 154;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(242, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 16);
            textBox4.TabIndex = 153;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 240);
            label6.Name = "label6";
            label6.Size = new Size(168, 18);
            label6.TabIndex = 152;
            label6.Text = "Ingrese Numero de Plaza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(217, 27);
            label5.Name = "label5";
            label5.Size = new Size(277, 50);
            label5.TabIndex = 151;
            label5.Text = "Altas Servicios";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(242, 335);
            panel9.Name = "panel9";
            panel9.Size = new Size(230, 2);
            panel9.TabIndex = 159;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(242, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 2);
            panel4.TabIndex = 149;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(242, 294);
            panel10.Name = "panel10";
            panel10.Size = new Size(230, 2);
            panel10.TabIndex = 158;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(242, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 2);
            panel2.TabIndex = 150;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(242, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 148;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ActiveCaption;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(242, 195);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(230, 16);
            textBox8.TabIndex = 157;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(242, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 16);
            textBox2.TabIndex = 147;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(55, 319);
            label9.Name = "label9";
            label9.Size = new Size(130, 18);
            label9.TabIndex = 156;
            label9.Text = "Ingrese ID Clientes";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(242, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 16);
            textBox1.TabIndex = 146;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 201);
            label4.Name = "label4";
            label4.Size = new Size(163, 18);
            label4.TabIndex = 145;
            label4.Text = "Ingrese ID de neumatico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(29, 278);
            label11.Name = "label11";
            label11.Size = new Size(198, 18);
            label11.TabIndex = 155;
            label11.Text = "Ingresar Nombre Funcionario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 159);
            label3.Name = "label3";
            label3.Size = new Size(140, 18);
            label3.TabIndex = 144;
            label3.Text = "Ingrese La Matricula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 118);
            label1.Name = "label1";
            label1.Size = new Size(172, 18);
            label1.TabIndex = 143;
            label1.Text = "Ingrese El ID del Servicio";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(233, 474);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 142;
            btnIngresarVehiculos.Text = "Ingresar Servicio";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // AltasServiciosEjecutivoDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(RBBalanceo);
            Controls.Add(label24);
            Controls.Add(RBNeumaticos);
            Controls.Add(RBAlineacion);
            Controls.Add(RBLavado);
            Controls.Add(RBParking);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(panel5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox8);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltasServiciosEjecutivoDeServicios";
            Text = "AltasServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RadioButton RBBalanceo;
        public Label label24;
        public RadioButton RBNeumaticos;
        public RadioButton RBAlineacion;
        public RadioButton RBLavado;
        public RadioButton RBParking;
        private Label label10;
        private Label label8;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox7;
        private TextBox textBox6;
        private Panel panel5;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private Panel panel4;
        private Panel panel10;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBox8;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private Label label4;
        private Label label11;
        private Label label3;
        private Label label1;
        private Button btnIngresarVehiculos;
    }
}