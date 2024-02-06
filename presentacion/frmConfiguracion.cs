using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();

            /*
            WebClient webClient = new WebClient();
            var client = new WebClient();
            if (!webClient.DownloadString("https://www.dropbox.com/scl/fi/1msft52mx4qs6envwgp1m/updates.txt?rlkey=lzrl141ifv2mbixdr58szlqtu&dl=1").Contains("1.0.0"))
            {
                if(MessageBox.Show("Nueva Actualizacion Disponible | Desea instalar Ahora?", "Valent France", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if(File.Exists(@".\Inventario - Valent France-x64.msi")) { File.Delete(@".\Inventario - Valent France-x64.msix");  }
                        client.DownloadFile("https://www.dropbox.com/scl/fi/cmdv9yno9e3b50t3w48px/inventario.zip?rlkey=hlwzexgxvql1xesv7jg21xed4&dl=1", @"inventario.zip");
                        string zipPath = @".\inventario.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);
                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = String.Format("/i Inventario - Valent France-x64.msi");
                        this.Close();
                        process.Start();
                    } catch
                    {
                    }
                }
            }*/
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {

        }
    }
}
