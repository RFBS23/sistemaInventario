using entidad;
using negocio;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtnombreusuario.Select();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            Usuarios ousuario = new N_Usuarios().Listar().Where(u => u.correo == txtnombreusuario.Text && u.clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Dashboard form = new Dashboard(ousuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al Iniciar Sesion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Usuarios ousuario = new N_Usuarios().Listar().Where(u => u.correo == txtnombreusuario.Text && u.clave == txtclave.Text).FirstOrDefault();

                if (ousuario != null)
                {
                    Dashboard form = new Dashboard(ousuario);
                    form.Show();
                    this.Hide();
                }
                else
                {
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
