using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DataAccess.MySQL
{
    public class ProyectoDao : ConnectionToMySQL
    {
        private int _proyecto_id;
        private int _programa_id;
        private int _contratista_id;
        private string _nombre_proyecto;
        private string _descripcion;
        private string _ubicacion;
        private decimal _cantidad_estimada;
        private decimal _costo_unitario_estimado;
        private decimal _presupuesto_estimado;
        private DateTime _fecha_inicio_prevista;
        private DateTime _fecha_fin_prevista;
        private string _estado;
        private DateTime _fecha_creacion;
        private int _creado_por;

        private string _textobuscar;

        public int Proyecto_id { get => _proyecto_id; set => _proyecto_id = value; }
        public int Programa_id { get => _programa_id; set => _programa_id = value; }
        public int Contratista_id { get => _contratista_id; set => _contratista_id = value; }
        public string Nombre_proyecto { get => _nombre_proyecto; set => _nombre_proyecto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public decimal Cantidad_estimada { get => _cantidad_estimada; set => _cantidad_estimada = value; }
        public decimal Costo_unitario_estimado { get => _costo_unitario_estimado; set => _costo_unitario_estimado = value; }
        public decimal Presupuesto_estimado { get => _presupuesto_estimado; set => _presupuesto_estimado = value; }
        public DateTime Fecha_inicio_prevista { get => _fecha_inicio_prevista; set => _fecha_inicio_prevista = value; }
        public DateTime Fecha_fin_prevista { get => _fecha_fin_prevista; set => _fecha_fin_prevista = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public DateTime Fecha_creacion { get => _fecha_creacion; set => _fecha_creacion = value; }
        public int Creado_por { get => _creado_por; set => _creado_por = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public ProyectoDao()
        {
        }

        //Constructor con parametros
        public ProyectoDao(int proyecto_id, int programa_id, int contratista_id, string nombre_proyecto, string descripcion, string ubicacion, decimal cantidad_estimada, decimal costo_unitario_estimado, decimal presupuesto_estimado, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, string estado, DateTime fecha_creacion, int creado_por)
        {
            this.Proyecto_id = proyecto_id;
            this.Programa_id = programa_id;
            this.Contratista_id = contratista_id;
            this.Nombre_proyecto = nombre_proyecto;
            this.Descripcion = descripcion;
            this.Ubicacion = ubicacion;
            this.Cantidad_estimada = cantidad_estimada;
            this.Costo_unitario_estimado = costo_unitario_estimado;
            this.Presupuesto_estimado = presupuesto_estimado;
            this.Fecha_inicio_prevista = fecha_inicio_prevista;
            this.Fecha_fin_prevista = fecha_fin_prevista;
            this.Estado = estado;
            this.Fecha_creacion = fecha_creacion;
            this.Creado_por = creado_por;
        }

        //metodo para insertar un proyecto
        public string Insertar(ProyectoDao proyecto)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO proyecto " +
                        "(programa_id, contratista_id, nombre_proyecto, descripcion, ubicacion, cantidad_estimada, costo_unitario_estimado, presupuesto_estimado, fecha_inicio_prevista, fecha_fin_prevista, estado, fecha_creacion, creado_por) VALUES " +
                        "(@programa_id, @contratista_id, @nombre_proyecto, @descripcion, @ubicacion, @cantidad_estimada, @costo_unitario_estimado, @presupuesto_estimado, @fecha_inicio_prevista, @fecha_fin_prevista, @estado, @fecha_creacion, @creado_por)";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@programa_id", proyecto.Programa_id);
                    cmd.Parameters.AddWithValue("@contratista_id", proyecto.Contratista_id);
                    cmd.Parameters.AddWithValue("@nombre_proyecto", proyecto.Nombre_proyecto);
                    cmd.Parameters.AddWithValue("@descripcion", proyecto.Descripcion);
                    cmd.Parameters.AddWithValue("@ubicacion", proyecto.Ubicacion);
                    cmd.Parameters.AddWithValue("@cantidad_estimada", proyecto.Cantidad_estimada);
                    cmd.Parameters.AddWithValue("@costo_unitario_estimado", proyecto.Costo_unitario_estimado);
                    cmd.Parameters.AddWithValue("@presupuesto_estimado", proyecto.Presupuesto_estimado);
                    cmd.Parameters.AddWithValue("@fecha_inicio_prevista", proyecto.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fecha_fin_prevista", proyecto.Fecha_fin_prevista);
                    cmd.Parameters.AddWithValue("@estado", proyecto.Estado);
                    cmd.Parameters.AddWithValue("@fecha_creacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@creado_por", proyecto.Creado_por);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para editar un proyecto
        public string Editar(ProyectoDao proyecto)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE proyecto SET " +
                        "programa_id=@programa_id, contratista_id=@contratista_id, nombre_proyecto=@nombre_proyecto, descripcion=@descripcion, ubicacion=@ubicacion, cantidad_estimada=@cantidad_estimada, costo_unitario_estimado=@costo_unitario_estimado, presupuesto_estimado=@presupuesto_estimado, fecha_inicio_prevista=@fecha_inicio_prevista, fecha_fin_prevista=@fecha_fin_prevista, estado=@estado " +
                        "WHERE proyecto_id=@proyecto_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto.Proyecto_id);
                    cmd.Parameters.AddWithValue("@programa_id", proyecto.Programa_id);
                    cmd.Parameters.AddWithValue("@contratista_id", proyecto.Contratista_id);
                    cmd.Parameters.AddWithValue("@nombre_proyecto", proyecto.Nombre_proyecto);
                    cmd.Parameters.AddWithValue("@descripcion", proyecto.Descripcion);
                    cmd.Parameters.AddWithValue("@ubicacion", proyecto.Ubicacion);
                    cmd.Parameters.AddWithValue("@cantidad_estimada", proyecto.Cantidad_estimada);
                    cmd.Parameters.AddWithValue("@costo_unitario_estimado", proyecto.Costo_unitario_estimado);
                    cmd.Parameters.AddWithValue("@presupuesto_estimado", proyecto.Presupuesto_estimado);
                    cmd.Parameters.AddWithValue("@fecha_inicio_prevista", proyecto.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fecha_fin_prevista", proyecto.Fecha_fin_prevista);
                    cmd.Parameters.AddWithValue("@estado", proyecto.Estado);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para eliminar un proyecto
        public string Eliminar(ProyectoDao proyecto)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM proyecto WHERE proyecto_id=@proyecto_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@proyecto_id", proyecto.Proyecto_id);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para mostrar todos los proyectos
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto";
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

        //metodo para buscar un proyecto por nombre
        public DataTable BuscarNombre(ProyectoDao proyecto)
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto WHERE nombre_proyecto LIKE @textobuscar";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@textobuscar", proyecto.Textobuscar + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para buscara por fecha inicio y fin
        public DataTable BuscarFecha(ProyectoDao proyecto)
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto WHERE fecha_inicio_prevista BETWEEN @fechainicio AND @fechafin";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@fechainicio", proyecto.Fecha_inicio_prevista);
                    cmd.Parameters.AddWithValue("@fechafin", proyecto.Fecha_fin_prevista);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los proyectos por programa
        public DataTable MostrarPorPrograma(ProyectoDao proyecto)
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto WHERE programa_id=@programa_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@programa_id", proyecto.Programa_id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los proyectos por contratista
        public DataTable MostrarPorContratista(ProyectoDao proyecto)
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto WHERE contratista_id=@contratista_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@contratista_id", proyecto.Contratista_id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para mostrar los proyectos por estado
        public DataTable MostrarPorEstado(ProyectoDao proyecto)
        {
            DataTable dt = new DataTable("proyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM proyecto WHERE estado=@estado";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@estado", proyecto.Estado);
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
