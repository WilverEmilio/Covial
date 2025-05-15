using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace DataAccess.MySQL
{
    public class AvanceProyectoDao : ConnectionToMySQL
    {
        private int avance_id;
        private int proyecto_id;
        private DateTime fecha_avance;
        private decimal cantidad_reportada;
        private string descripcion_avance;
        private string fotos;
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
        public string Fotos { get => fotos; set => fotos = value; }

        // Constructor vacio
        public AvanceProyectoDao()
        {
        }

        // Constructor con parametros
        public AvanceProyectoDao(int avance_id, int proyecto_id, DateTime fecha_avance, decimal cantidad_reportada, string descripcion_avance,string fotos, int reportado_por, DateTime fecha_registro)
        {
            this.avance_id = avance_id;
            this.proyecto_id = proyecto_id;
            this.fecha_avance = fecha_avance;
            this.cantidad_reportada = cantidad_reportada;
            this.descripcion_avance = descripcion_avance;
            this.fotos = fotos;
            this.reportado_por = reportado_por;
            this.fecha_registro = fecha_registro;
        }

        // Metodo para insertar un avance de proyecto
        public string Insertar(AvanceProyectoDao avanceProyectoDao)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"INSERT INTO avancesproyecto 
                                (proyecto_id, fecha_avance, cantidad_reportada, descripcion_avance, fotos, reportado_por, fecha_registro)
                                VALUES (@proyecto_id, @fecha_avance, @cantidad_reportada, @descripcion_avance, @fotos, @reportado_por, @fecha_registro)";

                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"proyecto_id", avanceProyectoDao.proyecto_id);
                        SqlCmd.Parameters.AddWithValue(@"fecha_avance", avanceProyectoDao.fecha_avance);
                        SqlCmd.Parameters.AddWithValue(@"cantidad_reportada", avanceProyectoDao.cantidad_reportada);
                        SqlCmd.Parameters.AddWithValue(@"descripcion_avance", avanceProyectoDao.descripcion_avance);
                        SqlCmd.Parameters.AddWithValue(@"fotos", avanceProyectoDao.fotos);
                        SqlCmd.Parameters.AddWithValue(@"reportado_por", avanceProyectoDao.reportado_por);
                        SqlCmd.Parameters.AddWithValue(@"fecha_registro", DateTime.Now);

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

        // Metodo para editar un avance de proyecto
        public string Editar(AvanceProyectoDao avanceProyectoDao)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"UPDATE avancesproyecto SET 
                                proyecto_id=@proyecto_id, 
                                fecha_avance=@fecha_avance, 
                                cantidad_reportada=@cantidad_reportada, 
                                descripcion_avance=@descripcion_avance, 
                                fotos=@fotos, 
                                reportado_por=@reportado_por, 
                                fecha_registro=@fecha_registro
                                WHERE avance_id=@avance_id ";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"avance_id", avanceProyectoDao.avance_id);
                        SqlCmd.Parameters.AddWithValue(@"proyecto_id", avanceProyectoDao.proyecto_id);
                        SqlCmd.Parameters.AddWithValue(@"fecha_avance", avanceProyectoDao.fecha_avance);
                        SqlCmd.Parameters.AddWithValue(@"cantidad_reportada", avanceProyectoDao.cantidad_reportada);
                        SqlCmd.Parameters.AddWithValue(@"descripcion_avance", avanceProyectoDao.descripcion_avance);
                        SqlCmd.Parameters.AddWithValue(@"fotos", avanceProyectoDao.fotos);
                        SqlCmd.Parameters.AddWithValue(@"reportado_por", avanceProyectoDao.reportado_por);
                        SqlCmd.Parameters.AddWithValue(@"fecha_registro", DateTime.Now);
                        //Ejecutar el comando
                        int result = SqlCmd.ExecuteNonQuery();
                        //Verificar si se editó el registro
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

        // Metodo para eliminar un avance de proyecto
        public string Eliminar(AvanceProyectoDao avanceProyectoDao)
        {
            string rpta = "";
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"DELETE FROM avancesproyecto WHERE avance_id=@avance_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"avance_id", avanceProyectoDao.avance_id);
                        //Ejecutar el comando
                        int result = SqlCmd.ExecuteNonQuery();
                        //Verificar si se eliminó el registro
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

        // Metodo para mostrar un avance de proyecto
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("avancesproyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"
                        SELECT 
                            ap.avance_id,
                            ap.proyecto_id,
                            p.nombre_proyecto,
                            ap.fecha_avance,
                            ap.cantidad_reportada,
                            ap.descripcion_avance,
                            ap.fotos,
                            ap.reportado_por,
                            u.nombre_usuario,
                            ap.fecha_registro
                        FROM 
                            avancesproyecto ap
                        INNER JOIN 
                            proyectos p ON ap.proyecto_id = p.proyecto_id
                        INNER JOIN 
                            usuarios u ON ap.reportado_por = u.usuario_id";
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

        // Metodo para mostrar un avance de proyecto por id
        public DataTable MostrarPorId(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dt = new DataTable("avancesproyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT * FROM avancesproyecto WHERE avance_id=@avance_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"avance_id", avanceProyectoDao.avance_id);
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

        // Metodo para mostrar los avances de un proyecto
        public DataTable MostrarAvancesPorProyecto(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dt = new DataTable("avancesproyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT * FROM avancesproyecto WHERE proyecto_id=@proyecto_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"proyecto_id", avanceProyectoDao.proyecto_id);
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

        // Metodo para mostrar los avances de un proyecto por fecha
        public DataTable MostrarAvancesPorFecha(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dt = new DataTable("avancesproyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT * FROM avancesproyecto WHERE fecha_avance=@fecha_avance";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"fecha_avance", avanceProyectoDao.fecha_avance);
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

        //Metodo para buscar un avance port proyecto_id que entonces seria nombre
        public DataTable Buscar(AvanceProyectoDao avanceProyectoDao)
        {
            DataTable dt = new DataTable("avancesproyecto");
            using (MySqlConnection SqlCon = new MySqlConnection(connectionString))
                try
                {
                    SqlCon.Open();
                    string query = @"SELECT * FROM avancesproyecto WHERE proyecto_id=@proyecto_id";
                    using (MySqlCommand SqlCmd = new MySqlCommand(query, SqlCon))
                    {
                        SqlCmd.Parameters.AddWithValue(@"proyecto_id", avanceProyectoDao.proyecto_id);
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
    }
}
