using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Productos
    {
        public int idproducto { get; set; }
        public string rutaimagen { get; set; }
        public string nombreimagen { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Categorias oCategorias { get; set; }
        public Tallasropa oTallasropa { get; set; }
        public int stock { get; set; }
        public string colores { get; set; }
        public decimal precioventa { get; set; }
        public string numcaja { get; set; }
        public string temporada { get; set; }
        public int descuento { get; set; }
        public decimal total {  get; set; }
        public string fecharegistro { get; set; }
    }
}
