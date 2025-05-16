using System.Data;
using System.Runtime.InteropServices;
using Presentation;

namespace Covial
{
    public partial class Ingreso_al_sistema : Form
    {
        public Ingreso_al_sistema()
        {
            InitializeComponent();
        }

        #region Funciones del formulario
        //para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void usuario_Enter(object sender, EventArgs e)
        {
            if (usuario.Text == "Usuario")
            {
                usuario.Text = "";
                usuario.ForeColor = Color.Black;
            }
        }

        private void usuario_Leave(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                usuario.Text = "Usuario";
                usuario.ForeColor = Color.Black;
            }
        }

        private void contrasena_Enter(object sender, EventArgs e)
        {
            if (contraseña.Text == "Contraseña")
            {
                contraseña.Text = "";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void contrasena_Leave(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Contraseña";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Ingreso_al_sistema_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Funcion ingresar
        private void login_Click(object sender, EventArgs e)
        {
            DataTable Datos = Domain.UserModel.Login(usuario.Text, contraseña.Text);

           //Evaluar si existe el usuario
           if (Datos.Rows.Count == 0)
            {
                msgError("Usuario o contraseña incorrectos");
                contraseña.Text = "Contraseña";
                usuario.Focus();
                contraseña.UseSystemPasswordChar = false;
            }
           else
            {
                this.Hide();
                Bienvenida bienvenida = new Bienvenida();
                bienvenida.usuario_id = Datos.Rows[0][0].ToString();
                bienvenida.nombre_usuario = Datos.Rows[0][1].ToString();
                bienvenida.rol = Datos.Rows[0][3].ToString();
                bienvenida.ShowDialog();

                Principal principal = new Principal();
                principal.usuario_id = Datos.Rows[0][0].ToString();
                principal.nombre_usuario = Datos.Rows[0][1].ToString();
                principal.rol = Datos.Rows[0][3].ToString();
                principal.Show();
                principal.FormClosed += (s, args) => this.Close();
            }
        }

        private void msgError(string msg)
        {
            labelError.Text = "     " + msg;
            labelError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            contraseña.Text = "Contraseña";
            contraseña.UseSystemPasswordChar = false;
            usuario.Text = "Usuario";
            labelError.Visible = false;
            this.Show();
        }
        #endregion

        private void Ingreso_al_sistema_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }


    }
}
