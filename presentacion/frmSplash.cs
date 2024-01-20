using entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmSplash : Form
    {

        public frmSplash()
        {
            InitializeComponent();
            Timer.Interval = 3000; // 3000 milisegundos (3 segundos)
            Timer.Tick += Timer_Tick;
            Timer.Start();

            btnportafolio.Click += new EventHandler(btnportafolio_Click);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Close();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnportafolio_Click(object sender, EventArgs e)
        {
            string url = "https://rfbs23.github.io/portafolio/";

            try
            {
                // Intenta abrir la URL en el navegador predeterminado del usuario
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                // Manejo de errores: muestra un mensaje si no se puede abrir la URL
                MessageBox.Show("No se pudo abrir la página. Detalles del error: " + ex.Message);
            }
        }
    }
}
