﻿namespace GUI.Diseño.Cajero.DiseñosDeBotonesSubMenusCajero
{
    partial class EntregaDeVehiculos
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
            btnEntregarVehiculos = new Button();
            tbEntregaMatr = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnEntregarVehiculos
            // 
            btnEntregarVehiculos.BackColor = SystemColors.ButtonFace;
            btnEntregarVehiculos.FlatAppearance.BorderSize = 0;
            btnEntregarVehiculos.FlatStyle = FlatStyle.Flat;
            btnEntregarVehiculos.Location = new Point(240, 436);
            btnEntregarVehiculos.Name = "btnEntregarVehiculos";
            btnEntregarVehiculos.Size = new Size(204, 38);
            btnEntregarVehiculos.TabIndex = 177;
            btnEntregarVehiculos.Text = "Entregar";
            btnEntregarVehiculos.UseVisualStyleBackColor = false;
            btnEntregarVehiculos.Click += btnEntregarVehiculos_Click;
            // 
            // tbEntregaMatr
            // 
            tbEntregaMatr.BackColor = SystemColors.ActiveCaption;
            tbEntregaMatr.BorderStyle = BorderStyle.None;
            tbEntregaMatr.Location = new Point(240, 254);
            tbEntregaMatr.Name = "tbEntregaMatr";
            tbEntregaMatr.Size = new Size(230, 16);
            tbEntregaMatr.TabIndex = 176;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(240, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 175;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(143, 87);
            label5.Name = "label5";
            label5.Size = new Size(390, 50);
            label5.TabIndex = 168;
            label5.Text = "Entrega De Vehiculos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(51, 254);
            label9.Name = "label9";
            label9.Size = new Size(170, 18);
            label9.TabIndex = 169;
            label9.Text = "Ingrese El ID del Parking";
            // 
            // EntregaDeVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(btnEntregarVehiculos);
            Controls.Add(tbEntregaMatr);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntregaDeVehiculos";
            Text = "EntregaDeVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntregarVehiculos;
        private TextBox tbEntregaMatr;
        private Panel panel1;
        private Label label5;
        private Label label9;

        public TextBox TbEntregaMatr { get => tbEntregaMatr; set => tbEntregaMatr = value; }
       
    }
}