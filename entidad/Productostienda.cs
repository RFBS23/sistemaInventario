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
        public Usuarios oUsuarios { get; set; }
        public int cantidad { get; set; }
        public List<Detallestienda> oDetallestienda { get; set; }
        public string fecharegistro { get; set; }
    }
}
