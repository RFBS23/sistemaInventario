using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Reportes
    {
        private D_Reportes objd_reporte = new D_Reportes();

        public List<ReporteVenta> Ventas(string fechainicio, string fechafin)
        {
            return objd_reporte.Ventas(fechainicio, fechafin);
        }
    }
}
