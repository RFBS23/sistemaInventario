using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Tallasropa
    {
        private D_Tallasropa objd_tallaropa = new D_Tallasropa();

        public List<Tallasropa> Listar()
        {
            return objd_tallaropa.Listar();
        }

        public int Registrar(Tallasropa obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombretalla == "")
            {
                Mensaje += "Es necesario que ingrese una talla que no se repita \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_tallaropa.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Tallasropa obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombretalla == "")
            {
                Mensaje += "Es necesario que cambie el nombre de la talla \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_tallaropa.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Tallasropa obj, out string Mensaje)
        {
            return objd_tallaropa.Eliminar(obj, out Mensaje);
        }
    }
}
