using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Ventas
    {
        private D_Ventas objcd_venta = new D_Ventas();

        public int obtenercorrelativo()
        {
            return objcd_venta.obtenercorrelativo();
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }

        public bool registrar(Ventas obj, DataTable detalleventa, out string Mensaje)
        {
            return objcd_venta.registrar(obj, detalleventa, out Mensaje);
        }

        public Ventas ObtenerVentas(string numero)
        {
            Ventas oVenta = objcd_venta.ObtenerVenta(numero);
            if (oVenta.idventa != 0)
            {
                List<Detalle_Venta> oDetalleVentas = objcd_venta.ObtenerDetallesVenta(oVenta.idventa);
                oVenta.oDetalle_Venta = oDetalleVentas;
            }
            return oVenta;
        }
    }
}
