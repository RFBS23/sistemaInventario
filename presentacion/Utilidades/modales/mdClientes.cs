using DocumentFormat.OpenXml.Wordprocessing;
using entidad;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion.Utilidades.modales
{
    public partial class mdClientes : Form
    {
        public Clientes _Clientes { get; set; }
        public mdClientes()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void gbmdclientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mdClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgclientes.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            //mostrar todos los clientes
            List<Clientes> lista = new N_Clientes().Listar();
            foreach (Clientes item in lista)
            {
                string nombreCompleto = $"{item.nombres} {item.apellidos}";
                dgclientes.Rows.Add(new object[] { "", item.idcliente, item.documento, nombreCompleto,  item.correo, item.telefono });
            }
        }

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evita que se procesen los encabezados

            int iRow = e.RowIndex;
            if (dgclientes.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                try
                {
                    _Clientes = new Clientes()
                    {
                        idcliente = Convert.ToInt32(dgclientes.Rows[iRow].Cells["id"].Value?.ToString()),
                        documento = dgclientes.Rows[iRow].Cells["documento"].Value?.ToString(),
                        nombres = dgclientes.Rows[iRow].Cells["nombres"].Value?.ToString(),
                        apellidos = dgclientes.Rows[iRow].Cells["apellidos"].Value?.ToString(),
                        correo = dgclientes.Rows[iRow].Cells["correo"].Value?.ToString(),
                        telefono = dgclientes.Rows[iRow].Cells["telefono"].Value?.ToString(),
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evita que se procesen los encabezados

            int iRow = e.RowIndex;
            try
            {
                _Clientes = new Clientes()
                {
                    idcliente = Convert.ToInt32(dgclientes.Rows[iRow].Cells["id"].Value?.ToString()),
                    documento = dgclientes.Rows[iRow].Cells["documento"].Value?.ToString(),
                    nombres = dgclientes.Rows[iRow].Cells["nombres"].Value?.ToString(),
                    apellidos = dgclientes.Rows[iRow].Cells["apellidos"].Value?.ToString(),
                    correo = dgclientes.Rows[iRow].Cells["correo"].Value?.ToString(),
                    telefono = dgclientes.Rows[iRow].Cells["telefono"].Value?.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
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
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
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
