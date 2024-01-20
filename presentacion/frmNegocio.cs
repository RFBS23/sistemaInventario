using entidad;
using negocio;
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
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return new Bitmap(image); // Para asegurar que el nuevo objeto Bitmap no está ligado al MemoryStream original
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine("Error al convertir bytes a imagen: " + ex.Message);
                return null;
            }
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new N_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                piclogo.Image = ByteToImage(byteimage);

                Negocio datos = new N_Negocio().ObtenerDatos();
                txtnombreempresa.Text = datos.nombre;
                txtruc.Text = datos.ruc;
                txtdireccionempresa.Text = datos.direccion;
        }

        private void txtnombreempresa_TextChanged(object sender, EventArgs e)
        {
            txtnombreempresa.Text = txtnombreempresa.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombreempresa.SelectionStart = txtnombreempresa.Text.Length;
        }

        private void txtdireccionempresa_TextChanged(object sender, EventArgs e)
        {
            txtdireccionempresa.Text = txtdireccionempresa.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtdireccionempresa.SelectionStart = txtdireccionempresa.Text.Length;
        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            txtruc.Text = txtruc.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtruc.SelectionStart = txtruc.Text.Length;
        }

        private void btnsubirlogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new N_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    piclogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            String mensaje = string.Empty;
            Negocio obj = new Negocio()
            {
                nombre = txtnombreempresa.Text,
                ruc = txtruc.Text,
                direccion = txtdireccionempresa.Text
            };
            bool respuesta = new N_Negocio().GuardarDatos(obj, out mensaje);
            if(respuesta)
                MessageBox.Show("Los cambios fueron guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
