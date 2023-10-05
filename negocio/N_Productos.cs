using datos;
using entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class N_Productos
    {
        private D_Productos objd_productos = new D_Productos();

        public List<Productos> Listar()
        {
            return objd_productos.Listar();
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
                Mensaje += "Ingrese el nombre del producto \n";
            }
            if (obj.descripcion == "")
            {
                Mensaje += "Ingrese una descripcion";
            }
            if (obj.stock <= 0)
            {
                Mensaje += "Ingrese la cantidad de los productos";
            }
            if (obj.colores == "")
            {
                Mensaje += "Ingrese el color del producto";
            }
            if (obj.precioventa <= 0)
            {
                Mensaje += "El precio del producto debe ser mayor o igual a 0";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objd_productos.Registrar(obj, out Mensaje);
            }
        }

    }
}
