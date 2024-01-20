using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Detallestienda
    {
        public int iddetalletienda {  get; set; }
        public Productos oProductos { get; set; }
        public Productostienda oProductostienda { get; set; }
        public int cantidad { get; set; }
        public string fecharegistro { get; set; }
    }
}
