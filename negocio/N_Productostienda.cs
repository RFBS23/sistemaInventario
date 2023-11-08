using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Productostienda
    {
        private D_Productotienda objd_productotienda = new D_Productotienda();

        public List<Productostienda> Listar()
        {
            return objd_productotienda.Listar();
        }
    }
}
