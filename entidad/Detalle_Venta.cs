﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidad
{
    public class Detalle_Venta
    {
        public int iddetalleventa {  get; set; }
        public Productos oProductos { get; set;}
        public decimal precioventa { get; set;}
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public string fecharegistro { get; set; }
    }
}
