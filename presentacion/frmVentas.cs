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
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            txtpagocon.Text = "0.00";
            txtcambio.Text = "0.00";
            txttotalpagar.Text = "0.00";
            txtdescuento.Text = "0.00";
            /*fin opciones boleta o factura*/

            rbclientes_CheckedChanged(rbclientes, EventArgs.Empty);
            if (rbclientes.Checked)
            {
                btnbuscardoc.Visible = true;
                btnbuscardocproveedor.Visible = false;
                lbldocproveedor.Visible = false;
                lblnomproveedor.Visible = false;

                lbldoccliente.Visible = true;
                lblnomcliente.Visible = true;

                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
            }
            else if (rbProveedores.Checked)
            {
                btnbuscardocproveedor.Visible = true;
                btnbuscardoc.Visible = false;

                lbldocproveedor.Visible = true;
                lblnomproveedor.Visible = true;

                lbldoccliente.Visible = false;
                lblnomcliente.Visible = false;

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
                txtdescuento.Text = oProductos.descuento.ToString();
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
                txtdescuento.Text = "0.00";
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
            if (rbclientes.Checked)
            {
                // Límite de 8 dígitos para clientes
                if (txtdocproveedor.Text.Length >= 8)
                {
                    MessageBox.Show("El límite es de 8 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdocproveedor.Text = txtdocproveedor.Text.Substring(0, 8); // Truncar a 8 dígitos
                }
            }
            else if (rbProveedores.Checked)
            {
                // Límite de 20 dígitos para proveedores
                if (txtdocproveedor.Text.Length >= 11)
                {
                    MessageBox.Show("El límite es de 11 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdocproveedor.Text = txtdocproveedor.Text.Substring(0, 11); // Truncar a 20 dígitos
                }
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
            
            foreach (DataGridViewRow fila in dgproductosventa.Rows)
            {
                if (fila.Cells["idproducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                bool respuesta = new N_Ventas().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidadprod.Value.ToString()));
                if (respuesta)
                {
                    dgproductosventa.Rows.Add(new object[]
                    {
                        txtidproducto.Text,
                        txtdocproveedor.Text,
                        txtnombreproveedor.Text,
                        txtnombre.Text,
                        listatallas.Text,
                        txtcolores.Text,
                        txtprecioventa.Text,  // Asumiendo que ya está en formato correcto o necesitas un formato específico
                        txtdescuento.Text,
                        txtcantidadprod.Value.ToString(),
                        (txtcantidadprod.Value * Convert.ToDecimal(txtprecioventa.Text)).ToString("0.00") // Aquí, hago el cálculo de cantidad * precio
                    });
                    calcularTotal();
                    limpiarProducto();
                    RecalcularTotal();
                    txtcodigoprod.Select();
                }
                
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

        private void RecalcularTotal()
        {
            decimal total = 0;
            if (dgproductosventa.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductosventa.Rows)
                {
                    // Asegúrate de que la celda "subtotal" exista y tenga un valor válido antes de convertirlo.
                    if (row.Cells["subtotal"].Value != null && !string.IsNullOrEmpty(row.Cells["subtotal"].Value.ToString()))
                    {
                        total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                    }
                }
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

            txtcantidadprod.Value = 1;
        }

        private void dgproductosventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductosventa.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new N_Ventas().SumarStock(
                        Convert.ToInt32(dgproductosventa.Rows[index].Cells["idproducto"].Value.ToString()),
                        Convert.ToInt32(dgproductosventa.Rows[index].Cells["stock"].Value.ToString()));
                    dgproductosventa.Rows.RemoveAt(index);
                    RecalcularTotal();
                    limpiarProducto();
                }
            }
        }

        private void dgproductosventa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 10)
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


        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            calcularcambio();
        }

        private void calcularcambio()
        {
            if (txttotalpagar.Text.Trim() == "")
            {
                // MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);
            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "";
            }
            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagocon_TextChanged(object sender, EventArgs e)
        {
            calcularcambio();
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {
            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("idproducto", typeof(int));
            detalle_venta.Columns.Add("precioventa", typeof(decimal));
            detalle_venta.Columns.Add("stock", typeof(int));
            detalle_venta.Columns.Add("subtotal", typeof(decimal));

            foreach (DataGridViewRow row in dgproductosventa.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    row.Cells["idproducto"].Value.ToString(),
                    row.Cells["precioventa"].Value.ToString(),
                    row.Cells["stock"].Value.ToString(),
                    row.Cells["subtotal"].Value.ToString(),
                });
            }

            int idcorrelativo = new N_Ventas().obtenercorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            calcularcambio();
            Ventas oVentas = new Ventas()
            {
                oUsuarios = new Usuarios() { idusuario = _usuarios.idusuario },
                tipodocumento = ((opcionesComboBox)listadocumento.SelectedItem).Texto,
                numerodocumento = numeroDocumento,
                documentocliente = txtdocproveedor.Text,
                nombrecliente = txtnombreproveedor.Text,
                
                montopago = Convert.ToDecimal(txtpagocon.Text),
                montocambio = Convert.ToDecimal(txtcambio.Text),
                montototal = Convert.ToDecimal(txttotalpagar.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new N_Ventas().registrar(oVentas, detalle_venta, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada correctamente: \n" + numeroDocumento + "\n\n ¿Desea Copiar al portapapeles?", "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Clipboard.SetText(text: numeroDocumento);
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
                dgproductosventa.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void btnbuscarprove_Click(object sender, EventArgs e)
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarProducto();
        }

        private void txtdocproveedor_TextChanged(object sender, EventArgs e)
        {
            Proveedor oProveedores = new N_Proveedores().Listar().Where(p => p.documento == txtdocproveedor.Text).FirstOrDefault();
            if (oProveedores != null)
            {
                txtidproducto.Text = oProveedores.idproveedor.ToString();
                txtnombreproveedor.Text = oProveedores.nombreproveedor;
            }
            else
            {
                txtidproducto.Text = "0";
                txtnombreproveedor.Text = "";
            }
        }

        private void rbclientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbclientes.Checked)
            {
                btnbuscardoc.Visible = true;
                btnbuscardocproveedor.Visible = false;
                lbldocproveedor.Visible = false;
                lblnomproveedor.Visible = false;
                lbldoccliente.Visible = true;
                lblnomcliente.Visible = true;

                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
            }
        }

        private void rbProveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProveedores.Checked)
            {
                btnbuscardocproveedor.Visible = true;
                btnbuscardoc.Visible = false;

                lbldocproveedor.Visible = true;
                lblnomproveedor.Visible = true;

                lbldoccliente.Visible = false;
                lblnomcliente.Visible = false;

                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
            }
        }

        private async void btnbuscardoc_Click(object sender, EventArgs e)
        {
            if (txtdocproveedor.Text.Length == 8)
            {
                // URL de la API con el número de DNI
                string apiUrl = $"https://api.apis.net.pe/v1/dni?numero={txtdocproveedor.Text}";

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Realizar la solicitud a la API
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        // Verificar si la solicitud fue exitosa
                        if (response.IsSuccessStatusCode)
                        {
                            // Leer la respuesta como cadena JSON
                            string jsonResponse = await response.Content.ReadAsStringAsync();

                            // Deserializar la respuesta JSON para obtener la información del DNI
                            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                            if (json != null)
                            {
                                // Asignar la información del DNI a los TextBox correspondientes
                                txtidproducto.Text = json.dni;
                                txtnombreproveedor.Text = $"{json.nombres} {json.apellidoPaterno} {json.apellidoMaterno}";
                                // Otros campos si es necesario
                            }
                            else
                            {
                                MessageBox.Show("La respuesta de la API no tiene el formato esperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error en la respuesta de la API: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener la información del DNI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
