using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;

namespace Domain
{
    public class ContratistaModel
    {
        //Metodo Insertar que llama al metodo Insertar de la clase ContratistaDao de la capa de DataAccess
        public static string Insertar(string nombre_contratista, string contacto, string telefono, string direccion, DateTime fecha_registro)
        {
            ContratistaDao obj = new ContratistaDao();
            obj.Nombre_contratista = nombre_contratista;
            obj.Contacto = contacto;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Fecha_registro = fecha_registro;
            return obj.Insertar(obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase ContratistaDao de la capa de DataAccess
        public static string Editar(int contratista_id, string nombre_contratista, string contacto, string telefono, string direccion, DateTime fecha_registro)
        {
            ContratistaDao obj = new ContratistaDao();
            obj.Contratista_id = contratista_id;
            obj.Nombre_contratista = nombre_contratista;
            obj.Contacto = contacto;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Fecha_registro = fecha_registro;
            return obj.Editar(obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase ContratistaDao de la capa de DataAccess
        public static string Eliminar(int contratista_id)
        {
            ContratistaDao obj = new ContratistaDao();
            obj.Contratista_id = contratista_id;
            return obj.Eliminar(obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase ContratistaDao de la capa de DataAccess
        public static DataTable Mostrar()
        {
            return new ContratistaDao().Mostrar();
        }

        //Metodo Buscar Nombre que llama al metodo BuscarNombre de la clase ContratistaDao de la capa de DataAccess
        public static DataTable BuscarNombre(string texto_buscar)
        {
            ContratistaDao obj = new ContratistaDao();
            obj.Textobuscar = texto_buscar;
            return obj.BuscarNombre(obj);
        }

        //Metodo Buscar Contacto que llama al metodo BuscarContacto de la clase ContratistaDao de la capa de DataAccess
        public static DataTable BuscarContacto(string texto_buscar)
        {
            ContratistaDao obj = new ContratistaDao();
            obj.Textobuscar = texto_buscar;
            return obj.BuscarContacto(obj);
        }
    }
}
