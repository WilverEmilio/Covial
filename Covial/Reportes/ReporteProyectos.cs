using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.MySQL;
using Domain;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MigraDoc.DocumentObjectModel.Tables;
using PdfSharp.Pdf;

namespace Presentation.Reportes
{
    public partial class ReporteProyectos : Form
    {
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        private static ReporteProyectos _Instancia;

        public static ReporteProyectos GetInstancia()
        {
            if (_Instancia == null || _Instancia.IsDisposed)
            {
                _Instancia = new ReporteProyectos();
            }
            else if (_Instancia.Created == false)
            {
                _Instancia = new ReporteProyectos();
            }
            return _Instancia;
        }
        public ReporteProyectos()
        {
            InitializeComponent();
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string rtpa = "";

            DataTable datos = ProgramaModel.Mostrar();
            if (datos == null || datos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para el reporte.");
                return;
            }
            var doc = new Document();

            

            // Cambiar la orientación de la página a horizontal
            var section = doc.AddSection();
            section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
            // TÍTULO
            var title = section.AddParagraph("REPORTE DE PROGRAMAS DETALLADO");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.SpaceBefore = "1cm";
            title.Format.SpaceAfter = "0.5cm";
            title.Format.Alignment = ParagraphAlignment.Center;
            // TABLA
            var table = section.AddTable();
            table.Borders.Width = 0.5;
            string[] headers = {
        "ID", "Plan Anual", "Tipo Programa", "Nombre Programa",
        "Descripción", "Inicio", "Fin", "Creación"
    };
            float[] widths = { 2, 3.5f, 3.5f, 4, 5, 3, 3, 3 };
            foreach (var width in widths)
                table.AddColumn(Unit.FromCentimeter(width));
            var headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Format.Font.Bold = true;
            for (int i = 0; i < headers.Length; i++)
                headerRow.Cells[i].AddParagraph(headers[i]);
            foreach (DataRow row in datos.Rows)
            {
                var r = table.AddRow();
                r.Cells[0].AddParagraph(row["programa_id"].ToString());
                r.Cells[1].AddParagraph(row["nombre_plan"].ToString());
                r.Cells[2].AddParagraph(row["nombre_tipo"].ToString());
                r.Cells[3].AddParagraph(row["nombre_programa"].ToString());
                r.Cells[4].AddParagraph(row["descripcion"].ToString());
                r.Cells[5].AddParagraph(Convert.ToDateTime(row["fecha_inicio_prevista"]).ToShortDateString());
                r.Cells[6].AddParagraph(Convert.ToDateTime(row["fecha_fin_prevista"]).ToShortDateString());
                r.Cells[7].AddParagraph(Convert.ToDateTime(row["fecha_creacion"]).ToShortDateString());
            }
            // PIE DE PÁGINA
            var footer = section.Footers.Primary.AddParagraph();
            footer.AddText("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            footer.Format.Alignment = ParagraphAlignment.Left;
            footer.AddTab();
            footer.AddPageField();
            footer.AddText(" de ");
            footer.AddNumPagesField();
            footer.Format.Alignment = ParagraphAlignment.Right;
            // GUARDAR
            using var sfd = new SaveFileDialog
            {
                Filter = "PDF|*.pdf",
                FileName = "Reporte_Programas.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var renderer = new PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(sfd.FileName);
                MessageBox.Show("Reporte generado correctamente.");
                Process.Start("explorer", sfd.FileName);
            }
            string jsonData = GuardarDatosComoJSON(datos);
           rtpa = ReporteProyectosModel.Insertar(DateTime.Now,Convert.ToInt32(UsuarioId),jsonData);
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            // Usando la nueva consulta de proyectos
            DataTable datos = ProyectoModel.Mostrar();
            if (datos == null || datos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para el reporte.");
                return;
            }
            var doc = new Document();
            GuardarDatosComoJSON(datos);

            try
            {
                // Generar JSON y guardarlo en la base de datos
                string jsonData = GuardarDatosComoJSON(datos);

                if (jsonData != "{}")
                {
                     string rtpa = ReporteProyectosModel.Insertar(DateTime.Now, Convert.ToInt32(UsuarioId), jsonData);
                }
                else
                {
                    MessageBox.Show("No se pudo generar el JSON correctamente.");
                    // Opcionalmente podrías retornar aquí si no quieres continuar con el PDF
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
                // Opcionalmente podrías retornar aquí si no quieres continuar con el PDF
            }
            // Cambiar la orientación de la página a horizontal
            var section = doc.AddSection();
            section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
            // TÍTULO
            var title = section.AddParagraph("REPORTE DE PROYECTOS DETALLADO");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.SpaceBefore = "1cm";
            title.Format.SpaceAfter = "0.5cm";
            title.Format.Alignment = ParagraphAlignment.Center;
            // TABLA
            var table = section.AddTable();
            table.Borders.Width = 0.5;
            // Nuevos encabezados que se alinean con los campos de proyecto
            string[] headers = {
        "ID", "Programa", "Contratista", "Nombre Proyecto",
        "Descripción", "Ubicación", "U.Medida", "Cantidad",
        "Costo Unit.", "Presupuesto", "Inicio", "Fin", "Estado", "Creado Por"
    };
            // Ajustar los anchos según la cantidad de columnas
            float[] widths = { 2, 3, 3, 4, 4, 3, 2, 2, 2, 2.5f, 2.5f, 2.5f, 2, 3 };
            foreach (var width in widths)
                table.AddColumn(Unit.FromCentimeter(width));
            var headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Format.Font.Bold = true;
            for (int i = 0; i < headers.Length; i++)
                headerRow.Cells[i].AddParagraph(headers[i]);
            // Llenar datos de proyectos
            foreach (DataRow row in datos.Rows)
            {
                var r = table.AddRow();
                r.Cells[0].AddParagraph(row["proyecto_id"].ToString());
                r.Cells[1].AddParagraph(row["nombre_programa"].ToString());
                r.Cells[2].AddParagraph(row["nombre_contratista"].ToString());
                r.Cells[3].AddParagraph(row["nombre_proyecto"].ToString());
                r.Cells[4].AddParagraph(row["descripcion"].ToString());
                r.Cells[5].AddParagraph(row["ubicacion"].ToString());
                r.Cells[6].AddParagraph(row["unidad_medida"].ToString());
                r.Cells[7].AddParagraph(row["cantidad_estimada"].ToString());
                r.Cells[8].AddParagraph(Convert.ToDecimal(row["costo_unitario_estimado"]).ToString("N2"));
                r.Cells[9].AddParagraph(Convert.ToDecimal(row["presupuesto_estimado"]).ToString("N2"));
                r.Cells[10].AddParagraph(Convert.ToDateTime(row["fecha_inicio_prevista"]).ToShortDateString());
                r.Cells[11].AddParagraph(Convert.ToDateTime(row["fecha_fin_prevista"]).ToShortDateString());
                r.Cells[12].AddParagraph(row["estado"].ToString());
                r.Cells[13].AddParagraph(row["nombre_usuario"].ToString());
            }
            // PIE DE PÁGINA
            var footer = section.Footers.Primary.AddParagraph();
            footer.AddText("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            footer.Format.Alignment = ParagraphAlignment.Left;
            footer.AddTab();
            footer.AddPageField();
            footer.AddText(" de ");
            footer.AddNumPagesField();
            footer.Format.Alignment = ParagraphAlignment.Right;
            // GUARDAR
            using var sfd = new SaveFileDialog
            {
                Filter = "PDF|*.pdf",
                FileName = "Reporte_Proyectos.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var renderer = new PdfDocumentRenderer(true) { Document = doc };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(sfd.FileName);
                MessageBox.Show("Reporte generado correctamente.");
                Process.Start("explorer", sfd.FileName);
            }
 
        }

        private string GuardarDatosComoJSON(DataTable dt)
        {
            try
            {
                // Crear una lista de diccionarios para almacenar los datos
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;

                // Convertir cada fila a un diccionario
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        // Manejar valores especiales como fechas y decimales para formato JSON adecuado
                        if (dr[col] is DateTime)
                        {
                            row[col.ColumnName] = ((DateTime)dr[col]).ToString("yyyy-MM-dd");
                        }
                        else if (dr[col] is DBNull)
                        {
                            row[col.ColumnName] = null;
                        }
                        else
                        {
                            row[col.ColumnName] = dr[col];
                        }
                    }
                    rows.Add(row);
                }

                // Serializar a JSON
                string json = System.Text.Json.JsonSerializer.Serialize(rows, new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });

                return json;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "{}"; // Devolver JSON vacío en caso de error
            }
        }
    }
}
