using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Productostienda
    {
        private D_Productotienda objd_productotienda = new D_Productotienda();

        public int obtenerCorrelativo()
        {
            return objd_productotienda.obtenercorrelativo();
        }
                
        public List<Productostienda> Listar()
        {
            return objd_productotienda.Listar();
        }

        public bool Registrar(Productostienda obj, DataTable detalletienda, out string Mensaje)
        {
            return objd_productotienda.Registrar(obj, detalletienda, out Mensaje);
        }

    }
}
