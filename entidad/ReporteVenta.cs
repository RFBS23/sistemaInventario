using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class ReporteVenta
    {
        public string FechaRegistro {  get; set; }
        public string tipodocumento { get; set; }
        public string numerodocumento { get; set; }
        public string montototal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string documentocliente { get; set; }
        public string nombrecliente { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descuento { get; set; }
        public string Categoria { get; set; }
        public string precioventa { get; set; }
        public string cantidad { get; set; }
        public string subtotal { get; set; }
    }
}
