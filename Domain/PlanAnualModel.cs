using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.MySQL;
using System.Data;

namespace Domain
{
    public class PlanAnualModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase PlanAnualDao de la capa de DataAccess
        public static string Insertar(int año,DateTime fecha_creacion, string nombre_plan, string descripcion, int creado_por)
        {
            PlanAnualDao obj = new PlanAnualDao();
            obj.Año = año;
            obj.Nombre_plan = nombre_plan;
            obj.Descripcion = descripcion;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creado_por = creado_por;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase PlanAnualDao de la capa de DataAccess
        public static string Editar(int plan_anual_id, int año, string nombre_plan, string descripcion, DateTime fecha_creacion, int creado_por)
        {
            PlanAnualDao obj = new PlanAnualDao();
            obj.Plan_anual_id = plan_anual_id;
            obj.Año = año;
            obj.Nombre_plan = nombre_plan;
            obj.Descripcion = descripcion;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creado_por = creado_por;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase PlanAnualDao de la capa de DataAccess
        public static string Eliminar(int plan_anual_id)
        {
            PlanAnualDao obj = new PlanAnualDao();
            obj.Plan_anual_id = plan_anual_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase PlanAnualDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new PlanAnualDao().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase PlanAnualDao de la capa de DataAccess
        public static DataTable BuscarNombre(string textobuscar)
        {
            PlanAnualDao obj = new PlanAnualDao();
            obj.Textobuscar = textobuscar;
            return obj.Buscar(obj);
        }

        //Metodo MostrarPlanAnualPorAño que llama al metodo MostrarPlanAnualPorAño de la clase PlanAnualDao de la capa de DataAccess
        public static DataTable MostrarPlanAnualPorAño(int año)
        {
            PlanAnualDao obj = new PlanAnualDao();
            obj.Año = año;
            return obj.MostrarPlanAnualPorAño(obj);
        }
    }
}
