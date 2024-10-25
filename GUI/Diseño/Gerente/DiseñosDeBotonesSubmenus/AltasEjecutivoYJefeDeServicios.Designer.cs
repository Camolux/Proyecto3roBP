namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class AltasEjecutivoYJefeDeServicios
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
            panel2 = new Panel();
            panel1 = new Panel();
            TBAltaUsuPassGer = new TextBox();
            TBAltaUsuNomUsuGer = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BTNAltaUsuarioGer = new Button();
            CBAltaTipoUsu = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 24);
            label5.Name = "label5";
            label5.Size = new Size(612, 50);
            label5.TabIndex = 99;
            label5.Text = "Altas Ejecutivo Y Jefe De Servicios";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(251, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 2);
            panel4.TabIndex = 97;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(251, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 2);
            panel2.TabIndex = 98;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(251, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 2);
            panel1.TabIndex = 96;
            // 
            // TBAltaUsuPassGer
            // 
            TBAltaUsuPassGer.BackColor = SystemColors.ActiveCaption;
            TBAltaUsuPassGer.BorderStyle = BorderStyle.None;
            TBAltaUsuPassGer.Location = new Point(251, 230);
            TBAltaUsuPassGer.Name = "TBAltaUsuPassGer";
            TBAltaUsuPassGer.Size = new Size(232, 16);
            TBAltaUsuPassGer.TabIndex = 95;
            // 
            // TBAltaUsuNomUsuGer
            // 
            TBAltaUsuNomUsuGer.BackColor = SystemColors.ActiveCaption;
            TBAltaUsuNomUsuGer.BorderStyle = BorderStyle.None;
            TBAltaUsuNomUsuGer.Location = new Point(251, 188);
            TBAltaUsuNomUsuGer.Name = "TBAltaUsuNomUsuGer";
            TBAltaUsuNomUsuGer.Size = new Size(232, 16);
            TBAltaUsuNomUsuGer.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(123, 281);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 93;
            label4.Text = "Ingrese Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 236);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 92;
            label3.Text = "Ingrese Contrasenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 194);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 91;
            label1.Text = "Ingresr Username ";
            // 
            // BTNAltaUsuarioGer
            // 
            BTNAltaUsuarioGer.BackColor = SystemColors.ButtonFace;
            BTNAltaUsuarioGer.FlatAppearance.BorderSize = 0;
            BTNAltaUsuarioGer.FlatStyle = FlatStyle.Flat;
            BTNAltaUsuarioGer.Location = new Point(270, 389);
            BTNAltaUsuarioGer.Name = "BTNAltaUsuarioGer";
            BTNAltaUsuarioGer.Size = new Size(204, 38);
            BTNAltaUsuarioGer.TabIndex = 90;
            BTNAltaUsuarioGer.Text = "Dar de alta";
            BTNAltaUsuarioGer.UseVisualStyleBackColor = false;
            BTNAltaUsuarioGer.Click += btnIngresarVehiculos_Click;
            // 
            // CBAltaTipoUsu
            // 
            CBAltaTipoUsu.BackColor = SystemColors.ActiveCaption;
            CBAltaTipoUsu.DropDownStyle = ComboBoxStyle.DropDownList;
            CBAltaTipoUsu.FormattingEnabled = true;
            CBAltaTipoUsu.Items.AddRange(new object[] { "ejecutivo", "jefe", "operador", "cajero" });
            CBAltaTipoUsu.Location = new Point(251, 276);
            CBAltaTipoUsu.Name = "CBAltaTipoUsu";
            CBAltaTipoUsu.Size = new Size(232, 23);
            CBAltaTipoUsu.TabIndex = 100;
            // 
            // AltasEjecutivoYJefeDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(CBAltaTipoUsu);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TBAltaUsuPassGer);
            Controls.Add(TBAltaUsuNomUsuGer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BTNAltaUsuarioGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltasEjecutivoYJefeDeServicios";
            Text = "AltasEjecutivoYJefeDeServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label5;
        public Panel panel4;
        public Panel panel2;
        public Panel panel1;
        private TextBox TBAltaUsuPassGer;
        private TextBox TBAltaUsuNomUsuGer;
        public Label label4;
        public Label label3;
        public Label label1;
        public Button BTNAltaUsuarioGer;
        private ComboBox CBAltaTipoUsu;

        public TextBox TBAltaUsuPass1 { get => TBAltaUsuPassGer; set => TBAltaUsuPassGer = value; }
        public TextBox TBAltaUsuNom1 { get => TBAltaUsuNomUsuGer; set => TBAltaUsuNomUsuGer = value; }
        public ComboBox CBAltaTipoUsu1 { get => CBAltaTipoUsu; set => CBAltaTipoUsu = value; }
    }
}