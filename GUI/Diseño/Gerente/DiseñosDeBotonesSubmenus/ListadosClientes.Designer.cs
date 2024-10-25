namespace GUI.Diseño.Gerente.Clientes
{
    partial class ListadosClientes
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
            dataGridViewVehiculos = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            btnIngresarVehiculos = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(73, 180);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.RowTemplate.Height = 25;
            dataGridViewVehiculos.Size = new Size(589, 268);
            dataGridViewVehiculos.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(225, 32);
            label5.Name = "label5";
            label5.Size = new Size(274, 50);
            label5.TabIndex = 57;
            label5.Text = "Listar Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(266, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(266, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 16);
            textBox1.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 140);
            label1.Name = "label1";
            label1.Size = new Size(147, 18);
            label1.TabIndex = 54;
            label1.Text = "Buscar Cliente por CI ";
            // 
            // btnIngresarVehiculos
            // 
            btnIngresarVehiculos.BackColor = SystemColors.ButtonFace;
            btnIngresarVehiculos.FlatAppearance.BorderSize = 0;
            btnIngresarVehiculos.FlatStyle = FlatStyle.Flat;
            btnIngresarVehiculos.Location = new Point(121, 469);
            btnIngresarVehiculos.Name = "btnIngresarVehiculos";
            btnIngresarVehiculos.Size = new Size(204, 38);
            btnIngresarVehiculos.TabIndex = 53;
            btnIngresarVehiculos.Text = "Buscar";
            btnIngresarVehiculos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(404, 469);
            button1.Name = "button1";
            button1.Size = new Size(204, 38);
            button1.TabIndex = 59;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ListadosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(button1);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnIngresarVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadosClientes";
            Text = "ListadosClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewVehiculos;
        private Label label5;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button btnIngresarVehiculos;
        private Button button1;
    }
}