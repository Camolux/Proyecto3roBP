namespace GUI.Diseño.Gerente.Vehiculos
{
    partial class EmitirFacturasServicios
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
            label8 = new Label();
            mTBFacturaFecha = new MaskedTextBox();
            TBFacturaCI = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            TBFacturaMatr = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            BTNImprimirFactura = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(48, 339);
            label8.Name = "label8";
            label8.Size = new Size(230, 18);
            label8.TabIndex = 162;
            label8.Text = "Ingrese Fecha De inicio se servicio";
            // 
            // mTBFacturaFecha
            // 
            mTBFacturaFecha.Location = new Point(309, 334);
            mTBFacturaFecha.Mask = "00/00/0000 00:00";
            mTBFacturaFecha.Name = "mTBFacturaFecha";
            mTBFacturaFecha.Size = new Size(230, 23);
            mTBFacturaFecha.TabIndex = 160;
            mTBFacturaFecha.ValidatingType = typeof(DateTime);
            // 
            // TBFacturaCI
            // 
            TBFacturaCI.BackColor = SystemColors.ActiveCaption;
            TBFacturaCI.BorderStyle = BorderStyle.None;
            TBFacturaCI.Location = new Point(246, 274);
            TBFacturaCI.Name = "TBFacturaCI";
            TBFacturaCI.Size = new Size(230, 16);
            TBFacturaCI.TabIndex = 159;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(221, 61);
            label5.Name = "label5";
            label5.Size = new Size(285, 50);
            label5.TabIndex = 149;
            label5.Text = "Emitir facturas";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(246, 294);
            panel9.Name = "panel9";
            panel9.Size = new Size(230, 2);
            panel9.TabIndex = 157;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(48, 278);
            label9.Name = "label9";
            label9.Size = new Size(183, 18);
            label9.TabIndex = 154;
            label9.Text = "Ingrese Cedula del Clientes";
            // 
            // TBFacturaMatr
            // 
            TBFacturaMatr.BackColor = SystemColors.ActiveCaption;
            TBFacturaMatr.BorderStyle = BorderStyle.None;
            TBFacturaMatr.Location = new Point(246, 216);
            TBFacturaMatr.Name = "TBFacturaMatr";
            TBFacturaMatr.Size = new Size(230, 16);
            TBFacturaMatr.TabIndex = 166;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(246, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 214);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 164;
            label1.Text = "Ingrese Matricula";
            // 
            // BTNImprimirFactura
            // 
            BTNImprimirFactura.BackColor = SystemColors.ButtonFace;
            BTNImprimirFactura.FlatAppearance.BorderSize = 0;
            BTNImprimirFactura.FlatStyle = FlatStyle.Flat;
            BTNImprimirFactura.Location = new Point(230, 435);
            BTNImprimirFactura.Name = "BTNImprimirFactura";
            BTNImprimirFactura.Size = new Size(204, 38);
            BTNImprimirFactura.TabIndex = 167;
            BTNImprimirFactura.Text = "imprimir factura";
            BTNImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // EmitirFacturasServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(711, 539);
            Controls.Add(BTNImprimirFactura);
            Controls.Add(TBFacturaMatr);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(mTBFacturaFecha);
            Controls.Add(TBFacturaCI);
            Controls.Add(label5);
            Controls.Add(panel9);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmitirFacturasServicios";
            Text = "EmitirFacturasServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private MaskedTextBox mTBFacturaFecha;
        private TextBox TBFacturaCI;
        private Label label5;
        private Panel panel9;
        private Label label9;
        private TextBox TBFacturaMatr;
        private Panel panel1;
        private Label label1;
        private Button BTNImprimirFactura;
    }
}