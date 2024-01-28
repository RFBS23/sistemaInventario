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
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.NombreEmpresa = new System.Windows.Forms.Label();
            this.lblhora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.imguser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.submenutallas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuprodtienda = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuprovventas = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuDetVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menunegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuconfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.panelEscritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.submenu = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblfecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.piclogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.footer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.menuventastienda = new FontAwesome.Sharp.IconMenuItem();
            this.subventienda = new System.Windows.Forms.ToolStripMenuItem();
            this.detventas = new System.Windows.Forms.ToolStripMenuItem();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            this.submenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.header.BorderRadius = 10;
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.guna2ControlBox2);
            this.header.Controls.Add(this.guna2ControlBox1);
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
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = false;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("MesloLGL NF", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(844, 156);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(485, 80);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "lblhora";
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblusuario.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Black;
            this.lblusuario.Location = new System.Drawing.Point(223, 89);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblusuario.Size = new System.Drawing.Size(331, 49);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblusuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblusuario_MouseDown);
            // 
            // imguser
            // 
            this.imguser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imguser.ErrorImage")));
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.ImageRotate = 0F;
            this.imguser.Location = new System.Drawing.Point(51, 89);
            this.imguser.Name = "imguser";
            this.imguser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imguser.Size = new System.Drawing.Size(51, 49);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imguser.TabIndex = 7;
            this.imguser.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderRadius = 20;
            this.panelMenu.Controls.Add(this.guna2HtmlLabel1);
            this.panelMenu.Controls.Add(this.menu);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(167)))), ((int)(((byte)(254)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.White;
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
            this.menuprodtienda,
            this.menuproveedores,
            this.menuventas,
            this.menuventastienda,
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
            // menuprodtienda
            // 
            this.menuprodtienda.AutoSize = false;
            this.menuprodtienda.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprodtienda.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuprodtienda.IconColor = System.Drawing.Color.Black;
            this.menuprodtienda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprodtienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuprodtienda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprodtienda.Name = "menuprodtienda";
            this.menuprodtienda.Size = new System.Drawing.Size(240, 70);
            this.menuprodtienda.Text = "Productos";
            this.menuprodtienda.Click += new System.EventHandler(this.menuprodtienda_Click);
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
            this.submenuprovventas,
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
            // submenuprovventas
            // 
            this.submenuprovventas.Image = global::presentacion.Properties.Resources.puntero;
            this.submenuprovventas.Name = "submenuprovventas";
            this.submenuprovventas.Size = new System.Drawing.Size(298, 34);
            this.submenuprovventas.Text = "Ventas";
            this.submenuprovventas.Click += new System.EventHandler(this.submenuprovventas_Click);
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
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
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
            this.menunegocio.Click += new System.EventHandler(this.menunegocio_Click);
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
            this.submenu.Controls.Add(this.tableLayoutPanel1);
            this.submenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submenu.Location = new System.Drawing.Point(0, 0);
            this.submenu.Name = "submenu";
            this.submenu.Size = new System.Drawing.Size(1344, 757);
            this.submenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.38045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.30779F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 757);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.lblfecha);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel3.Controls.Add(this.lblcargo);
            this.guna2Panel3.Controls.Add(this.lblhora);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel3.Controls.Add(this.lblusuario);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Controls.Add(this.imguser);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 522);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1338, 232);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = false;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(844, 86);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(578, 64);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "lblfecha";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("MesloLGM NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(783, 17);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(894, 63);
            this.guna2HtmlLabel7.TabIndex = 12;
            this.guna2HtmlLabel7.Text = "Fecha y Hora del sistema";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.ErrorImage")));
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(51, 144);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(51, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblcargo
            // 
            this.lblcargo.BackColor = System.Drawing.Color.Transparent;
            this.lblcargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcargo.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.Black;
            this.lblcargo.Location = new System.Drawing.Point(223, 146);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcargo.Size = new System.Drawing.Size(331, 49);
            this.lblcargo.TabIndex = 10;
            this.lblcargo.Text = "lblcargo";
            this.lblcargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("MesloLGM NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(108, 156);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(371, 84);
            this.guna2HtmlLabel6.TabIndex = 9;
            this.guna2HtmlLabel6.Text = "Cargo: ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("MesloLGM NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(37, 17);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(716, 63);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Sesión Iniciada";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("MesloLGM NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(108, 99);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(371, 84);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "Usuario: ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 127);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1338, 389);
            this.guna2Panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel6, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1338, 389);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.piclogo);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(449, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(440, 383);
            this.guna2Panel4.TabIndex = 0;
            // 
            // piclogo
            // 
            this.piclogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piclogo.BorderRadius = 20;
            this.piclogo.Image = global::presentacion.Properties.Resources.icono;
            this.piclogo.ImageRotate = 0F;
            this.piclogo.Location = new System.Drawing.Point(31, 16);
            this.piclogo.Name = "piclogo";
            this.piclogo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.piclogo.Size = new System.Drawing.Size(379, 350);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 3;
            this.piclogo.TabStop = false;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(440, 383);
            this.guna2Panel5.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.Location = new System.Drawing.Point(895, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(440, 383);
            this.guna2Panel6.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1338, 118);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("MesloLGSDZ NF", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(693, 71);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(692, 79);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "v 1.0.3";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("MesloLGL Nerd Font", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(434, 28);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(1243, 112);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "SISTEMA DE INVENTARIO";
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
            // menuventastienda
            // 
            this.menuventastienda.AutoSize = false;
            this.menuventastienda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subventienda,
            this.detventas});
            this.menuventastienda.Font = new System.Drawing.Font("MesloLGL NF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventastienda.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventastienda.IconColor = System.Drawing.Color.Black;
            this.menuventastienda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventastienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuventastienda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventastienda.Name = "menuventastienda";
            this.menuventastienda.Size = new System.Drawing.Size(240, 70);
            this.menuventastienda.Text = "Ventas";
            // 
            // subventienda
            // 
            this.subventienda.Image = global::presentacion.Properties.Resources.puntero;
            this.subventienda.Name = "subventienda";
            this.subventienda.Size = new System.Drawing.Size(298, 34);
            this.subventienda.Text = "Ventas";
            this.subventienda.Click += new System.EventHandler(this.subventienda_Click);
            // 
            // detventas
            // 
            this.detventas.Image = ((System.Drawing.Image)(resources.GetObject("detventas.Image")));
            this.detventas.Name = "detventas";
            this.detventas.Size = new System.Drawing.Size(298, 34);
            this.detventas.Text = "Detalles de Ventas";
            this.detventas.Click += new System.EventHandler(this.detventas_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 879);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem submenuDetVentas;
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
        private System.Windows.Forms.ToolStripMenuItem submenuprovventas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Label lblcargo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblfecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox piclogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private FontAwesome.Sharp.IconMenuItem menuprodtienda;
        private FontAwesome.Sharp.IconMenuItem menuventastienda;
        private System.Windows.Forms.ToolStripMenuItem subventienda;
        private System.Windows.Forms.ToolStripMenuItem detventas;
    }
}