namespace presentacion.Utilidades.modales
{
    partial class mdProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProductos));
            this.listbuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgproductosmodal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupboxproductos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.cerrarlogin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bordesmodal = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductosmodal)).BeginInit();
            this.groupboxproductos.SuspendLayout();
            this.SuspendLayout();
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
            this.listbuscar.Location = new System.Drawing.Point(37, 96);
            this.listbuscar.Name = "listbuscar";
            this.listbuscar.Size = new System.Drawing.Size(361, 36);
            this.listbuscar.TabIndex = 20;
            // 
            // dgproductosmodal
            // 
            this.dgproductosmodal.AllowUserToAddRows = false;
            this.dgproductosmodal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgproductosmodal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgproductosmodal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgproductosmodal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgproductosmodal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductosmodal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgproductosmodal.ColumnHeadersHeight = 30;
            this.dgproductosmodal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgproductosmodal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.id,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.nombrecategoria,
            this.nombretalla,
            this.colores,
            this.stock,
            this.descuento,
            this.precioventa});
            this.dgproductosmodal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproductosmodal.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgproductosmodal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgproductosmodal.Location = new System.Drawing.Point(12, 193);
            this.dgproductosmodal.Name = "dgproductosmodal";
            this.dgproductosmodal.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductosmodal.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgproductosmodal.RowHeadersVisible = false;
            this.dgproductosmodal.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgproductosmodal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgproductosmodal.RowTemplate.Height = 24;
            this.dgproductosmodal.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductosmodal.Size = new System.Drawing.Size(1095, 397);
            this.dgproductosmodal.TabIndex = 17;
            this.dgproductosmodal.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgproductosmodal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgproductosmodal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgproductosmodal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgproductosmodal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgproductosmodal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgproductosmodal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgproductosmodal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgproductosmodal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgproductosmodal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgproductosmodal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgproductosmodal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgproductosmodal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgproductosmodal.ThemeStyle.HeaderStyle.Height = 30;
            this.dgproductosmodal.ThemeStyle.ReadOnly = true;
            this.dgproductosmodal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgproductosmodal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgproductosmodal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgproductosmodal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgproductosmodal.ThemeStyle.RowsStyle.Height = 24;
            this.dgproductosmodal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgproductosmodal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgproductosmodal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgproductosmodal_CellContentClick);
            this.dgproductosmodal.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgproductos_CellPainting);
            // 
            // groupboxproductos
            // 
            this.groupboxproductos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupboxproductos.BorderColor = System.Drawing.Color.OrangeRed;
            this.groupboxproductos.BorderRadius = 20;
            this.groupboxproductos.BorderThickness = 2;
            this.groupboxproductos.Controls.Add(this.dgproductosmodal);
            this.groupboxproductos.Controls.Add(this.guna2ControlBox1);
            this.groupboxproductos.Controls.Add(this.btnbuscar);
            this.groupboxproductos.Controls.Add(this.txtbusqueda);
            this.groupboxproductos.Controls.Add(this.cerrarlogin);
            this.groupboxproductos.Controls.Add(this.listbuscar);
            this.groupboxproductos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.groupboxproductos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 55, 0, 0);
            this.groupboxproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupboxproductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.groupboxproductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupboxproductos.ForeColor = System.Drawing.Color.Black;
            this.groupboxproductos.Location = new System.Drawing.Point(0, 0);
            this.groupboxproductos.MinimumSize = new System.Drawing.Size(1121, 602);
            this.groupboxproductos.Name = "groupboxproductos";
            this.groupboxproductos.Size = new System.Drawing.Size(1121, 602);
            this.groupboxproductos.TabIndex = 21;
            this.groupboxproductos.Text = "Informacion de Productos";
            this.groupboxproductos.TextOffset = new System.Drawing.Point(0, 5);
            this.groupboxproductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupboxproductos_MouseDown);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(989, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(56, 41);
            this.guna2ControlBox1.TabIndex = 25;
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
            this.btnbuscar.Location = new System.Drawing.Point(980, 96);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(102, 64);
            this.btnbuscar.TabIndex = 24;
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
            this.txtbusqueda.Location = new System.Drawing.Point(469, 96);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.Size = new System.Drawing.Size(455, 64);
            this.txtbusqueda.TabIndex = 23;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
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
            this.cerrarlogin.Location = new System.Drawing.Point(1051, 10);
            this.cerrarlogin.Name = "cerrarlogin";
            this.cerrarlogin.PressedColor = System.Drawing.Color.White;
            this.cerrarlogin.Size = new System.Drawing.Size(56, 41);
            this.cerrarlogin.TabIndex = 22;
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
            this.btnseleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnseleccionar.FillWeight = 35.29412F;
            this.btnseleccionar.HeaderText = "Seleccionar";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Text = "";
            this.btnseleccionar.Width = 150;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "idusuario";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 127;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 105;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretalla.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.stock.HeaderText = "Stock en Almacen";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 208;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 139;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 98;
            // 
            // mdProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 602);
            this.Controls.Add(this.groupboxproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1001, 602);
            this.Name = "mdProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProductos";
            this.Load += new System.EventHandler(this.mdProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproductosmodal)).EndInit();
            this.groupboxproductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox listbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgproductosmodal;
        private Guna.UI2.WinForms.Guna2GroupBox groupboxproductos;
        private Guna.UI2.WinForms.Guna2BorderlessForm bordesmodal;
        private Guna.UI2.WinForms.Guna2ControlBox cerrarlogin;
        private Guna.UI2.WinForms.Guna2TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colores;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
    }
}