using ClosedXML.Excel;
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
    public partial class frmPTienda : Form
    {
        public frmPTienda()
        {
            InitializeComponent();
        }

        private void frmPTienda_Load(object sender, EventArgs e)
        {
            // btnbuscar
            foreach (DataGridViewColumn columna in dgproductos.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscarC.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }

                listbuscarC.DisplayMember = "Texto";
                listbuscarC.ValueMember = "Valor";
                //listbuscarC.SelectedIndex = 0;
            }

            /*lista de productos en la tabla*/
            List<Productos> lista = new N_Ptienda().Listar();
            foreach (Productos item in lista)
            {
                dgproductos.Rows.Add(new object[] { item.idproducto, item.codigo, item.nombre, item.descripcion, item.oCategorias.idcategoria, item.oCategorias.nombrecategoria, item.oTallasropa.idtallaropa, item.oTallasropa.nombretalla, item.colores, item.stock, item.numcaja, item.temporada, item.descuento, item.precioventa, item.total,  item.fecharegistro });
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
            if (dgproductos.Rows.Count < 1)
            {
                MessageBox.Show("NO HE PODIDO ENCONTRAR DATOS PARA PODER EXPORTARLOS", "VALENT FRANCE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                            row.Cells[14].Value.ToString(),
                            row.Cells[15].Value.ToString(),
                        });
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy"));
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
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }
    }
}
