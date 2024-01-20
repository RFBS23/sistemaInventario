using entidad;
using negocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private int borderSize = 2;
        private Size formSize;

        public Dashboard(Usuarios objusuario = null)
        {
            InitializeComponent();
            usuarioActual = objusuario;
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
            lblcargo.Text = usuarioActual.oRol.nombrerol;

            MostrarFechaActual();
        }


        private void MostrarFechaActual()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Mostrar la fecha en el formato deseado (día, mes, año)
            lblfecha.Text = $"{fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}";
        }
        /*mostramos formulario*/
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.FromArgb(207, 226, 255);
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

            //
        }
        /* fin mostramos formulario*/

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
            submenu.Hide();
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucategoria, new frmCategorias());
            submenu.Hide();
        }

        private void submenutallas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucategoria, new frmTallas());
            submenu.Hide();
        }

        private void menuproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProductos());
            submenu.Hide();
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
           submenu.Hide();
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
            submenu.Hide();
        }

        private void submenuRVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentasTienda(usuarioActual));
            submenu.Hide();
        }

        private void submenuprovventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
            submenu.Hide();
        }

        private void submenuDetVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetallesVentas());
            submenu.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.Show();
            this.Hide();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblusuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            submenu.Show();
        }

        private void submenutienda_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menuingresotienda, new frmTienda(usuarioActual));
            submenu.Hide();
        }

        private void subprodtienda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuingresotienda, new frmProdtiendas());
            submenu.Hide();
        }

        private void menuconfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmConfiguracion());
            submenu.Hide();
        }

        private void menunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmNegocio());
            submenu.Hide();
        }

    }
}
