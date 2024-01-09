namespace presentacion
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imguser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.NombreEmpresa = new System.Windows.Forms.Label();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.submenutallas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuingresotienda = new FontAwesome.Sharp.IconMenuItem();
            this.submenutienda = new System.Windows.Forms.ToolStripMenuItem();
            this.subprodtienda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuDetVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menunegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuconfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.panelEscritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.submenu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblhora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.footer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            this.submenu.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.header.BorderRadius = 10;
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.imguser);
            this.header.Controls.Add(this.guna2ControlBox2);
            this.header.Controls.Add(this.guna2ControlBox1);
            this.header.Controls.Add(this.lblusuario);
            this.header.Controls.Add(this.NombreEmpresa);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1709, 65);
            this.header.TabIndex = 3;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // logo
            // 
            this.logo.BorderRadius = 10;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(26, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(51, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // imguser
            // 
            this.imguser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imguser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imguser.ErrorImage")));
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.ImageRotate = 0F;
            this.imguser.Location = new System.Drawing.Point(1287, 11);
            this.imguser.Name = "imguser";
            this.imguser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imguser.Size = new System.Drawing.Size(47, 43);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imguser.TabIndex = 7;
            this.imguser.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(87)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(218)))), ((int)(((byte)(104)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1595, 9);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(48, 34);
            this.guna2ControlBox2.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(248)))), ((int)(((byte)(99)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(104)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1649, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(48, 34);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // lblusuario
            // 
            this.lblusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblusuario.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(1340, 8);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblusuario.Size = new System.Drawing.Size(202, 49);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblusuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblusuario_MouseDown);
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NombreEmpresa.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.NombreEmpresa.Location = new System.Drawing.Point(87, 3);
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.Size = new System.Drawing.Size(432, 59);
            this.NombreEmpresa.TabIndex = 0;
            this.NombreEmpresa.Text = "Inventario - VALENT FRANCE";
            this.NombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NombreEmpresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderRadius = 20;
            this.panelMenu.Controls.Add(this.guna2HtmlLabel1);
            this.panelMenu.Controls.Add(this.menu);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(167)))), ((int)(((byte)(254)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 65);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(365, 757);
            this.panelMenu.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(5, 950);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(275, 25);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = null;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menucategoria,
            this.menuproductos,
            this.menuingresotienda,
            this.menuclientes,
            this.menuproveedores,
            this.menuventas,
            this.menureportes,
            this.menunegocio,
            this.menuconfiguracion,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(333, 975);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(240, 70);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menucategoria
            // 
            this.menucategoria.AutoSize = false;
            this.menucategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenutallas});
            this.menucategoria.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucategoria.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.menucategoria.IconColor = System.Drawing.Color.Black;
            this.menucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucategoria.Name = "menucategoria";
            this.menucategoria.Size = new System.Drawing.Size(240, 70);
            this.menucategoria.Text = "Categorias";
            // 
            // submenucategoria
            // 
            this.submenucategoria.Image = ((System.Drawing.Image)(resources.GetObject("submenucategoria.Image")));
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(210, 34);
            this.submenucategoria.Text = "CATEGORIAS";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenutallas
            // 
            this.submenutallas.Image = ((System.Drawing.Image)(resources.GetObject("submenutallas.Image")));
            this.submenutallas.Name = "submenutallas";
            this.submenutallas.Size = new System.Drawing.Size(210, 34);
            this.submenutallas.Text = "TALLAS";
            this.submenutallas.Click += new System.EventHandler(this.submenutallas_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.Shirt;
            this.menuproductos.IconColor = System.Drawing.Color.Black;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(240, 70);
            this.menuproductos.Text = "Productos";
            this.menuproductos.Click += new System.EventHandler(this.menuproductos_Click);
            // 
            // menuingresotienda
            // 
            this.menuingresotienda.AutoSize = false;
            this.menuingresotienda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenutienda,
            this.subprodtienda});
            this.menuingresotienda.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuingresotienda.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menuingresotienda.IconColor = System.Drawing.Color.Black;
            this.menuingresotienda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuingresotienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuingresotienda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuingresotienda.Name = "menuingresotienda";
            this.menuingresotienda.Size = new System.Drawing.Size(240, 70);
            this.menuingresotienda.Text = "Tienda";
            // 
            // submenutienda
            // 
            this.submenutienda.AutoSize = false;
            this.submenutienda.Image = ((System.Drawing.Image)(resources.GetObject("submenutienda.Image")));
            this.submenutienda.Name = "submenutienda";
            this.submenutienda.Size = new System.Drawing.Size(309, 40);
            this.submenutienda.Tag = "Registrar Productos";
            this.submenutienda.Text = "Registrar Productos";
            this.submenutienda.Click += new System.EventHandler(this.submenutienda_Click);
            // 
            // subprodtienda
            // 
            this.subprodtienda.AutoSize = false;
            this.subprodtienda.Image = ((System.Drawing.Image)(resources.GetObject("subprodtienda.Image")));
            this.subprodtienda.Name = "subprodtienda";
            this.subprodtienda.Size = new System.Drawing.Size(309, 40);
            this.subprodtienda.Tag = "Ver Productos";
            this.subprodtienda.Text = "Ver Productos";
            this.subprodtienda.Click += new System.EventHandler(this.subprodtienda_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(240, 70);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(240, 70);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRVentas,
            this.submenuDetVentas});
            this.menuventas.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(240, 70);
            this.menuventas.Text = "Ventas";
            // 
            // submenuRVentas
            // 
            this.submenuRVentas.Image = ((System.Drawing.Image)(resources.GetObject("submenuRVentas.Image")));
            this.submenuRVentas.Name = "submenuRVentas";
            this.submenuRVentas.Size = new System.Drawing.Size(298, 34);
            this.submenuRVentas.Text = "Registrar Ventas";
            this.submenuRVentas.Click += new System.EventHandler(this.submenuRVentas_Click);
            // 
            // submenuDetVentas
            // 
            this.submenuDetVentas.Image = ((System.Drawing.Image)(resources.GetObject("submenuDetVentas.Image")));
            this.submenuDetVentas.Name = "submenuDetVentas";
            this.submenuDetVentas.Size = new System.Drawing.Size(298, 34);
            this.submenuDetVentas.Text = "Detalles de Ventas";
            this.submenuDetVentas.Click += new System.EventHandler(this.submenuDetVentas_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(240, 70);
            this.menureportes.Text = "Reportes";
            // 
            // menunegocio
            // 
            this.menunegocio.AutoSize = false;
            this.menunegocio.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menunegocio.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menunegocio.IconColor = System.Drawing.Color.Black;
            this.menunegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menunegocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menunegocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menunegocio.Name = "menunegocio";
            this.menunegocio.Size = new System.Drawing.Size(240, 70);
            this.menunegocio.Text = "Datos de Tienda";
            // 
            // menuconfiguracion
            // 
            this.menuconfiguracion.AutoSize = false;
            this.menuconfiguracion.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuconfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.menuconfiguracion.IconColor = System.Drawing.Color.Black;
            this.menuconfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuconfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuconfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuconfiguracion.Name = "menuconfiguracion";
            this.menuconfiguracion.Size = new System.Drawing.Size(240, 70);
            this.menuconfiguracion.Text = "Configuraciones";
            this.menuconfiguracion.Click += new System.EventHandler(this.menuconfiguracion_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(240, 70);
            this.menuacercade.Text = "Acerca De";
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panelEscritorio.BorderRadius = 20;
            this.panelEscritorio.Controls.Add(this.submenu);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(365, 65);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1344, 757);
            this.panelEscritorio.TabIndex = 7;
            // 
            // submenu
            // 
            this.submenu.AutoScroll = true;
            this.submenu.Controls.Add(this.lblhora);
            this.submenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submenu.Location = new System.Drawing.Point(0, 0);
            this.submenu.Name = "submenu";
            this.submenu.Size = new System.Drawing.Size(1344, 757);
            this.submenu.TabIndex = 0;
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(22, 23);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(87, 33);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "lblhora";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.footer.BorderRadius = 20;
            this.footer.Controls.Add(this.btnSalir);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.footer.Location = new System.Drawing.Point(0, 822);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1709, 57);
            this.footer.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MesloLGL NF", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.IndianRed;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(333, 57);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Cerrar Sesion";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 879);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.header);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelEscritorio.ResumeLayout(false);
            this.submenu.ResumeLayout(false);
            this.submenu.PerformLayout();
            this.footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel header;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelEscritorio;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label NombreEmpresa;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel footer;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private System.Windows.Forms.ToolStripMenuItem submenuRVentas;
        private System.Windows.Forms.ToolStripMenuItem submenuDetVentas;
        private FontAwesome.Sharp.IconMenuItem menuingresotienda;
        private System.Windows.Forms.ToolStripMenuItem submenutienda;
        private System.Windows.Forms.ToolStripMenuItem subprodtienda;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menucategoria;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imguser;
        private System.Windows.Forms.Timer horafecha;
        private FontAwesome.Sharp.IconMenuItem menunegocio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private System.Windows.Forms.ToolStripMenuItem submenucategoria;
        private System.Windows.Forms.ToolStripMenuItem submenutallas;
        private Guna.UI2.WinForms.Guna2Panel submenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblhora;
        private FontAwesome.Sharp.IconMenuItem menuconfiguracion;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
    }
}