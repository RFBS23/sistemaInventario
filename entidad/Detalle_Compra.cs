﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Detalle_Compra
    {
        public int iddetallecompra { get; set; }
        public Productos oProductos { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public int cantidad { get; set; }
        public decimal montototal { get; set; }
        public string fecharegistro { get; set; }
    }
}
