using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;

namespace Domain
{
    public class OrdenPagoModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase OrdenPagoDao de la capa de DataAccess
        public static string Insertar(int proyecto_id, int contratista_id, DateTime fecha_emision, decimal monto, string descripcion, string estado, DateTime fecha_creacion, int creado_por)
        {
            OrdenPagoDao obj = new OrdenPagoDao();
            obj.Proyecto_id = proyecto_id;
            obj.Contratista_id = contratista_id;
            obj.Fecha_emision = fecha_emision;
            obj.Monto = monto;
            obj.Descripcion = descripcion;
            obj.Estado = estado;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creada_por = creado_por;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase OrdenPagoDao de la capa de DataAccess
        public static string Editar(int orden_pago_id, int proyecto_id, int contratista_id, DateTime fecha_emision, decimal monto, string descripcion, string estado, DateTime fecha_creacion, int creado_por)
        {
            OrdenPagoDao obj = new OrdenPagoDao();
            obj.Orden_pago_id = orden_pago_id;
            obj.Proyecto_id = proyecto_id;
            obj.Contratista_id = contratista_id;
            obj.Fecha_emision = fecha_emision;
            obj.Monto = monto;
            obj.Descripcion = descripcion;
            obj.Estado = estado;
            obj.Fecha_creacion = fecha_creacion;
            obj.Creada_por = creado_por;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase OrdenPagoDao de la capa de DataAccess
        public static string Eliminar(int orden_pago_id)
        {
            OrdenPagoDao obj = new OrdenPagoDao();
            obj.Orden_pago_id = orden_pago_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase OrdenPagoDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new OrdenPagoDao().Mostrar();
        }

        //Metodo Buscar Nombre que llama al metodo BuscarNombre de la clase OrdenPagoDao de la capa de DataAccess
        public static DataTable BuscarNombre(string texto_buscar)
        {
            OrdenPagoDao obj = new OrdenPagoDao();
            obj.Textobuscar = texto_buscar;
            return obj.Buscar(obj);
        }

        //Metodo MostrarMontoTotal que llama al metodo MostrarMontoTotal de la clase OrdenPagoDao de la capa de DataAccess
        public static DataTable MostrarMontoTotal(int proyecto_id)
        {
            OrdenPagoDao obj = new OrdenPagoDao();
            obj.Proyecto_id = proyecto_id;
            return obj.MostrarMontoTotal(obj);
        }
    }
}
