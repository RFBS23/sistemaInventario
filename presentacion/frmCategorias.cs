using entidad;
using negocio;
using presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            /*obtenemos lista de categorias*/
            List<Categorias> listacat= new N_Categorias().Listar();
            foreach (Categorias item in listacat)
            {
                listarcategoria.Items.Add(new opcionesComboBox() { Valor = item.idcategoria, Texto = item.nombrecategoria });
            }
            listarcategoria.DisplayMember = "Texto";
            listarcategoria.ValueMember = "Valor";
            listarcategoria.SelectedIndex = 0;
            /*fin lista de categorias*/

            /*buscamos las categorias*/
            foreach (DataGridViewColumn columna in dgcategorias.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgtallaprendas.Columns)
            {
                if (columna.Visible == true)
                {
                    txtbusca.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                txtbusca.DisplayMember = "Texto";
                txtbusca.ValueMember = "Valor";
                txtbusca.SelectedIndex = 0;
            }

            /*obtenemos mostramos las categorias y los tipos de tallas*/
            List<Categorias> lista = new N_Categorias().Listar();
            foreach (Categorias item in lista)
            {
                dgcategorias.Rows.Add(new object[] { "", item.idcategoria, item.nombrecategoria });
            }

            List<Tallasropa> listaropa = new N_Tallasropa().Listar();
            foreach (Tallasropa item in listaropa)
            {
                dgtallaprendas.Rows.Add(new object[] { "", item.idtallaropa, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.nombretalla  });
            }
            /*fin mostrar categorias y los tipos de tallas*/
        }

        private void Limpiarc ()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtnombrecatecoria.Text = "";
            txtnombrecatecoria.Select();
        }

        private void dgcategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgcategorias.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgcategorias.Rows[indice].Cells["id"].Value.ToString();
                    txtnombrecatecoria.Text = dgcategorias.Rows[indice].Cells["nombrecategoria"].Value.ToString();
                }
            }
        }

        private void btnguardarc_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categorias objcategoria = new Categorias()
            {
                idcategoria = Convert.ToInt32(txtid.Text),
                nombrecategoria = txtnombrecatecoria.Text
            };
            if (objcategoria.idcategoria == 0)
            {
                int idcategoriagenerado = new N_Categorias().Registrar(objcategoria, out mensaje);

                if (idcategoriagenerado != 0)
                {
                    dgcategorias.Rows.Add(new object[] { "", txtid.Text, txtnombrecatecoria.Text });
                    Limpiarc();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Categorias().Editar(objcategoria, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgcategorias.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["nombrecategoria"].Value = txtnombrecatecoria.Text;
                    Limpiarc();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        /*tallas*/
        private void btnlimpiarc_Click(object sender, EventArgs e)
        {
            Limpiarc();
        }

        private void Limpiartr()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtnombreropa.Text = "";
            txtnombreropa.Select();
        }

        private void btnguardarropa_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Tallasropa objropa = new Tallasropa()
            {
                idtallaropa = Convert.ToInt32(txtid.Text),
                nombretalla = txtnombreropa.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listarcategoria.SelectedItem).Valor) },
            };
            if (objropa.idtallaropa == 0)
            {
                int idtallaropagenerado = new N_Tallasropa().Registrar(objropa, out mensaje);

                if (idtallaropagenerado != 0)
                {
                    dgtallaprendas.Rows.Add(new object[] { "", txtid.Text,
                        ((opcionesComboBox)listarcategoria.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listarcategoria.SelectedItem).Texto.ToString(),
                        txtnombreropa.Text });
                    Limpiartr();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Tallasropa().Editar(objropa, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgtallaprendas.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idtallaropa"].Value = txtid.Text;
                    row.Cells["nombretalla"].Value = txtnombreropa.Text;
                    Limpiartr();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btneliminarropa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTA TALLA?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Tallasropa objropa = new Tallasropa()
                    {
                        idtallaropa = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Tallasropa().Eliminar(objropa, out mensaje);
                    if (respuesta)
                    {
                        dgtallaprendas.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiartr();
            }
        }

        private void dgtallaprendas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgtallaprendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgtallaprendas.Columns[e.ColumnIndex].Name == "btnseleccionarropa")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgtallaprendas.Rows[indice].Cells["idtallaropa"].Value.ToString();
                    foreach (opcionesComboBox ocb in listarcategoria.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgtallaprendas.Rows[indice].Cells["idcategoria"].Value))
                        {
                            int indice_combo = listarcategoria.Items.IndexOf(ocb);
                            listarcategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    txtnombreropa.Text = dgtallaprendas.Rows[indice].Cells["nombretalla"].Value.ToString();
                }
            }
        }

        private void btnlimpiarropa_Click(object sender, EventArgs e)
        {
            Limpiartr();
        }

        private void txtnombrecatecoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string mensaje = string.Empty;

                Categorias objcategoria = new Categorias()
                {
                    idcategoria = Convert.ToInt32(txtid.Text),
                    nombrecategoria = txtnombrecatecoria.Text
                };
                if (objcategoria.idcategoria == 0)
                {
                    int idcategoriagenerado = new N_Categorias().Registrar(objcategoria, out mensaje);

                    if (idcategoriagenerado != 0)
                    {
                        dgcategorias.Rows.Add(new object[] { "", txtid.Text, txtnombrecatecoria.Text });
                        Limpiarc();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    bool resultado = new N_Categorias().Editar(objcategoria, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = dgcategorias.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["id"].Value = txtid.Text;
                        row.Cells["nombrecategoria"].Value = txtnombrecatecoria.Text;
                        Limpiarc();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        private void btneliminarc_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTA CATEGORIA?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categorias objcategoria = new Categorias()
                    {
                        idcategoria = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Categorias().Eliminar(objcategoria, out mensaje);
                    if (respuesta)
                    {
                        dgcategorias.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiarc();
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgcategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgcategorias.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtbuscartalla_TextChanged(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)txtbusca.SelectedItem).Valor.ToString();
            if (dgtallaprendas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgtallaprendas.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscartalla.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

    }
}
