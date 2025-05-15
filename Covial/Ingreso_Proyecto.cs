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
    public partial class Ingreso_Proyecto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        private static Ingreso_Proyecto _Instancia;

        public static Ingreso_Proyecto GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_Proyecto();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_Proyecto();
            }
            return _Instancia;
        }

        public Ingreso_Proyecto()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre del proyecto");
            this.ttMensaje.SetToolTip(this.textDescripcion, "Ingrese la descripción del proyecto");
            this.ttMensaje.SetToolTip(this.textUbicacion, "Ingrese la ubicación del proyecto");
            this.ttMensaje.SetToolTip(this.textCantidadEstimada, "Ingrese la cantidad estimada del proyecto");
            this.ttMensaje.SetToolTip(this.textCostoUnitario, "Ingrese el costo unitario del proyecto");
            this.ttMensaje.SetToolTip(this.textPresupuesto, "Ingrese el presupuesto del proyecto");
            this.ttMensaje.SetToolTip(this.dateTimePickerInicio, "Seleccione la fecha de inicio del proyecto");
            this.ttMensaje.SetToolTip(this.dateTimePickerFin, "Seleccione la fecha de fin del proyecto");
            this.ttMensaje.SetToolTip(this.textEstado, "Ingrese el estado del proyecto");
            this.ttMensaje.SetToolTip(this.textCreadoPor, "Ingrese el nombre del usuario que creó el proyecto");
            this.ttMensaje.SetToolTip(this.textNombrePrograma, "Seleccione el programa del proyecto");
            this.ttMensaje.SetToolTip(this.textNombreContratista, "Seleccione el contratista del proyecto");
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
            this.textDescripcion.Text = string.Empty;
            this.textUbicacion.Text = string.Empty;
            this.textCantidadEstimada.Text = string.Empty;
            this.textCostoUnitario.Text = string.Empty;
            this.textPresupuesto.Text = string.Empty;
            this.dateTimePickerInicio.Value = DateTime.Now;
            this.dateTimePickerFin.Value = DateTime.Now;
            this.textNombrePrograma.Text = string.Empty;
            this.textNombreContratista.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textDescripcion.ReadOnly = !valor;
            this.textUbicacion.ReadOnly = !valor;
            this.textCantidadEstimada.ReadOnly = !valor;
            this.textCostoUnitario.ReadOnly = !valor;
            this.textPresupuesto.ReadOnly = !valor;
            this.dateTimePickerInicio.Enabled = valor;
            this.dateTimePickerFin.Enabled = valor;
            this.textEstado.ReadOnly = !valor;
            this.textCreadoPor.ReadOnly = !valor;
            this.textNombrePrograma.ReadOnly = !valor;
            this.textNombreContratista.ReadOnly = !valor;
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

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            this.datosListar.Columns[2].Visible = false;
            this.datosListar.Columns[4].Visible = false;
            this.datosListar.Columns[17].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.textEstado.Text = "Planificado";

            this.textIdUser.Text = UsuarioId;
            this.textCreadoPor.Text = NombreUsuario;

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

            this.textNombre.Focus();
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = ProyectoModel.Mostrar();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = ProyectoModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingreso_Proyecto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.textNombre.Text == string.Empty || this.textDescripcion.Text == string.Empty || this.textUbicacion.Text == string.Empty || this.textCantidadEstimada.Text == string.Empty || this.textCostoUnitario.Text == string.Empty || this.textPresupuesto.Text == string.Empty || this.textEstado.Text == string.Empty || this.textCreadoPor.Text == string.Empty || this.textNombrePrograma.Text == string.Empty || this.textNombreContratista.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcon.SetError(textNombre, "Ingrese un nombre");
                    errorIcon.SetError(textDescripcion, "Ingrese una descripción");
                    errorIcon.SetError(textUbicacion, "Ingrese una ubicación");
                    errorIcon.SetError(textCantidadEstimada, "Ingrese una cantidad estimada");
                    errorIcon.SetError(textCostoUnitario, "Ingrese un costo unitario");
                    errorIcon.SetError(textPresupuesto, "Ingrese un presupuesto");
                    errorIcon.SetError(textEstado, "Ingrese un estado");
                    errorIcon.SetError(textCreadoPor, "Ingrese un creador");
                    errorIcon.SetError(textNombrePrograma, "Seleccione un programa");
                    errorIcon.SetError(textNombreContratista, "Seleccione un contratista");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = ProyectoModel.Insertar(Convert.ToInt32(this.textIdPrograma.Text), Convert.ToInt32(this.textIdContratista.Text), this.textNombre.Text.Trim().ToUpper(), this.textDescripcion.Text.Trim().ToUpper(), this.textUbicacion.Text.Trim().ToUpper(),this.textUnidadDeMedida.Text.Trim().ToUpper(), Convert.ToDecimal(this.textCantidadEstimada.Text), Convert.ToDecimal(this.textCostoUnitario.Text), Convert.ToDecimal(this.textPresupuesto.Text), Convert.ToDateTime(this.dateTimePickerInicio.Value), Convert.ToDateTime(this.dateTimePickerFin.Value), this.textEstado.Text.Trim().ToUpper(), DateTime.Now, Convert.ToInt32(this.textIdUser.Text));
                    }
                    else
                    {
                        rpta = ProyectoModel.Editar(Convert.ToInt32(this.textIdProyecto.Text), Convert.ToInt32(this.textIdPrograma.Text), Convert.ToInt32(this.textIdContratista.Text), this.textNombre.Text.Trim().ToUpper(), this.textDescripcion.Text.Trim().ToUpper(), this.textUbicacion.Text.Trim().ToUpper(), this.textUnidadDeMedida.Text.Trim().ToUpper(), Convert.ToDecimal(this.textCantidadEstimada.Text), Convert.ToDecimal(this.textCostoUnitario.Text), Convert.ToDecimal(this.textPresupuesto.Text), Convert.ToDateTime(this.dateTimePickerInicio.Value), Convert.ToDateTime(this.dateTimePickerFin.Value), this.textEstado.Text.Trim().ToUpper(), DateTime.Now, Convert.ToInt32(this.textIdUser.Text));
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
            if (!string.IsNullOrEmpty(this.textIdProyecto.Text))
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
            this.textIdProyecto.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["proyecto_id"].Value);
            this.textIdPrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["programa_id"].Value);
            this.textNombrePrograma.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_programa"].Value);
            this.textIdContratista.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["contratista_id"].Value);
            this.textNombreContratista.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_contratista"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_proyecto"].Value);
            this.textDescripcion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["descripcion"].Value);
            this.textUbicacion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["ubicacion"].Value);
            this.textCantidadEstimada.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["cantidad_estimada"].Value);
            this.textCostoUnitario.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["costo_unitario_estimado"].Value);
            this.textPresupuesto.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["presupuesto_estimado"].Value);
            this.dateTimePickerInicio.Value = Convert.ToDateTime(this.datosListar.CurrentRow.Cells["fecha_inicio_prevista"].Value);
            this.dateTimePickerFin.Value = Convert.ToDateTime(this.datosListar.CurrentRow.Cells["fecha_fin_prevista"].Value);
            this.textEstado.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["estado"].Value);
            this.textIdUser.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["usuario_id"].Value);
            this.textCreadoPor.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_usuario"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema de Gestión de Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = ProyectoModel.Eliminar(Convert.ToInt32(codigo));
                        }
                    }
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se eliminó correctamente el registro");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setPrograma(string idprograma, string nombreprograma)
        {
            this.textIdPrograma.Text = idprograma;
            this.textNombrePrograma.Text = nombreprograma;
        }

        public void setContratista(string idcontratista, string nombrecontratista)
        {
            this.textIdContratista.Text = idcontratista;
            this.textNombreContratista.Text = nombrecontratista;
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            SeleccionarPrograma forma = new SeleccionarPrograma();
            forma.ShowDialog();
        }

        private void btnBuscarContratista_Click(object sender, EventArgs e)
        {
            SeleccionarContratista forma = new SeleccionarContratista();
            forma.ShowDialog();
        }
    }
}
