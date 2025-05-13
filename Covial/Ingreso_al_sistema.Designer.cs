namespace Covial
{
    partial class Ingreso_al_sistema
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            usuario = new TextBox();
            contraseña = new TextBox();
            labelError = new Label();
            login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Presentation.Properties.Resources.covial;
            pictureBox1.Location = new Point(160, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 157, 228);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 219);
            panel1.TabIndex = 1;
            // 
            // usuario
            // 
            usuario.Font = new Font("Century Gothic", 14.25F);
            usuario.Location = new Point(161, 261);
            usuario.Name = "usuario";
            usuario.Size = new Size(374, 31);
            usuario.TabIndex = 1;
            usuario.Text = "Usuario";
            usuario.Enter += usuario_Enter;
            usuario.Leave += usuario_Leave;
            // 
            // contraseña
            // 
            contraseña.Font = new Font("Century Gothic", 14.25F);
            contraseña.Location = new Point(161, 298);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(374, 31);
            contraseña.TabIndex = 2;
            contraseña.Text = "Contraseña";
            contraseña.Enter += contrasena_Enter;
            contraseña.Leave += contrasena_Enter;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.FromArgb(15, 15, 15);
            labelError.Font = new Font("Century Gothic", 9.75F);
            labelError.ForeColor = Color.Red;
            labelError.Image = Presentation.Properties.Resources.advertencia;
            labelError.ImageAlign = ContentAlignment.MiddleLeft;
            labelError.Location = new Point(161, 341);
            labelError.Name = "labelError";
            labelError.Size = new Size(95, 17);
            labelError.TabIndex = 4;
            labelError.Text = "Error Message";
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(40, 40, 40);
            login.FlatStyle = FlatStyle.Popup;
            login.Font = new Font("Century Gothic", 14.25F);
            login.ForeColor = Color.LightGray;
            login.Location = new Point(195, 388);
            login.Name = "login";
            login.Size = new Size(314, 46);
            login.TabIndex = 3;
            login.Text = "Acceder";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // Ingreso_al_sistema
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(686, 492);
            Controls.Add(login);
            Controls.Add(labelError);
            Controls.Add(contraseña);
            Controls.Add(usuario);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ingreso_al_sistema";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Ingreso_al_sistema_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox usuario;
        private TextBox contraseña;
        private Label labelError;
        private Button login;
    }
}
