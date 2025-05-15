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
    public partial class Ingreso_Programas : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static Ingreso_Programas _Instancia;

        public static Ingreso_Programas GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_Programas();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_Programas();
            }
            return _Instancia;
        }
        public Ingreso_Programas()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre del programa");
            this.ttMensaje.SetToolTip(this.textDescripcion, "Ingrese la descripcion del programa");
            this.ttMensaje.SetToolTip(this.dateTimePickerInicio, "Seleccione la fecha de inicio del programa");
            this.ttMensaje.SetToolTip(this.dateTimePickerFin, "Seleccione la fecha de fin del programa");
            this.ttMensaje.SetToolTip(this.textNombreTipoPrograma, "Seleccione el tipo de programa");
            this.ttMensaje.SetToolTip(this.textNombrePlanAnual, "Seleccione el Plan Anual");
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
            this.textDescripcion.Text = string.Empty;
            this.dateTimePickerInicio.Value = DateTime.Now;
            this.dateTimePickerFin.Value = DateTime.Now;
            this.textNombreTipoPrograma.Text = string.Empty;
            this.textNombrePlanAnual.Text = string.Empty;
            this.textIdTipoPrograma.Text = string.Empty;
            this.textIdPlanAnual.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.Enabled = valor;
            this.textDescripcion.Enabled = valor;
            this.dateTimePickerInicio.Enabled = valor;
            this.dateTimePickerFin.Enabled = valor;
            this.textNombreTipoPrograma.Enabled = valor;
            this.textNombrePlanAnual.Enabled = valor;
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

        private void OculatrColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            this.datosListar.Columns[2].Visible = false;
            this.datosListar.Columns[4].Visible = false;
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = ProgramaModel.Mostrar();
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = ProgramaModel.BuscarNombre(this.textBuscar.Text);
            this.OculatrColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingreso_Programas_Load(object sender, EventArgs e)
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
                if (this.textNombre.Text == string.Empty || this.textDescripcion.Text == string.Empty || this.textNombreTipoPrograma.Text == string.Empty || this.textNombrePlanAnual.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcon.SetError(textNombre, "Ingrese el nombre del programa");
                    errorIcon.SetError(textDescripcion, "Ingrese la descripcion del programa");
                    errorIcon.SetError(textNombreTipoPrograma, "Seleccione el tipo de programa");
                    errorIcon.SetError(textNombrePlanAnual, "Seleccione el Plan Anual");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = ProgramaModel.Insertar(
                            Convert.ToInt32(this.textIdPlanAnual.Text),
                            Convert.ToInt32(this.textIdTipoPrograma.Text),
                            this.textNombre.Text.Trim().ToUpper(),
                            this.textDescripcion.Text.Trim(),
                            this.dateTimePickerInicio.Value,
                            this.dateTimePickerFin.Value,
                            DateTime.Now);
                    }
                    else
                    {
                        rpta = ProgramaModel.Editar(
                            Convert.ToInt32(this.textIdPrograma.Text),
                            Convert.ToInt32(this.textIdPlanAnual.Text),
                            Convert.ToInt32(this.textIdTipoPrograma.Text),
                            this.textNombre.Text.Trim().ToUpper(),
                            this.textDescripcion.Text.Trim(),
                            this.dateTimePickerInicio.Value,
                            this.dateTimePickerFin.Value,
                            DateTime.Now);
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
            if (!this.textIdPrograma.Text.Equals(""))
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
            this.textIdPrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["programa_id"].Value);
            this.textIdPlanAnual.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["plan_anual_id"].Value);
            this.textIdTipoPrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["tipo_programa_id"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_programa"].Value);
            this.textDescripcion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["descripcion"].Value);
            this.dateTimePickerInicio.Value = Convert.ToDateTime(this.datosListar.CurrentRow.Cells["fecha_inicio_prevista"].Value);
            this.dateTimePickerFin.Value = Convert.ToDateTime(this.datosListar.CurrentRow.Cells["fecha_fin_prevista"].Value);
            this.textNombrePlanAnual.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_plan"].Value);
            this.textNombreTipoPrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_tipo"].Value);

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
                    int Id;
                    string Rpta = "";
                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Id = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = ProgramaModel.Eliminar(Id);
                                if (!Rpta.Equals("OK"))
                                {
                                    this.MensajeError(Rpta);
                                }
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
        public void setPlanAnual(string idplan, string nombre)
        {
            this.textIdPlanAnual.Text = idplan;
            this.textNombrePlanAnual.Text = nombre;
        }

        public void setTipoPrograma(string idtipo, string nombre)
        {
            this.textIdTipoPrograma.Text = idtipo;
            this.textNombreTipoPrograma.Text = nombre;
        }

        private void btnBuscarPlanAnual_Click(object sender, EventArgs e)
        {
            SeleccionarPlanAnual form = new SeleccionarPlanAnual();
            form.ShowDialog();
        }

        private void btnBuscarTipoPrograma_Click(object sender, EventArgs e)
        {
            SeleccionarTipoPrograma forma = new SeleccionarTipoPrograma();
            forma.ShowDialog();
        }
    }
}
