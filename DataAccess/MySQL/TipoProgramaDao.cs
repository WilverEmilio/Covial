using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class TipoProgramaDao : ConnectionToMySQL
    {
        private int _tipo_programa_id;
        private string _nombre_tipo;

        public int Tipo_programa_id { get => _tipo_programa_id; set => _tipo_programa_id = value; }
        public string Nombre_tipo { get => _nombre_tipo; set => _nombre_tipo = value; }

        public TipoProgramaDao() { }

        public TipoProgramaDao(int tipo_programa_id, string nombre_tipo)
        {
            this.Tipo_programa_id = tipo_programa_id;
            this.Nombre_tipo = nombre_tipo;
        }

        //metodo para insertar un tipo de programa
        public string Insertar(TipoProgramaDao tipo)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO tipo_programa " +
                        "(nombre_tipo) VALUES " +
                        "(@nombre_tipo)";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@nombre_tipo", tipo.Nombre_tipo);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para editar un tipo de programa
        public string Editar(TipoProgramaDao tipo)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE tipo_programa SET " +
                        "nombre_tipo=@nombre_tipo " +
                        "WHERE tipo_programa_id=@tipo_programa_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@tipo_programa_id", tipo.Tipo_programa_id);
                    cmd.Parameters.AddWithValue("@nombre_tipo", tipo.Nombre_tipo);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para eliminar un tipo de programa
        public string Eliminar(TipoProgramaDao tipo)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM tipo_programa WHERE tipo_programa_id=@tipo_programa_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@tipo_programa_id", tipo.Tipo_programa_id);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para mostrar todos los tipos de programa
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("tipo_programa");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM tipo_programa";
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

        //metodo para buscar un tipo de programa por su nombre
        public DataTable Buscar(TipoProgramaDao tipo)
        {
            DataTable dt = new DataTable("tipo_programa");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM tipo_programa WHERE nombre_tipo LIKE @nombre_tipo";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@nombre_tipo", "%" + tipo.Nombre_tipo + "%");
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
