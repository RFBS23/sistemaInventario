using entidad;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion.Utilidades.modales
{
    public partial class mdProdTienda : Form
    {
        public Productostienda _Productostienda { get; set; }

        public mdProdTienda()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mdProdTienda_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgverproductostienda.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            List<Productostienda> listaProductostienda = new N_Productostienda().Listar();
            
            foreach (Productostienda item in listaProductostienda)
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
                        "",
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
                    });
                }
            }
            /**/
        }

        private void dgverproductostienda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check1.Width;
                var h = Properties.Resources.check1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check1, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgverproductostienda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0 && dgverproductostienda.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                _Productostienda = new Productostienda()
                {
                    idproductotienda = Convert.ToInt32(dgverproductostienda.Rows[iRow].Cells["idproductotienda"].Value.ToString()),
                    oProductos = new Productos()
                    {
                        codigo = dgverproductostienda.Rows[iRow].Cells["codigo"].Value.ToString(),
                        nombre = dgverproductostienda.Rows[iRow].Cells["nombre"].Value.ToString(),
                        descripcion = dgverproductostienda.Rows[iRow].Cells["descripcion"].Value.ToString(),
                        oCategorias = new Categorias() { nombrecategoria = dgverproductostienda.Rows[iRow].Cells["nombrecategoria"].Value.ToString() },
                        oTallasropa = new Tallasropa() { nombretalla = dgverproductostienda.Rows[iRow].Cells["nombretalla"].Value.ToString() },
                        colores = dgverproductostienda.Rows[iRow].Cells["colores"].Value?.ToString(),
                        stock = Convert.ToInt32(dgverproductostienda.Rows[iRow].Cells["stock"].Value?.ToString()),
                        precioventa = Convert.ToDecimal(dgverproductostienda.Rows[iRow].Cells["precioventa"].Value?.ToString()),
                        descuento = Convert.ToInt32(dgverproductostienda.Rows[iRow].Cells["descuento"].Value?.ToString()),
                    },
                    // Aquí puedes continuar con otras propiedades si las tienes
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgverproductostienda.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgverproductostienda.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void guna2GroupBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgverproductostienda.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgverproductostienda.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
    }
}
