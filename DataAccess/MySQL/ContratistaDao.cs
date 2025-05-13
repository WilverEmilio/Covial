using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess.MySQL
{
    public class ContratistaDao : ConnectionToMySQL
    {
        private int _contratista_id;
        private string _nombre_contratista;
        private string _contacto;
        private string _telefono;
        private string _direccion;
        private bool _fecha_registro;
        private string _textobuscar;

        public int Contratista_id { get => _contratista_id; set => _contratista_id = value; }
        public string Nombre_contratista { get => _nombre_contratista; set => _nombre_contratista = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Fecha_registro { get => _fecha_registro; set => _fecha_registro = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public ContratistaDao()
        {
        }

        //Constructor con parametros
        public ContratistaDao(int contratista_id, string nombre_contratista, string contacto, string telefono, string direccion, bool fecha_registro)
        {
            this.Contratista_id = contratista_id;
            this.Nombre_contratista = nombre_contratista;
            this.Contacto = contacto;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Fecha_registro = fecha_registro;
        }

        //metodo para insertar un contratista
        public string Insertar(ContratistaDao contratista)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "INSERT INTO contratista " +
                        "(nombre_contratista, contacto, telefono, direccion, fecha_registro) VALUES " +
                        "(@nombre_contratista, @contacto, @telefono, @direccion, @fecha_registro)";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@nombre_contratista", contratista.Nombre_contratista);
                    cmd.Parameters.AddWithValue("@contacto", contratista.Contacto);
                    cmd.Parameters.AddWithValue("@telefono", contratista.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", contratista.Direccion);
                    cmd.Parameters.AddWithValue("@fecha_registro", DateTime.Now);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para editar un contratista
        public string Editar(ContratistaDao contratista)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "UPDATE contratista SET " +
                        "nombre_contratista=@nombre_contratista, contacto=@contacto, telefono=@telefono, direccion=@direccion " +
                        "WHERE contratista_id=@contratista_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@contratista_id", contratista.Contratista_id);
                    cmd.Parameters.AddWithValue("@nombre_contratista", contratista.Nombre_contratista);
                    cmd.Parameters.AddWithValue("@contacto", contratista.Contacto);
                    cmd.Parameters.AddWithValue("@telefono", contratista.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", contratista.Direccion);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al editar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para eliminar un contratista
        public string Eliminar(ContratistaDao contratista)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "DELETE FROM contratista WHERE contratista_id=@contratista_id";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@contratista_id", contratista.Contratista_id);
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al eliminar el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            return rpta;
        }

        //metodo para mostrar todos los contratistas
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("contratista");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM contratista";
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

        //metodo para buscar un contratista por nombre
        public DataTable BuscarNombre(ContratistaDao contratista)
        {
            DataTable dt = new DataTable("contratista");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM contratista WHERE nombre_contratista LIKE @textobuscar";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@textobuscar", "%" + contratista.Textobuscar + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            return dt;
        }

        //metodo para buscar un contratista por contacto
        public DataTable BuscarContacto(ContratistaDao contratista)
        {
            DataTable dt = new DataTable("contratista");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = "SELECT * FROM contratista WHERE contacto LIKE @textobuscar";
                    MySqlCommand cmd = new MySqlCommand(query, SqlCon);
                    cmd.Parameters.AddWithValue("@textobuscar", "%" + contratista.Textobuscar + "%");
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
