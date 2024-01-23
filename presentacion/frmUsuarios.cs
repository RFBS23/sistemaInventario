using CustomAlertBoxDemo;
using entidad;
using Guna.UI2.WinForms;
using negocio;
using presentacion.Utilidades;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /*obtenemos lista de roles*/
            List<Rol> listaRol = new N_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                listarol.Items.Add(new opcionesComboBox() { Valor = item.idrol, Texto = item.nombrerol });
            }
            listarol.DisplayMember = "Texto";
            listarol.ValueMember = "Valor";
            listarol.SelectedIndex = 0;
            /*fin lista de roles*/

            foreach(DataGridViewColumn columna in dgusuarios.Columns)
            {
                if (columna.Visible == true)
                {
                    listbuscar.Items.Add(new opcionesComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                listbuscar.DisplayMember = "Texto";
                listbuscar.ValueMember = "Valor";
                listbuscar.SelectedIndex = 0;
            }

            /*obtenemos mostramos los usuarios*/
            List<Usuarios> listaUsuario = new N_Usuarios().Listar();
            foreach (Usuarios item in listaUsuario)
            {
                dgusuarios.Rows.Add(new object[] {"",item.idusuario, item.documento, item.nombreusuario, item.correo, item.clave, item.oRol.idrol, item.oRol.nombrerol});
            }
            /*fin mostrar usuarios*/
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuarios objusuario = new Usuarios()
            {
                idusuario = Convert.ToInt32(txtid.Text),
                documento = txtdocumento.Text,
                nombreusuario = txtnombreusuario.Text,
                correo = txtcorreo.Text,
                clave = txtclave.Text,
                oRol = new Rol() { idrol = Convert.ToInt32(((opcionesComboBox)listarol.SelectedItem).Valor)},
            };
            if (objusuario.idusuario == 0)
            {
                int idusuariogenerado = new N_Usuarios().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgusuarios.Rows.Add(new object[] {"", idusuariogenerado, txtdocumento.Text, txtnombreusuario.Text, txtcorreo.Text, txtclave.Text,
                        ((opcionesComboBox)listarol.SelectedItem).Valor.ToString(),
                        ((opcionesComboBox)listarol.SelectedItem).Texto.ToString(),
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            } else
            {
                bool resultado = new N_Usuarios().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgusuarios.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["idusuario"].Value = Convert.ToInt32(txtid.Text);
                    row.Cells["documento"].Value = txtdocumento.Text;
                    row.Cells["nombreusuario"].Value = txtnombreusuario.Text;
                    row.Cells["correo"].Value = txtcorreo.Text;
                    row.Cells["clave"].Value = txtclave.Text;
                    row.Cells["idrol"].Value = ((opcionesComboBox)listarol.SelectedItem).Valor.ToString();
                    row.Cells["rol"].Value = ((opcionesComboBox)listarol.SelectedItem).Texto.ToString();
                    Limpiar();
                    this.Alert("Usuario Editado", Form_Alert.enmType.Success);
                }
                else
                {
                    MessageBox.Show(mensaje);
                    this.Alert("No se pudo editar", Form_Alert.enmType.Error);
                }
            }
        } 

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombreusuario.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            listarol.SelectedIndex = 0;

            txtdocumento.Select();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgusuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check1.Width;
                var h = Properties.Resources.check1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check1, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgusuarios.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if(indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgusuarios.Rows[indice].Cells["idusuario"].Value.ToString();
                    txtdocumento.Text = dgusuarios.Rows[indice].Cells["documento"].Value.ToString();
                    txtnombreusuario.Text = dgusuarios.Rows[indice].Cells["nombreusuario"].Value.ToString();
                    txtcorreo.Text = dgusuarios.Rows[indice].Cells["correo"].Value.ToString();
                    txtclave.Text = dgusuarios.Rows[indice].Cells["clave"].Value.ToString();
                    txtconfirmarclave.Text = dgusuarios.Rows[indice].Cells["clave"].Value.ToString();

                    foreach (opcionesComboBox ocb in listarol.Items)
                    {
                        if (Convert.ToInt32(ocb.Valor) == Convert.ToInt32(dgusuarios.Rows[indice].Cells["idrol"].Value))
                        {
                            int indice_combo = listarol.Items.IndexOf(ocb);
                            listarol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        /*Validacion y limitacion de numeros*/
        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255 ))
            {
                MessageBox.Show("Ingresa Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
        /*Validacione y limitacion de numeros*/
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) !=0)
            {
                if(MessageBox.Show("¿ESTA SEGURO DE ELIMINAR A ESTE USUARIO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuarios objusuario = new Usuarios()
                    {
                        idusuario = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new N_Usuarios().Eliminar(objusuario, out mensaje);
                    if (respuesta)
                    {
                        dgusuarios.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    } else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Limpiar();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgusuarios.Rows.Count > 0 )
            {
                foreach (DataGridViewRow row in dgusuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()) )
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            String columnaFiltro = ((opcionesComboBox)listbuscar.SelectedItem).Valor.ToString();
            if (dgusuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgusuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            string email = txtcorreo.Text.Trim();

            // Utiliza una expresión regular para validar el formato del correo electrónico.
            // Aquí se utiliza una expresión regular simple para demostrar el concepto, pero podrías utilizar una expresión más robusta según tus necesidades.
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);

            if (!isValid)
            {
                MessageBox.Show("Correo electrónico no válido. Introduce un correo electrónico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcorreo.Focus();
                e.Cancel = true; // Evita que el foco se mueva fuera del TextBox si la validación falla.
            }
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {
            txtnombreusuario.Text = txtnombreusuario.Text.ToUpper();

            // Puedes mantener el cursor en la última posición después de convertir a mayúsculas
            txtnombreusuario.SelectionStart = txtnombreusuario.Text.Length;
        }

    }
}
