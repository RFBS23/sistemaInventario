using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Tallas
    {
        private D_Tallas objd_tallas = new D_Tallas();
        public List<Tallas> Listar()
        {
            return objd_tallas.Listar();
        }



    }
}
