namespace presentacion.Utilidades.modales
{
    partial class mdProdTienda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProdTienda));
            this.dgverproductostienda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cerrarlogin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.listbuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bordesmodal = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idproductotienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgverproductostienda)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgverproductostienda
            // 
            this.dgverproductostienda.AllowUserToAddRows = false;
            this.dgverproductostienda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgverproductostienda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgverproductostienda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgverproductostienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgverproductostienda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgverproductostienda.ColumnHeadersHeight = 30;
            this.dgverproductostienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgverproductostienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.idproductotienda,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.nombrecategoria,
            this.nombretalla,
            this.colores,
            this.stock,
            this.precioventa,
            this.descuento});
            this.dgverproductostienda.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgverproductostienda.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgverproductostienda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgverproductostienda.Location = new System.Drawing.Point(9, 177);
            this.dgverproductostienda.Name = "dgverproductostienda";
            this.dgverproductostienda.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgverproductostienda.RowHeadersVisible = false;
            this.dgverproductostienda.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgverproductostienda.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgverproductostienda.RowTemplate.Height = 24;
            this.dgverproductostienda.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.Size = new System.Drawing.Size(1100, 445);
            this.dgverproductostienda.TabIndex = 17;
            this.dgverproductostienda.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dgverproductostienda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgverproductostienda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgverproductostienda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgverproductostienda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgverproductostienda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgverproductostienda.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgverproductostienda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgverproductostienda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dgverproductostienda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgverproductostienda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgverproductostienda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgverproductostienda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgverproductostienda.ThemeStyle.HeaderStyle.Height = 30;
            this.dgverproductostienda.ThemeStyle.ReadOnly = true;
            this.dgverproductostienda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgverproductostienda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgverproductostienda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgverproductostienda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgverproductostienda.ThemeStyle.RowsStyle.Height = 24;
            this.dgverproductostienda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgverproductostienda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgverproductostienda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgverproductostienda_CellContentClick);
            this.dgverproductostienda.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgverproductostienda_CellPainting);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(248)))), ((int)(((byte)(99)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(218)))), ((int)(((byte)(104)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(978, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(56, 41);
            this.guna2ControlBox1.TabIndex = 28;
            // 
            // cerrarlogin
            // 
            this.cerrarlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarlogin.BackColor = System.Drawing.Color.Transparent;
            this.cerrarlogin.BorderRadius = 10;
            this.cerrarlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cerrarlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cerrarlogin.HoverState.IconColor = System.Drawing.Color.White;
            this.cerrarlogin.IconColor = System.Drawing.Color.White;
            this.cerrarlogin.Location = new System.Drawing.Point(1046, 7);
            this.cerrarlogin.Name = "cerrarlogin";
            this.cerrarlogin.PressedColor = System.Drawing.Color.White;
            this.cerrarlogin.Size = new System.Drawing.Size(56, 41);
            this.cerrarlogin.TabIndex = 29;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.dgverproductostienda);
            this.guna2GroupBox1.Controls.Add(this.btnbuscar);
            this.guna2GroupBox1.Controls.Add(this.txtbusqueda);
            this.guna2GroupBox1.Controls.Add(this.listbuscar);
            this.guna2GroupBox1.Controls.Add(this.cerrarlogin);
            this.guna2GroupBox1.Controls.Add(this.guna2ControlBox1);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1121, 639);
            this.guna2GroupBox1.TabIndex = 30;
            this.guna2GroupBox1.Text = "Informacion de Prod. en  Tienda";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 5);
            this.guna2GroupBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GroupBox1_MouseDown);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(178)))), ((int)(((byte)(59)))));
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 40;
            this.btnbuscar.Location = new System.Drawing.Point(988, 83);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(102, 64);
            this.btnbuscar.TabIndex = 32;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtbusqueda.BorderRadius = 10;
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusqueda.DefaultText = "";
            this.txtbusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Location = new System.Drawing.Point(455, 83);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.Size = new System.Drawing.Size(473, 64);
            this.txtbusqueda.TabIndex = 31;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // listbuscar
            // 
            this.listbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbuscar.BackColor = System.Drawing.Color.Transparent;
            this.listbuscar.BorderRadius = 10;
            this.listbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listbuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listbuscar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listbuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.listbuscar.ItemHeight = 30;
            this.listbuscar.Location = new System.Drawing.Point(25, 94);
            this.listbuscar.Name = "listbuscar";
            this.listbuscar.Size = new System.Drawing.Size(361, 36);
            this.listbuscar.TabIndex = 30;
            // 
            // bordesmodal
            // 
            this.bordesmodal.BorderRadius = 30;
            this.bordesmodal.ContainerControl = this;
            this.bordesmodal.DockIndicatorTransparencyValue = 0.6D;
            this.bordesmodal.HasFormShadow = false;
            this.bordesmodal.ResizeForm = false;
            this.bordesmodal.TransparentWhileDrag = true;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnseleccionar.HeaderText = "Seleccionar";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 124;
            // 
            // idproductotienda
            // 
            this.idproductotienda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproductotienda.HeaderText = "idusuario";
            this.idproductotienda.MinimumWidth = 6;
            this.idproductotienda.Name = "idproductotienda";
            this.idproductotienda.ReadOnly = true;
            this.idproductotienda.Visible = false;
            this.idproductotienda.Width = 127;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.FillWeight = 448.8688F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 105;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre.FillWeight = 113.9045F;
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 112;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.descripcion.FillWeight = 0.570844F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // nombrecategoria
            // 
            this.nombrecategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombrecategoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.MinimumWidth = 6;
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            this.nombrecategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombrecategoria.Width = 130;
            // 
            // nombretalla
            // 
            this.nombretalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretalla.DefaultCellStyle = dataGridViewCellStyle6;
            this.nombretalla.HeaderText = "Talla";
            this.nombretalla.MinimumWidth = 6;
            this.nombretalla.Name = "nombretalla";
            this.nombretalla.ReadOnly = true;
            this.nombretalla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombretalla.Width = 83;
            // 
            // colores
            // 
            this.colores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colores.DefaultCellStyle = dataGridViewCellStyle7;
            this.colores.HeaderText = "Color";
            this.colores.MinimumWidth = 6;
            this.colores.Name = "colores";
            this.colores.ReadOnly = true;
            this.colores.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colores.Width = 89;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle8;
            this.stock.HeaderText = "Cantidades";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 143;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioventa.DefaultCellStyle = dataGridViewCellStyle9;
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 98;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 139;
            // 
            // mdProdTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 639);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1121, 639);
            this.Name = "mdProdTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProdTienda";
            this.Load += new System.EventHandler(this.mdProdTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgverproductostienda)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgverproductostienda;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox cerrarlogin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtbusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox listbuscar;
        private Guna.UI2.WinForms.Guna2BorderlessForm bordesmodal;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductotienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colores;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}