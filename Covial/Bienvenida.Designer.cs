namespace Presentation
{
    partial class Bienvenida
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lblusuario = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(15, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(132, 38);
            label1.Name = "label1";
            label1.Size = new Size(352, 29);
            label1.TabIndex = 2;
            label1.Text = "Control de avance de proyectos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 157, 228);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 111);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Microsoft Sans Serif", 40F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(312, 141);
            label2.Name = "label2";
            label2.Size = new Size(375, 63);
            label2.TabIndex = 2;
            label2.Text = "BIENVENIDO!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Carretera;
            pictureBox2.Location = new Point(50, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Microsoft Sans Serif", 18F);
            lblusuario.ForeColor = SystemColors.ButtonFace;
            lblusuario.Location = new Point(445, 221);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(96, 29);
            lblusuario.TabIndex = 4;
            lblusuario.Text = "Usuario";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(312, 270);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(375, 23);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 346);
            Controls.Add(progressBar1);
            Controls.Add(lblusuario);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label lblusuario;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}