namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class BajasEjecutivoYJefeDeServicios
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
            panel3 = new Panel();
            textBox3 = new TextBox();
            label12 = new Label();
            label5 = new Label();
            btnIngresarVehiculos = new Button();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(252, 249);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 2);
            panel3.TabIndex = 132;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(252, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 16);
            textBox3.TabIndex = 129;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(96, 233);
            label12.Name = "label12";
            label12.Size = new Size(124, 18);
            label12.TabIndex = 127;
            label12.Text = "Ingrese Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 27);
            label5.Name = "label5";
            label5.Size = new Size(619, 50);
            label5.TabIndex = 131;
            label5.Text = "Bajas Ejecutivo Y Jefe De Servicios";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(263, 394);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 120;
            btnIngresarVehiculos.Text = "Eliminar";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            btnIngresarVehiculos.Click += btnIngresarVehiculos_Click;
            // 
            // BajasEjecutivoYJefeDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(panel3);
            Controls.Add(textBox3);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BajasEjecutivoYJefeDeServicios";
            Text = "BajasEjecutivoYJefeDeServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox textBox3;
        private Label label12;
        private Label label5;
        private Button btnIngresarVehiculos;
    }
}