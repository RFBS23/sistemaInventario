using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Productostienda
    {
        public int idproductotienda {  get; set; }
        public Productos oProductos { get; set; }
        public int cantidad { get; set; }
        public bool estado { get; set; }
        public string fecharegistro { get; set; }
    }
}
