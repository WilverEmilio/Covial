using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.MySQL;

namespace Domain
{
    public class UserModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase UserDao de la capa de DataAccess
        public static string Insertar(string nombre_usuario, string contrasena, string rol, string nombre_completo, bool activo, DateTime fecha_creacion)
        {
            UserDao obj = new UserDao();
            obj.Nombre_usuario = nombre_usuario;
            obj.Contrasena = contrasena;
            obj.Rol = rol;
            obj.Nombre_completo = nombre_completo;
            obj.Activo = activo;
            obj.Fecha_creacion = fecha_creacion;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase UserDao de la capa de DataAccess
        public static string Editar(int id_usuario, string nombre_usuario, string contrasena, string rol, string nombre_completo, bool activo, DateTime fecha_creacion)
        {
            UserDao obj = new UserDao();
            obj.Usuario_id = id_usuario;
            obj.Nombre_usuario = nombre_usuario;
            obj.Contrasena = contrasena;
            obj.Rol = rol;
            obj.Nombre_completo = nombre_completo;
            obj.Activo = activo;
            obj.Fecha_creacion = fecha_creacion;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase UserDao de la capa de DataAccess
        public static string Eliminar(int id_usuario)
        {
            UserDao obj = new UserDao();
            obj.Usuario_id = id_usuario;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase UserDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new UserDao().Mostrar();
        }

        //Metodo mostrar no disponibles
        public static DataTable MostrarNoDisponibles()
        {
            return new UserDao().MostrarNoDisponible();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase UserDao de la capa de DataAccess
        public static DataTable BuscarNombre(string nombre_usuario)
        {
            UserDao obj = new UserDao();
            obj.Nombre_usuario = nombre_usuario;
            return obj.Buscar(obj);
        }

        //Metodo Login que llama al metodo Login de la clase UserDao de la capa de DataAccess
        public static DataTable Login(string nombre_usuario, string contrasena)
        {
            UserDao obj = new UserDao();
            obj.Nombre_usuario = nombre_usuario;
            obj.Contrasena = contrasena;
            return obj.Ingresar(obj);
        }

        public void AnyMethod()
        {
            
        }
    }
}
