using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Compras
    {
        public int idcompra {  get; set; }
        public Usuarios oUsuarios { get; set; }
        public Proveedor oProveedor { get; set; }
        public string tipodocumento { get; set; }
        public string numerodocumento { get; set; }
        public decimal montototal { get; set; }
        public List<Detalle_Compra> oDetalle_Compra { get; set; }
        public string fecharegistro { get; set; }
    }
}
