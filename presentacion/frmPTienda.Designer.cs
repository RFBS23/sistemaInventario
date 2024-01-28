namespace presentacion
{
    partial class frmPTienda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPTienda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgproductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listbuscarC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grupoboxdescargar = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtbusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtallaropa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.grupoboxdescargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgproductos
            // 
            this.dgproductos.AllowUserToAddRows = false;
            this.dgproductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgproductos.ColumnHeadersHeight = 30;
            this.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.idcategoria,
            this.nombrecategoria,
            this.idtallaropa,
            this.nombretalla,
            this.colores,
            this.stock,
            this.numcaja,
            this.temporada,
            this.descuento,
            this.precioventa,
            this.total,
            this.fecharegistro});
            this.dgproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproductos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgproductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgproductos.Location = new System.Drawing.Point(0, 0);
            this.dgproductos.Name = "dgproductos";
            this.dgproductos.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgproductos.RowHeadersVisible = false;
            this.dgproductos.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgproductos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgproductos.RowTemplate.Height = 24;
            this.dgproductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproductos.Size = new System.Drawing.Size(1334, 546);
            this.dgproductos.TabIndex = 7;
            this.dgproductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dgproductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgproductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgproductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgproductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgproductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgproductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgproductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgproductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dgproductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgproductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgproductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgproductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgproductos.ThemeStyle.HeaderStyle.Height = 30;
            this.dgproductos.ThemeStyle.ReadOnly = true;
            this.dgproductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgproductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgproductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgproductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgproductos.ThemeStyle.RowsStyle.Height = 24;
            this.dgproductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgproductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.04533F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1340, 706);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgproductos);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 157);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1334, 546);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.listbuscarC);
            this.guna2Panel1.Controls.Add(this.grupoboxdescargar);
            this.guna2Panel1.Controls.Add(this.txtbusqueda);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1334, 148);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar Productos:";
            // 
            // listbuscarC
            // 
            this.listbuscarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listbuscarC.BackColor = System.Drawing.Color.Transparent;
            this.listbuscarC.BorderRadius = 10;
            this.listbuscarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listbuscarC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listbuscarC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listbuscarC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listbuscarC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listbuscarC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listbuscarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.listbuscarC.ItemHeight = 30;
            this.listbuscarC.Location = new System.Drawing.Point(760, 54);
            this.listbuscarC.Name = "listbuscarC";
            this.listbuscarC.Size = new System.Drawing.Size(290, 36);
            this.listbuscarC.TabIndex = 19;
            // 
            // grupoboxdescargar
            // 
            this.grupoboxdescargar.BackColor = System.Drawing.Color.Transparent;
            this.grupoboxdescargar.BorderColor = System.Drawing.Color.Black;
            this.grupoboxdescargar.BorderRadius = 15;
            this.grupoboxdescargar.Controls.Add(this.btnexcel);
            this.grupoboxdescargar.Cursor = System.Windows.Forms.Cursors.Default;
            this.grupoboxdescargar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grupoboxdescargar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.grupoboxdescargar.Font = new System.Drawing.Font("MesloLGL NF", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoboxdescargar.ForeColor = System.Drawing.Color.Black;
            this.grupoboxdescargar.Location = new System.Drawing.Point(99, 14);
            this.grupoboxdescargar.Name = "grupoboxdescargar";
            this.grupoboxdescargar.Size = new System.Drawing.Size(190, 116);
            this.grupoboxdescargar.TabIndex = 17;
            this.grupoboxdescargar.Text = "Descargar: ";
            this.grupoboxdescargar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexcel.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcel.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnexcel.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnexcel.ImageRotate = 0F;
            this.btnexcel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Location = new System.Drawing.Point(25, 50);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnexcel.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexcel.Size = new System.Drawing.Size(63, 51);
            this.btnexcel.TabIndex = 19;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbusqueda.BorderRadius = 8;
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusqueda.DefaultText = "";
            this.txtbusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Font = new System.Drawing.Font("MesloLGL NF", 14F);
            this.txtbusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Location = new System.Drawing.Point(1068, 51);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.Size = new System.Drawing.Size(227, 41);
            this.txtbusqueda.TabIndex = 18;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "idusuario";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 129;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.FillWeight = 448.8688F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 99;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.FillWeight = 113.9045F;
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 99;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.FillWeight = 0.570844F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 149;
            // 
            // idcategoria
            // 
            this.idcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcategoria.HeaderText = "idcategoria";
            this.idcategoria.MinimumWidth = 6;
            this.idcategoria.Name = "idcategoria";
            this.idcategoria.ReadOnly = true;
            this.idcategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcategoria.Visible = false;
            this.idcategoria.Width = 149;
            // 
            // nombrecategoria
            // 
            this.nombrecategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.MinimumWidth = 6;
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            this.nombrecategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombrecategoria.Width = 129;
            // 
            // idtallaropa
            // 
            this.idtallaropa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idtallaropa.HeaderText = "idtallaropa";
            this.idtallaropa.MinimumWidth = 6;
            this.idtallaropa.Name = "idtallaropa";
            this.idtallaropa.ReadOnly = true;
            this.idtallaropa.Visible = false;
            this.idtallaropa.Width = 149;
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
            this.nombretalla.Width = 89;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle4;
            this.stock.HeaderText = "Cantidades";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 139;
            // 
            // numcaja
            // 
            this.numcaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numcaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.numcaja.HeaderText = "N° Caja";
            this.numcaja.MinimumWidth = 6;
            this.numcaja.Name = "numcaja";
            this.numcaja.ReadOnly = true;
            this.numcaja.Width = 109;
            // 
            // temporada
            // 
            this.temporada.HeaderText = "Temporada";
            this.temporada.MinimumWidth = 6;
            this.temporada.Name = "temporada";
            this.temporada.ReadOnly = true;
            this.temporada.Width = 129;
            // 
            // descuento
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle6;
            this.descuento.HeaderText = "Descuento";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 129;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 99;
            // 
            // total
            // 
            this.total.HeaderText = "Monto Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 149;
            // 
            // fecharegistro
            // 
            this.fecharegistro.HeaderText = "Fecha Registro";
            this.fecharegistro.MinimumWidth = 6;
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Width = 179;
            // 
            // frmPTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPTienda";
            this.Text = "frmPTienda";
            this.Load += new System.EventHandler(this.frmPTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.grupoboxdescargar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgproductos;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox listbuscarC;
        private Guna.UI2.WinForms.Guna2GroupBox grupoboxdescargar;
        private Guna.UI2.WinForms.Guna2ImageButton btnexcel;
        private Guna.UI2.WinForms.Guna2TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtallaropa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colores;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
    }
}