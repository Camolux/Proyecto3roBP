namespace GUI.Diseño.Jefe_de_Servicios
{
    partial class ModificacionesEjecutivoYJefeDeServiciosMenuJefe
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
            CBTipoVehiculo = new ComboBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnIngresarVehiculos = new Button();
            SuspendLayout();
            // 
            // CBTipoVehiculo
            // 
            CBTipoVehiculo.BackColor = SystemColors.ActiveCaption;
            CBTipoVehiculo.FormattingEnabled = true;
            CBTipoVehiculo.Items.AddRange(new object[] { "ejecutivo", "jefe", "operador", "cajero" });
            CBTipoVehiculo.Location = new Point(250, 300);
            CBTipoVehiculo.Name = "CBTipoVehiculo";
            CBTipoVehiculo.Size = new Size(232, 23);
            CBTipoVehiculo.TabIndex = 185;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(250, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 2);
            panel4.TabIndex = 183;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(250, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 2);
            panel2.TabIndex = 184;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(250, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 2);
            panel1.TabIndex = 182;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(250, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 16);
            textBox2.TabIndex = 181;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(250, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 16);
            textBox1.TabIndex = 180;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 305);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 179;
            label4.Text = "Ingrese Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(92, 260);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 178;
            label3.Text = "Ingrese Contrasenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 218);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 177;
            label1.Text = "Ingresr Username ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 108);
            label5.Name = "label5";
            label5.Size = new Size(683, 50);
            label5.TabIndex = 176;
            label5.Text = "Modificar Ejecutivo y jefe de servicios";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(266, 392);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 175;
            btnIngresarVehiculos.Text = "Modificar";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // ModificacionesEjecutivoYJefeDeServiciosMenuJefe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(CBTipoVehiculo);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificacionesEjecutivoYJefeDeServiciosMenuJefe";
            Text = "ModificacionesEjecutivoYJefeDeServiciosMenuJefe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox CBTipoVehiculo;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Button btnIngresarVehiculos;
    }
}