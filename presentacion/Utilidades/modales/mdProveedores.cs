using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class mdProveedores : Form
    {
        public Proveedor _Proveedor { get; set; }
        public mdProveedores()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mdProveedores_Load(object sender, EventArgs e)
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

            List<Proveedor> listaProveedor = new N_Proveedores().Listar();
            foreach (Proveedor item in listaProveedor)
            {
                dgproveedores.Rows.Add(new object[] { "", item.idproveedor, item.nombreproveedor, item.documento, item.direccion, item.correo, item.telefono });
            }
        }

        private void dgproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (dgproveedores.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                _Proveedor = new Proveedor()
                {
                    idproveedor = Convert.ToInt32(dgproveedores.Rows[iRow].Cells["id"].Value.ToString()),
                    nombreproveedor = dgproveedores.Rows[iRow].Cells["nombreproveedor"].Value.ToString(),
                    documento = dgproveedores.Rows[iRow].Cells["documento"].Value.ToString(),
                    direccion = dgproveedores.Rows[iRow].Cells["direccion"].Value.ToString(),
                    correo = dgproveedores.Rows[iRow].Cells["correo"].Value.ToString(),
                    telefono = dgproveedores.Rows[iRow].Cells["telefono"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Proveedor = new Proveedor()
                {
                    idproveedor = Convert.ToInt32(dgproveedores.Rows[iRow].Cells["id"].Value.ToString()),
                    nombreproveedor = dgproveedores.Rows[iRow].Cells["nombreproveedor"].Value.ToString(),
                    documento = dgproveedores.Rows[iRow].Cells["documento"].Value.ToString(),
                    direccion = dgproveedores.Rows[iRow].Cells["direccion"].Value.ToString(),
                    correo = dgproveedores.Rows[iRow].Cells["correo"].Value.ToString(),
                    telefono = dgproveedores.Rows[iRow].Cells["telefono"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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

        private void guna2GroupBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
