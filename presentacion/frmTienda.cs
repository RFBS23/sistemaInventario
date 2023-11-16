using DocumentFormat.OpenXml.Spreadsheet;
using entidad;
using Irony.Parsing;
using negocio;
using presentacion.Utilidades;
using presentacion.Utilidades.modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Windows.Media;

namespace presentacion
{
    public partial class frmTienda : Form
    {
        private Usuarios _usuarios;

        public frmTienda(Usuarios oUsuarios = null)
        {
            _usuarios = oUsuarios;

            InitializeComponent();            
        }

        private void frmTienda_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void dgproductostienda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtnumcaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Productos.idproducto.ToString();
                    txtcodigoprod.Text = modal._Productos.codigo;
                    txtnombre.Text = modal._Productos.nombre;
                    txtdescripcion.Text = modal._Productos.descripcion;
                    listacategoria.Text = modal._Productos.oCategorias.nombrecategoria.ToString();
                    listatallas.Text = modal._Productos.oTallasropa.nombretalla.ToString();
                    txtnumcaja.Text = modal._Productos.numcaja;
                    txtcolores.Text = modal._Productos.colores;
                    txtstock.Text = modal._Productos.stock.ToString();
                    txtprecioventa.Text = modal._Productos.precioventa.ToString();
                    txtcantidadprod.Select();
                }
                else
                {
                    txtcodigoprod.Select();
                }
            }
        }

        private void txtcodigoprod_TextChanged(object sender, EventArgs e)
        {
            Productos oProductos = new N_Productos().Listar().Where(p => p.codigo == txtcodigoprod.Text).FirstOrDefault();
            if (oProductos != null)
            {
                txtidproducto.Text = oProductos.idproducto.ToString();
                txtnombre.Text = oProductos.nombre;
                txtdescripcion.Text = oProductos.descripcion;
                listacategoria.Text = oProductos.oCategorias.nombrecategoria.ToString();
                listatallas.Text = oProductos.oTallasropa.nombretalla.ToString();
                txtnumcaja.Text = oProductos.numcaja;
                txtcolores.Text = oProductos.colores;
                txtstock.Text = oProductos.stock.ToString();
                txtprecioventa.Text = oProductos.precioventa.ToString();
                txtcantidadprod.Select();
            }
            else
            {
                txtidproducto.Text = "0";
                txtnombre.Text = "";
                txtdescripcion.Text = "";
                listacategoria.Text = "";
                listatallas.Text = "";
                txtnumcaja.Text = "";
                txtcolores.Text = "";
                txtstock.Text = "";
                txtprecioventa.Text = "";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            decimal cantidad = 0;
            
            if (!decimal.TryParse(txtcantidadprod.Text, out cantidad))
            {
                MessageBox.Show("Cantidad - Formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidadprod.Select();
                return;
            }

            // Buscar el producto en la lista
            foreach (DataGridViewRow fila in dgproductostienda.Rows)
            {
                if (fila.Cells["idproducto"].Value.ToString() == txtidproducto.Text)
                {
                    // Producto encontrado, actualizar la cantidad
                    decimal cantidadExistente = Convert.ToDecimal(fila.Cells["stock"].Value);
                    fila.Cells["stock"].Value = cantidadExistente + cantidad;

                    MessageBox.Show("Cantidad actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarProducto();
                    txtcodigoprod.Select();
                    return;  // Salir de la función ya que encontramos el producto
                }
            }

            // Si el producto no existe, agregar uno nuevo
            dgproductostienda.Rows.Add(new object[] {
                txtidproducto.Text,
                txtcodigoprod.Text,
                txtnombre.Text,
                txtdescripcion.Text,
                listacategoria.Text,
                listatallas.Text,
                txtcolores.Text,
                cantidad.ToString(),
                txtnumcaja.Text,
                txtprecioventa.Text,
                txtfecha.Text,
            });
            MessageBox.Show("Producto agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarProducto();
            txtcodigoprod.Select();
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodigoprod.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            listacategoria.Text = "";
            listatallas.Text = "";
            txtcolores.Text = "";
            txtstock.Text = "0";
            txtnumcaja.Text = "";
            txtprecioventa.Text = "0";
            txtcantidadprod.Value = 1;

            txtcodigoprod.Select();
        }

        private void dgproductostienda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductostienda.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgproductostienda.Rows.RemoveAt(indice);
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (dgproductostienda.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalletienda = new DataTable();
            detalletienda.Columns.Add("idproducto", typeof(int));
            detalletienda.Columns.Add("cantidad", typeof(int));
            detalletienda.Columns.Add("fecharegistro", typeof(DateTime));

            foreach (DataGridViewRow row in dgproductostienda.Rows)
            {
                detalletienda.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt32(row.Cells["idproducto"].Value),
                        Convert.ToInt32(row.Cells["stock"].Value), // Asegúrate de convertir a int
                        DateTime.Parse(row.Cells["fecharegistro"].Value.ToString())
                    }
                );
            }

            //int idcorrelativo = new N_Productostienda().obtenerCorrelativo();

            Productostienda oProductostienda = new Productostienda()
            {
                oUsuarios = new Usuarios() { idusuario = _usuarios.idusuario },
                fecharegistro = fecharegistro.ToString(),
            };

            string mensaje = string.Empty;
            bool respuesta = new N_Productostienda().Registrar(oProductostienda, detalletienda, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Producto Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los controles después de registrar
                txtfecha.Text = "";
                dgproductostienda.Rows.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
