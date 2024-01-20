using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmProdtiendas : Form
    {
        public frmProdtiendas()
        {
            InitializeComponent();
        }

        private void frmProdtiendas_Load(object sender, EventArgs e)
        {
            List<Productostienda> listaProductoTienda = new N_Productostienda().Listar();

            foreach (Productostienda item in listaProductoTienda)
            {
                // Buscar si el producto ya existe en el DataGridView
                DataGridViewRow existingRow = dgverproductostienda.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => Convert.ToInt32(r.Cells["idproductotienda"].Value) == item.oProductos.idproducto)
                    .FirstOrDefault();

                if (existingRow != null)
                {
                    // Si el producto ya existe, actualiza la cantidad
                    int existingIndex = existingRow.Index;
                    int newCantidad = Convert.ToInt32(existingRow.Cells["stock"].Value) + item.cantidad;
                    existingRow.Cells["stock"].Value = newCantidad;
                }
                else
                {
                    // Si el producto no existe, agrega una nueva fila
                    dgverproductostienda.Rows.Add(new object[] {
                        item.oProductos.idproducto,
                        item.oProductos.codigo,
                        item.oProductos.nombre,
                        item.oProductos.descripcion,
                        item.oProductos.oCategorias.nombrecategoria,
                        item.oProductos.oTallasropa.nombretalla,
                        item.oProductos.colores,
                        item.cantidad,
                        item.oProductos.precioventa,
                        item.oProductos.descuento,
                        item.fecharegistro,
                    });
                }
            }
        }

        private void dgverproductostienda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 11)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.boton_eliminar.Width;
                var h = Properties.Resources.boton_eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.boton_eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgverproductostienda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
