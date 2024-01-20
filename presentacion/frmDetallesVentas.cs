using entidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetallesVentas : Form
    {

        public frmDetallesVentas()
        {
            InitializeComponent();

        }

        private void frmDetallesVentas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void txtcomprobantepago_TextChanged(object sender, EventArgs e)
        {
            txtcomprobantepago.Text = txtcomprobantepago.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtcomprobantepago.SelectionStart = txtcomprobantepago.Text.Length;
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {
            txtnombreusuario.Text = txtnombreusuario.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombreusuario.SelectionStart = txtnombreusuario.Text.Length;
        }

        private void txtdoccliente_TextChanged(object sender, EventArgs e)
        {
            txtdocproveedor.Text = txtdocproveedor.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtdocproveedor.SelectionStart = txtdocproveedor.Text.Length;
        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {
            txtnombreproveedor.Text = txtnombreproveedor.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombreproveedor.SelectionStart = txtnombreproveedor.Text.Length;
        }

        private void btnbuscarprod_Click(object sender, EventArgs e)
        {
            Ventas oVentas = new N_Ventas().ObtenerVentas(txtbusqueda.Text);
            if (oVentas.idventa != 0)
            {
                txtnumerodocumentoprove.Text = oVentas.numerodocumento;
                txtfecha.Text = oVentas.fecharegistro;
                txtcomprobantepago.Text = oVentas.tipodocumento;
                txtnombreusuario.Text = oVentas.oUsuarios.nombreusuario;

                txtdocproveedor.Text = oVentas.documentocliente;
                txtnombreproveedor.Text = oVentas.nombrecliente;
                dgdetallestienda.Rows.Clear();
                foreach (Detalle_Venta dv in oVentas.oDetalle_Venta)
                {
                    dgdetallestienda.Rows.Add(new object[] {dv.oProductos.nombre + " " + dv.oProductos.descripcion + " " + dv.oProductos.colores + " " + dv.oProductos.oTallasropa , dv.oProductos.descuento, dv.precioventa, dv.cantidad, dv.subtotal} );
                }
                txtmontototal.Text = oVentas.montototal.ToString("0.00");
                txtmontopago.Text = oVentas.montopago.ToString("0.00");
                txtmontocambio.Text = oVentas.montocambio.ToString("0.00");
            }
        }

        private void btnbuscarventacli_Click(object sender, EventArgs e)
        {
            //Ventas_Tienda oVentasTienda = new N_Ventastienda();
        }

        /*botones para proveedores*/
        private void btnticketprov_Click(object sender, EventArgs e)
        {
            if (txtcomprobantepago.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Ticket_Html = Properties.Resources.Tickets.ToString();
            Negocio odatos = new N_Negocio().ObtenerDatos();

            Ticket_Html = Ticket_Html.Replace("@nombrenegocio", odatos.nombre.ToUpper());
            Ticket_Html = Ticket_Html.Replace("@docnegocio", odatos.ruc);
            Ticket_Html = Ticket_Html.Replace("@direcnegocio", odatos.direccion);

            Ticket_Html = Ticket_Html.Replace("@tipodocumento", txtcomprobantepago.Text.ToUpper());
            Ticket_Html = Ticket_Html.Replace("@numerodocumento", txtnumerodocumentoprove.Text.ToUpper());

            Ticket_Html = Ticket_Html.Replace("@docproveedor", txtdocproveedor.Text.ToUpper());
            Ticket_Html = Ticket_Html.Replace("@nombreproveedor", txtnombreproveedor.Text.ToUpper());
            Ticket_Html = Ticket_Html.Replace("@fecharegistro", txtfecha.Text);
            Ticket_Html = Ticket_Html.Replace("@usuarioregistro", txtnombreusuario.Text.ToUpper());

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgdetallestienda.Rows)
            {
                filas += "<tr>";
                filas += "<th>" + row.Cells["nombre"].Value.ToString() + "</th>";
                filas += "<th>" + row.Cells["descuento"].Value.ToString() + "</th>";
                filas += "<th>" + row.Cells["precioventa"].Value.ToString() + "</th>";
                filas += "<th>" + row.Cells["stock"].Value.ToString() + "</th>";
                filas += "<th>" + row.Cells["subtotal"].Value.ToString() + "</th>";
                filas += "</tr>";
            }
            Ticket_Html = Ticket_Html.Replace("@filas", filas);
            Ticket_Html = Ticket_Html.Replace("@montototal", txtmontototal.Text);
            Ticket_Html = Ticket_Html.Replace("@pagocon", txtmontopago.Text);
            Ticket_Html = Ticket_Html.Replace("@cambio", txtmontocambio.Text);
            
            string enlace = "https://rfbs23.github.io/portafolio";

            // URL del servicio web para generar el código QR
            string urlServicioQR = $"https://api.qrserver.com/v1/create-qr-code/?data={enlace}&size=60x60";

            // Asignar la URL del código QR al HTML
            Ticket_Html = Ticket_Html.Replace("@urlCodigoQR", urlServicioQR);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}_Tikets.pdf", txtnumerodocumentoprove.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Ajusta el tamaño del documento PDF (A6 a A7)
                    Document pdfDoc = new Document(PageSize.A7, 5, 5, 5, 5);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    bool obtenido = true;
                    byte[] byteImage = new N_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(30, 30); // Ajusta el tamaño del logo en el PDF
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(41));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Ticket_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abre el archivo PDF con el visor de PDF predeterminado del sistema
                    System.Diagnostics.Process.Start(savefile.FileName);
                }
            }

        }


        private void btnfacturaprov_Click(object sender, EventArgs e)
        {
            if (txtcomprobantepago.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Factura_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new N_Negocio().ObtenerDatos();

            Factura_Html = Factura_Html.Replace("@nombrenegocio", odatos.nombre.ToUpper());
            Factura_Html = Factura_Html.Replace("@docnegocio", odatos.ruc);
            Factura_Html = Factura_Html.Replace("@direcnegocio", odatos.direccion);

            Factura_Html = Factura_Html.Replace("@tipodocumento", txtcomprobantepago.Text.ToUpper());
            Factura_Html = Factura_Html.Replace("@numerodocumento", txtnumerodocumentoprove.Text.ToUpper());

            Factura_Html = Factura_Html.Replace("@docproveedor", txtdocproveedor.Text.ToUpper());
            Factura_Html = Factura_Html.Replace("@nombreproveedor", txtnombreproveedor.Text.ToUpper());
            Factura_Html = Factura_Html.Replace("@fecharegistro", txtfecha.Text);
            Factura_Html = Factura_Html.Replace("@usuarioregistro", txtnombreusuario.Text.ToUpper());

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgdetallestienda.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precioventa"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["stock"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Factura_Html = Factura_Html.Replace("@filas", filas);
            Factura_Html = Factura_Html.Replace("@montototal", txtmontototal.Text);
            Factura_Html = Factura_Html.Replace("@pagocon", txtmontopago.Text);
            Factura_Html = Factura_Html.Replace("@cambio", txtmontocambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}_Facturas.pdf", txtnumerodocumentoprove.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    bool obtenido = true;
                    byte[] byteImage = new N_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Factura_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(savefile.FileName);
                }
            }
        }
                
    }
}
