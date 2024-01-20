using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Ventas_Tienda
    {
        public int idventatienda { get; set; }
        public Usuarios oUsuarios { get; set; }
        public string tipodocumento { get; set; }
        public string numerodocumento { get; set; }
        public string documentocliente { get; set; }
        public string nombrecliente { get; set; }
        public decimal montopago { get; set; }
        public decimal montocambio { get; set; }
        public decimal montototal { get; set; }
        public List<Detalle_ventatienda> oDetalle_VentaTienda { get; set; }
        public string fecharegistro { get; set; }
    }
}
