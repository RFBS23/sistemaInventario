using entidad;
using FontAwesome.Sharp;
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

namespace presentacion
{
    public partial class Dashboard : Form
    {
        private static Usuarios usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Dashboard(Usuarios objusuario = null)
        {
            /**
            if (objusuario == null) usuarioActual = new Usuarios()
            {
                nombreusuario = ""
            }**/

            usuarioActual = objusuario;

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new N_Permisos().Listar(usuarioActual.idusuario);
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.nombremenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblusuario.Text = usuarioActual.nombreusuario;
        }

        /*mostramos formulario*/
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.FromArgb(87,151, 255);
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            panelEscritorio.Controls.Add(formulario);
            formulario.Show();
        }
        /* fin mostramos formulario*/

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategorias());
        }

        private void submenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProductos());
        }

        private void submenuRVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmRegitroVentas());
        }

        private void submenuDetVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetallesVentas());
        }

        private void submenuRCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmRegistroCompras());
        }

        private void submenuDetCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetallesCompras());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            // AbrirFormulario((IconMenuItem)sender, );
        }

        private void menunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmNegocio());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();
            this.Hide();
        }
    }
}
