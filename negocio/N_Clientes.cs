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

        public int Registrar(Clientes obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento de identidad \n";
            }
            if (obj.nombres == "")
            {
                Mensaje += "Es necesario el nombre del cliente \n";
            }
            if (obj.apellidos == "")
            {
                Mensaje += "Es necesario el apellido del cliente \n";
            }
            if (obj.correo == "")
            {
                Mensaje += "Es necesario el correo del cliente \n";
            }
            if (obj.telefono == "")
            {
                Mensaje += "Es necesario el contacto del cliente \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_clientes.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Clientes obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.documento == "")
            {
                Mensaje += "Es necesario el documento de identidad \n";
            }
            if (obj.nombres == "")
            {
                Mensaje += "Es necesario el nombre del cliente \n";
            }
            if (obj.apellidos == "")
            {
                Mensaje += "Es necesario el apellido del cliente \n";
            }
            if (obj.correo == "")
            {
                Mensaje += "Es necesario el correo del cliente \n";
            }
            if (obj.telefono == "")
            {
                Mensaje += "Es necesario el contacto del cliente \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_clientes.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Clientes obj, out string Mensaje)
        {
            return objd_clientes.Eliminar(obj, out Mensaje);
        }

    }
}
