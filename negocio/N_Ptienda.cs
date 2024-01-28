using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Ptienda
    {
        private D_Productotienda objd_producto = new D_Productotienda();

        public List<Productos> Listar()
        {
            return objd_producto.Listar();
        }
    }
}
