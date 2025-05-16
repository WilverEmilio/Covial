using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class OrdenPagoDao : ConnectionToMySQL
    {
        private int _orden_pago_id;
        private int _proyecto_id;
        private int _contratista_id;
        private DateTime _fecha_emision;
        private decimal _monto;
        private string _descripcion;
        private string _estado;
        private DateTime _fecha_creacion;
        private int _creada_por;
        private string _textobuscar;

        public int Orden_pago_id { get => _orden_pago_id; set => _orden_pago_id = value; }
        public int Proyecto_id { get => _proyecto_id; set => _proyecto_id = value; }
        public int Contratista_id { get => _contratista_id; set => _contratista_id = value; }
        public DateTime Fecha_emision { get => _fecha_emision; set => _fecha_emision = value; }
        public decimal Monto { get => _monto; set => _monto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public DateTime Fecha_creacion { get => _fecha_creacion; set => _fecha_creacion = value; }
        public int Creada_por { get => _creada_por; set => _creada_por = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public OrdenPagoDao() { }

        //Constructor con parametros
        public OrdenPagoDao(int orden_pago_id, int proyecto_id, int contratista_id, DateTime fecha_emision, decimal monto, string descripcion, string estado, DateTime fecha_creacion, int creada_por)
        {
            this.Orden_pago_id = orden_pago_id;
            this.Proyecto_id = proyecto_id;
            this.Contratista_id = contratista_id;
            this.Fecha_emision = fecha_emision;
            this.Monto = monto;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Fecha_creacion = fecha_creacion;
            this.Creada_por = creada_por;
        }

        //Metodo para insertar una orden de pago
        public string Insertar(OrdenPagoDao ordenPago)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
            try
            {
                    SqlCon.Open();
                    string query = @"INSERT INTO ordenespago (proyecto_id, contratista_id, fecha_emision, monto, descripcion, estado, fecha_creacion, creada_por) VALUES (@proyecto_id, @contratista_id, @fecha_emision, @monto, @descripcion, @estado, @fecha_creacion, @creada_por)";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))

                    {
                        SqlCmd.Parameters.AddWithValue("@proyecto_id", ordenPago.Proyecto_id);
                        SqlCmd.Parameters.AddWithValue("@contratista_id", ordenPago.Contratista_id);
                        SqlCmd.Parameters.AddWithValue("@fecha_emision", ordenPago.Fecha_emision);
                        SqlCmd.Parameters.AddWithValue("@monto", ordenPago.Monto);
                        SqlCmd.Parameters.AddWithValue("@descripcion", ordenPago.Descripcion);
                        SqlCmd.Parameters.AddWithValue("@estado", ordenPago.Estado);
                        SqlCmd.Parameters.AddWithValue("@fecha_creacion", ordenPago.Fecha_creacion);
                        SqlCmd.Parameters.AddWithValue("@creada_por", ordenPago.Creada_por);
                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar la orden de pago";
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
        //Metodo para editar una orden de pago
        public string Editar(OrdenPagoDao ordenPago)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"UPDATE orden_pago SET proyecto_id=@proyecto_id, contratista_id=@contratista_id, fecha_emision=@fecha_emision, monto=@monto, descripcion=@descripcion, estado=@estado WHERE orden_pago_id=@orden_pago_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@orden_pago_id", ordenPago.Orden_pago_id);
                        SqlCmd.Parameters.AddWithValue("@proyecto_id", ordenPago.Proyecto_id);
                        SqlCmd.Parameters.AddWithValue("@contratista_id", ordenPago.Contratista_id);
                        SqlCmd.Parameters.AddWithValue("@fecha_emision", ordenPago.Fecha_emision);
                        SqlCmd.Parameters.AddWithValue("@monto", ordenPago.Monto);
                        SqlCmd.Parameters.AddWithValue("@descripcion", ordenPago.Descripcion);
                        SqlCmd.Parameters.AddWithValue("@estado", ordenPago.Estado);
                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar la orden de pago";
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

        //Metodo para eliminar una orden de pago
        public string Eliminar(OrdenPagoDao ordenPagoDao)
        {
            string respuesta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
            {
                SqlCon.Open();
                try
                {
                    string query = "DELETE FROM orden_pago WHERE orden_pago_id=@orden_pago_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@orden_pago_id", ordenPagoDao.Orden_pago_id);
                        respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar la orden de pago";
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
                finally
                {
                    SqlCon.Close();
                }
                return respuesta;
            }
        }

        //Metodo para mostrar una orden de pago
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("ordenespago");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT 
                                    o.orden_pago_id,
                                    o.proyecto_id,
                                    p.nombre_proyecto,
                                    o.contratista_id,
                                    c.nombre_contratista,
                                    o.fecha_emision,
                                    o.monto,
                                    o.descripcion,
                                    o.estado,
                                    o.fecha_creacion,
                                    o.creada_por,
                                    u.nombre_usuario
                                FROM 
                                    ordenespago o
                                INNER JOIN 
                                    proyectos p ON o.proyecto_id = p.proyecto_id
                                INNER JOIN
	                                usuarios u ON o.creada_por = u.usuario_id
                                INNER JOIN 
                                    contratistas c ON o.contratista_id = c.contratista_id;";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(SqlCmd);
                        sqlDataAdapter.Fill(dt);
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
            }
            return dt;

        }

        //Metodo para buscar una orden de pago
        public DataTable Buscar(OrdenPagoDao ordenPago)
        {
            DataTable dt = new DataTable("ordenespago");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM orden_pago WHERE CONCAT(orden_pago_id, ' ', proyecto_id, ' ', contratista_id, ' ', fecha_emision, ' ', monto, ' ', descripcion, ' ', estado) LIKE @textobuscar";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@textobuscar", ordenPago.Textobuscar);
                        MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(SqlCmd);
                        sqlDataAdapter.Fill(dt);
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

        //Metodo para mostrar el monto total de las ordenes de pago
        public DataTable MostrarMontoTotal(OrdenPagoDao ordenPagoDao)
        {
            DataTable dtResultado = new DataTable("ordenespago");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_monto_total_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_orden_pago_id", ordenPagoDao.Orden_pago_id);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return dtResultado;
        }
    }
}
