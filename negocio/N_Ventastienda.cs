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
    public class N_Ventastienda
    {
        private D_Ventastienda objcd_ventatienda = new D_Ventastienda();

        public int obtenercorrelativo()
        {
            return objcd_ventatienda.obtenercorrelativo();
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_ventatienda.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_ventatienda.SumarStock(idproducto, cantidad);
        }
        
        public bool registrar(Ventas_Tienda obj, DataTable detalleventatienda, out string Mensaje)
        {
            return objcd_ventatienda.registrar(obj, detalleventatienda, out Mensaje);
        }
        /*
        public Ventas_Tienda ObtenerVentas(string numero)
        {
            Ventas_Tienda oVenta = objcd_ventatienda.ObtenerVenta(numero);
            if (oVenta.idventatienda != 0)
            {
                List<Detalle_ventatienda> oDetalleVentas = objcd_ventatienda.ObtenerDetallesVenta(oVenta.idventatienda);
                oVenta.oDetalle_VentaTienda = oDetalleVentas;
            }
            return oVenta;
        }*/
    }
}
