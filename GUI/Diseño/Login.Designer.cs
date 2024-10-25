namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            BTNConfirmar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            TBNomUsu = new TextBox();
            panel2 = new Panel();
            TBPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 232);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(55, 322);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // BTNConfirmar
            // 
            BTNConfirmar.BackColor = SystemColors.ActiveCaption;
            BTNConfirmar.FlatAppearance.BorderSize = 0;
            BTNConfirmar.FlatStyle = FlatStyle.Flat;
            BTNConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTNConfirmar.ForeColor = SystemColors.ActiveCaptionText;
            BTNConfirmar.Location = new Point(33, 412);
            BTNConfirmar.Name = "BTNConfirmar";
            BTNConfirmar.Size = new Size(286, 37);
            BTNConfirmar.TabIndex = 5;
            BTNConfirmar.Text = "Login";
            BTNConfirmar.UseVisualStyleBackColor = false;
            BTNConfirmar.Click += BTNConfirmar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_08_08_a_las_20_52_05_2f3b1360_removebg_preview;
            pictureBox1.Location = new Point(84, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 196);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cerrar_con_llave;
            pictureBox2.Location = new Point(33, 313);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 27);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.usuario;
            pictureBox3.Location = new Point(34, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 24);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(34, 270);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 2);
            panel1.TabIndex = 65;
            // 
            // TBNomUsu
            // 
            TBNomUsu.BackColor = Color.White;
            TBNomUsu.BorderStyle = BorderStyle.None;
            TBNomUsu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TBNomUsu.Location = new Point(34, 253);
            TBNomUsu.Name = "TBNomUsu";
            TBNomUsu.Size = new Size(280, 16);
            TBNomUsu.TabIndex = 64;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(34, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 2);
            panel2.TabIndex = 67;
            // 
            // TBPass
            // 
            TBPass.BackColor = Color.White;
            TBPass.BorderStyle = BorderStyle.None;
            TBPass.Location = new Point(34, 343);
            TBPass.Name = "TBPass";
            TBPass.PasswordChar = '*';
            TBPass.Size = new Size(280, 16);
            TBPass.TabIndex = 66;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(353, 543);
            Controls.Add(panel2);
            Controls.Add(TBPass);
            Controls.Add(panel1);
            Controls.Add(TBNomUsu);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BTNConfirmar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoreTex";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button BTNConfirmar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox TBNomUsu;
        private Panel panel2;
        private TextBox TBPass;

        public TextBox TBPass1 { get => TBPass; set => TBPass = value; }
        public TextBox TBNomUsu1 { get => TBNomUsu; set => TBNomUsu = value; }
    }
}
