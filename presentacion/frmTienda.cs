using entidad;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmTienda : Form
    {
        public frmTienda()
        {
            InitializeComponent();
        }

        private void frmTienda_Load(object sender, EventArgs e)
        {
            List<Productostienda> listaProductoTienda = new N_Productostienda().Listar();
            foreach (Productostienda item in listaProductoTienda)
            {
                dgproductostienda.Rows.Add(new object[] { 
                    "",
                    item.oProductos.idproducto, 
                    item.oProductos.codigo, 
                    item.oProductos.nombre, 
                    item.oProductos.descripcion, 
                    item.oProductos.oCategorias.nombrecategoria,
                    item.oProductos.oTallasropa.nombretalla,
                    item.oProductos.colores,
                    item.oProductos.stock,
                    item.oProductos.numcaja, 
                    item.oProductos.precioventa 
                });
            }
        }
    }
}
