using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Proveedor
    {
        public int idproveedor {  get; set; }
        public string documento {  get; set; }
        public string razonsocial { get; set;}
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecharegistro { get; set; }
    }
}
