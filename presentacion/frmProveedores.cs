using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgproveedores.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            /*lista de productos en la tabla*/
            List<Proveedor> listaProveedor = new N_Proveedores().Listar();
            foreach (Proveedor item in listaProveedor)
            {
                dgproveedores.Rows.Add(new object[] { "", item.idproveedor, item.nombreproveedor, item.documento, item.direccion, item.correo, item.telefono });
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

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            // nos aseguramos que el munero y la cantidad del texto sea menor o igual a 9.
            if (!char.IsDigit(e.KeyChar) || txttelefono.Text.Length >= 9)
            {
                e.Handled = true; // Ignoramos el carácter.
            }

            // Aseguramos de que el primer carácter sea '9'.
            if (txttelefono.Text.Length == 0 && e.KeyChar != '9')
            {
                e.Handled = true; // Ignoramos el carácter.
                MessageBox.Show("El Telefono debe de empezar con 9", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgproveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproveedores.Rows)
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
            if (dgproveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgproveedores.Rows)
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
            txtnombreprov.Text = "";
            txtdocumento.Text = "";
            txtrazonsocial.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";

            txtdocumento.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor objproveedor = new Proveedor()
            {
                idproveedor = Convert.ToInt32(txtid.Text),
                nombreproveedor = txtnombreprov.Text,
                documento = txtdocumento.Text,
                direccion = txtrazonsocial.Text,
                correo = txtcorreo.Text,
                telefono = txttelefono.Text,
            };
            if (objproveedor.idproveedor == 0)
            {
                int idprovedorgenerado = new N_Proveedores().Registrar(objproveedor, out mensaje);

                if (idprovedorgenerado != 0)
                {
                    dgproveedores.Rows.Add(new object[] {"", idprovedorgenerado,txtnombreprov.Text, txtdocumento.Text, txtrazonsocial.Text, txtcorreo.Text, txttelefono.Text });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new N_Proveedores().Editar(objproveedor, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgproveedores.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["nombreproveedor"].Value = txtnombreprov.Text;
                    row.Cells["documento"].Value = txtdocumento.Text;
                    row.Cells["direccion"].Value = txtrazonsocial.Text;
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

        private void dgproveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproveedores.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgproveedores.Rows[indice].Cells["id"].Value.ToString();
                    txtnombreprov.Text = dgproveedores.Rows[indice].Cells["nombreproveedor"].Value.ToString();
                    txtdocumento.Text = dgproveedores.Rows[indice].Cells["documento"].Value.ToString();
                    txtrazonsocial.Text = dgproveedores.Rows[indice].Cells["direccion"].Value.ToString();
                    txtcorreo.Text = dgproveedores.Rows[indice].Cells["correo"].Value.ToString();
                    txttelefono.Text = dgproveedores.Rows[indice].Cells["telefono"].Value.ToString();
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTE PROVEEDOR?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor objproveedor = new Proveedor()
                    {
                        idproveedor = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Proveedores().Eliminar(objproveedor, out mensaje);
                    if (respuesta)
                    {
                        dgproveedores.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiar();
            }
        }
    }
}
