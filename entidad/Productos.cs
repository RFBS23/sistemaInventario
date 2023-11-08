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
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string ubiprod { get; set; }
        public Categorias oCategorias { get; set; }
        public Tallasropa oTallasropa { get; set; }
        public int stock { get; set; }
        public string colores { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public string numcaja { get; set; }
        public string devolucion { get; set; }
        public string devoluciontalla { get; set; }
    }
}
