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
        public Categorias oCategorias { get; set; }
        public int tallaxs {  get; set; }
        public int tallas { get; set; }
        public int tallam { get; set; }
        public int tallal { get; set; }
        public int tallaxl { get; set; }
        public int tallaxxl { get; set; }
        public int total { get; set; }
        public string colores { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public bool estado { get; set; }
        public string fecharegistro { get; set; }
    }
}
