using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Usuarios
    {
        private D_Usuarios objd_usuario = new D_Usuarios();

        public List<Usuarios> Listar()
        {
            return objd_usuario.Listar();
        }

        public int Registrar(Usuarios obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.documento == "")
            {
                Mensaje += "Es necesario el numero de documento \n";
            }
            if (obj.nombreusuario == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario \n";
            }
            if (obj.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            } else
            {
                return objd_usuario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar (Usuarios obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento de identificacion del usuario\n";
            }
            if(obj.nombreusuario == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }
            if(obj.clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            if(Mensaje != string.Empty)
            {
                return false;
            } else
            {
                return objd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuarios obj, out string Mensaje)
        {
            return objd_usuario.Eliminar(obj, out Mensaje);
        }

    }
}
