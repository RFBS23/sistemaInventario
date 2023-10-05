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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {

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

            /*obtenemos mostramos los categorias*/
            List<Categorias> lista = new N_Categorias().Listar();
            foreach (Categorias item in lista)
            {
                dgcategorias.Rows.Add(new object[] { "", item.idcategoria, item.nombrecategoria, item.fecharegistro });
            }
            /*fin mostrar categorias*/
        }

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtnombrecatecoria.Text = "";
            txtnombrecatecoria.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
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
                    dgcategorias.Rows.Add(new object[] {"", txtid.Text, txtnombrecatecoria.Text});
                    Limpiar();
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
                Limpiar();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
    }
}
