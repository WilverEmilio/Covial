using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public abstract class ConnectionToMySQL
    {
        protected static string connectionString;

        public ConnectionToMySQL()
        {
            connectionString = "Server=localhost;Database=sistema_gestion_proyectos;Uid=root;Pwd=123456789";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

