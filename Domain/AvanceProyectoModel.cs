using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class AvanceProyectoModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase AvanceProyectoDao de la capa de DataAccess
        public static string Insertar(int proyecto_id, DateTime fecha_avance, decimal cantidad_reportada, string descripcion_avance, string fotos, int reportado_por, DateTime fecha_registro)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Proyecto_id = proyecto_id;
            obj.Fecha_avance = fecha_avance;
            obj.Cantidad_reportada = cantidad_reportada;
            obj.Descripcion_avance = descripcion_avance;
            obj.Fotos = fotos;
            obj.Reportado_por = reportado_por;
            obj.Fecha_registro = fecha_registro;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase AvanceProyectoDao de la capa de DataAccess
        public static string Editar(int id_avance, int proyecto_id, DateTime fecha_avance, decimal cantidad_reportada, string descripcion_avance, string fotos, int reportado_por, DateTime fecha_registro)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Avance_id = id_avance;
            obj.Proyecto_id = proyecto_id;
            obj.Fecha_avance = fecha_avance;
            obj.Cantidad_reportada = cantidad_reportada;
            obj.Descripcion_avance = descripcion_avance;
            obj.Fotos = fotos;
            obj.Reportado_por = reportado_por;
            obj.Fecha_registro = fecha_registro;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase AvanceProyectoDao de la capa de DataAccess
        public static string Eliminar(int id_avance)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Avance_id = id_avance;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase AvanceProyectoDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new AvanceProyectoDao().Mostrar();
        }

        //Metodo Mostrar por proyecto id que llama al metodo MostrarPorProyectoId de la clase AvanceProyectoDao de la capa de DataAccess
        public static DataTable MostrarPorProyectoId(int proyecto_id)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Proyecto_id = proyecto_id;
            return obj.MostrarAvancesPorProyecto(obj);
        }

        //Metodo MostrarPorFecha que llama al metodo MostrarPorFecha de la clase AvanceProyectoDao de la capa de DataAccess
        public static DataTable MostrarPorFecha(DateTime fecha_inicio, DateTime fecha_fin)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Fecha_avance = fecha_inicio;
            return obj.MostrarAvancesPorFecha(obj);
        }

        //Metodo para buscar un avance port proyecto_id que entonces seria nombre
        public static DataTable Buscar(string texto)
        {
            AvanceProyectoDao obj = new AvanceProyectoDao();
            obj.Textobuscar = texto;
            return obj.Buscar(obj);
        }
    }
}
