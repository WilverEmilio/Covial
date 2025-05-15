using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class ProgramaDao : ConnectionToMySQL
    {
        private int _programa_id;
        private int _plan_anual_id;
        private int _tipo_programa_id;
        private string _nombre_programa;
        private string _descripcion;
        private DateTime _fecha_inicio_prevista;
        private DateTime _fecha_fin_prevista;
        private DateTime _fecha_creacion;
        private string _textobuscar;

        public int Programa_id { get => _programa_id; set => _programa_id = value; }
        public int Plan_anual_id { get => _plan_anual_id; set => _plan_anual_id = value; }
        public int Tipo_programa_id { get => _tipo_programa_id; set => _tipo_programa_id = value; }
        public string Nombre_programa { get => _nombre_programa; set => _nombre_programa = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime Fecha_inicio_prevista { get => _fecha_inicio_prevista; set => _fecha_inicio_prevista = value; }
        public DateTime Fecha_fin_prevista { get => _fecha_fin_prevista; set => _fecha_fin_prevista = value; }
        public DateTime Fecha_creacion { get => _fecha_creacion; set => _fecha_creacion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public ProgramaDao()
        {
        }

        //Constructor con parametros
        public ProgramaDao(int programa_id, int plan_anual_id, int tipo_programa_id, string nombre_programa, string descripcion, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, DateTime fecha_creacion)
        {
            this.Programa_id = programa_id;
            this.Plan_anual_id = plan_anual_id;
            this.Tipo_programa_id = tipo_programa_id;
            this.Nombre_programa = nombre_programa;
            this.Descripcion = descripcion;
            this.Fecha_inicio_prevista = fecha_inicio_prevista;
            this.Fecha_fin_prevista = fecha_fin_prevista;
            this.Fecha_creacion = fecha_creacion;
        }

        //metodo para insertar un programa
        public string Insertar(ProgramaDao programa)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO programas " +
                        "(plan_anual_id, tipo_programa_id, nombre_programa, descripcion, fecha_inicio_prevista, fecha_fin_prevista, fecha_creacion) VALUES " +
                        "(@plan_anual_id, @tipo_programa_id, @nombre_programa, @descripcion, @fecha_inicio_prevista, @fecha_fin_prevista, @fecha_creacion)";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@plan_anual_id", programa.Plan_anual_id);
                    cmd.Parameters.AddWithValue("@tipo_programa_id", programa.Tipo_programa_id);
                    cmd.Parameters.AddWithValue("@nombre_programa", programa.Nombre_programa);
                    cmd.Parameters.AddWithValue("@descripcion", programa.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha_inicio_prevista", programa.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fecha_fin_prevista", programa.Fecha_fin_prevista);
                    cmd.Parameters.AddWithValue("@fecha_creacion", DateTime.Now);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para editar un programa
        public string Editar(ProgramaDao programa)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE programas SET " +
                        "plan_anual_id=@plan_anual_id, tipo_programa_id=@tipo_programa_id, nombre_programa=@nombre_programa, descripcion=@descripcion, fecha_inicio_prevista=@fecha_inicio_prevista, fecha_fin_prevista=@fecha_fin_prevista " +
                        "WHERE programa_id=@programa_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@programa_id", programa.Programa_id);
                    cmd.Parameters.AddWithValue("@plan_anual_id", programa.Plan_anual_id);
                    cmd.Parameters.AddWithValue("@tipo_programa_id", programa.Tipo_programa_id);
                    cmd.Parameters.AddWithValue("@nombre_programa", programa.Nombre_programa);
                    cmd.Parameters.AddWithValue("@descripcion", programa.Descripcion);
                    cmd.Parameters.AddWithValue("@fecha_inicio_prevista", programa.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fecha_fin_prevista", programa.Fecha_fin_prevista);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para eliminar un programa
        public string Eliminar(ProgramaDao programa)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM programas WHERE programa_id=@programa_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@programa_id", programa.Programa_id);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para mostrar un programa
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("programas");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"
                        SELECT 
                            p.programa_id,
                            p.plan_anual_id,
                            pa.nombre_plan,
                            p.tipo_programa_id,
                            tp.nombre_tipo,
                            p.nombre_programa,
                            p.descripcion,
                            p.fecha_inicio_prevista,
                            p.fecha_fin_prevista,
                            p.fecha_creacion
                        FROM programas p
                        INNER JOIN planesanuales pa ON p.plan_anual_id = pa.plan_anual_id
                        INNER JOIN tiposprograma tp ON p.tipo_programa_id = tp.tipo_programa_id;
                    ";
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

        //metodo para buscar un programa por nombre
        public DataTable BuscarNombre(ProgramaDao programa)
        {
            DataTable dt = new DataTable("programas");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT 
                            p.programa_id,
                            p.plan_anual_id,
                            pa.nombre_plan,
                            p.tipo_programa_id,
                            tp.nombre_tipo,
                            p.nombre_programa,
                            p.descripcion,
                            p.fecha_inicio_prevista,
                            p.fecha_fin_prevista,
                            p.fecha_creacion
                        FROM programas p
                        INNER JOIN planesanuales pa ON p.plan_anual_id = pa.plan_anual_id
                        INNER JOIN tiposprograma tp ON p.tipo_programa_id = tp.tipo_programa_id; WHERE p.nombre_programa LIKE @textobuscar";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@textobuscar", programa.Textobuscar);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para busscar por fechas inicio y fin
        public DataTable BuscarFechas(ProgramaDao programa)
        {
            DataTable dt = new DataTable("programas");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT p.programa_id, p.plan_anual_id, p.tipo_programa_id, p.nombre_programa, p.descripcion, p.fecha_inicio_prevista, p.fecha_fin_prevista, p.fecha_creacion " +
                        "FROM programas p WHERE p.fecha_inicio_prevista BETWEEN @fecha_inicio AND @fecha_fin";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@fecha_inicio", programa.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fecha_fin", programa.Fecha_fin_prevista);
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
