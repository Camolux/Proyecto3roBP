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
            TBNomBorrarFunci = new TextBox();
            label12 = new Label();
            label5 = new Label();
            BTNEliminarFunciGer = new Button();
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
            // TBNomBorrarFunci
            // 
            TBNomBorrarFunci.BackColor = SystemColors.ActiveCaption;
            TBNomBorrarFunci.BorderStyle = BorderStyle.None;
            TBNomBorrarFunci.Location = new Point(252, 227);
            TBNomBorrarFunci.Name = "TBNomBorrarFunci";
            TBNomBorrarFunci.Size = new Size(232, 16);
            TBNomBorrarFunci.TabIndex = 129;
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
            // BTNEliminarFunciGer
            // 
            BTNEliminarFunciGer.BackColor = SystemColors.ButtonFace;
            BTNEliminarFunciGer.FlatAppearance.BorderSize = 0;
            BTNEliminarFunciGer.FlatStyle = FlatStyle.Flat;
            BTNEliminarFunciGer.Location = new Point(263, 394);
            BTNEliminarFunciGer.Name = "BTNEliminarFunciGer";
            BTNEliminarFunciGer.Size = new Size(204, 38);
            BTNEliminarFunciGer.TabIndex = 120;
            BTNEliminarFunciGer.Text = "Eliminar";
            BTNEliminarFunciGer.UseVisualStyleBackColor = false;
            BTNEliminarFunciGer.Click += btnIngresarVehiculos_Click;
            // 
            // BajasEjecutivoYJefeDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(panel3);
            Controls.Add(TBNomBorrarFunci);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(BTNEliminarFunciGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BajasEjecutivoYJefeDeServicios";
            Text = "BajasEjecutivoYJefeDeServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox TBNomBorrarFunci;
        private Label label12;
        private Label label5;
        private Button BTNEliminarFunciGer;

        public TextBox TBNomBorrarFunci1 { get => TBNomBorrarFunci; set => TBNomBorrarFunci = value; }
    }
}