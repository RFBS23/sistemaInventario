using System;
using entidad;
using negocio;
using presentacion.Utilidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace presentacion
{
    public partial class frmTallas : Form
    {
        public frmTallas()
        {
            InitializeComponent();
        }

        private void frmTallas_Load(object sender, EventArgs e)
        {
            /*obtenemos lista de categorias*/
            List<Categorias> listacat = new N_Categorias().Listar();
            foreach (Categorias item in listacat)
            {
                listacategorias.Items.Add(new opcionesComboBox() { Valor = item.idcategoria, Texto = item.nombrecategoria });
            }
            listacategorias.DisplayMember = "Texto";
            listacategorias.ValueMember = "Valor";
            listacategorias.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgtallaprendas.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            List<Tallasropa> listaropa = new N_Tallasropa().Listar();
            foreach (Tallasropa item in listaropa)
            {
                dgtallaprendas.Rows.Add(new object[] { "", item.idtallaropa, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.nombretalla });
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
            if (dgtallaprendas.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgtallaprendas.Rows[indice].Cells["id"].Value.ToString();
                    foreach (opcionesComboBox ocb in listacategorias.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgtallaprendas.Rows[indice].Cells["idcategoria"].Value))
                        {
                            int indice_combo = listacategorias.Items.IndexOf(ocb);
                            listacategorias.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    txttallas.Text = dgtallaprendas.Rows[indice].Cells["nombretalla"].Value.ToString();
                }
            }
        }

        private void Limpiar ()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            listacategorias.SelectedIndex = 0;
            txttallas.Text = "";

            listacategorias.Select();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Tallasropa objropa = new Tallasropa()
            {
                idtallaropa = Convert.ToInt32(txtid.Text),
                nombretalla = txttallas.Text,
                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(((opcionesComboBox)listacategorias.SelectedItem).Valor) },
            };
            if (objropa.idtallaropa == 0)
            {
                int idtallaropagenerado = new N_Tallasropa().Registrar(objropa, out mensaje);

                if (idtallaropagenerado != 0)
                {
                    dgtallaprendas.Rows.Add(new object[] { "", idtallaropagenerado,
                        ((opcionesComboBox)listacategorias.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listacategorias.SelectedItem).Texto.ToString(),
                        txttallas.Text });
                    Limpiar();
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
                    row.Cells["nombretalla"].Value = txttallas.Text;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la talla?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Tallasropa objtallas = new Tallasropa()
                    {
                        idtallaropa = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new N_Tallasropa().Eliminar(objtallas, out mensaje);

                    if (respuesta)
                    {
                        dgtallaprendas.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgtallaprendas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgtallaprendas.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgtallaprendas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgtallaprendas.Rows)
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
