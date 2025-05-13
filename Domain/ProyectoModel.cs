using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;

namespace Domain
{
    public class ProyectoModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase ProyectoDao de la capa de DataAccess
        public static string Insertar(int programa_id, int contratista_id, string nombre_proyecto, string descripcion, string ubicacion, decimal cantidad_estimada, decimal costo_unitario_estimado, decimal presupuesto_estimado, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, string estado, DateTime fecha_creacion, int creado_por)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Programa_id = programa_id;
            obj.Contratista_id = contratista_id;
            obj.Nombre_proyecto = nombre_proyecto;
            obj.Descripcion = descripcion;
            obj.Ubicacion = ubicacion;
            obj.Cantidad_estimada = cantidad_estimada;
            obj.Costo_unitario_estimado = costo_unitario_estimado;
            obj.Presupuesto_estimado = presupuesto_estimado;
            obj.Fecha_inicio_prevista = fecha_inicio_prevista;
            obj.Fecha_fin_prevista = fecha_fin_prevista;
            obj.Estado = estado;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creado_por = creado_por;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase ProyectoDao de la capa de DataAccess
        public static string Editar(int proyecto_id, int programa_id, int contratista_id, string nombre_proyecto, string descripcion, string ubicacion, decimal cantidad_estimada, decimal costo_unitario_estimado, decimal presupuesto_estimado, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, string estado, DateTime fecha_creacion, int creado_por)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Proyecto_id = proyecto_id;
            obj.Programa_id = programa_id;
            obj.Contratista_id = contratista_id;
            obj.Nombre_proyecto = nombre_proyecto;
            obj.Descripcion = descripcion;
            obj.Ubicacion = ubicacion;
            obj.Cantidad_estimada = cantidad_estimada;
            obj.Costo_unitario_estimado = costo_unitario_estimado;
            obj.Presupuesto_estimado = presupuesto_estimado;
            obj.Fecha_inicio_prevista = fecha_inicio_prevista;
            obj.Fecha_fin_prevista = fecha_fin_prevista;
            obj.Estado = estado;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creado_por = creado_por;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase ProyectoDao de la capa de DataAccess
        public static string Eliminar(int proyecto_id)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Proyecto_id = proyecto_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase ProyectoDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new ProyectoDao().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase ProyectoDao de la capa de DataAccess
        public static DataTable BuscarNombre(string texto_buscar)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Nombre_proyecto = texto_buscar;
            return obj.BuscarNombre(obj);
        }

        //Metodo BuscarFecha que llama al metodo BuscarFecha de la clase ProyectoDao de la capa de DataAccess
        public static DataTable BuscarFecha(DateTime fecha_inicio, DateTime fecha_fin)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Fecha_inicio_prevista = fecha_inicio;
            obj.Fecha_fin_prevista = fecha_fin;
            return obj.BuscarFecha(obj);
        }

        //Metodo MostrarPorPrograma que llama al metodo MostrarPorPrograma de la clase ProyectoDao de la capa de DataAccess
        public static DataTable MostrarPorPrograma(int programa_id)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Programa_id = programa_id;
            return obj.MostrarPorPrograma(obj);
        }

        //Metodo MostrarPorContratista que llama al metodo MostrarPorContratista de la clase ProyectoDao de la capa de DataAccess
        public static DataTable MostrarPorContratista(int contratista_id)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Contratista_id = contratista_id;
            return obj.MostrarPorContratista(obj);
        }

        //Metodo MostrarPorEstado que llama al metodo MostrarPorEstado de la clase ProyectoDao de la capa de DataAccess
        public static DataTable MostrarPorEstado(string estado)
        {
            ProyectoDao obj = new ProyectoDao();
            obj.Estado = estado;
            return obj.MostrarPorEstado(obj);
        }
    }
}
