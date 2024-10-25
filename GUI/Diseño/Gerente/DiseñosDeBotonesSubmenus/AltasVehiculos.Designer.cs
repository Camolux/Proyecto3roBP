namespace GUI
{
    partial class AltasVehiculos
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
            label5 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnIngresarVehiculos = new Button();
            CBTipoVehiculo = new ComboBox();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(230, 73);
            label5.Name = "label5";
            label5.Size = new Size(286, 50);
            label5.TabIndex = 52;
            label5.Text = "Altas Vehiculos";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(256, 387);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 2);
            panel4.TabIndex = 49;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(256, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 2);
            panel3.TabIndex = 51;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(256, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 2);
            panel2.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(256, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 48;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(256, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 16);
            textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(256, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 16);
            textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(256, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 16);
            textBox1.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 371);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 43;
            label4.Text = "Ingrese Tipo de Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 256);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 42;
            label3.Text = "Ingrese Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 313);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 41;
            label2.Text = "Ingrese Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 201);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 40;
            label1.Text = "Ingrese Matricula";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(273, 476);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 39;
            btnIngresarVehiculos.Text = "Ingresar vehiculo";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // CBTipoVehiculo
            // 
            CBTipoVehiculo.BackColor = SystemColors.ActiveCaption;
            CBTipoVehiculo.FormattingEnabled = true;
            CBTipoVehiculo.Items.AddRange(new object[] { "moto", "auto", "camioneta", "pequeño camión", "pequeño utilitario" });
            CBTipoVehiculo.Location = new Point(256, 363);
            CBTipoVehiculo.Name = "CBTipoVehiculo";
            CBTipoVehiculo.Size = new Size(246, 23);
            CBTipoVehiculo.TabIndex = 53;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mensual", "sistematico", "eventual", "extraordinario" });
            comboBox1.Location = new Point(256, 418);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 56;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(256, 442);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 2);
            panel5.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(82, 426);
            label6.Name = "label6";
            label6.Size = new Size(157, 18);
            label6.TabIndex = 54;
            label6.Text = "Ingrese Tipo de Cliente";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(256, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(246, 2);
            panel6.TabIndex = 59;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(256, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 16);
            textBox4.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(92, 158);
            label7.Name = "label7";
            label7.Size = new Size(147, 18);
            label7.TabIndex = 57;
            label7.Text = "Ingrese CI Del Cliente";
            // 
            // AltasVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(panel6);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(CBTipoVehiculo);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltasVehiculos";
            Text = "AltasVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnIngresarVehiculos;
        public ComboBox CBTipoVehiculo;
        public ComboBox comboBox1;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private TextBox textBox4;
        private Label label7;
    }
}