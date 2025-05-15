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
    public partial class Ingreso_AvancesProyecto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        // Variable para la ruta de la imagen seleccionada
        private string rutaImagenActual = "";
        private PictureBox pictureBoxFoto = new PictureBox();

        private static Ingreso_AvancesProyecto _Instancia;

        public static Ingreso_AvancesProyecto GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingreso_AvancesProyecto();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingreso_AvancesProyecto();
            }
            return _Instancia;
        }


        public Ingreso_AvancesProyecto()
        {
            InitializeComponent();
            ConfigurarComponentes();

            this.ttMensaje.SetToolTip(this.textDescripcion, "Ingrese la descripción del avance");
            this.ttMensaje.SetToolTip(this.dateTimePickerInicio, "Seleccione una fecha");
            this.ttMensaje.SetToolTip(this.textReportadoPor, "Seleccione el nombre del reportador");
            this.ttMensaje.SetToolTip(this.textNombreProyecto, "Seleccione el proyecto");
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
            this.textDescripcion.Text = string.Empty;
            this.textReportadoPor.Text = string.Empty;
            this.textNombreProyecto.Text = string.Empty;
            this.dateTimePickerInicio.Value = DateTime.Now;
            this.textCantidadReportada.Text = string.Empty;
            this.textIdAvance.Text = string.Empty;
            this.textIdProyecto.Text = string.Empty;
            this.textIdAvance.Text = string.Empty;
            if (pictureBoxFoto.Image != null)
            {
                pictureBoxFoto.Image.Dispose();
                pictureBoxFoto.Image = null;
            }
        }

        private void Habilitar(bool valor)
        {
            this.textDescripcion.Enabled = valor;
            this.textReportadoPor.Enabled = valor;
            this.textNombreProyecto.Enabled = valor;
            this.dateTimePickerInicio.Enabled = valor;
            this.BtnCargarImagen.Enabled = valor;
            this.BtnLimpiar.Enabled = valor;
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

                this.BtnCargarImagen.Enabled = true;
                this.BtnLimpiar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                this.BtnCargarImagen.Enabled = false;
                this.BtnLimpiar.Enabled = false;
            }
        }

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            this.datosListar.Columns[2].Visible = false;
            this.datosListar.Columns[8].Visible = false;
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = AvanceProyectoModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = AvanceProyectoModel.Buscar(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void ConfigurarComponentes()
        {
            // Configurar el OpenFileDialog (si no está ya configurado en el diseñador)
            if (openFileDialog1 == null)
            {
                openFileDialog1 = new OpenFileDialog();
            }

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Seleccionar Imagen";

            // Configurar el pictureBox para la foto
            // Buscamos si ya existe un PictureBox en el formulario cerca de donde dice "Foto"
            // Si no se encuentra, lo creamos
            bool encontrado = false;
            foreach (Control c in this.Controls)
            {
                if (c is Panel || c is GroupBox || c is FlowLayoutPanel)
                {
                    foreach (Control child in c.Controls)
                    {
                        if (child is PictureBox && child.Location.X > 500)
                        {
                            pictureBoxFoto = (PictureBox)child;
                            encontrado = true;
                            break;
                        }
                    }
                }
                if (encontrado) break;
            }

            if (!encontrado)
            {
                // Si no encontramos un PictureBox existente, buscaremos el control "Foto" y añadiremos
                // un PictureBox a su lado
                foreach (Control c in this.Controls)
                {
                    if (c is Panel || c is GroupBox || c is FlowLayoutPanel)
                    {
                        foreach (Control child in c.Controls)
                        {
                            if (child is Label && child.Text.Contains("Foto"))
                            {
                                // Crear un nuevo PictureBox junto al label "Foto"
                                pictureBoxFoto = new PictureBox();
                                pictureBoxFoto.Size = new Size(250, 130);
                                pictureBoxFoto.Location = new Point(child.Location.X + 200, child.Location.Y);
                                pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle;
                                pictureBoxFoto.BackColor = Color.WhiteSmoke;

                                // Añadir el PictureBox al mismo contenedor del label
                                child.Parent.Controls.Add(pictureBoxFoto);
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    if (encontrado) break;
                }
            }

            // Buscar los botones de Cargar y Limpiar y asignar los eventos
            foreach (Control c in this.Controls)
            {
                if (c is Panel || c is GroupBox || c is FlowLayoutPanel)
                {
                    foreach (Control child in c.Controls)
                    {
                        if (child is Button)
                        {
                            if (child.Text == "Cargar")
                            {
                                ((Button)child).Click += new EventHandler(BtnCargarImagen_Click);
                            }
                            else if (child.Text == "Limpiar")
                            {
                                ((Button)child).Click += new EventHandler(BtnLimpiar_Click);
                            }
                        }
                    }
                }
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta de la imagen seleccionada
                    rutaImagenActual = openFileDialog1.FileName;

                    // Liberar recursos de la imagen anterior si existe
                    if (pictureBoxFoto.Image != null)
                    {
                        pictureBoxFoto.Image.Dispose();
                    }

                    // Cargar la nueva imagen en el PictureBox
                    pictureBoxFoto.Image = Image.FromFile(rutaImagenActual);

                    // Opcional: mostrar el nombre del archivo en algún label o control
                    // si tienes un control para ello
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel || c is GroupBox || c is FlowLayoutPanel)
                        {
                            foreach (Control child in c.Controls)
                            {
                                if (child is Label && child.Name.Contains("label"))
                                {
                                    ((Label)child).Text = Path.GetFileName(rutaImagenActual);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar la imagen del PictureBox
            if (pictureBoxFoto.Image != null)
            {
                pictureBoxFoto.Image.Dispose(); // Liberar recursos
                pictureBoxFoto.Image = null;
                rutaImagenActual = "";

                // Opcional: limpiar el texto del label si establecimos alguno
                foreach (Control c in this.Controls)
                {
                    if (c is Panel || c is GroupBox || c is FlowLayoutPanel)
                    {
                        foreach (Control child in c.Controls)
                        {
                            if (child is Label && child.Name.Contains("label"))
                            {
                                ((Label)child).Text = "";
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Este método se llamará si necesitas obtener la ruta de la imagen en otro lugar del código
        public string ObtenerRutaImagen()
        {
            return rutaImagenActual;
        }

        // Este método se puede usar para guardar la imagen en una ubicación específica si lo necesitas
        public bool GuardarImagenEnRuta(string rutaDestino)
        {
            try
            {
                if (!string.IsNullOrEmpty(rutaImagenActual) && File.Exists(rutaImagenActual))
                {
                    File.Copy(rutaImagenActual, rutaDestino, true);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Mostrar la imagen ampliada en una ventana separada
            PictureBox picClicked = (PictureBox)sender;
            Form vistaPrevia = new Form();
            vistaPrevia.Text = "Vista Previa de Imagen";
            vistaPrevia.Size = new Size(800, 600);
            vistaPrevia.StartPosition = FormStartPosition.CenterParent;

            PictureBox picAmpliada = new PictureBox();
            picAmpliada.Dock = DockStyle.Fill;
            picAmpliada.SizeMode = PictureBoxSizeMode.Zoom;
            picAmpliada.Image = picClicked.Image;

            vistaPrevia.Controls.Add(picAmpliada);
            vistaPrevia.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string imagenBase64 = "";
                if (pictureBoxFoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // O usa .Jpeg si prefieres
                        byte[] imageBytes = ms.ToArray();
                        imagenBase64 = Convert.ToBase64String(imageBytes);
                    }
                }
                if (
                 this.textDescripcion.Text == string.Empty ||
                   this.textReportadoPor.Text == string.Empty ||
                   this.textNombreProyecto.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcon.SetError(this.textDescripcion, "Ingrese una descripción");
                    errorIcon.SetError(this.textReportadoPor, "Seleccione un reportador");
                    errorIcon.SetError(this.textNombreProyecto, "Seleccione un proyecto");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = AvanceProyectoModel.Insertar(Convert.ToInt32(this.textIdProyecto.Text),
                                                            this.dateTimePickerInicio.Value,
                                                            Convert.ToDecimal(this.textCantidadReportada.Text),
                                                            this.textDescripcion.Text,
                                                            imagenBase64,
                                                            Convert.ToInt32(this.textIdReportadoPor.Text),
                                                            DateTime.Now);
                    }
                    else
                    {
                        rpta = AvanceProyectoModel.Editar(Convert.ToInt32(this.textIdAvance.Text),
                                                          Convert.ToInt32(this.textIdProyecto.Text),
                                                          this.dateTimePickerInicio.Value,
                                                          Convert.ToDecimal(this.textCantidadReportada.Text),
                                                          this.textDescripcion.Text,
                                                          imagenBase64,
                                                          Convert.ToInt32(this.textIdReportadoPor.Text),
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

        private void Ingreso_AvancesProyecto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.textIdAvance.Text.Equals(""))
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
            this.textIdAvance.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["avance_id"].Value);
            this.textIdProyecto.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["proyecto_id"].Value);
            this.textNombreProyecto.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_proyecto"].Value);
            this.dateTimePickerInicio.Value = Convert.ToDateTime(this.datosListar.CurrentRow.Cells["fecha_avance"].Value);
            this.textCantidadReportada.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["cantidad_reportada"].Value);
            this.textDescripcion.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["descripcion_avance"].Value);
            // Mostrar la imagen desde base64
            string base64String = Convert.ToString(this.datosListar.CurrentRow.Cells["fotos"].Value);
            if (!string.IsNullOrEmpty(base64String))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxFoto.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
                }
            }
            else
            {
                pictureBoxFoto.Image = null;
            }
            this.textIdReportadoPor.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["reportado_por"].Value);
            this.textReportadoPor.Text = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_usuario"].Value);
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
                Opcion = MessageBox.Show("Realmente desea eliminar los registros", "Sistema de Gestión de Usuarios",
                                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string rpta = "";
                    foreach (DataGridViewRow row in datosListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            rpta = AvanceProyectoModel.Eliminar(Convert.ToInt32(row.Cells[1].Value));
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

        public void setProyecto(string idProyecto, string nombreProyecto)
        {
            this.textIdProyecto.Text = idProyecto;
            this.textNombreProyecto.Text = nombreProyecto;
        }

        private void btnBuscarTipoPrograma_Click(object sender, EventArgs e)
        {
            SeleccionarProyecto programa = new SeleccionarProyecto();
            programa.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

            this.textIdReportadoPor.Text = UsuarioId;
            this.textReportadoPor.Text = NombreUsuario;
        }
    }
}
