using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Diagnostics;
using Domain;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Kernel.Geom;

namespace Presentation
{
    public partial class Ingresar_OrdenPago : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        //Variables para obtener los datos del usuario
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        // Constantes para validaciones
        private const decimal PORCENTAJE_MINIMO_COHERENCIA = 0.8m; // 80% de coherencia mínima
        private const decimal PORCENTAJE_MAXIMO_COHERENCIA = 1.2m; // 120% de coherencia máxima

        // Variables para almacenar los valores calculados (se usarán para la constancia)
        private decimal montoBase = 0;
        private decimal montoImpuesto = 0;
        private decimal montoRetencion = 0;
        private decimal montoFinal = 0;

        private static Ingresar_OrdenPago _Instancia;

        public static Ingresar_OrdenPago GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new Ingresar_OrdenPago();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new Ingresar_OrdenPago();
            }
            return _Instancia;
        }
        public Ingresar_OrdenPago()
        {
            InitializeComponent();

            //Asignar a Proyecto
            this.ttMensaje.SetToolTip(this.textNombreProyecto, "Seleccione el proyecto");
            this.ttMensaje.SetToolTip(this.textDescripcionProyecto, "Seleccione el proyecto");
            this.ttMensaje.SetToolTip(this.textUbicacionProyecto, "Seleccione el proyecto");
            this.ttMensaje.SetToolTip(this.textCantidadEstimada, "Seleccione el proyecto");
            this.ttMensaje.SetToolTip(this.textPrecioUnitario, "Seleccione el proyecto");
            this.ttMensaje.SetToolTip(this.textPresupuestoEstimado, "Seleccione el proyecto");

            //Asignar a Avance
            this.ttMensaje.SetToolTip(this.textIdAvance, "Seleccione el avance");
            this.ttMensaje.SetToolTip(this.textCantidadR, "Seleccione el avance");

            //Asignar a Información
            this.ttMensaje.SetToolTip(this.textImpuesto, "Ingrese el porcentaje de impuesto");
            this.ttMensaje.SetToolTip(this.textRetencion, "Ingrese el porcentaje de retención");
            this.ttMensaje.SetToolTip(this.textMonto, "Monto total a pagar");
            this.ttMensaje.SetToolTip(this.textDescripcion, "Descripción del pago");
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

            //Limpiar campos de texto de Proyecto
            this.textIdProyecto.Text = string.Empty;
            this.textNombreProyecto.Text = string.Empty;
            this.textDescripcionProyecto.Text = string.Empty;
            this.textUbicacionProyecto.Text = string.Empty;
            this.textCantidadEstimada.Text = string.Empty;
            this.textPrecioUnitario.Text = string.Empty;
            this.textPresupuestoEstimado.Text = string.Empty;
            //Limpiar campos de texto de Avance
            this.textIdAvance.Text = string.Empty;
            this.textCantidadR.Text = string.Empty;
            this.textDescripcionAvance.Text = string.Empty;
            //Limpiar campos de texto de Información
            this.textImpuesto.Text = string.Empty;
            this.textRetencion.Text = string.Empty;
            this.textMonto.Text = string.Empty;
            this.textDescripcion.Text = string.Empty;
            this.textIdOrdenPago.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.textImpuesto.ReadOnly = !valor;
            this.textRetencion.ReadOnly = !valor;
            this.textDescripcion.ReadOnly = !valor;
            this.textMonto.ReadOnly = !valor;
            this.textEstado.ReadOnly = !valor;

        }

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnNuevo.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnNuevo.Enabled = true;
            }
        }

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false;
            this.datosListar.Columns[2].Visible = false;
            this.datosListar.Columns[4].Visible = false;
            this.datosListar.Columns[11].Visible = false;
        }
        private void btnBuscarTipoPrograma_Click(object sender, EventArgs e)
        {
            SeleccionarProyectoPago seleccionarProyectoPago = new SeleccionarProyectoPago();
            seleccionarProyectoPago.ShowDialog();
        }

        public void SetProyecto(string idproyecto, string nombreproyecto, string descripcion, string ubicacion, string cantidadestimada, string costounitarioestimado, string presupuestoestimado)
        {
            this.textIdProyecto.Text = idproyecto;
            this.textNombreProyecto.Text = nombreproyecto;
            this.textDescripcionProyecto.Text = descripcion;
            this.textUbicacionProyecto.Text = ubicacion;
            this.textCantidadEstimada.Text = cantidadestimada;
            this.textPrecioUnitario.Text = costounitarioestimado;
            this.textPresupuestoEstimado.Text = presupuestoestimado;
        }

        public void SetAvance(string idavance, string cantidadreportada, string descripcion)
        {
            this.textIdAvance.Text = idavance;
            this.textCantidadR.Text = cantidadreportada;
            this.textDescripcionAvance.Text = descripcion;
        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            SeleccionarAvance seleccionarAvance = new SeleccionarAvance();
            seleccionarAvance.ShowDialog();
        }

        #region Metodo para pdoer calcular y hacer el recibo
        // Método para validar que solo se ingresen números decimales
        private void ValidarDecimal(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto decimal y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se hayan seleccionado proyecto y avance
                if (string.IsNullOrEmpty(textIdProyecto.Text) || string.IsNullOrEmpty(textIdAvance.Text))
                {
                    MessageBox.Show("Debe seleccionar un proyecto y un avance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que los campos numéricos no estén vacíos
                if (string.IsNullOrEmpty(textCantidadR.Text) || string.IsNullOrEmpty(textPrecioUnitario.Text))
                {
                    MessageBox.Show("La cantidad reportada y el precio unitario son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir valores a decimal
                decimal cantidadReportada = decimal.Parse(textCantidadR.Text);
                decimal precioUnitario = decimal.Parse(textPrecioUnitario.Text);
                decimal cantidadEstimada = !string.IsNullOrEmpty(textCantidadEstimada.Text) ?
                                          decimal.Parse(textCantidadEstimada.Text) : 0;

                // Porcentaje de impuesto y retención (por defecto 0 si no se especifica)
                decimal porcentajeImpuesto = !string.IsNullOrEmpty(textImpuesto.Text) ?
                                           decimal.Parse(textImpuesto.Text) / 100 : 0;
                decimal porcentajeRetencion = !string.IsNullOrEmpty(textRetencion.Text) ?
                                            decimal.Parse(textRetencion.Text) / 100 : 0;

                // Validar coherencia entre cantidad reportada y estimada
                if (cantidadEstimada > 0)
                {
                    decimal porcentajeCoherencia = cantidadReportada / cantidadEstimada;
                    if (porcentajeCoherencia < PORCENTAJE_MINIMO_COHERENCIA || porcentajeCoherencia > PORCENTAJE_MAXIMO_COHERENCIA)
                    {
                        DialogResult resultado = MessageBox.Show(
                            "La cantidad reportada difiere significativamente de la estimada. ¿Desea continuar?",
                            "Advertencia de coherencia",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (resultado == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                // Cálculo del monto base (cantidad × precio unitario)
                this.montoBase = cantidadReportada * precioUnitario;

                // Cálculo de impuestos y retenciones
                this.montoImpuesto = this.montoBase * porcentajeImpuesto;
                this.montoRetencion = this.montoBase * porcentajeRetencion;

                // Cálculo del monto final
                this.montoFinal = this.montoBase + this.montoImpuesto - this.montoRetencion;

                // Mostrar el resultado en el campo de monto
                textMonto.Text = this.montoFinal.ToString("N2"); // Formato con dos decimales

                // Información adicional en la descripción si está vacía
                if (string.IsNullOrEmpty(textDescripcion.Text))
                {
                    textDescripcion.Text = $"Pago por avance de proyecto. Monto base: {this.montoBase:N2}, Impuesto: {this.montoImpuesto:N2}, Retención: {this.montoRetencion:N2}";
                }

                MessageBox.Show("Cálculo realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos. Verifique que los valores sean numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarConstancia_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se hayan calculado los montos
                if (string.IsNullOrEmpty(textMonto.Text) || montoFinal == 0)
                {
                    MessageBox.Show("Debe calcular el monto antes de generar la constancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Preparar la información a mostrar
                string fechaActual = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                string proyectoNombre = textNombreProyecto.Text;
                string proyectoDescripcion = textDescripcionProyecto.Text;
                string ubicacion = textUbicacionProyecto.Text;
                string cantidadEstimada = textCantidadEstimada.Text;
                string cantidadReportada = textCantidadR.Text;
                string precioUnitario = textPrecioUnitario.Text;
                string impuesto = textImpuesto.Text;
                string retencion = textRetencion.Text;
                string descripcionAvance = textDescripcionAvance.Text;
                string idProyecto = textIdProyecto.Text;
                string idAvance = textIdAvance.Text;

                // Crear formulario para la constancia
                Form formConstancia = new Form();
                formConstancia.Text = "Constancia de Pago";
                formConstancia.Size = new Size(800, 800);
                formConstancia.StartPosition = FormStartPosition.CenterScreen;
                formConstancia.BackColor = Color.White;
                formConstancia.FormBorderStyle = FormBorderStyle.FixedDialog;
                formConstancia.MaximizeBox = false;

                // Panel para la información
                Panel panelInfo = new Panel();
                panelInfo.Dock = DockStyle.Fill;
                panelInfo.AutoScroll = true;
                formConstancia.Controls.Add(panelInfo);

                // Encabezado
                Label lblTitulo = new Label();
                lblTitulo.Text = "CONSTANCIA DE PAGO";
                lblTitulo.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
                lblTitulo.Size = new Size(760, 40);
                lblTitulo.Location = new System.Drawing.Point(20, 20);
                panelInfo.Controls.Add(lblTitulo);

                // Fecha
                Label lblFecha = new Label();
                lblFecha.Text = "Fecha de Emisión: " + fechaActual;
                lblFecha.Font = new System.Drawing.Font("Arial", 10);
                lblFecha.Size = new Size(760, 20);
                lblFecha.Location = new System.Drawing.Point(20, 70);
                lblFecha.TextAlign = ContentAlignment.MiddleRight;
                panelInfo.Controls.Add(lblFecha);

                // Separador
                Label lblSeparador1 = new Label();
                lblSeparador1.Text = "";
                lblSeparador1.BorderStyle = BorderStyle.Fixed3D;
                lblSeparador1.Height = 2;
                lblSeparador1.Width = 760;
                lblSeparador1.Location = new System.Drawing.Point(20, 100);
                panelInfo.Controls.Add(lblSeparador1);

                // Información del Proyecto
                Label lblProyectoTitulo = new Label();
                lblProyectoTitulo.Text = "INFORMACIÓN DEL PROYECTO";
                lblProyectoTitulo.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                lblProyectoTitulo.Size = new Size(760, 25);
                lblProyectoTitulo.Location = new System.Drawing.Point(20, 110);
                panelInfo.Controls.Add(lblProyectoTitulo);

                Label lblProyectoID = new Label();
                lblProyectoID.Text = "ID Proyecto: " + idProyecto;
                lblProyectoID.Font = new System.Drawing.Font("Arial", 10);
                lblProyectoID.Size = new Size(760, 20);
                lblProyectoID.Location = new System.Drawing.Point(40, 140);
                panelInfo.Controls.Add(lblProyectoID);

                Label lblProyectoNombre = new Label();
                lblProyectoNombre.Text = "Nombre: " + proyectoNombre;
                lblProyectoNombre.Font = new System.Drawing.Font("Arial", 10);
                lblProyectoNombre.Size = new Size(760, 20);
                lblProyectoNombre.Location = new System.Drawing.Point(40, 160);
                panelInfo.Controls.Add(lblProyectoNombre);

                Label lblProyectoDesc = new Label();
                lblProyectoDesc.Text = "Descripción: " + proyectoDescripcion;
                lblProyectoDesc.Font = new System.Drawing.Font("Arial", 10);
                lblProyectoDesc.Size = new Size(760, 20);
                lblProyectoDesc.Location = new System.Drawing.Point(40, 180);
                panelInfo.Controls.Add(lblProyectoDesc);

                Label lblUbicacion = new Label();
                lblUbicacion.Text = "Ubicación: " + ubicacion;
                lblUbicacion.Font = new System.Drawing.Font("Arial", 10);
                lblUbicacion.Size = new Size(760, 20);
                lblUbicacion.Location = new System.Drawing.Point(40, 200);
                panelInfo.Controls.Add(lblUbicacion);

                Label lblCantEst = new Label();
                lblCantEst.Text = "Cantidad Estimada: " + cantidadEstimada;
                lblCantEst.Font = new System.Drawing.Font("Arial", 10);
                lblCantEst.Size = new Size(360, 20);
                lblCantEst.Location = new System.Drawing.Point(40, 220);
                panelInfo.Controls.Add(lblCantEst);

                Label lblPrecioUnit = new Label();
                lblPrecioUnit.Text = "Precio Unitario: $" + precioUnitario;
                lblPrecioUnit.Font = new System.Drawing.Font("Arial", 10);
                lblPrecioUnit.Size = new Size(360, 20);
                lblPrecioUnit.Location = new System.Drawing.Point(400, 220);
                panelInfo.Controls.Add(lblPrecioUnit);

                // Separador
                Label lblSeparador2 = new Label();
                lblSeparador2.Text = "";
                lblSeparador2.BorderStyle = BorderStyle.Fixed3D;
                lblSeparador2.Height = 2;
                lblSeparador2.Width = 760;
                lblSeparador2.Location = new System.Drawing.Point(20, 250);
                panelInfo.Controls.Add(lblSeparador2);

                // Información del Avance
                Label lblAvanceTitulo = new Label();
                lblAvanceTitulo.Text = "INFORMACIÓN DE AVANCE";
                lblAvanceTitulo.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                lblAvanceTitulo.Size = new Size(760, 25);
                lblAvanceTitulo.Location = new System.Drawing.Point(20, 260);
                panelInfo.Controls.Add(lblAvanceTitulo);

                Label lblAvanceID = new Label();
                lblAvanceID.Text = "ID Avance: " + idAvance;
                lblAvanceID.Font = new System.Drawing.Font("Arial", 10);
                lblAvanceID.Size = new Size(760, 20);
                lblAvanceID.Location = new System.Drawing.Point(40, 290);
                panelInfo.Controls.Add(lblAvanceID);

                Label lblCantReport = new Label();
                lblCantReport.Text = "Cantidad Reportada: " + cantidadReportada;
                lblCantReport.Font = new System.Drawing.Font("Arial", 10);
                lblCantReport.Size = new Size(760, 20);
                lblCantReport.Location = new System.Drawing.Point(40, 310);
                panelInfo.Controls.Add(lblCantReport);

                Label lblDescAvance = new Label();
                lblDescAvance.Text = "Descripción del Avance: " + descripcionAvance;
                lblDescAvance.Font = new System.Drawing.Font("Arial", 10);
                lblDescAvance.Size = new Size(760, 20);
                lblDescAvance.Location = new System.Drawing.Point(40, 330);
                panelInfo.Controls.Add(lblDescAvance);

                // Separador
                Label lblSeparador3 = new Label();
                lblSeparador3.Text = "";
                lblSeparador3.BorderStyle = BorderStyle.Fixed3D;
                lblSeparador3.Height = 2;
                lblSeparador3.Width = 760;
                lblSeparador3.Location = new System.Drawing.Point(20, 360);
                panelInfo.Controls.Add(lblSeparador3);

                // Detalles del Cálculo
                Label lblCalculoTitulo = new Label();
                lblCalculoTitulo.Text = "DETALLES DEL CÁLCULO";
                lblCalculoTitulo.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                lblCalculoTitulo.Size = new Size(760, 25);
                lblCalculoTitulo.Location = new System.Drawing.Point(20, 370);
                panelInfo.Controls.Add(lblCalculoTitulo);

                Label lblMontoBase = new Label();
                lblMontoBase.Text = "Monto Base: $" + montoBase.ToString("N2");
                lblMontoBase.Font = new System.Drawing.Font("Arial", 10);
                lblMontoBase.Size = new Size(760, 20);
                lblMontoBase.Location = new System.Drawing.Point(40, 400);
                panelInfo.Controls.Add(lblMontoBase);

                Label lblPorcentajeImp = new Label();
                lblPorcentajeImp.Text = "Porcentaje de Impuesto: " + impuesto + "%";
                lblPorcentajeImp.Font = new System.Drawing.Font("Arial", 10);
                lblPorcentajeImp.Size = new Size(360, 20);
                lblPorcentajeImp.Location = new System.Drawing.Point(40, 420);
                panelInfo.Controls.Add(lblPorcentajeImp);

                Label lblMontoImp = new Label();
                lblMontoImp.Text = "Monto Impuesto: $" + montoImpuesto.ToString("N2");
                lblMontoImp.Font = new System.Drawing.Font("Arial", 10);
                lblMontoImp.Size = new Size(360, 20);
                lblMontoImp.Location = new System.Drawing.Point(400, 420);
                panelInfo.Controls.Add(lblMontoImp);

                Label lblPorcentajeRet = new Label();
                lblPorcentajeRet.Text = "Porcentaje de Retención: " + retencion + "%";
                lblPorcentajeRet.Font = new System.Drawing.Font("Arial", 10);
                lblPorcentajeRet.Size = new Size(360, 20);
                lblPorcentajeRet.Location = new System.Drawing.Point(40, 440);
                panelInfo.Controls.Add(lblPorcentajeRet);

                Label lblMontoRet = new Label();
                lblMontoRet.Text = "Monto Retención: $" + montoRetencion.ToString("N2");
                lblMontoRet.Font = new System.Drawing.Font("Arial", 10);
                lblMontoRet.Size = new Size(360, 20);
                lblMontoRet.Location = new System.Drawing.Point(400, 440);
                panelInfo.Controls.Add(lblMontoRet);

                // Separador
                Label lblSeparador4 = new Label();
                lblSeparador4.Text = "";
                lblSeparador4.BorderStyle = BorderStyle.Fixed3D;
                lblSeparador4.Height = 2;
                lblSeparador4.Width = 760;
                lblSeparador4.Location = new System.Drawing.Point(20, 470);
                panelInfo.Controls.Add(lblSeparador4);

                // Monto Final
                Label lblMontoFinalTitulo = new Label();
                lblMontoFinalTitulo.Text = "MONTO FINAL A PAGAR";
                lblMontoFinalTitulo.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
                lblMontoFinalTitulo.Size = new Size(760, 30);
                lblMontoFinalTitulo.Location = new System.Drawing.Point(20, 480);
                lblMontoFinalTitulo.TextAlign = ContentAlignment.MiddleCenter;
                panelInfo.Controls.Add(lblMontoFinalTitulo);

                Label lblMontoFinal = new Label();
                lblMontoFinal.Text = "Q" + montoFinal.ToString("N2");
                lblMontoFinal.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                lblMontoFinal.Size = new Size(760, 40);
                lblMontoFinal.Location = new System.Drawing.Point(20, 510);
                lblMontoFinal.TextAlign = ContentAlignment.MiddleCenter;
                panelInfo.Controls.Add(lblMontoFinal);

                // Pie de página
                Label lblNotasPie = new Label();
                lblNotasPie.Text = "Esta constancia no tiene validez fiscal. Solo es un documento informativo para control interno.";
                lblNotasPie.Font = new System.Drawing.Font("Arial", 8, FontStyle.Italic);
                lblNotasPie.Size = new Size(760, 20);
                lblNotasPie.Location = new System.Drawing.Point(20, 560);
                lblNotasPie.TextAlign = ContentAlignment.MiddleCenter;
                panelInfo.Controls.Add(lblNotasPie);

                // Panel para botones
                Panel panelBotones = new Panel();
                panelBotones.Size = new Size(760, 50);
                panelBotones.Location = new System.Drawing.Point(20, 590);
                panelInfo.Controls.Add(panelBotones);

                // Botón para guardar como imagen
                Button btnGuardarImagen = new Button();
                btnGuardarImagen.Text = "Guardar como Imagen";
                btnGuardarImagen.Size = new Size(150, 30);
                btnGuardarImagen.Location = new System.Drawing.Point(330, 10);
                btnGuardarImagen.Click += (s, evt) =>
                {
                    // Crear un diálogo para guardar archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Archivos de imagen (*.png)|*.png",
                        Title = "Guardar constancia como imagen",
                        FileName = $"Constancia_Pago_{idProyecto}_{fechaActual.Replace('/', '-')}.png"
                    };

                    // Si el usuario selecciona una ubicación y nombre de archivo
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Crear un bitmap del tamaño del panel
                            using (Bitmap bitmap = new Bitmap(panelInfo.Width, panelInfo.Height))
                            {
                                // Dibujar el panel en el bitmap
                                panelInfo.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, panelInfo.Width, panelInfo.Height));

                                // Guardar el bitmap como archivo PNG
                                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);

                                MessageBox.Show($"Constancia guardada como imagen en: {saveFileDialog.FileName}",
                                               "Guardar exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar la imagen: {ex.Message}",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
                panelBotones.Controls.Add(btnGuardarImagen);

                // Botón para guardar como PDF
                Button btnGuardarPDF = new Button();
                btnGuardarPDF.Text = "Guardar como PDF";
                btnGuardarPDF.Size = new Size(150, 30);
                btnGuardarPDF.Location = new System.Drawing.Point(490, 10);
                btnGuardarPDF.Click += (s, evt) =>
                {
                    // Crear un diálogo para guardar archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Archivos PDF (*.pdf)|*.pdf",
                        Title = "Guardar constancia como PDF",
                        FileName = $"Constancia_Pago_{idProyecto}_{fechaActual.Replace('/', '-')}.pdf"
                    };

                    // Si el usuario selecciona una ubicación y nombre de archivo
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;

                        try
                        {
                            using (FileStream stream = new FileStream(path, FileMode.Create))
                            {
                                // Crear PDF
                                PdfWriter writer = new PdfWriter(stream);
                                PdfDocument pdf = new PdfDocument(writer);
                                Document document = new Document(pdf, PageSize.A4);
                                document.SetMargins(60, 50, 60, 50);

                                // Fuentes
                                PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                                PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                                // Título
                                Paragraph titulo = new Paragraph("CONSTANCIA DE PAGO")
                                    .SetFont(titleFont)
                                    .SetFontSize(16)
                                    .SetTextAlignment(TextAlignment.CENTER);
                                document.Add(titulo);

                                document.Add(new Paragraph("Fecha de Emisión: " + fechaActual).SetFont(normalFont));

                                document.Add(new Paragraph("\nINFORMACIÓN DEL PROYECTO").SetFont(titleFont).SetFontSize(12));
                                document.Add(new Paragraph("ID Proyecto: " + idProyecto).SetFont(normalFont));
                                document.Add(new Paragraph("Nombre: " + proyectoNombre).SetFont(normalFont));
                                document.Add(new Paragraph("Descripción: " + proyectoDescripcion).SetFont(normalFont));
                                document.Add(new Paragraph("Ubicación: " + ubicacion).SetFont(normalFont));
                                document.Add(new Paragraph("Cantidad Estimada: " + cantidadEstimada).SetFont(normalFont));
                                document.Add(new Paragraph("Precio Unitario: $" + precioUnitario).SetFont(normalFont));

                                document.Add(new Paragraph("\nINFORMACIÓN DE AVANCE").SetFont(titleFont).SetFontSize(12));
                                document.Add(new Paragraph("ID Avance: " + idAvance).SetFont(normalFont));
                                document.Add(new Paragraph("Cantidad Reportada: " + cantidadReportada).SetFont(normalFont));
                                document.Add(new Paragraph("Descripción del Avance: " + descripcionAvance).SetFont(normalFont));

                                document.Add(new Paragraph("\nDETALLES DEL CÁLCULO").SetFont(titleFont).SetFontSize(12));
                                document.Add(new Paragraph("Monto Base: Q" + montoBase.ToString("N2")).SetFont(normalFont));
                                document.Add(new Paragraph("Porcentaje de Impuesto: " + impuesto + "%").SetFont(normalFont));
                                document.Add(new Paragraph("Monto Impuesto: Q" + montoImpuesto.ToString("N2")).SetFont(normalFont));
                                document.Add(new Paragraph("Porcentaje de Retención: " + retencion + "%").SetFont(normalFont));
                                document.Add(new Paragraph("Monto Retención: Q" + montoRetencion.ToString("N2")).SetFont(normalFont));

                                document.Add(new Paragraph("\nMONTO FINAL A PAGAR").SetFont(titleFont).SetFontSize(14));
                                document.Add(new Paragraph("Q" + montoFinal.ToString("N2"))
                                    .SetFont(titleFont)
                                    .SetFontSize(12));

                                document.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al generar el PDF: " + ex.Message);
                        }
                    }
                };
                panelBotones.Controls.Add(btnGuardarPDF);

                // Mostrar la constancia
                formConstancia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la constancia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.textEstado.Text = "Emitida";

            this.textIdCreadoPor.Text = UsuarioId;
            this.textCreadoPor.Text = NombreUsuario;

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

        }

        private void Mostrar()
        {
            this.datosListar.DataSource = OrdenPagoModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = OrdenPagoModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Ingresar_OrdenPago_Load(object sender, EventArgs e)
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
                if (this.textImpuesto.Text == string.Empty || this.textDescripcion.Text == string.Empty || this.textRetencion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcon.SetError(textImpuesto, "Ingrese el porcentaje de impuesto");
                    errorIcon.SetError(textRetencion, "Ingrese el porcentaje de retención");
                    errorIcon.SetError(textDescripcion, "Ingrese la descripción del pago");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = OrdenPagoModel.Insertar(Convert.ToInt32(this.textIdProyecto.Text), Convert.ToInt32(this.textIdContratista.Text), Convert.ToDateTime(this.dateTimePicker1.Value), Convert.ToDecimal(this.textMonto.Text), this.textDescripcion.Text, this.textEstado.Text, DateTime.Now, Convert.ToInt32(this.textIdCreadoPor.Text));
                    }
                    else
                    {
                        rpta = OrdenPagoModel.Editar(Convert.ToInt32(this.textIdOrdenPago.Text), Convert.ToInt32(this.textIdProyecto.Text), Convert.ToInt32(this.textIdContratista.Text), Convert.ToDateTime(this.dateTimePicker1.Value), Convert.ToDecimal(this.textMonto.Text), this.textDescripcion.Text, this.textEstado.Text, DateTime.Now, Convert.ToInt32(this.textIdCreadoPor.Text));
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro: " + textDescripcion.Text);
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó de forma correcta el registro: " + textDescripcion.Text);
                        }
                    }
                    else
                    {
                        MensajeError(rpta);
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

        private void btnBuscarContratista_Click(object sender, EventArgs e)
        {
            SeleccionarContratistaOrdenPago seleccionarContratistaOrdenPago = new SeleccionarContratistaOrdenPago();
            seleccionarContratistaOrdenPago.ShowDialog();
        }

        public void setContratista(string idcontratista, string nombrecontratista)
        {
            this.textIdContratista.Text = idcontratista;
            this.textNombreContratista.Text = nombrecontratista;
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
    }
}