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
    public partial class Ingreso_Plan_Anual : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        private static Ingreso_Plan_Anual _Instancia;

        public static Ingreso_Plan_Anual GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_Plan_Anual();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_Plan_Anual();
            }
            return _Instancia;
        }
        public Ingreso_Plan_Anual()
        {
            InitializeComponent();


            this.ttMensaje.SetToolTip(this.textNombre, "Ingrese el nombre del plan");
            this.ttMensaje.SetToolTip(this.textDescripcion, "Ingrese la descripcion del plan");
            this.ttMensaje.SetToolTip(this.textCreadoPor, "Ingrese el nombre del creador del plan");
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
            this.textIdUsuario.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textNombre.ReadOnly = !valor;
            this.textDescripcion.ReadOnly = !valor;
            this.textCreadoPor.ReadOnly = !valor;
            this.textIdUser.ReadOnly = !valor;
            this.textIdUsuario.ReadOnly = !valor;
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
            this.datosListar.Columns[6].Visible = false;
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = PlanAnualModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = PlanAnualModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingreso_Plan_Anual_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

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


            this.textIdUser.Text = UsuarioId;
            this.textCreadoPor.Text = NombreUsuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int anio = dateTimePicker1.Value.Year;
            try
            {
                string rpta = "";
                if (this.textNombre.Text == string.Empty || this.textDescripcion.Text == string.Empty || this.textCreadoPor.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcon.SetError(textNombre, "Ingrese el nombre del plan");
                    errorIcon.SetError(textDescripcion, "Ingrese la descripcion del plan");
                    errorIcon.SetError(textCreadoPor, "Ingrese el nombre del creador del plan");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = PlanAnualModel.Insertar(
                            Convert.ToInt32(this.dateTimePicker1.Value.Year),
                            this.textNombre.Text.Trim(),
                            this.textDescripcion.Text.Trim(),
                            DateTime.Now, // Fecha actual
                            Convert.ToInt32(this.textIdUser.Text) // Asegúrate de usar .Text aquí
                        );
                    }
                    else
                    {
                        rpta = PlanAnualModel.Editar(
                            Convert.ToInt32(this.datosListar.CurrentRow.Cells["plan_anual_id"].Value),
                            this.dateTimePicker1.Value.Year,  // Solo el año como int
                            this.textNombre.Text.Trim(),      // Extraer el texto
                            this.textDescripcion.Text.Trim(),
                            DateTime.Now,                     // Fecha actual
                            Convert.ToInt32(this.textIdUser.Text) // Asegúrate de usar .Text aquí
                        );
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
            if (!string.IsNullOrEmpty(this.textIdUser.Text))
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
            this.textIdUser.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["plan_anual_id"].Value);
            this.textNombre.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_plan"].Value);
            this.textDescripcion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["descripcion"].Value);
            int year = Convert.ToInt32(this.datosListar.CurrentRow.Cells["año"].Value);
            this.dateTimePicker1.Value = new DateTime(year, 1, 1); // Defaults to January 1st of the year
            this.textCreadoPor.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["creado_por"].Value);
            this.textIdUser.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["usuario_id"].Value);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema de Gestión de Usuarios",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Id;
                    string rpta = "";
                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            rpta = PlanAnualModel.Eliminar(Convert.ToInt32(Id));
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
                    this.checkEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Sistema de Gestión de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
