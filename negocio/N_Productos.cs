using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Productos
    {
        private D_Productos objd_producto = new D_Productos();

        public List<Productos> Listar()
        {
            return objd_producto.Listar();
        }

        public int Registrar(Productos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.codigo == "")
            {
                Mensaje += "Es necesario que ingrese el codigo del producto \n";
            }
            if (obj.nombre == "")
            {
                Mensaje += "• Ingrese el nombre del producto \n";
            }
            if (obj.descripcion == "")
            {
                Mensaje += "• Ingrese una descripcion \n";
            }
            if (obj.stock <= 0)
            {
                Mensaje += "• El precio del producto debe ser mayor o igual a 0 \n";
            }
            if (obj.colores == "")
            {
                Mensaje += "• Ingrese el color del producto \n";
            }
            if (obj.numcaja == "")
            {
                Mensaje += "• El numero de caja y/o bolsa esta vacio \n";
            }
            if (obj.precioventa <= 0)
            {
                Mensaje += "• El precio del producto debe ser mayor o igual a 0 \n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            } else
            {
                return objd_producto.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Productos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if(obj.codigo == "")
            {
                Mensaje += "Es necesario que ingrese el codigo del producto \n";
            }
            if (obj.nombre == "")
            {
                Mensaje += "• Ingrese el nombre del producto \n";
            }
            if (obj.descripcion == "")
            {
                Mensaje += "• Ingrese una descripcion \n";
            }
            if (obj.stock == 0)
            {
                Mensaje += "• El precio del producto debe ser mayor o igual a 0 \n";
            }
            if (obj.colores == "")
            {
                Mensaje += "• Ingrese el color del producto \n";
            }
            if (obj.numcaja == "")
            {
                Mensaje += "• El numero de caja y/o bolsa esta vacio \n";
            }
            if (obj.precioventa <= 0)
            {
                Mensaje += "• El precio del producto debe ser mayor o igual a 0 \n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objd_producto.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Productos obj, out string Mensaje)
        {
            return objd_producto.Eliminar(obj, out Mensaje);
        }

    }
}
