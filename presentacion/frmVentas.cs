using entidad;
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
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmVentas : Form
    {
        private Usuarios _usuarios;

        public frmVentas(Usuarios oUsuarios = null)
        {
            _usuarios = oUsuarios;

            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");

            /*opciones boleta o factura*/
            listadocumento.Items.Add(new opcionesComboBox() { Valor = "Boleta", Texto = "Boleta" });
            listadocumento.Items.Add(new opcionesComboBox() { Valor = "Factura", Texto = "Factura" });
            listadocumento.DisplayMember = "Texto";
            listadocumento.ValueMember = "Valor";
            listadocumento.SelectedIndex = 0;
            txtstock.Text = "0";
            txtprecioventa.Text = "0.00";
            
            txtidproducto.Text = "0";
            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0.00";
            /*fin opciones boleta o factura*/

            if (rbclientes.Checked)
            {
                txtdocumento.Visible = true;
                txtnombrecliente.Visible = true;
                lbldoccliente.Visible = true;
                lblnomcliente.Visible = true;
                btnbuscardoc.Visible = true;

                txtdocproveedor.Visible = false;
                txtnombreproveedor.Visible = false;
                lbldocproveedor.Visible = false;
                lblnomproveedor.Visible = false;
                btnbuscardocproveedor.Visible = false;
            } 
            else if (rbproveedores.Checked)
            {
                txtdocproveedor.Visible = true;
                txtnombreproveedor.Visible = true;
                lbldocproveedor.Visible = true;
                lblnomproveedor.Visible = true;
                btnbuscardocproveedor.Visible = true;

                txtdocumento.Visible = false;
                txtnombrecliente.Visible = false;
                lbldoccliente.Visible = false;
                lblnomcliente.Visible = false;
                btnbuscardoc.Visible = false;
            }
        }

        private void btnbuscardoc_Click(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var result = modal.ShowDialog();
                 if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Clientes.idcliente.ToString();
                    txtdocumento.Text = modal._Clientes.documento;
                    txtnombrecliente.Text = modal._Clientes.nombres;

                    txtcodigoprod.Select();
                }
                else
                {
                    txtcodigoprod.Select();
                }
            }
        }

        private void rbclientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbclientes.Checked)
            {
                txtdocumento.Visible = true;
                txtnombrecliente.Visible = true;
                lbldoccliente.Visible = true;
                lblnomcliente.Visible = true;
                btnbuscardoc.Visible = true;

                txtdocproveedor.Visible = false;
                txtnombreproveedor.Visible = false;
                lbldocproveedor.Visible = false;
                lblnomproveedor.Visible = false;
                btnbuscardocproveedor.Visible = false;

                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";

                // Limpiar TextBox de clientes
                txtdocumento.Text = "";
                txtnombrecliente.Text = "";
            }
        }

        private void rbproveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbproveedores.Checked)
            {
                txtdocproveedor.Visible = true;
                txtnombreproveedor.Visible = true;
                lbldocproveedor.Visible = true;
                lblnomproveedor.Visible = true;
                btnbuscardocproveedor.Visible = true;

                txtdocumento.Visible = false;
                txtnombrecliente.Visible = false;
                lbldoccliente.Visible = false;
                lblnomcliente.Visible = false;
                btnbuscardoc.Visible = false;

                txtdocumento.Text = "";
                txtnombrecliente.Text = "";

                // Limpiar TextBox de proveedores
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
            }
        }

        private void btnbuscardocproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedores())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Proveedor.idproveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.documento;
                    txtnombreproveedor.Text = modal._Proveedor.nombreproveedor;
                    txtcodigoprod.Select();
                }
                else
                {
                    txtcodigoprod.Select();
                }
            }
        }

        private void btnbuscarprod_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Productos.idproducto.ToString();
                    txtcodigoprod.Text = modal._Productos.codigo;
                    txtnombre.Text = modal._Productos.nombre;
                    txtstock.Text = modal._Productos.stock.ToString();
                    txtprecioventa.Text = modal._Productos.precioventa.ToString("0.00");
                    listatallas.Text = modal._Productos.oTallasropa.nombretalla.ToString();
                    txtcolores.Text = modal._Productos.colores.ToString();

                    txtcantidadprod.Select();
                }
                else
                {
                    txtcantidadprod.Select();
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
                txtstock.Text = oProductos.stock.ToString();
                txtprecioventa.Text = oProductos.precioventa.ToString();
                listatallas.Text = oProductos.oTallasropa.nombretalla.ToString();
                txtcolores.Text = oProductos.colores.ToString();
                txtcantidadprod.Select();
            }
            else
            {
                txtidproducto.Text = "0";
                txtnombre.Text = "";
                txtstock.Text = "0";
                txtprecioventa.Text = "";
                listatallas.Text = "";
                txtcolores.Text = "";
                txtcantidadprod.Value = 1;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.Text = txtnombre.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombre.SelectionStart = txtnombre.Text.Length;
        }

        private void listatallas_TextChanged(object sender, EventArgs e)
        {
            listatallas.Text = listatallas.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            listatallas.SelectionStart = listatallas.Text.Length;
        }

        private void txtcolores_TextChanged(object sender, EventArgs e)
        {
            txtcolores.Text = txtcolores.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtcolores.SelectionStart = txtcolores.Text.Length;
        }

        private void txtnombreproveedor_TextChanged(object sender, EventArgs e)
        {
            txtnombreproveedor.Text = txtnombreproveedor.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombreproveedor.SelectionStart = txtnombreproveedor.Text.Length;
        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {
            Clientes oClientes = new N_Clientes().Listar().Where(p => p.documento == txtdocumento.Text).FirstOrDefault();
            if (oClientes != null)
            {
                txtidproducto.Text = oClientes.idcliente.ToString();
                txtnombrecliente.Text = oClientes.nombres + " " + oClientes.apellidos;
            }
            else
            {
                txtidproducto.Text = "0";
                txtnombrecliente.Text = "";
            }
        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {
            txtnombrecliente.Text = txtnombrecliente.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombrecliente.SelectionStart = txtnombrecliente.Text.Length;
        }

        private void txtdocproveedor_TextChanged(object sender, EventArgs e)
        {
            Proveedor oProveedor = new N_Proveedores().Listar().Where(p => p.documento == txtdocproveedor.Text).FirstOrDefault();
            if (oProveedor != null)
            {
                txtidproducto.Text = oProveedor.idproveedor.ToString();
                txtnombreproveedor.Text = oProveedor.nombreproveedor;
            }
            else
            {
                txtidproducto.Text = "0";
                txtnombreproveedor.Text = "";
            }
        }

        private void txtdocproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permite el carácter de control
                return;
            }

            // Verificar si el carácter ingresado no es un dígito
            if (!char.IsDigit(e.KeyChar))
            {
                // Si no es un dígito, mostrar un mensaje de alerta y no permitir que se escriba en el TextBox
                MessageBox.Show("Ingresa solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            // Verificar la longitud actual del texto en el TextBox
            if (txtdocproveedor.Text.Length >= 20)
            {
                // Si la longitud es 20 o más, no permitir que se escriba más
                MessageBox.Show("El límite es de 20 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permite el carácter de control
                return;
            }

            // Verificar si el carácter ingresado no es un dígito
            if (!char.IsDigit(e.KeyChar))
            {
                // Si no es un dígito, mostrar un mensaje de alerta y no permitir que se escriba en el TextBox
                MessageBox.Show("Ingresa solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            // Verificar la longitud actual del texto en el TextBox
            if (txtdocumento.Text.Length >= 8)
            {
                // Si la longitud es 20 o más, no permitir que se escriba más
                MessageBox.Show("El límite es de 8 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtcantidadprod.Text, out precio))
            {
                MessageBox.Show("Cantidad - Formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidadprod.Select();
                return;
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidadprod.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            /*
            foreach (DataGridViewRow fila in dgproductosventa.Rows)
            {
                if (fila.Cells["idproducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }*/

            if (!producto_existe)
            {
                string documento = rbclientes.Checked ? txtdocumento.Text : txtdocproveedor.Text;
                string nombre = rbclientes.Checked ? txtnombrecliente.Text : txtnombreproveedor.Text;

                dgproductosventa.Rows.Add(new object[]
                {
                    txtidproducto.Text,
                    documento,
                    nombre,
                    txtnombre.Text,
                    listatallas.Text,
                    txtcolores.Text,
                    txtprecioventa.Text,  // Asumiendo que ya está en formato correcto o necesitas un formato específico
                    txtcantidadprod.Value.ToString(),
                    (txtcantidadprod.Value * Convert.ToDecimal(txtprecioventa.Text)).ToString("0.00") // Aquí, hago el cálculo de cantidad * precio
                });

                calcularTotal();
                limpiarProducto();
                txtcodigoprod.Select();
            }

        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgproductosventa.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductosventa.Rows)
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodigoprod.Text = "";
            txtnombre.Text = "";
            txtprecioventa.Text = "";
            txtstock.Text = "";

            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            txtdocumento.Text = "";
            txtnombrecliente.Text = "";

            txtcantidadprod.Value = 1;
        }

        private void dgproductosventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductosventa.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgproductosventa.Rows.RemoveAt(indice);
                }
            }
        }

        private void dgproductosventa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 9)
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
    }
}
