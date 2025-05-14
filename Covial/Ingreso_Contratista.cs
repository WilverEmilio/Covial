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
    public partial class Ingreso_Contratista : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static Ingreso_Contratista _Instancia;

        public static Ingreso_Contratista GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_Contratista();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_Contratista();
            }
            return _Instancia;
        }

        public Ingreso_Contratista()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre del contratista");
            this.ttMensaje.SetToolTip(this.textContacto, "Ingrese el nombre del contacto");
            this.ttMensaje.SetToolTip(this.textTelefono, "Ingrese el telefono del contacto");
            this.ttMensaje.SetToolTip(this.textDireccion, "Ingrese la direccion del contratista");
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Contratistas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Contratistas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.textNombre.Text = string.Empty;
            this.textContacto.Text = string.Empty;
            this.textTelefono.Text = string.Empty;
            this.textDireccion.Text = string.Empty;
            this.textIdContratista.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textContacto.ReadOnly = !valor;
            this.textTelefono.ReadOnly = !valor;
            this.textDireccion.ReadOnly = !valor;
        }

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

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            //this.datosListar.Columns[1].Visible = false;
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = ContratistaModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = ContratistaModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingreso_Contratista_Load(object sender, EventArgs e)
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

            this.textNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.textNombre.Text == string.Empty || this.textContacto.Text == string.Empty || this.textTelefono.Text == string.Empty || this.textDireccion.Text == string.Empty)
                {
                    MensajeError("Faltan datos por ingresar");
                    errorIcon.SetError(textNombre, "Ingrese un nombre");
                    errorIcon.SetError(textContacto, "Ingrese un contacto");
                    errorIcon.SetError(textTelefono, "Ingrese un telefono");
                    errorIcon.SetError(textDireccion, "Ingrese una direccion");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = ContratistaModel.Insertar(this.textNombre.Text.Trim().ToUpper(), this.textContacto.Text.Trim().ToUpper(), this.textTelefono.Text.Trim(), this.textDireccion.Text.Trim(), DateTime.Now);
                    }
                    else
                    {
                        rpta = ContratistaModel.Editar(Convert.ToInt32(this.textIdContratista.Text), this.textNombre.Text.Trim().ToUpper(), this.textContacto.Text.Trim().ToUpper(), this.textTelefono.Text.Trim(), this.textDireccion.Text.Trim(), DateTime.Now);
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
            if (!this.textIdContratista.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Seleccione el registro a modificar");
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
            if (e.ColumnIndex == this.datosListar.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)this.datosListar.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void datosListar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textIdContratista.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["contratista_id"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_contratista"].Value);
            this.textContacto.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["contacto"].Value);
            this.textTelefono.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["telefono"].Value);
            this.textDireccion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["direccion"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Sistema de Gestión de Contratistas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = ContratistaModel.Eliminar(id);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(rpta);
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
    }
}
