using entidad;
using negocio;
using presentacion.Utilidades;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        //validaciones de cajas
        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa solo numeros para la cantidad del producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa solo numeros para el precio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //fin de validaciones de cajas

        private void frmProductos_Load(object sender, EventArgs e)
        {
            /*listas de tallas y categorias*/
            List<Categorias> listaCategoria = new N_Categorias().Listar();
            foreach (Categorias item in listaCategoria)
            {
                listacategoria.Items.Add(new opcionesComboBox() { Valor = item.idcategoria, Texto = item.nombrecategoria });
            }
            listacategoria.DisplayMember = "Texto";
            listacategoria.ValueMember = "Valor";
            listacategoria.SelectedIndex = 0;

            List<Tallas> listadoTallas = new N_Tallas().Listar();
            foreach (Tallas item in listadoTallas)
            {
                listatalla.Items.Add(new opcionesComboBox() { Valor = item.idtalla, Texto = item.nombretalla });
            }
            listatalla.DisplayMember = "Texto";
            listatalla.ValueMember = "Valor";
            listatalla.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgproductos.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscarC.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscarC.DisplayMember = "Texto";
                listbuscarC.ValueMember = "Valor";
                listbuscarC.SelectedIndex = 0;
            }
            /*fin lista de tallas y categorias*/

            /*obtenemos mostramos los usuarios*/
            List<Productos> listaProductos = new N_Productos().Listar();
            foreach (Productos item in listaProductos)
            {
                dgproductos.Rows.Add(new object[] { "",item.idproducto, item.nombre, item.descripcion, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.oTallas.idtalla, item.oTallas.nombretalla, item.stock, item.precioventa });
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

        private void dgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductos.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgproductos.Rows[indice].Cells["id"].Value.ToString();
                    txtcodigo.Text = dgproductos.Rows[indice].Cells["codigo"].Value.ToString();
                    txtnombre.Text = dgproductos.Rows[indice].Cells["nombre"].Value.ToString();
                    txtdescripcion.Text = dgproductos.Rows[indice].Cells["descripcion"].Value.ToString();

                    foreach (opcionesComboBox ocb in listacategoria.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgproductos.Rows[indice].Cells["idcategoria"].Value))
                        {
                            int indice_combo = listacategoria.Items.IndexOf(ocb);
                            listacategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (opcionesComboBox ocb in listatalla.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgproductos.Rows[indice].Cells["idtalla"].Value))
                        {
                            int indice_combo = listatalla.Items.IndexOf(ocb);
                            listatalla.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    txtstock.Text = dgproductos.Rows[indice].Cells["stock"].Value.ToString();
                    txtcolores.Text = dgproductos.Rows[indice].Cells["colores"].Value.ToString();
                    txtprecioventa.Text = dgproductos.Rows[indice].Cells["precioventa"].Value.ToString();
                }
            }
        }


    }
}
