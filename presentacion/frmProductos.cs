using System;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
using entidad;
using Guna.UI2.WinForms;
using negocio;
using presentacion.Utilidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace presentacion
{
    public partial class frmProductos : Form
    {
        public Productos _Productos { get; set; }

        public frmProductos()
        {
            InitializeComponent();

            txtdecuento.TextChanged += txtdecuento_TextChanged;

            txtprecioventa.TextChanged += txtprecioventa_TextChanged;
            txtstock.TextChanged += txtstock_TextChanged;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            LlenarComboBox();
            /**/
            txtstock.Text = "0";
            txtdecuento.Text = "0";
            txttotal.Text = "0.00";
            txtprecioventa.Text = "0.00";
            /**/

            /*categorias*/
            List<Categorias> listaCat = new N_Categorias().Listar();
            foreach (Categorias item in listaCat)
            {
                listacategoria.Items.Add(new opcionesComboBox() { Valor = item.idcategoria, Texto = item.nombrecategoria });
            }
            listacategoria.DisplayMember = "Texto";
            listacategoria.ValueMember = "Valor";
            listacategoria.SelectedIndex = 0;
            

            // tallas ropa
            List<Tallasropa> listaTalla = new N_Tallasropa().Listar();
            foreach (Tallasropa item in listaTalla)
            {
                listatallas.Items.Add(new opcionesComboBox() { Valor = item.idtallaropa, Texto = item.nombretalla });
            }
            listatallas.DisplayMember = "Texto";
            listatallas.ValueMember = "Valor";
            listatallas.SelectedIndex = 0;
            
            
            // btnbuscar
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

            foreach (DataGridViewColumn columna in dgtienda.Columns)
            {
                if (columna.Visible == true)
                {
                    listabucartienda.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listabucartienda.DisplayMember = "Texto";
                listabucartienda.ValueMember = "Valor";
                listabucartienda.SelectedIndex = 0;
            }

            /*lista de productos en la tabla*/
            List<Productos> listaProductos = new N_Productos().Listar();
            foreach (Productos item in listaProductos)
            {
                dgproductos.Rows.Add(new object[] { "", item.idproducto, item.codigo, item.nombre, item.descripcion, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.oTallasropa.idtallaropa, item.oTallasropa.nombretalla, item.colores, item.stock, item.numcaja, item.temporada, item.descuento, item.precioventa, item.total, item.ubicacion, item.fecharegistro });
            }


            List<Productos> lista = new N_Ptienda().Listar();
            foreach (Productos item in lista)
            {
                dgtienda.Rows.Add(new object[] { "", item.idproducto, item.codigo, item.nombre, item.descripcion, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.oTallasropa.idtallaropa, item.oTallasropa.nombretalla, item.colores, item.stock, item.numcaja, item.temporada, item.descuento, item.precioventa, item.total, item.ubicacion, item.fecharegistro });
            }

            rbAlmacen_CheckedChanged(rbAlmacen, EventArgs.Empty);
            if (rbAlmacen.Checked)
            {
                dgproductos.Visible = true;
                btnexcel.Visible = true;
                listbuscarC.Visible = true;
                txtbusqueda.Visible = true;
                btneliminar.Visible = true;
                btnguardar.Visible = true;

                dgtienda.Visible = false;
                btnexceltienda.Visible = false;
                txttienda.Visible = false;
                listabucartienda.Visible = false;
                btnrtienda.Visible = false;
                btndeletetienda.Visible = false;

                Limpiar();

            }
            else if (rbTienda.Checked)
            {
                dgtienda.Visible = true;
                btnexceltienda.Visible = true;
                txttienda.Visible = true;
                listabucartienda.Visible = true;
                btnrtienda.Visible = true;
                btndeletetienda.Visible = true;

                dgproductos.Visible = false;
                btnexcel.Visible = false;
                listbuscarC.Visible = false;
                txtbusqueda.Visible = false;
                btneliminar.Visible = false;
                btnguardar.Visible = false;

                Limpiar();

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

                    foreach (opcionesComboBox otb in listatallas.Items)
                    {
                        if (Convert.ToInt32(otb.Valor) == Convert.ToInt32(dgproductos.Rows[indice].Cells["idtallaropa"].Value))
                        {
                            int indice_combo = listatallas.Items.IndexOf(otb);
                            listatallas.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    txtcolores.Text = dgproductos.Rows[indice].Cells["colores"].Value.ToString();
                    txtstock.Text = dgproductos.Rows[indice].Cells["stock"].Value.ToString();
                    txtnumcaja.Text = dgproductos.Rows[indice].Cells["numcaja"].Value.ToString();
                    cbestaciones.Text = dgproductos.Rows[indice].Cells["temporada"].Value.ToString();
                    txtdecuento.Text = dgproductos.Rows[indice].Cells["descuento"].Value.ToString();
                    txtprecioventa.Text = dgproductos.Rows[indice].Cells["precioventa"].Value.ToString();
                    txttotal.Text = dgproductos.Rows[indice].Cells["total"].Value.ToString();
                    cbubicacion.Text = dgproductos.Rows[indice].Cells["ubicacion"].Value.ToString();
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscarC.SelectedItem).Valor.ToString();
            if (dgproductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            listacategoria.SelectedIndex = 0;
            listatallas.SelectedIndex = 0;
            txtcolores.Text = "";
            txtstock.Text = "0";
            txtnumcaja.Text = "";
            cbestaciones.SelectedIndex = 0;
            cbubicacion.SelectedIndex = 0;
            txtdecuento.Text = "0";
            txttotal.Text = "0.00";
            txtprecioventa.Text = "0.00";

            txtcodigo.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            string mensaje = string.Empty;

            Productos objproductos = new Productos()
            {
                idproducto = Convert.ToInt32(txtid.Text),
                codigo = txtcodigo.Text,
                nombre = txtnombre.Text,
                descripcion = txtdescripcion.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listacategoria.SelectedItem).Valor) },
                oTallasropa = new Tallasropa() { idtallaropa = Convert.ToInt32(((opcionesComboBox)listatallas.SelectedItem).Valor) },
                colores = txtcolores.Text,
                stock = Convert.ToInt32(txtstock.Text),
                numcaja = txtnumcaja.Text,
                temporada = cbestaciones.Text,
                descuento = Convert.ToInt32(txtdecuento.Text),
                precioventa = Convert.ToDecimal(txtprecioventa.Text),
                total = Convert.ToDecimal(txttotal.Text),
                ubicacion = cbubicacion.Text,
                fecharegistro = txtfecha.Text,
            };
            if (objproductos.idproducto == 0)
            {
                int idproductogenerado = new N_Productos().Registrar(objproductos, out mensaje);

                if (idproductogenerado != 0)
                {
                    dgproductos.Rows.Add(new object[] {"", idproductogenerado, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text,
                        ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString(),
                        txtcolores.Text,
                        txtstock.Text,
                        txtnumcaja.Text,
                        cbestaciones.Text,
                        txtdecuento.Text,
                        Convert.ToDecimal(txtprecioventa.Text).ToString("0.00"),
                        txttotal.Text,
                        cbubicacion.Text,
                        txtfecha.Text,
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Productos().Editar(objproductos, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgproductos.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["codigo"].Value = txtcodigo.Text;
                    row.Cells["nombre"].Value = txtnombre.Text;
                    row.Cells["descripcion"].Value = txtdescripcion.Text;
                    row.Cells["idcategoria"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(); 
                    row.Cells["nombrecategoria"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString();
                    row.Cells["idtallaropa"].Value = ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString();
                    row.Cells["nombretalla"].Value = ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString();
                    row.Cells["colores"].Value = txtcolores.Text;
                    row.Cells["stock"].Value = txtstock.Text;
                    row.Cells["numcaja"].Value = txtnumcaja.Text;
                    row.Cells["temporada"].Value = cbestaciones.Text;
                    row.Cells["descuento"].Value = txtdecuento.Text;
                    row.Cells["precioventa"].Value = Convert.ToDecimal(txtprecioventa.Text).ToString("0.00");
                    row.Cells["total"].Value = txttotal.Text;
                    row.Cells["ubicacion"].Value = cbubicacion.Text;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTE PRODUCTO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Productos objproductos = new Productos()
                    {
                        idproducto = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Productos().Eliminar(objproductos, out mensaje);
                    if (respuesta)
                    {
                        dgproductos.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiar();
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscarC.SelectedItem).Valor.ToString();
            if (dgproductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgproductos.Rows.Count < 1)
            {
                MessageBox.Show("NO HE PODIDO ENCONTRAR DATOS PARA PODER EXPORTARLOS", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgproductos.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgproductos.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString(),
                            row.Cells[15].Value.ToString(),
                            row.Cells[16].Value.ToString(),
                            row.Cells[17].Value.ToString(),
                        });
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy"));
                savefile.Filter = "Excel Files | *.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe de productos en stock");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("REPORTE GENERADO EXITOSAMENTE", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        private void dgproductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgproductos.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int stockValue = Convert.ToInt32(e.Value);

                    // Stock mayor a 20
                    if (stockValue >= 20)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(129, 250, 123);
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    // Stock menor o igual a 19
                    else if (stockValue <= 19)
                    {
                        e.CellStyle.BackColor = Color.Salmon;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnumcaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LlenarComboBox()
        {
            // Crear una lista de estaciones del año con nombre y año
            List<string> estaciones = new List<string>
            {
                ObtenerEstacionDelAño("Primavera", DateTime.Now.Year - 1),
                ObtenerEstacionDelAño("Verano", DateTime.Now.Year - 1),
                ObtenerEstacionDelAño("Otoño", DateTime.Now.Year - 1),
                ObtenerEstacionDelAño("Invierno", DateTime.Now.Year - 1) 
                // -1 o +1 es para retroceder o adelantar el año en el que estamos
            };
            // Asignar la lista al ComboBox
            cbestaciones.DataSource = estaciones;
        }

        private string ObtenerEstacionDelAño(string nombreEstacion, int año)
        {
            // Construir la cadena con el nombre y el año
            return $"{nombreEstacion} - {año}";
        }

        private void txtdecuento_TextChanged(object sender, EventArgs e)
        {
            calculardescuento();
        }

        private void calculardescuento()
        {
            if (decimal.TryParse(txtprecioventa.Text, out decimal precioVenta) && decimal.TryParse(txtdecuento.Text, out decimal descuento))
            {
                // Calcular el nuevo precio con descuento
                decimal nuevoPrecio = precioVenta - (precioVenta * descuento / 100);

                // Mostrar el nuevo precio en txtprecioventa
                txtprecioventa.Text = nuevoPrecio.ToString("0.00");
            }
        }

        private void txtprecioventa_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (decimal.TryParse(txtprecioventa.Text, out decimal precioVenta) && int.TryParse(txtstock.Text, out int stock))
            {
                decimal nuevoTotal = precioVenta * stock;

                txttotal.Text = nuevoTotal.ToString("0.00");
            }
        }

        private void rbAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            dgproductos.Visible = true;
            btnexcel.Visible = true;
            listbuscarC.Visible = true;
            txtbusqueda.Visible = true;
            btneliminar.Visible = true;
            btnguardar.Visible = true;

            dgtienda.Visible = false;
            btnexceltienda.Visible = false;
            txttienda.Visible = false;
            listabucartienda.Visible = false;
            btnrtienda.Visible = false;
            btndeletetienda.Visible = false;

            Limpiar();
        }

        private void rbTienda_CheckedChanged(object sender, EventArgs e)
        {
            dgtienda.Visible = true;
            btnexceltienda.Visible = true;
            txttienda.Visible = true;
            listabucartienda.Visible = true;
            btnrtienda.Visible = true;
            btndeletetienda.Visible = true;

            dgproductos.Visible = false;
            btnexcel.Visible = false;
            listbuscarC.Visible = false;
            txtbusqueda.Visible = false;
            btneliminar.Visible = false;
            btnguardar.Visible = false;

            Limpiar();
        }

        private void dgtienda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgtienda.Columns[e.ColumnIndex].Name == "btnselec")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgtienda.Rows[indice].Cells["idprod"].Value.ToString();
                    txtcodigo.Text = dgtienda.Rows[indice].Cells["codigotienda"].Value.ToString();
                    txtnombre.Text = dgtienda.Rows[indice].Cells["nombretienda"].Value.ToString();
                    txtdescripcion.Text = dgtienda.Rows[indice].Cells["desctienda"].Value.ToString();

                    foreach (opcionesComboBox ocb in listacategoria.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgtienda.Rows[indice].Cells["idcat"].Value))
                        {
                            int indice_combo = listacategoria.Items.IndexOf(ocb);
                            listacategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (opcionesComboBox otb in listatallas.Items)
                    {
                        if (Convert.ToInt32(otb.Valor) == Convert.ToInt32(dgtienda.Rows[indice].Cells["idtalla"].Value))
                        {
                            int indice_combo = listatallas.Items.IndexOf(otb);
                            listatallas.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    txtcolores.Text = dgtienda.Rows[indice].Cells["colortienda"].Value.ToString();
                    txtstock.Text = dgtienda.Rows[indice].Cells["stocktienda"].Value.ToString();
                    txtnumcaja.Text = dgtienda.Rows[indice].Cells["numcajatienda"].Value.ToString();
                    cbestaciones.Text = dgtienda.Rows[indice].Cells["temporadatienda"].Value.ToString();
                    txtdecuento.Text = dgtienda.Rows[indice].Cells["descuentotienda"].Value.ToString();
                    txtprecioventa.Text = dgtienda.Rows[indice].Cells["preciotienda"].Value.ToString();
                    txttotal.Text = dgtienda.Rows[indice].Cells["totaltienda"].Value.ToString();
                    cbubicacion.Text = dgtienda.Rows[indice].Cells["ubitienda"].Value.ToString();
                }
            }
        }

        private void dgtienda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgtienda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgtienda.Columns[e.ColumnIndex].Name == "stocktienda")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    int stockValue = Convert.ToInt32(e.Value);

                    // Stock mayor a 20
                    if (stockValue >= 20)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(129, 250, 123);
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    // Stock menor o igual a 19
                    else if (stockValue <= 19)
                    {
                        e.CellStyle.BackColor = Color.Salmon;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnexceltienda_Click(object sender, EventArgs e)
        {
            if (dgtienda.Rows.Count < 1)
            {
                MessageBox.Show("NO HE PODIDO ENCONTRAR DATOS PARA PODER EXPORTARLOS", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dtt = new DataTable();
                foreach (DataGridViewColumn columna in dgtienda.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dtt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgtienda.Rows)
                {
                    if (row.Visible)
                        dtt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString(),
                            row.Cells[15].Value.ToString(),
                            row.Cells[16].Value.ToString(),
                            row.Cells[17].Value.ToString(),
                        });
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProductoTienda_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy"));
                savefile.Filter = "Excel Files | *.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dtt, "Informe de productos en stock");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("REPORTE GENERADO EXITOSAMENTE", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        private void txttienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listabucartienda.SelectedItem).Valor.ToString();
            if (dgtienda.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgtienda.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btndeletetienda_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTE PRODUCTO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Productos objproductos = new Productos()
                    {
                        idproducto = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Productos().Eliminar(objproductos, out mensaje);
                    if (respuesta)
                    {
                        dgtienda.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiar();
            }
        }

        private void btnrtienda_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            string mensaje = string.Empty;

            Productos objproductos = new Productos()
            {
                idproducto = Convert.ToInt32(txtid.Text),
                codigo = txtcodigo.Text,
                nombre = txtnombre.Text,
                descripcion = txtdescripcion.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listacategoria.SelectedItem).Valor) },
                oTallasropa = new Tallasropa() { idtallaropa = Convert.ToInt32(((opcionesComboBox)listatallas.SelectedItem).Valor) },
                colores = txtcolores.Text,
                stock = Convert.ToInt32(txtstock.Text),
                numcaja = txtnumcaja.Text,
                temporada = cbestaciones.Text,
                descuento = Convert.ToInt32(txtdecuento.Text),
                precioventa = Convert.ToDecimal(txtprecioventa.Text),
                total = Convert.ToDecimal(txttotal.Text),
                ubicacion = cbubicacion.Text,
                fecharegistro = txtfecha.Text,
            };
            if (objproductos.idproducto == 0)
            {
                int idproductogenerado = new N_Productos().Registrar(objproductos, out mensaje);

                if (idproductogenerado != 0)
                {
                    dgproductos.Rows.Add(new object[] {"", idproductogenerado, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text,
                        ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString(),
                        txtcolores.Text,
                        txtstock.Text,
                        txtnumcaja.Text,
                        cbestaciones.Text,
                        txtdecuento.Text,
                        Convert.ToDecimal(txtprecioventa.Text).ToString("0.00"),
                        txttotal.Text,
                        cbubicacion.Text,
                        txtfecha.Text,
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Productos().Editar(objproductos, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgtienda.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idprod"].Value = txtid.Text;
                    row.Cells["codigotienda"].Value = txtcodigo.Text;
                    row.Cells["nombretienda"].Value = txtnombre.Text;
                    row.Cells["desctienda"].Value = txtdescripcion.Text;
                    row.Cells["idcat"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString();
                    row.Cells["cattienda"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString();
                    row.Cells["idtalla"].Value = ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString();
                    row.Cells["tallatienda"].Value = ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString();
                    row.Cells["colortienda"].Value = txtcolores.Text;
                    row.Cells["stocktienda"].Value = txtstock.Text;
                    row.Cells["numcajatienda"].Value = txtnumcaja.Text;
                    row.Cells["temporadatienda"].Value = cbestaciones.Text;
                    row.Cells["descuentotienda"].Value = txtdecuento.Text;
                    row.Cells["preciotienda"].Value = Convert.ToDecimal(txtprecioventa.Text).ToString("0.00");
                    row.Cells["totaltienda"].Value = txttotal.Text;
                    row.Cells["ubitienda"].Value = cbubicacion.Text;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}
