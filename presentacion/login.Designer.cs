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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imagenlogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclave = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtnombreusuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarlogin = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenlogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenlogin
            // 
            this.imagenlogin.BorderRadius = 10;
            this.imagenlogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagenlogin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imagenlogin.ErrorImage")));
            this.imagenlogin.Image = ((System.Drawing.Image)(resources.GetObject("imagenlogin.Image")));
            this.imagenlogin.ImageRotate = 0F;
            this.imagenlogin.Location = new System.Drawing.Point(0, 0);
            this.imagenlogin.Name = "imagenlogin";
            this.imagenlogin.Size = new System.Drawing.Size(629, 670);
            this.imagenlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenlogin.TabIndex = 0;
            this.imagenlogin.TabStop = false;
            this.imagenlogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagenlogin_MouseDown);
            // 
            // panelLogin
            // 
            this.panelLogin.BorderRadius = 10;
            this.panelLogin.Controls.Add(this.btnlogin);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtclave);
            this.panelLogin.Controls.Add(this.txtnombreusuario);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.cerrarlogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(629, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(559, 670);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.BorderRadius = 15;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(142, 498);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(284, 60);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Iniciar Sesion";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.SystemColors.Window;
            this.txtclave.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtclave.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtclave.BorderRadius = 10;
            this.txtclave.BorderSize = 1;
            this.txtclave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtclave.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtclave.Location = new System.Drawing.Point(142, 369);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Multiline = false;
            this.txtclave.Name = "txtclave";
            this.txtclave.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtclave.PasswordChar = true;
            this.txtclave.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtclave.PlaceholderText = "contraseña";
            this.txtclave.Size = new System.Drawing.Size(283, 52);
            this.txtclave.TabIndex = 9;
            this.txtclave.Texts = "";
            this.txtclave.UnderlinedStyle = false;
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreusuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtnombreusuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtnombreusuario.BorderRadius = 10;
            this.txtnombreusuario.BorderSize = 1;
            this.txtnombreusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreusuario.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombreusuario.Location = new System.Drawing.Point(142, 233);
            this.txtnombreusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreusuario.Multiline = false;
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnombreusuario.PasswordChar = false;
            this.txtnombreusuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnombreusuario.PlaceholderText = "nombre usuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(283, 52);
            this.txtnombreusuario.TabIndex = 8;
            this.txtnombreusuario.Texts = "";
            this.txtnombreusuario.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MesloLGL NF", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iniciar Sesion";
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
            this.cerrarlogin.Location = new System.Drawing.Point(499, 12);
            this.cerrarlogin.Name = "cerrarlogin";
            this.cerrarlogin.PressedColor = System.Drawing.Color.White;
            this.cerrarlogin.Size = new System.Drawing.Size(48, 34);
            this.cerrarlogin.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 670);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.imagenlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.imagenlogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2PictureBox imagenlogin;
        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private Guna.UI2.WinForms.Guna2ControlBox cerrarlogin;
        private RJCodeAdvance.RJControls.RJTextBox txtnombreusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtclave;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
    }
}