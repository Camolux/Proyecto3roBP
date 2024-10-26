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
            dataGridViewClientes = new DataGridView();
            label5 = new Label();
            panel1 = new Panel();
            TBBuscarClienteCI = new TextBox();
            label1 = new Label();
            BTNBuscarClientesGer = new Button();
            BTNMostrarClientesGer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(73, 180);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(589, 268);
            dataGridViewClientes.TabIndex = 58;
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
            // TBBuscarClienteCI
            // 
            TBBuscarClienteCI.BackColor = SystemColors.ActiveCaption;
            TBBuscarClienteCI.BorderStyle = BorderStyle.None;
            TBBuscarClienteCI.Location = new Point(266, 140);
            TBBuscarClienteCI.Name = "TBBuscarClienteCI";
            TBBuscarClienteCI.Size = new Size(246, 16);
            TBBuscarClienteCI.TabIndex = 55;
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
            // BTNBuscarClientesGer
            // 
            BTNBuscarClientesGer.BackColor = SystemColors.ButtonFace;
            BTNBuscarClientesGer.FlatAppearance.BorderSize = 0;
            BTNBuscarClientesGer.FlatStyle = FlatStyle.Flat;
            BTNBuscarClientesGer.Location = new Point(121, 469);
            BTNBuscarClientesGer.Name = "BTNBuscarClientesGer";
            BTNBuscarClientesGer.Size = new Size(204, 38);
            BTNBuscarClientesGer.TabIndex = 53;
            BTNBuscarClientesGer.Text = "Buscar";
            BTNBuscarClientesGer.UseVisualStyleBackColor = false;
            BTNBuscarClientesGer.Click += BTNBuscarClientesGer_Click;
            // 
            // BTNMostrarClientesGer
            // 
            BTNMostrarClientesGer.BackColor = SystemColors.ButtonFace;
            BTNMostrarClientesGer.FlatAppearance.BorderSize = 0;
            BTNMostrarClientesGer.FlatStyle = FlatStyle.Flat;
            BTNMostrarClientesGer.Location = new Point(404, 469);
            BTNMostrarClientesGer.Name = "BTNMostrarClientesGer";
            BTNMostrarClientesGer.Size = new Size(204, 38);
            BTNMostrarClientesGer.TabIndex = 59;
            BTNMostrarClientesGer.Text = "Mostrar";
            BTNMostrarClientesGer.UseVisualStyleBackColor = false;
            BTNMostrarClientesGer.Click += BTNMostrarClientesGer_Click;
            // 
            // ListadosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(BTNMostrarClientesGer);
            Controls.Add(dataGridViewClientes);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(TBBuscarClienteCI);
            Controls.Add(label1);
            Controls.Add(BTNBuscarClientesGer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListadosClientes";
            Text = "ListadosClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Label label5;
        private Panel panel1;
        private TextBox TBBuscarClienteCI;
        private Label label1;
        private Button BTNBuscarClientesGer;
        private Button BTNMostrarClientesGer;

        public DataGridView DataGridViewClientes { get => dataGridViewClientes; set => dataGridViewClientes = value; }
        public TextBox TBBuscarClienteCI1 { get => TBBuscarClienteCI; set => TBBuscarClienteCI = value; }
    }
}