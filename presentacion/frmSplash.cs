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
    }
}
