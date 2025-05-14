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
    public partial class Ingreso_Tipo_Programa : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static Ingreso_Tipo_Programa _Instancia;

        public static Ingreso_Tipo_Programa GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_Tipo_Programa();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_Tipo_Programa();
            }
            return _Instancia;
        }
        public Ingreso_Tipo_Programa()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre del tipo de programa");
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.textNombre.Text = string.Empty;
            this.textIdTipoPrograma.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textIdTipoPrograma.ReadOnly = !valor;
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

        private void OculatrColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = TipoProgramaModel.Mostrar();
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = TipoProgramaModel.BuscarNombre(this.textBuscar.Text);
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingreso_Tipo_Programa_Load(object sender, EventArgs e)
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
                if (this.textNombre.Text == string.Empty)
                {
                    MensajeError("Faltan datos pro ingresar");
                    errorIcon.SetError(textNombre, "Ingrese un nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = TipoProgramaModel.Insertar(this.textNombre.Text.Trim());
                    }
                    else
                    {
                        rpta = TipoProgramaModel.Editar(Convert.ToInt32(this.textIdTipoPrograma.Text), this.textNombre.Text.Trim());
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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.textIdTipoPrograma.Text.Equals(""))
            {
                this.IsEditar = true;
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
            if (e.ColumnIndex == datosListar.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChEliminar =
                    (DataGridViewCheckBoxCell)datosListar.Rows[e.RowIndex].Cells["Eliminar"];

                ChEliminar.Value = !(Convert.ToBoolean(ChEliminar.Value));
            }
        }

        private void datosListar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textIdTipoPrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["tipo_programa_id"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_tipo"].Value);
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
                Opcion = MessageBox.Show("Realmente desea eliminar los registros", "Sistema de Gestión de Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string id;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id = Convert.ToString(row.Cells[1].Value);
                            Rpta = TipoProgramaModel.Eliminar(Convert.ToInt32(id));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + id);
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                this.Mostrar();
                this.checkEliminar.Checked = false;
            }
        }
    }
}
