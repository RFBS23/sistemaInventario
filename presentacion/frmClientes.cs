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
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Permitir el carácter de control
                return;
            }

            // Verificar si el carácter ingresado no es un dígito o si la longitud es mayor o igual a 9
            if (!char.IsDigit(e.KeyChar) || txttelefono.Text.Length >= 9)
            {
                e.Handled = true; // Ignoramos el carácter.
                return;
            }

            // Asegurarnos de que el primer carácter sea '9'.
            if (txttelefono.Text.Length == 0 && e.KeyChar != '9')
            {
                e.Handled = true; // Ignoramos el carácter.
                MessageBox.Show("El Telefono debe de empezar con 9", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            string email = txtcorreo.Text.Trim();

            // Utiliza una expresión regular para validar el formato del correo electrónico.
            // Aquí se utiliza una expresión regular simple para demostrar el concepto, pero podrías utilizar una expresión más robusta según tus necesidades.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);

            if (!isValid)
            {
                MessageBox.Show("Correo electrónico no válido. Introduce un correo electrónico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcorreo.Focus();
                e.Cancel = true; // Evita que el foco se mueva fuera del TextBox si la validación falla.
            }
        }
    }
}
