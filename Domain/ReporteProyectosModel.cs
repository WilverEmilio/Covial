using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.MySQL;

namespace Domain
{
    public class ReporteProyectosModel
    {
        //Metodo para insertar un nuevo Reporte
        public static string Insertar(DateTime fecha_generacion, int generaro_por, string contenido_reporte)
        {
            ReportesProyectosDao obj = new ReportesProyectosDao();
            obj.Fecha_generacion = fecha_generacion;
            obj.Generado_por = generaro_por;
            obj.Contenido_reporte = contenido_reporte;
            return obj.Insertar(obj);
        }
    }
}

