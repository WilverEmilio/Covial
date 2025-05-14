using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.MySQL
{
    public class UserDao : ConnectionToMySQL
    {
        private int _usuario_id;
        private string _nombre_usuario;
        private string _contrasena;
        private string _rol;
        private string _nombre_completo;
        private bool _activo;
        private DateTime _fecha_creacion;

        private string _textobuscar;

        public int Usuario_id { get => _usuario_id; set => _usuario_id = value; }
        public string Nombre_usuario { get => _nombre_usuario; set => _nombre_usuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string Rol { get => _rol; set => _rol = value; }
        public string Nombre_completo { get => _nombre_completo; set => _nombre_completo = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public DateTime Fecha_creacion { get => _fecha_creacion; set => _fecha_creacion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //constructor vacio
        public UserDao()
        {

        }

        //constructor con parametros
        public UserDao(int usuario_id, string nombre_usuario, string contrasena, string rol, string nombre_completo, bool activo, DateTime fecha_creacion, string Textobuscar)
        {
            this.Usuario_id = usuario_id;
            this.Nombre_usuario = nombre_usuario;
            this.Contrasena = contrasena;
            this.Rol = rol;
            this.Nombre_completo = nombre_completo;
            this.Activo = activo;
            this.Fecha_creacion = fecha_creacion;
            this.Textobuscar = Textobuscar;
        }

        //metodo para insertar un usuario
        public string Insertar(UserDao user)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"INSERT INTO usuarios 
                            (nombre_usuario, contrasena, rol, nombre_completo, activo, fecha_creacion) 
                             VALUES 
                            (@nombre_usuario, @contrasena, @rol, @nombre_completo, @activo, @fecha_creacion);";

                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@nombre_usuario", user.Nombre_usuario);
                        SqlCmd.Parameters.AddWithValue("@contrasena", user.Contrasena);
                        SqlCmd.Parameters.AddWithValue("@rol", user.Rol);
                        SqlCmd.Parameters.AddWithValue("@nombre_completo", user.Nombre_completo);
                        SqlCmd.Parameters.AddWithValue("@activo", user.Activo);
                        SqlCmd.Parameters.AddWithValue("@fecha_creacion", user.Fecha_creacion);

                        //Ejecutar el comando
                        int result = SqlCmd.ExecuteNonQuery();
                        //Verificar si se insertó el registro
                        rpta = result == 1 ? "OK" : "No se insertó el registro";
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

        //metodo para editar un usuario
        public string Editar(UserDao user)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"UPDATE usuarios SET 
                            nombre_usuario=@nombre_usuario, 
                            contrasena=@contrasena, 
                            rol=@rol, 
                            nombre_completo=@nombre_completo, 
                            activo=@activo, 
                            fecha_creacion=@fecha_creacion 
                            WHERE usuario_id=@usuario_id;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@usuario_id", user.Usuario_id);
                        SqlCmd.Parameters.AddWithValue("@nombre_usuario", user.Nombre_usuario);
                        SqlCmd.Parameters.AddWithValue("@contrasena", user.Contrasena);
                        SqlCmd.Parameters.AddWithValue("@rol", user.Rol);
                        SqlCmd.Parameters.AddWithValue("@nombre_completo", user.Nombre_completo);
                        SqlCmd.Parameters.AddWithValue("@activo", user.Activo);
                        SqlCmd.Parameters.AddWithValue("@fecha_creacion", user.Fecha_creacion);
                        //Ejecutar el comando
                        int result = SqlCmd.ExecuteNonQuery();
                        //Verificar si se insertó el registro
                        rpta = result == 1 ? "OK" : "No se editó el registro";
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

        //metodo para eliminar un usuario
        public string Eliminar(UserDao user)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"DELETE FROM usuarios WHERE usuario_id=@usuario_id;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@usuario_id", user.Usuario_id);
                        //Ejecutar el comando
                        int result = SqlCmd.ExecuteNonQuery();
                        //Verificar si se insertó el registro
                        rpta = result == 1 ? "OK" : "No se eliminó el registro";
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

        //metodo para mostrar todos los usuarios
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("usuarios");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"SELECT * FROM usuarios;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        //Crear el adaptador
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        //Llenar el DataTable
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

        //metodo mostrar usuario no disponible
        public DataTable MostrarNoDisponible()
        {
            DataTable dt = new DataTable("usuarios");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"SELECT * FROM usuarios WHERE activo=0;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        //Crear el adaptador
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        //Llenar el DataTable
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

        //metodo para buscar un usuario
        public DataTable Buscar(UserDao user)
        {
            DataTable dt = new DataTable("usuarios");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"SELECT * FROM usuarios WHERE nombre_usuario LIKE @textobuscar;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@textobuscar", "%" + user.Nombre_usuario + "%");
                        //Crear el adaptador
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        //Llenar el DataTable
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

        //Metodo ingresar usuario
        public DataTable Ingresar(UserDao user)
        {
            DataTable dt = new DataTable("usuarios");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    //codigo
                    SqlCon.Open();
                    //Establecer el Query
                    string query = @"SELECT * FROM usuarios WHERE nombre_usuario=@nombre_usuario AND contrasena=@contrasena;";
                    //Crear el comando
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue("@nombre_usuario", user.Nombre_usuario);
                        SqlCmd.Parameters.AddWithValue("@contrasena", user.Contrasena);
                        //Crear el adaptador
                        MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                        //Llenar el DataTable
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

        public void AnyMethod()
        {
            UserDao newUser = new UserDao
            {
                Nombre_usuario = "testuser",
                Contrasena = "password",
                Rol = "admin",
                Nombre_completo = "Test User",
                Activo = true,
                Fecha_creacion = DateTime.Now
            };
            string result = Insertar(newUser);
            Console.WriteLine(result);
        }
    }
}
