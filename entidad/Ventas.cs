using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Ventas
    {
        public int idventa {  get; set; }
        public Usuarios oUsuarios { get; set; }
        public string tipodocumento {  get; set; }
        public string numerodocumento { get; set; }
        public string documentocliente { get; set; }
        public string nombrecliente { get; set; }
        public decimal montopago { get; set; }
        public decimal montocambio { get; set; }
        public decimal montototal { get; set; }
        public List<Detalle_Venta> oDetalle_Venta { get; set; }
        public string fecharegistro { get; set; }
    }
}
