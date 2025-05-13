using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;

namespace Domain
{
    public class ProgramaModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase ProgramaDao de la capa de DataAccess
        public static string Insertar(int plan_anual_id, int tipo_programa_id, string nombre_programa, string descripcion, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, DateTime fecha_creacion)
        {
            ProgramaDao obj = new ProgramaDao();
            obj.Plan_anual_id = plan_anual_id;
            obj.Tipo_programa_id = tipo_programa_id;
            obj.Nombre_programa = nombre_programa;
            obj.Descripcion = descripcion;
            obj.Fecha_inicio_prevista = fecha_inicio_prevista;
            obj.Fecha_fin_prevista = fecha_fin_prevista;
            obj.Fecha_creacion = fecha_creacion;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase ProgramaDao de la capa de DataAccess
        public static string Editar(int programa_id, int plan_anual_id, int tipo_programa_id, string nombre_programa, string descripcion, DateTime fecha_inicio_prevista, DateTime fecha_fin_prevista, DateTime fecha_creacion)
        {
            ProgramaDao obj = new ProgramaDao();
            obj.Programa_id = programa_id;
            obj.Plan_anual_id = plan_anual_id;
            obj.Tipo_programa_id = tipo_programa_id;
            obj.Nombre_programa = nombre_programa;
            obj.Descripcion = descripcion;
            obj.Fecha_inicio_prevista = fecha_inicio_prevista;
            obj.Fecha_fin_prevista = fecha_fin_prevista;
            obj.Fecha_creacion = fecha_creacion;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase ProgramaDao de la capa de DataAccess
        public static string Eliminar(int programa_id)
        {
            ProgramaDao obj = new ProgramaDao();
            obj.Programa_id = programa_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase ProgramaDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new ProgramaDao().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase ProgramaDao de la capa de DataAccess
        public static DataTable BuscarNombre(string texto_buscar)
        {
            ProgramaDao obj = new ProgramaDao();
            obj.Nombre_programa = texto_buscar;
            return obj.BuscarNombre(obj);
        }

        //Metodo BuscarFechas que llama al metodo BuscarFechas de la clase ProgramaDao de la capa de DataAccess
        public static DataTable BuscarFechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            ProgramaDao obj = new ProgramaDao();
            obj.Fecha_inicio_prevista = fecha_inicio;
            obj.Fecha_fin_prevista = fecha_fin;
            return obj.BuscarFechas(obj);
        }
    }
}
