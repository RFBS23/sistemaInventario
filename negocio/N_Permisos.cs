using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Permisos
    {
        private D_Permisos objd_permiso = new D_Permisos();
        public List<Permisos> Listar(int idusuario)
        {
            return objd_permiso.Listar(idusuario);
        }
    }
}
