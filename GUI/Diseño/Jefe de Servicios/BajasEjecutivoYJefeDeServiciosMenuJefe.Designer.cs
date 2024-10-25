namespace GUI.Diseño.Jefe_de_Servicios
{
    partial class BajasEjecutivoYJefeDeServiciosMenuJefe
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
            panel3.Location = new Point(247, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 2);
            panel3.TabIndex = 137;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(247, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 16);
            textBox3.TabIndex = 135;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(91, 273);
            label12.Name = "label12";
            label12.Size = new Size(124, 18);
            label12.TabIndex = 134;
            label12.Text = "Ingrese Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 67);
            label5.Name = "label5";
            label5.Size = new Size(619, 50);
            label5.TabIndex = 136;
            label5.Text = "Bajas Ejecutivo Y Jefe De Servicios";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(258, 434);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 133;
            btnIngresarVehiculos.Text = "Eliminar";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // BajasEjecutivoYJefeDeServiciosMenuJefe
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
            Name = "BajasEjecutivoYJefeDeServiciosMenuJefe";
            Text = "BajasEjecutivoYJefeDeServiciosMenuJefe";
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