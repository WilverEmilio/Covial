using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class PlanAnualDao : ConnectionToMySQL
    {
        private int _plan_anual_id;
        private int _año;
        private string _nombre_plan;
        private string _descripcion;
        private DateTime _fecha_creacion;
        private int _creado_por;

        private string _textobuscar;

        public int Plan_anual_id { get => _plan_anual_id; set => _plan_anual_id = value; }
        public int Año { get => _año; set => _año = value; }
        public string Nombre_plan { get => _nombre_plan; set => _nombre_plan = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime Fecha_creacion { get => _fecha_creacion; set => _fecha_creacion = value; }
        public int Creado_por { get => _creado_por; set => _creado_por = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public PlanAnualDao()
        {

        }

        //Constructor con parametros
        public PlanAnualDao(int plan_anual_id, int año, string nombre_plan, string descripcion, DateTime fecha_creacion, int creado_por, string TextoBuscar)
        {
            this.Plan_anual_id = plan_anual_id;
            this.Año = año;
            this.Nombre_plan = nombre_plan;
            this.Descripcion = descripcion;
            this.Fecha_creacion = fecha_creacion;
            this.Creado_por = creado_por;
            this.Textobuscar = TextoBuscar;
        }

        //metodo para insertar un plan anual
        public string Insertar(PlanAnualDao plan)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO plan_anual " +
                        "(año, nombre_plan, descripcion, fecha_creacion, " +
                        "creado_por) VALUES " +
                        "(@año, @nombre_plan, @descripcion, @fecha_creacion, @creado_por)";

                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@año", plan.Año);
                        SqlCmd.Parameters.AddWithValue("@nombre_plan", plan.Nombre_plan);
                        SqlCmd.Parameters.AddWithValue("@descripcion", plan.Descripcion);
                        SqlCmd.Parameters.AddWithValue("@fecha_creacion", plan.Fecha_creacion);
                        SqlCmd.Parameters.AddWithValue("@creado_por", plan.Creado_por);
                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    SqlCon.Close();
                }
            return rpta;
        }

        //metodo para editar un plan anual
        public string Editar(PlanAnualDao plan)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE plan_anual SET " +
                        "año=@año, nombre_plan=@nombre_plan, descripcion=@descripcion, " +
                        "fecha_creacion=@fecha_creacion, creado_por=@creado_por " +
                        "WHERE plan_anual_id=@plan_anual_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@plan_anual_id", plan.Plan_anual_id);
                        SqlCmd.Parameters.AddWithValue("@año", plan.Año);
                        SqlCmd.Parameters.AddWithValue("@nombre_plan", plan.Nombre_plan);
                        SqlCmd.Parameters.AddWithValue("@descripcion", plan.Descripcion);
                        SqlCmd.Parameters.AddWithValue("@fecha_creacion", plan.Fecha_creacion);
                        SqlCmd.Parameters.AddWithValue("@creado_por", plan.Creado_por);
                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    SqlCon.Close();
                }
            return rpta;
        }

        //metodo para eliminar un plan anual
        public string Eliminar(PlanAnualDao plan)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM plan_anual WHERE plan_anual_id=@plan_anual_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@plan_anual_id", plan.Plan_anual_id);
                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    SqlCon.Close();
                }
            return rpta;
        }

        //metodo todos los planes anuales
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("plan_anual");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT plan_anual_id, año, nombre_plan, descripcion, fecha_creacion, creado_por FROM plan_anual";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        SqlDat.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                finally
                {
                    SqlCon.Close();
                }
            return dt;
        }

        //metodo mostrar plan anual por año
        public DataTable MostrarPlanAnualPorAño(PlanAnualDao plan)
        {
            DataTable dt = new DataTable("plan_anual");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT plan_anual_id, año, nombre_plan, descripcion, fecha_creacion, creado_por FROM plan_anual WHERE año=@año";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@año", plan.Año);
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        SqlDat.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                finally
                {
                    SqlCon.Close();
                }
            return dt;
        }

        //metodo buscar plan anual por nombre
        public DataTable Buscar(PlanAnualDao plan)
        {
            DataTable dt = new DataTable("plan_anual");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT plan_anual_id, año, nombre_plan, descripcion, fecha_creacion, creado_por FROM plan_anual WHERE nombre_plan LIKE @textobuscar";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@textobuscar", "%" + plan.Textobuscar + "%");
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        SqlDat.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                finally
                {
                    SqlCon.Close();
                }
            return dt;
        }

    }
}
