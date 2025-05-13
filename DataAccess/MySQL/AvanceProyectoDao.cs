using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class AvanceProyectoDao : ConnectionToMySQL
    {
        private int avance_id;
        private int proyecto_id;
        private DateTime fecha_avance;
        private decimal cantidad_reportada;
        private string descripcion_avance;
        private int reportado_por;
        private DateTime fecha_registro;
        private string textobuscar;

        public int Avance_id { get => avance_id; set => avance_id = value; }
        public int Proyecto_id { get => proyecto_id; set => proyecto_id = value; }
        public DateTime Fecha_avance { get => fecha_avance; set => fecha_avance = value; }
        public decimal Cantidad_reportada { get => cantidad_reportada; set => cantidad_reportada = value; }
        public string Descripcion_avance { get => descripcion_avance; set => descripcion_avance = value; }
        public int Reportado_por { get => reportado_por; set => reportado_por = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Textobuscar { get => textobuscar; set => textobuscar = value; }

        // Constructor vacio
        public AvanceProyectoDao()
        {
        }

        // Constructor con parametros
        public AvanceProyectoDao(int avance_id, int proyecto_id, DateTime fecha_avance, decimal cantidad_reportada, string descripcion_avance, int reportado_por, DateTime fecha_registro)
        {
            this.avance_id = avance_id;
            this.proyecto_id = proyecto_id;
            this.fecha_avance = fecha_avance;
            this.cantidad_reportada = cantidad_reportada;
            this.descripcion_avance = descripcion_avance;
            this.reportado_por = reportado_por;
            this.fecha_registro = fecha_registro;
        }

        // Metodo para insertar un avance de proyecto
        public string Insertar(AvanceProyectoDao avanceProyectoDao)
        {
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_insertar_avance_proyecto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", avanceProyectoDao.Proyecto_id);
                sqlCommand.Parameters.AddWithValue("p_fecha_avance", avanceProyectoDao.Fecha_avance);
                sqlCommand.Parameters.AddWithValue("p_cantidad_reportada", avanceProyectoDao.Cantidad_reportada);
                sqlCommand.Parameters.AddWithValue("p_descripcion_avance", avanceProyectoDao.Descripcion_avance);
                sqlCommand.Parameters.AddWithValue("p_reportado_por", avanceProyectoDao.Reportado_por);
                sqlCommand.Parameters.AddWithValue("p_fecha_registro", avanceProyectoDao.Fecha_registro);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
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

        // Metodo para editar un avance de proyecto
        public string Editar(AvanceProyectoDao avanceProyectoDao)
        {
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_editar_avance_proyecto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_avance_id", avanceProyectoDao.Avance_id);
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", avanceProyectoDao.Proyecto_id);
                sqlCommand.Parameters.AddWithValue("p_fecha_avance", avanceProyectoDao.Fecha_avance);
                sqlCommand.Parameters.AddWithValue("p_cantidad_reportada", avanceProyectoDao.Cantidad_reportada);
                sqlCommand.Parameters.AddWithValue("p_descripcion_avance", avanceProyectoDao.Descripcion_avance);
                sqlCommand.Parameters.AddWithValue("p_reportado_por", avanceProyectoDao.Reportado_por);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
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

        // Metodo para eliminar un avance de proyecto
        public string Eliminar(AvanceProyectoDao avanceProyectoDao)
        {
            string respuesta = "";
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_eliminar_avance_proyecto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_avance_id", avanceProyectoDao.Avance_id);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
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

        // Metodo para mostrar un avance de proyecto
        public DataTable Mostrar(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dtResultado = new DataTable("avance_proyecto");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_avance_proyecto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_textobuscar", avanceProyectoDao.Textobuscar);
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

        // Metodo para mostrar un avance de proyecto por id
        public DataTable MostrarPorId(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dtResultado = new DataTable("avance_proyecto");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_avance_proyecto_por_id", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_avance_id", avanceProyectoDao.Avance_id);
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

        // Metodo para mostrar los avances de un proyecto
        public DataTable MostrarAvancesPorProyecto(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dtResultado = new DataTable("avance_proyecto");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_avances_por_proyecto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", avanceProyectoDao.Proyecto_id);
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

        // Metodo para mostrar los avances de un proyecto por fecha
        public DataTable MostrarAvancesPorFecha(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dtResultado = new DataTable("avance_proyecto");
            MySqlConnection sqlConnection = GetConnection();
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("sp_mostrar_avances_por_fecha", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("p_proyecto_id", avanceProyectoDao.Proyecto_id);
                sqlCommand.Parameters.AddWithValue("p_fecha_avance", avanceProyectoDao.Fecha_avance);
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
