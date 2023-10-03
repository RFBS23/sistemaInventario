using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Categorias
    {
        private D_Categorias objd_categoria = new D_Categorias();

        public List<Categorias> Listar()
        {
            return objd_categoria.Listar();
        }

        public int Registrar(Categorias obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombrecategoria == "")
            {
                Mensaje += "Es necesario que ingrese un nombre a la categoria bro \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_categoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Categorias obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombrecategoria == "")
            {
                Mensaje += "Es necesario que cambie la descripcion de la categoria \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categorias obj, out string Mensaje)
        {
            return objd_categoria.Eliminar(obj, out Mensaje);
        }
    }
}
