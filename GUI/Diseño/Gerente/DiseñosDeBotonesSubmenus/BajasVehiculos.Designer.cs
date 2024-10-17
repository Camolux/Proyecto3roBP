namespace GUI
{
    partial class BajasVehiculos
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
            label5 = new Label();
            CBTipoVehiculo = new ComboBox();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(243, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 2);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(243, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 2);
            panel3.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(243, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 2);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(243, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(243, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 16);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(243, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 16);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(243, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 16);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(69, 332);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 16;
            label4.Text = "Ingrese Tipo de Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(106, 217);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 15;
            label3.Text = "Ingrese Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 274);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 14;
            label2.Text = "Ingrese Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 162);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 13;
            label1.Text = "Ingrese Matricula";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(263, 411);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 12;
            btnIngresarVehiculos.Text = "Dar de baja";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(211, 57);
            label5.Name = "label5";
            label5.Size = new Size(293, 50);
            label5.TabIndex = 39;
            label5.Text = "Bajas Vehiculos";
            // 
            // CBTipoVehiculo
            // 
            CBTipoVehiculo.BackColor = SystemColors.ActiveCaption;
            CBTipoVehiculo.FormattingEnabled = true;
            CBTipoVehiculo.Items.AddRange(new object[] { "Moto", "Auto", "Camioneta", "Pequeño camión", "Pequeño utilitario" });
            CBTipoVehiculo.Location = new Point(243, 324);
            CBTipoVehiculo.Name = "CBTipoVehiculo";
            CBTipoVehiculo.Size = new Size(246, 23);
            CBTipoVehiculo.TabIndex = 54;
            // 
            // BajasVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
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
            Name = "BajasVehiculos";
            Text = "BajasVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label5;
        public ComboBox CBTipoVehiculo;
    }
}