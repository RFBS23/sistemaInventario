using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Usuarios
    {
        public int idusuario {  get; set; }
        public string documento { get; set; }
        public string nombreusuario { get; set; }
        public string correo { get; set; }
        public string clave {  get; set; }
        public Rol oRol { get; set; }
        public bool estado {  get; set; }
        public string fecharegistro {  get; set; }
    }
}
