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
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_insertar_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", ordenPago.Proyecto_id);
                sqlCommand.Parameters.AddWithValue("p_contratista_id", ordenPago.Contratista_id);
                sqlCommand.Parameters.AddWithValue("p_fecha_emision", ordenPago.Fecha_emision);
                sqlCommand.Parameters.AddWithValue("p_monto", ordenPago.Monto);
                sqlCommand.Parameters.AddWithValue("p_descripcion", ordenPago.Descripcion);
                sqlCommand.Parameters.AddWithValue("p_estado", ordenPago.Estado);
                sqlCommand.Parameters.AddWithValue("p_fecha_creacion", ordenPago.Fecha_creacion);
                sqlCommand.Parameters.AddWithValue("p_creada_por", ordenPago.Creada_por);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar la orden de pago";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return respuesta;
        }
        //Metodo para editar una orden de pago
        public string Editar(OrdenPagoDao ordenPago)
        {
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_editar_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_orden_pago_id", ordenPago.Orden_pago_id);
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", ordenPago.Proyecto_id);
                sqlCommand.Parameters.AddWithValue("p_contratista_id", ordenPago.Contratista_id);
                sqlCommand.Parameters.AddWithValue("p_fecha_emision", ordenPago.Fecha_emision);
                sqlCommand.Parameters.AddWithValue("p_monto", ordenPago.Monto);
                sqlCommand.Parameters.AddWithValue("p_descripcion", ordenPago.Descripcion);
                sqlCommand.Parameters.AddWithValue("p_estado", ordenPago.Estado);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al editar la orden de pago";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return respuesta;
        }

        //Metodo para eliminar una orden de pago
        public string Eliminar(int orden_pago_id)
        {
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_eliminar_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_orden_pago_id", orden_pago_id);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar la orden de pago";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return respuesta;
        }

        //Metodo para mostrar una orden de pago
        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("orden_pago");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
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

        //Metodo para buscar una orden de pago
        public DataTable Buscar(OrdenPagoDao ordenPago)
        {
            DataTable dtResultado = new DataTable("orden_pago");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_buscar_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_textobuscar", ordenPago.Textobuscar);
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

        //Metodo para mostrar el monto total de las ordenes de pago
        public DataTable MostrarMontoTotal()
        {
            DataTable dtResultado = new DataTable("orden_pago");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_monto_total_orden_pago", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
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
