using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class ReportesProyectosDao: ConnectionToMySQL
    {
        private int _reporte_id;
        private DateTime _fecha_generacion;
        private int _generado_por;
        private string _contenido_reporte;
        private string _textobuscar;

        public int Reporte_id { get => _reporte_id; set => _reporte_id = value; }
        public DateTime Fecha_generacion { get => _fecha_generacion; set => _fecha_generacion = value; }
        public int Generado_por { get => _generado_por; set => _generado_por = value; }
        public string Contenido_reporte { get => _contenido_reporte; set => _contenido_reporte = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public ReportesProyectosDao()
        {
        }

        //Constructor con parametros
        public ReportesProyectosDao(int reporte_id, DateTime fecha_generacion, int generado_por, string contenido_reporte)
        {
            this.Reporte_id = reporte_id;
            this.Fecha_generacion = fecha_generacion;
            this.Generado_por = generado_por;
            this.Contenido_reporte = contenido_reporte;
        }

        //metodo para insertar un reporte de proyectos
        public string Insertar(ReportesProyectosDao reporte)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO reportes_proyectos " +
                        "(fecha_generacion, generado_por, contenido_reporte) VALUES " +
                        "(@fecha_generacion, @generado_por, @contenido_reporte)";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@fecha_generacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@generado_por", reporte.Generado_por);
                    cmd.Parameters.AddWithValue("@contenido_reporte", reporte.Contenido_reporte);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para editar un reporte de proyectos
        public string Editar(ReportesProyectosDao reporte)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE reportes_proyectos SET " +
                        "fecha_generacion=@fecha_generacion, " +
                        "generado_por=@generado_por, " +
                        "contenido_reporte=@contenido_reporte " +
                        "WHERE reporte_id=@reporte_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@reporte_id", reporte.Reporte_id);
                    cmd.Parameters.AddWithValue("@fecha_generacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@generado_por", reporte.Generado_por);
                    cmd.Parameters.AddWithValue("@contenido_reporte", reporte.Contenido_reporte);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para eliminar un reporte de proyectos
        public string Eliminar(ReportesProyectosDao reporte)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM reportes_proyectos WHERE reporte_id=@reporte_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@reporte_id", reporte.Reporte_id);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para mostrar los reportes de proyectos
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("reportes_proyectos");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM reportes_proyectos";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para buscar reportes de proyectos
        public DataTable Buscar(ReportesProyectosDao reporte)
        {
            DataTable dt = new DataTable("reportes_proyectos");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM reportes_proyectos WHERE contenido_reporte LIKE @textobuscar";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@textobuscar", "%" + reporte.Textobuscar + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los reportes de proyectos por fecha
        public DataTable MostrarPorFecha(ReportesProyectosDao reporte)
        {
            DataTable dt = new DataTable("reportes_proyectos");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM reportes_proyectos WHERE fecha_generacion BETWEEN @fechainicio AND @fechafin";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@fechainicio", reporte.Fecha_generacion);
                    cmd.Parameters.AddWithValue("@fechafin", DateTime.Now);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los reportes de proyectos por usuario
        public DataTable MostrarPorUsuario(ReportesProyectosDao reporte)
        {
            DataTable dt = new DataTable("reportes_proyectos");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM reportes_proyectos WHERE generado_por=@generado_por";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@generado_por", reporte.Generado_por);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los reportes de proyectos por contenido
        public DataTable MostrarPorContenido(ReportesProyectosDao reporte)
        {
            DataTable dt = new DataTable("reportes_proyectos");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM reportes_proyectos WHERE contenido_reporte LIKE @contenido_reporte";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@contenido_reporte", "%" + reporte.Contenido_reporte + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }


    }
}
