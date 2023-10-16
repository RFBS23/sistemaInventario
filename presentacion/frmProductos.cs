using ClosedXML.Excel;
using entidad;
using Guna.UI2.WinForms;
using negocio;
using presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private void frmProductos_Load(object sender, EventArgs e)
        {
            /*obtenemos listado*/
            List<Categorias> listaCat = new N_Categorias().Listar();
            foreach (Categorias item in listaCat)
            {
                listacategoria.Items.Add(new opcionesComboBox() { Valor = item.idcategoria, Texto = item.nombrecategoria });
            }
            listacategoria.DisplayMember = "Texto";
            listacategoria.ValueMember = "Valor";
            listacategoria.SelectedIndex = 0;
            /*fin listas*/

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

            /*lista de productos en la tabla*/
            List<Productos> listaProductos = new N_Productos().Listar();
            foreach (Productos item in listaProductos)
            {
                dgproductos.Rows.Add(new object[] { "", item.idproducto, item.codigo, item.nombre, item.descripcion, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.tallaxs, item.tallas, item.tallam, item.tallal, item.tallaxl, item.tallaxxl, item.colores,  item.precioventa});
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

                    txtstockxs.Text = dgproductos.Rows[indice].Cells["tallaxs"].Value.ToString();
                    txtstockS.Text = dgproductos.Rows[indice].Cells["tallas"].Value.ToString();
                    txtstockM.Text = dgproductos.Rows[indice].Cells["tallam"].Value.ToString();
                    txtstockL.Text = dgproductos.Rows[indice].Cells["tallal"].Value.ToString();
                    txtstockXL.Text = dgproductos.Rows[indice].Cells["tallaxl"].Value.ToString();
                    txtstockXXL.Text = dgproductos.Rows[indice].Cells["tallaxxl"].Value.ToString();
                    txtcolores.Text = dgproductos.Rows[indice].Cells["colores"].Value.ToString();
                    txtprecioventa.Text = dgproductos.Rows[indice].Cells["precioventa"].Value.ToString();
                }
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
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
            //txtcodigo.Text = "";
            //txtnombre.Text = "";
            //txtdescripcion.Text = "";
            //listacategoria.SelectedIndex = 0;
            txtstockxs.Text = "0";
            txtstockS.Text = "0";
            txtstockM.Text = "0";
            txtstockL.Text = "0";
            txtstockXL.Text = "0";
            txtstockXXL.Text = "0";
            txtcolores.Text = "";
            txtprecioventa.Text = "0";

            txtcodigo.Select();
        }

        private void LimpiarTodo()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            listacategoria.SelectedIndex = 0;
            txtstockxs.Text = "0";
            txtstockS.Text = "0";
            txtstockM.Text = "0";
            txtstockL.Text = "0";
            txtstockXL.Text = "0";
            txtstockXXL.Text = "0";
            txtcolores.Text = "";
            txtprecioventa.Text = "0";

            txtcodigo.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Productos objproductos = new Productos()
            {
                
                idproducto = Convert.ToInt32(txtid.Text),
                codigo = txtcodigo.Text,
                nombre = txtnombre.Text,
                descripcion = txtdescripcion.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listacategoria.SelectedItem).Valor) },
                tallaxs = Convert.ToInt32(txtstockxs.Text),
                tallas = Convert.ToInt32(txtstockS.Text),
                tallam = Convert.ToInt32(txtstockM.Text),
                tallal = Convert.ToInt32(txtstockL.Text),
                tallaxl = Convert.ToInt32(txtstockXL.Text),
                tallaxxl = Convert.ToInt32(txtstockXXL.Text),
                colores = txtcolores.Text,
                precioventa = Convert.ToDecimal(txtprecioventa.Text),
            };
            if (objproductos.idproducto == 0)
            {
                int idproductogenerado = new N_Productos().Registrar(objproductos, out mensaje);

                if (idproductogenerado != 0)
                {
                    dgproductos.Rows.Add(new object[] {"", txtid.Text, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text,
                        ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString(),
                        txtstockxs.Text,
                        txtstockS.Text,
                        txtstockM.Text,
                        txtstockL.Text,
                        txtstockXL.Text,
                        txtstockXXL.Text,
                        txtcolores.Text,
                        txtprecioventa.Text,
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            } else
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
                    row.Cells["tallaxs"].Value = txtstockxs.Text;
                    row.Cells["tallas"].Value = txtstockS.Text;
                    row.Cells["tallam"].Value = txtstockM.Text;
                    row.Cells["tallal"].Value = txtstockL.Text;
                    row.Cells["tallaxl"].Value = txtstockXL.Text;
                    row.Cells["tallaxxl"].Value = txtstockXXL.Text;
                    row.Cells["colores"].Value = txtcolores.Text;
                    row.Cells["precioventa"].Value = txtprecioventa.Text;

                    LimpiarTodo();
                } else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTE USUARIO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                LimpiarTodo();
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
            if(dgproductos.Rows.Count < 1)
            {
                MessageBox.Show("NO HE PODIDO ENCONTRAR DATOS PARA PODER EXPORTARLOS", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
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
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString(),
                        });
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "ReporteProducto - ValentFrance.xlsx";
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
            }
        }

    }
}
