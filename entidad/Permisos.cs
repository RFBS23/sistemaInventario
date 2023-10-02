using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Permisos
    {
        public int idpermiso {  get; set; }
        public Rol oRol { get; set; }
        public string nombremenu {  get; set; }
        public string fecharegistro { get; set; }
    }
}
