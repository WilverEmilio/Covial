using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.MySQL;
using System.Data;

namespace Domain
{
    public class TipoProgramaModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase TipoProgramaDao de la capa de DataAccess
        public static string Insertar(string nombre_tipo)
        {
            TipoProgramaDao obj = new TipoProgramaDao();
            obj.Nombre_tipo = nombre_tipo;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase TipoProgramaDao de la capa de DataAccess
        public static string Editar(int tipo_programa_id, string nombre_tipo)
        {
            TipoProgramaDao obj = new TipoProgramaDao();
            obj.Tipo_programa_id = tipo_programa_id;
            obj.Nombre_tipo = nombre_tipo;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase TipoProgramaDao de la capa de DataAccess
        public static string Eliminar(int tipo_programa_id)
        {
            TipoProgramaDao obj = new TipoProgramaDao();
            obj.Tipo_programa_id = tipo_programa_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase TipoProgramaDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new TipoProgramaDao().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase TipoProgramaDao de la capa de DataAccess
        public static DataTable BuscarNombre(string texto_buscar)
        {
            TipoProgramaDao obj = new TipoProgramaDao();
            obj.Nombre_tipo = texto_buscar;
            return obj.Buscar(obj);
        }
    }
}
