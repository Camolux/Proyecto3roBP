namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class ModificacionesEjecutivoYJefeDeServicios
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
            btnModFuncionario = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            TBModFuncionarioContra = new TextBox();
            TBModFuncionarioNom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 41);
            label5.Name = "label5";
            label5.Size = new Size(683, 50);
            label5.TabIndex = 164;
            label5.Text = "Modificar Ejecutivo y jefe de servicios";
            // 
            // btnModFuncionario
            // 
            btnModFuncionario.BackColor = SystemColors.ButtonFace;
            btnModFuncionario.FlatAppearance.BorderSize = 0;
            btnModFuncionario.FlatStyle = FlatStyle.Flat;
            btnModFuncionario.Location = new Point(264, 325);
            btnModFuncionario.Name = "btnModFuncionario";
            btnModFuncionario.Size = new Size(204, 38);
            btnModFuncionario.TabIndex = 153;
            btnModFuncionario.Text = "Modificar";
            btnModFuncionario.UseVisualStyleBackColor = false;
            btnModFuncionario.Click += btnModFuncionario_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(248, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 2);
            panel4.TabIndex = 172;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(248, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 2);
            panel2.TabIndex = 173;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(248, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 2);
            panel1.TabIndex = 171;
            // 
            // TBModFuncionarioContra
            // 
            TBModFuncionarioContra.BackColor = SystemColors.ActiveCaption;
            TBModFuncionarioContra.BorderStyle = BorderStyle.None;
            TBModFuncionarioContra.Location = new Point(248, 187);
            TBModFuncionarioContra.Name = "TBModFuncionarioContra";
            TBModFuncionarioContra.Size = new Size(232, 16);
            TBModFuncionarioContra.TabIndex = 170;
            // 
            // TBModFuncionarioNom
            // 
            TBModFuncionarioNom.BackColor = SystemColors.ActiveCaption;
            TBModFuncionarioNom.BorderStyle = BorderStyle.None;
            TBModFuncionarioNom.Location = new Point(248, 145);
            TBModFuncionarioNom.Name = "TBModFuncionarioNom";
            TBModFuncionarioNom.Size = new Size(232, 16);
            TBModFuncionarioNom.TabIndex = 169;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(120, 238);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 168;
            label4.Text = "Ingrese Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 193);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 167;
            label3.Text = "Ingrese Contrasenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 151);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 166;
            label1.Text = "Ingresr Username ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "ejecutivo", "operador", "cajero", "jefe" });
            comboBox1.Location = new Point(248, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 174;
            // 
            // ModificacionesEjecutivoYJefeDeServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(comboBox1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TBModFuncionarioContra);
            Controls.Add(TBModFuncionarioNom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnModFuncionario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificacionesEjecutivoYJefeDeServicios";
            Text = "ModificacionesEjecutivoYJefeDeServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button btnModFuncionario;
        private ComboBox cBModFuncionarioRol;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private TextBox TBModFuncionarioContra;
        private TextBox TBModFuncionarioNom;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;

        public ComboBox CBModFuncionarioRol { get => comboBox1; set => comboBox1 = value; }
        public TextBox TBModFuncionarioContra1 { get => TBModFuncionarioContra; set => TBModFuncionarioContra = value; }
        public TextBox TBModFuncionarioNom1 { get => TBModFuncionarioNom; set => TBModFuncionarioNom = value; }
    }
}