namespace GUI
{
    partial class ModificacionesVehiculos
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
            panel4.Location = new Point(244, 348);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 2);
            panel4.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(244, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 2);
            panel3.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(244, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 2);
            panel2.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(244, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(244, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 16);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(244, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 16);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(244, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 16);
            textBox1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 332);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 29;
            label4.Text = "Ingrese Tipo de Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 217);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 28;
            label3.Text = "Ingrese Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 274);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 27;
            label2.Text = "Ingrese Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 162);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 26;
            label1.Text = "Ingrese Matricula";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(264, 411);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 25;
            btnIngresarVehiculos.Text = "Modificar vehiculo";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(165, 50);
            label5.Name = "label5";
            label5.Size = new Size(367, 50);
            label5.TabIndex = 38;
            label5.Text = "Modificar Vehiculos";
            // 
            // CBTipoVehiculo
            // 
            CBTipoVehiculo.BackColor = SystemColors.ActiveCaption;
            CBTipoVehiculo.FormattingEnabled = true;
            CBTipoVehiculo.Items.AddRange(new object[] { "Moto", "Auto", "Camioneta", "Pequeño camión", "Pequeño utilitario" });
            CBTipoVehiculo.Location = new Point(244, 324);
            CBTipoVehiculo.Name = "CBTipoVehiculo";
            CBTipoVehiculo.Size = new Size(246, 23);
            CBTipoVehiculo.TabIndex = 39;
            // 
            // ModificacionesVehiculos
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
            Name = "ModificacionesVehiculos";
            Text = "ModificacionesVehiculos";
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