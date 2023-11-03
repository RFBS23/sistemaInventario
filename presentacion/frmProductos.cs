using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace presentacion
{
    public partial class frmProductos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=FabrizioBS23\SQLEXPRESS;Initial Catalog=sistemainventario;Integrated Security=True");

        byte[] imagenByte;

        public frmProductos()
        {
            InitializeComponent();
        }
        
        private void frmProductos_Load(object sender, EventArgs e)
        {
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

            /*lista de productos en la tabla*/
            List<Productos> listaProductos = new N_Productos().Listar();
            foreach (Productos item in listaProductos)
            {
                dgproductos.Rows.Add(new object[] { "", item.idproducto, item.codigo, item.nombre, item.descripcion, item.ubiprod, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.oTallasropa.idtallaropa, item.oTallasropa.nombretalla, item.colores, item.stock, item.numcaja, item.precioventa, item.devolucion, item.devoluciontalla });
            }

            //ListarCategorias();
        }

        /*
        private void ListarCategorias()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select idcategoria, nombrecategoria from categorias", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["nombrecategoria"] = "Selecciona una categoria";
            dt.Rows.InsertAt(fila, 0);
            listacategoria.ValueMember = "idcategoria";
            listacategoria.DisplayMember = "nombrecategoria";
            listacategoria.DataSource = dt;
        }
        
        private void listarTalla(string idcategoria)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select idtallaropa, nombretalla from tallasropa where idcategoria = @idcategoria", con);
            cmd.Parameters.AddWithValue("idcategoria", idcategoria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow dr = dt.NewRow();
            dr["nombretalla"] = "Selecciona una talla";
            dt.Rows.InsertAt(dr, 0);

            listatallas.ValueMember = "idtallaropa";
            listatallas.DisplayMember = "nombretalla";
            listatallas.DataSource = dt;
        }
        */
        private void listacategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(listacategoria.SelectedIndex.ToString() != null)
            {
                string idcategoria = listacategoria.SelectedValue.ToString();
                listarTalla(idcategoria);
            }*/
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
                    txtubicacion.Text = dgproductos.Rows[indice].Cells["ubiprod"].Value.ToString();
                    
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
                    txtprecioventa.Text = dgproductos.Rows[indice].Cells["precioventa"].Value.ToString();
                    txtdevolucion.Text = dgproductos.Rows[indice].Cells["devolucion"].Value.ToString();
                    txtdevoluciontalla.Text = dgproductos.Rows[indice].Cells["devoluciontalla"].Value.ToString();
                }
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
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtubicacion.SelectedIndex = 0;
            listacategoria.SelectedIndex = 0;
            listatallas.SelectedIndex = 0;
            txtcolores.Text = "";
            txtstock.Text = "0";
            txtnumcaja.Text = "";
            txtprecioventa.Text = "0";
            txtdevolucion.SelectedIndex = 0;
            txtdevoluciontalla.SelectedIndex = 0;

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
                ubiprod = txtubicacion.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listacategoria.SelectedItem).Valor) },
                oTallasropa = new Tallasropa() { idtallaropa = Convert.ToInt32(((opcionesComboBox)listatallas.SelectedItem).Valor) },
                colores = txtcolores.Text,
                stock = Convert.ToInt32(txtstock.Text),
                numcaja = txtnumcaja.Text,
                precioventa = Convert.ToDecimal(txtprecioventa.Text),
                devolucion = txtdevolucion.Text,
                devoluciontalla = txtdevoluciontalla.Text,
            };
            if (objproductos.idproducto == 0)
            {
                int idproductogenerado = new N_Productos().Registrar(objproductos, out mensaje);

                if (idproductogenerado != 0)
                {
                    dgproductos.Rows.Add(new object[] {"", txtid.Text, txtcodigo.Text, txtnombre.Text, txtdescripcion.Text, txtubicacion.Text,
                        ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString(),
                        txtcolores.Text,
                        txtstock.Text,
                        txtnumcaja.Text,
                        txtprecioventa.Text,
                        txtdevolucion.Text,
                        txtdevoluciontalla.Text
                    });
                    Limpiar();
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                    notifyIcon1.Text = "Valent France";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Valent France";
                    notifyIcon1.BalloonTipText = "Nuevo Producto Agregado";
                    notifyIcon1.ShowBalloonTip(1000);
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
                    row.Cells["ubiprod"].Value = txtubicacion.Text;
                    row.Cells["idcategoria"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Valor.ToString(); 
                    row.Cells["nombrecategoria"].Value = ((opcionesComboBox)listacategoria.SelectedItem).Texto.ToString();
                    row.Cells["idtallaropa"].Value = ((opcionesComboBox)listatallas.SelectedItem).Valor.ToString();
                    row.Cells["nombretalla"].Value = ((opcionesComboBox)listatallas.SelectedItem).Texto.ToString();
                    row.Cells["colores"].Value = txtcolores.Text;
                    row.Cells["stock"].Value = txtstock.Text;
                    row.Cells["numcaja"].Value = txtnumcaja.Text;
                    row.Cells["precioventa"].Value = txtprecioventa.Text;
                    row.Cells["devolucion"].Value = txtdevolucion.Text;
                    row.Cells["devoluciontalla"].Value = txtdevoluciontalla.Text;

                    Limpiar();
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                    notifyIcon1.Text = "Valent France";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Valent France";
                    notifyIcon1.BalloonTipText = "El Producto: " + txtnombre.Text + "Fue Editado Correctamente";
                    notifyIcon1.ShowBalloonTip(1000);
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
                        notifyIcon1.Icon = new Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                        notifyIcon1.Text = "Valent France";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = "Valent France";
                        notifyIcon1.BalloonTipText = "El Producto: " + txtnombre.Text + " Fue Eliminado Correctamente";
                        notifyIcon1.ShowBalloonTip(1000);
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
                            row.Cells[5].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString() + "  |  " + row.Cells[15].Value.ToString()
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
                        
                        //notificacion
                        notifyIcon1.Icon = new Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                        notifyIcon1.Text = "Valent France";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = "Valent France";
                        notifyIcon1.BalloonTipText = "Valent France: Se ha generado un nuevo reporte";
                        notifyIcon1.ShowBalloonTip(1000);
                    }
                    catch
                    {
                        //notificacion
                        notifyIcon1.Icon = new Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                        notifyIcon1.Text = "Valent France";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = "Valent France";
                        notifyIcon1.BalloonTipText = "Valent France: No se ha podido generar un reporte";
                        notifyIcon1.ShowBalloonTip(1000);

                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                    }
                }
            }
        }

        private void dgproductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgproductos.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock mayor a 20
                        if (Convert.ToInt32(e.Value) >= 20)
                        {
                            e.CellStyle.BackColor = Color.FromArgb(129,250,123) ;
                            e.CellStyle.ForeColor = Color.Black;
                        }
                        //Stock menor a 19
                        if (Convert.ToInt32(e.Value) <= 19)
                        {
                            e.CellStyle.BackColor = Color.Salmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }

            //juntar celdas
            if (e.ColumnIndex == dgproductos.Columns["detalledevolucion"].Index && e.RowIndex >= 0)
            {
                string txtdevolucion = dgproductos["devolucion", e.RowIndex].Value as string;
                string txtdevoluciontalla = dgproductos["devoluciontalla", e.RowIndex].Value as string;
                
                if (txtdevolucion != null && txtdevoluciontalla != null)
                {
                    e.Value = txtdevolucion + " " + txtdevoluciontalla;
                    e.FormattingApplied = true;
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

        private void btnsubirimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Title = "Seleccionar imagen";
            foto.FileName = "Files|*.jpg;*.jpeg;*.png";
            DialogResult result = foto.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtimagen.Image = Image.FromFile(foto.FileName);
                MemoryStream memoria = new MemoryStream();
                txtimagen.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoria.ToArray();
            }
        }
    }
}
