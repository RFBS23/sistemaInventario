using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Negocio
    {
        private D_Negocios objd_negocio = new D_Negocios();
        public Negocio ObtenerDatos()
        {
            return objd_negocio.ObtnerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombre == "")
            {
                Mensaje += "Es necesario el nombre de la empresa \n";
            }
            if (obj.ruc == "")
            {
                Mensaje += "Es necesario el numero de RUC \n";
            }
            if(obj.direccion == "")
            {
                Mensaje += "Es necesario la direccion de la empresa \n";
            }
            if(Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_negocio.GuardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objd_negocio.obtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objd_negocio.ActualizarLogo(imagen, out mensaje);
        }
    }
}
