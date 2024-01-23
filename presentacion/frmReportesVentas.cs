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
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas()
        {
            InitializeComponent();
        }

        private void frmReportesVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgreportesventa.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();
            lista = new N_Reportes().Ventas(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString());
            dgreportesventa.Rows.Clear();
            foreach (ReporteVenta rv in lista)
            {
                dgreportesventa.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.tipodocumento,
                    rv.numerodocumento,
                    rv.UsuarioRegistro,
                    rv.documentocliente,
                    rv.nombrecliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.precioventa,
                    rv.cantidad,
                    rv.subtotal,
                    rv.montototal,
                });
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();

            if (dgreportesventa.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgreportesventa.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dgreportesventa.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgreportesventa.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in dgreportesventa.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe venta");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
