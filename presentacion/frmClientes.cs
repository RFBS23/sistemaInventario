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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgclientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    listbuscarCliente.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscarCliente.DisplayMember = "Texto";
                listbuscarCliente.ValueMember = "Valor";
                listbuscarCliente.SelectedIndex = 0;
            }

            //mostrar todos los clientes
            List<Clientes> lista = new N_Clientes().Listar();
            foreach (Clientes item in lista)
            {
                dgclientes.Rows.Add(new object[] { "", item.idcliente, item.documento, item.nombres, item.apellidos, item.correo, item.telefono });
            }
        }

        private void dgclientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgclientes.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgclientes.Rows[indice].Cells["id"].Value.ToString();
                    txtdocumento.Text = dgclientes.Rows[indice].Cells["documento"].Value.ToString();
                    txtnombre.Text = dgclientes.Rows[indice].Cells["nombres"].Value.ToString();
                    txtapellidos.Text = dgclientes.Rows[indice].Cells["apellidos"].Value.ToString();
                    txtcorreo.Text = dgclientes.Rows[indice].Cells["correo"].Value.ToString();
                    txttelefono.Text = dgclientes.Rows[indice].Cells["telefono"].Value.ToString();
                }
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";

            txtdocumento.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Clientes objcliente = new Clientes()
            {
                idcliente = Convert.ToInt32(txtid.Text),
                documento = txtdocumento.Text,
                nombres = txtnombre.Text,
                apellidos = txtapellidos.Text,
                correo = txtcorreo.Text,
                telefono = txttelefono.Text
            };
            if (objcliente.idcliente == 0)
            {
                int idclientegenerado = new N_Clientes().Registrar(objcliente, out mensaje);

                if (idclientegenerado != 0)
                {
                    dgclientes.Rows.Add(new object[] {"", txtid.Text, txtdocumento.Text, txtnombre.Text, txtapellidos.Text, txtcorreo.Text, txttelefono.Text });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Clientes().Editar(objcliente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgclientes.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["documento"].Value = txtdocumento.Text;
                    row.Cells["nombres"].Value = txtnombre.Text;
                    row.Cells["apellidos"].Value = txtapellidos.Text;
                    row.Cells["correo"].Value = txtcorreo.Text;
                    row.Cells["telefono"].Value = txttelefono.Text;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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
                if (MessageBox.Show("¿Esta seguro de eliminar al cliente?", "Valent France", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Clientes obj = new Clientes()
                    {
                        idcliente = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Clientes().Eliminar(obj, out mensaje);
                    if (respuesta)
                    {
                        dgclientes.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Valent France", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscarCliente.SelectedItem).Valor.ToString();
            if (dgclientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgclientes.Rows)
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
            String columnaFiltro = ((opcionesComboBox)listbuscarCliente.SelectedItem).Valor.ToString();
            if (dgclientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgclientes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscarCliente.SelectedItem).Valor.ToString();
            if (dgclientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgclientes.Rows)
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
