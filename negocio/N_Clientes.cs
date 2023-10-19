using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Clientes
    {
        private D_Clientes objd_clientes = new D_Clientes();

        public List<Clientes> Listar()
        {
            return objd_clientes.Listar();
        }
    }
}
