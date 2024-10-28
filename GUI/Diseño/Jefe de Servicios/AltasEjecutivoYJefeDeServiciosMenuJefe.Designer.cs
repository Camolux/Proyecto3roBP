namespace GUI.Diseño.Jefe_de_Servicios
{
    partial class AltasEjecutivoYJefeDeServiciosMenuJefe
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
            TBAltaFuncionarioContra = new TextBox();
            TBAltaFuncionarioNom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnIngresarFuncionarioGer = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 68);
            label5.Name = "label5";
            label5.Size = new Size(619, 50);
            label5.TabIndex = 111;
            label5.Text = "Altas Ejecutivo, Cajero Y Operador";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(249, 344);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 2);
            panel4.TabIndex = 109;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(249, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 2);
            panel2.TabIndex = 110;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(249, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 2);
            panel1.TabIndex = 108;
            // 
            // TBAltaFuncionarioContra
            // 
            TBAltaFuncionarioContra.BackColor = SystemColors.ActiveCaption;
            TBAltaFuncionarioContra.BorderStyle = BorderStyle.None;
            TBAltaFuncionarioContra.Location = new Point(249, 274);
            TBAltaFuncionarioContra.Name = "TBAltaFuncionarioContra";
            TBAltaFuncionarioContra.Size = new Size(232, 16);
            TBAltaFuncionarioContra.TabIndex = 107;
            // 
            // TBAltaFuncionarioNom
            // 
            TBAltaFuncionarioNom.BackColor = SystemColors.ActiveCaption;
            TBAltaFuncionarioNom.BorderStyle = BorderStyle.None;
            TBAltaFuncionarioNom.Location = new Point(249, 232);
            TBAltaFuncionarioNom.Name = "TBAltaFuncionarioNom";
            TBAltaFuncionarioNom.Size = new Size(232, 16);
            TBAltaFuncionarioNom.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(121, 325);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 105;
            label4.Text = "Ingrese Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 280);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 104;
            label3.Text = "Ingrese Contrasenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 238);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 103;
            label1.Text = "Ingresr Username ";
            // 
            // btnIngresarFuncionarioGer
            // 
            btnIngresarFuncionarioGer.BackColor = SystemColors.ButtonFace;
            btnIngresarFuncionarioGer.FlatAppearance.BorderSize = 0;
            btnIngresarFuncionarioGer.FlatStyle = FlatStyle.Flat;
            btnIngresarFuncionarioGer.Location = new Point(268, 433);
            btnIngresarFuncionarioGer.Name = "btnIngresarFuncionarioGer";
            btnIngresarFuncionarioGer.Size = new Size(204, 38);
            btnIngresarFuncionarioGer.TabIndex = 102;
            btnIngresarFuncionarioGer.Text = "Dar de alta";
            btnIngresarFuncionarioGer.UseVisualStyleBackColor = false;
            btnIngresarFuncionarioGer.Click += btnIngresarFuncionarioGer_Click;
            // 
            // AltasEjecutivoYJefeDeServiciosMenuJefe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TBAltaFuncionarioContra);
            Controls.Add(TBAltaFuncionarioNom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnIngresarFuncionarioGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltasEjecutivoYJefeDeServiciosMenuJefe";
            Text = "AltasEjecutivoYJefeDeServiciosMenuJefe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBAltaFuncionarioRol;
        private Label label5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private TextBox TBAltaFuncionarioContra;
        private TextBox TBAltaFuncionarioNom;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnIngresarFuncionarioGer;

        public ComboBox CBAltaFuncionarioRol { get => cBAltaFuncionarioRol; set => cBAltaFuncionarioRol = value; }
        public TextBox TBAltaFuncionarioContra1 { get => TBAltaFuncionarioContra; set => TBAltaFuncionarioContra = value; }
        public TextBox TBAltaFuncionarioNom1 { get => TBAltaFuncionarioNom; set => TBAltaFuncionarioNom = value; }
    }
}