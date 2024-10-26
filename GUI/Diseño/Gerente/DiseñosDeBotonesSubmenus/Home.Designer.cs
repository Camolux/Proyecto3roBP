namespace GUI
{
    partial class Home
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
            panelContenedordesubmenusHome = new Panel();
            pictureBox2 = new PictureBox();
            panelContenedordesubmenusHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelContenedordesubmenusHome
            // 
            panelContenedordesubmenusHome.BackColor = SystemColors.ActiveCaption;
            panelContenedordesubmenusHome.Controls.Add(pictureBox2);
            panelContenedordesubmenusHome.Dock = DockStyle.Fill;
            panelContenedordesubmenusHome.Location = new Point(0, 0);
            panelContenedordesubmenusHome.Name = "panelContenedordesubmenusHome";
            panelContenedordesubmenusHome.Size = new Size(711, 749);
            panelContenedordesubmenusHome.TabIndex = 2;
            panelContenedordesubmenusHome.Paint += panelContenedordesubmenusHome_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.Logo_Home;
            pictureBox2.Location = new Point(261, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 177);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 749);
            Controls.Add(panelContenedordesubmenusHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            panelContenedordesubmenusHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedordesubmenusHome;
        private PictureBox pictureBox2;
    }
}