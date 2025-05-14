using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class Ingresar_Usuario : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static Ingresar_Usuario _Instancia;

        public static Ingresar_Usuario GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingresar_Usuario();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingresar_Usuario();
            }
            return _Instancia;
        }
        public Ingresar_Usuario()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre completo");
            this.ttMensaje.SetToolTip(this.textUsuario, "Ingrese el nombre de usuario");
            this.ttMensaje.SetToolTip(this.textContraseña, "Ingrese la contraseña");
            this.ttMensaje.SetToolTip(this.comboRol, "Seleccione el rol del usuario");

            this.textContraseña.PasswordChar = '*';
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo limpiar
        private void Limpiar()
        {
            this.textNombre.Text = string.Empty;
            this.textUsuario.Text = string.Empty;
            this.textContraseña.Text = string.Empty;
            this.comboRol.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textUsuario.ReadOnly = !valor;
            this.textContraseña.ReadOnly = !valor;
            this.comboRol.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnNuevo.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }

        }

        //Metodo para oculatr columnas
        private void OculatrColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            this.datosListar.Columns[1].Visible = false;
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.datosListar.DataSource = UserModel.Mostrar();
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = UserModel.BuscarNombre(this.textBuscar.Text);
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingresar_Usuario_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

            this.textUsuario.Focus();

            foreach (DataGridViewColumn col in datosListar.Columns)
            {
                MessageBox.Show(col.Name);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.textUsuario.Text == string.Empty || this.textContraseña.Text == string.Empty || this.comboRol.Text == string.Empty)
                {
                    MensajeError("Faltan datos por ingresar");
                    errorIcon.SetError(textUsuario, "Ingrese un nombre de usuario");
                    errorIcon.SetError(textContraseña, "Ingrese una contraseña");
                    errorIcon.SetError(comboRol, "Seleccione un rol");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = UserModel.Insertar(this.textUsuario.Text.Trim().ToUpper(), this.textContraseña.Text.Trim(), this.comboRol.Text, this.textNombre.Text.Trim(), true, DateTime.Now);
                    }
                    else
                    {
                        rpta = UserModel.Editar(Convert.ToInt32(this.datosListar.CurrentRow.Cells["usuario_id"].Value), this.textUsuario.Text.Trim().ToUpper(), this.textContraseña.Text.Trim(), this.comboRol.Text, this.textNombre.Text.Trim(), true, DateTime.Now);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                                        this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.textIdUsuario.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Seleccione el registro a editar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsEditar = false;
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.Mostrar();
        }

        private void datosListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datosListar.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChEliminar =
                    (DataGridViewCheckBoxCell)datosListar.Rows[e.RowIndex].Cells["Eliminar"];

                ChEliminar.Value = !(Convert.ToBoolean(ChEliminar.Value));
            }
        }

        private void datosListar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textIdUsuario.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["usuario_id"].Value);
            this.textUsuario.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_usuario"].Value);
            this.textContraseña.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["contrasena"].Value);
            this.comboRol.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["rol"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_completo"].Value);


        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                this.datosListar.Columns[0].Visible = true;
            }
            else
            {
                this.datosListar.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema de Gestión de Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string id;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToString(row.Cells[1].Value);
                            Rpta = UserModel.Eliminar(Convert.ToInt32(id));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.checkEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
