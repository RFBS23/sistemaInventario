namespace presentacion
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtnombreusuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarlogin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BorderRadius = 10;
            this.panelLogin.Controls.Add(this.guna2ControlBox1);
            this.panelLogin.Controls.Add(this.btnlogin);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtclave);
            this.panelLogin.Controls.Add(this.txtnombreusuario);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.cerrarlogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.MinimumSize = new System.Drawing.Size(493, 475);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(889, 522);
            this.panelLogin.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(247)))), ((int)(((byte)(135)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(227)))), ((int)(((byte)(54)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(775, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Size = new System.Drawing.Size(48, 34);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Font = new System.Drawing.Font("MesloLGL NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(218, 401);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(459, 60);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Iniciar Sesion";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtclave
            // 
            this.txtclave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtclave.BackColor = System.Drawing.SystemColors.Window;
            this.txtclave.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtclave.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(255)))), ((int)(((byte)(82)))));
            this.txtclave.BorderRadius = 10;
            this.txtclave.BorderSize = 1;
            this.txtclave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclave.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclave.Location = new System.Drawing.Point(234, 307);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Multiline = false;
            this.txtclave.Name = "txtclave";
            this.txtclave.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtclave.PasswordChar = true;
            this.txtclave.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtclave.PlaceholderText = "contraseña";
            this.txtclave.Size = new System.Drawing.Size(433, 41);
            this.txtclave.TabIndex = 9;
            this.txtclave.Texts = "";
            this.txtclave.UnderlinedStyle = false;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombreusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreusuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtnombreusuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(255)))), ((int)(((byte)(82)))));
            this.txtnombreusuario.BorderRadius = 10;
            this.txtnombreusuario.BorderSize = 1;
            this.txtnombreusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreusuario.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombreusuario.Location = new System.Drawing.Point(234, 181);
            this.txtnombreusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreusuario.Multiline = false;
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnombreusuario.PasswordChar = false;
            this.txtnombreusuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnombreusuario.PlaceholderText = "nombre usuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(433, 46);
            this.txtnombreusuario.TabIndex = 8;
            this.txtnombreusuario.Texts = "";
            this.txtnombreusuario.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MesloLGL NF", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iniciar Sesion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cerrarlogin
            // 
            this.cerrarlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarlogin.BorderRadius = 10;
            this.cerrarlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cerrarlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cerrarlogin.HoverState.IconColor = System.Drawing.Color.White;
            this.cerrarlogin.IconColor = System.Drawing.Color.White;
            this.cerrarlogin.Location = new System.Drawing.Point(829, 12);
            this.cerrarlogin.Name = "cerrarlogin";
            this.cerrarlogin.PressedColor = System.Drawing.Color.White;
            this.cerrarlogin.Size = new System.Drawing.Size(48, 34);
            this.cerrarlogin.TabIndex = 6;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtclave;
        private RJCodeAdvance.RJControls.RJTextBox txtnombreusuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox cerrarlogin;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}