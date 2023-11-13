using DocumentFormat.OpenXml.Spreadsheet;
using entidad;
using Irony.Parsing;
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
    public partial class mdProductos : Form
    {
        public Productos _Productos { get; set; }

        public mdProductos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mdProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgproductosmodal.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            List<Productos> listaProductos = new N_Productos().Listar();
            foreach (Productos item in listaProductos)
            {
                dgproductosmodal.Rows.Add(new object[] { "", item.idproducto, item.codigo, item.nombre, item.descripcion, item.oCategorias.nombrecategoria, item.oTallasropa.nombretalla, item.colores, item.stock, item.numcaja, item.precioventa });
            }
        }

        private void groupboxproductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Productos = new Productos()
                {
                    idproducto = Convert.ToInt32(dgproductosmodal.Rows[iRow].Cells["id"].Value.ToString()),
                    codigo = dgproductosmodal.Rows[iRow].Cells["codigo"].Value.ToString(),
                    nombre = dgproductosmodal.Rows[iRow].Cells["nombre"].Value.ToString(),
                    descripcion = dgproductosmodal.Rows[iRow].Cells["descripcion"].Value.ToString(),
                    oCategorias = new Categorias() { nombrecategoria = dgproductosmodal.Rows[iRow].Cells["nombrecategoria"].Value.ToString() },
                    oTallasropa = new Tallasropa() { nombretalla = dgproductosmodal.Rows[iRow].Cells["nombretalla"].Value.ToString() },
                    numcaja = dgproductosmodal.Rows[iRow].Cells["numcaja"].Value?.ToString(),
                    colores = dgproductosmodal.Rows[iRow].Cells["colores"].Value?.ToString(),
                    stock = Convert.ToInt32(dgproductosmodal.Rows[iRow].Cells["stock"].Value?.ToString()),
                    precioventa = Convert.ToDecimal(dgproductosmodal.Rows[iRow].Cells["precioventa"].Value?.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgproductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgproductosmodal.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductosmodal.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgproductosmodal.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductosmodal.Rows)
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
