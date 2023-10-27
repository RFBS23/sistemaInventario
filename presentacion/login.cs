using entidad;
using negocio;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtnombreusuario.Select();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Usuarios ousuario = new N_Usuarios().Listar().Where(u => u.nombreusuario == txtnombreusuario.Texts && u.clave == txtclave.Texts).FirstOrDefault();
            
            if (ousuario != null)
            {
                Dashboard form = new Dashboard(ousuario);
                form.Show();
                this.Hide();
                //notificaciones
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                notifyIcon1.Text = "Valent France";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Valent France";
                notifyIcon1.BalloonTipText = "Nuevo Inicio de Sesion Detectado";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            {
                //notificaciones
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                notifyIcon1.Text = "Valent France";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Valent France";
                notifyIcon1.BalloonTipText = "Error al iniciar Sesion";
                notifyIcon1.ShowBalloonTip(1000);
                MessageBox.Show("Error al Iniciar Sesion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Usuarios ousuario = new N_Usuarios().Listar().Where(u => u.nombreusuario == txtnombreusuario.Texts && u.clave == txtclave.Texts).FirstOrDefault();
                
                if (ousuario != null)
                {
                    Dashboard form = new Dashboard(ousuario);
                    form.Show();
                    this.Hide();
                    //notificaciones
                    notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                    notifyIcon1.Text = "Valent France";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Valent France";
                    notifyIcon1.BalloonTipText = "Nuevo Inicio de Sesion Detectado";
                    notifyIcon1.ShowBalloonTip(1000);
                }
                else
                {
                    //notificaciones
                    notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icono.ico"));
                    notifyIcon1.Text = "Valent France";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Valent France";
                    notifyIcon1.BalloonTipText = "Error al iniciar Sesion";
                    notifyIcon1.ShowBalloonTip(1000);
                    MessageBox.Show("Error al Iniciar Sesion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
