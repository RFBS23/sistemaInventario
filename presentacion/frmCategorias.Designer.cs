namespace presentacion
{
    partial class frmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.listbuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnlimpiarc = new Guna.UI2.WinForms.Guna2Button();
            this.btneliminarc = new Guna.UI2.WinForms.Guna2Button();
            this.btnguardarc = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecatecoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dgcategorias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtindice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorias)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtbusqueda.BorderRadius = 10;
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbusqueda.DefaultText = "";
            this.txtbusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Font = new System.Drawing.Font("MesloLGL NF", 14F);
            this.txtbusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbusqueda.Location = new System.Drawing.Point(523, 45);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.PasswordChar = '\0';
            this.txtbusqueda.PlaceholderText = "";
            this.txtbusqueda.SelectedText = "";
            this.txtbusqueda.Size = new System.Drawing.Size(275, 42);
            this.txtbusqueda.TabIndex = 13;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // listbuscar
            // 
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
            this.listbuscar.Location = new System.Drawing.Point(240, 45);
            this.listbuscar.Name = "listbuscar";
            this.listbuscar.Size = new System.Drawing.Size(275, 36);
            this.listbuscar.TabIndex = 12;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 25);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(155, 28);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Buscar por: ";
            // 
            // btnlimpiarc
            // 
            this.btnlimpiarc.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarc.BorderRadius = 10;
            this.btnlimpiarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlimpiarc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlimpiarc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlimpiarc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlimpiarc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(225)))));
            this.btnlimpiarc.Font = new System.Drawing.Font("MesloLGL NF", 10F, System.Drawing.FontStyle.Bold);
            this.btnlimpiarc.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarc.Location = new System.Drawing.Point(30, 389);
            this.btnlimpiarc.Name = "btnlimpiarc";
            this.btnlimpiarc.Size = new System.Drawing.Size(342, 45);
            this.btnlimpiarc.TabIndex = 23;
            this.btnlimpiarc.Text = "Lim. Form";
            this.btnlimpiarc.Click += new System.EventHandler(this.btnlimpiarc_Click);
            // 
            // btneliminarc
            // 
            this.btneliminarc.BackColor = System.Drawing.Color.Transparent;
            this.btneliminarc.BorderRadius = 10;
            this.btneliminarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneliminarc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneliminarc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneliminarc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneliminarc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btneliminarc.Font = new System.Drawing.Font("MesloLGL NF", 10F, System.Drawing.FontStyle.Bold);
            this.btneliminarc.ForeColor = System.Drawing.Color.White;
            this.btneliminarc.Location = new System.Drawing.Point(30, 328);
            this.btneliminarc.Name = "btneliminarc";
            this.btneliminarc.Size = new System.Drawing.Size(342, 45);
            this.btneliminarc.TabIndex = 22;
            this.btneliminarc.Text = "Eliminar";
            this.btneliminarc.Click += new System.EventHandler(this.btneliminarc_Click);
            // 
            // btnguardarc
            // 
            this.btnguardarc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardarc.BackColor = System.Drawing.Color.Transparent;
            this.btnguardarc.BorderRadius = 10;
            this.btnguardarc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnguardarc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnguardarc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnguardarc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnguardarc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(178)))), ((int)(((byte)(56)))));
            this.btnguardarc.Font = new System.Drawing.Font("MesloLGL NF", 10F, System.Drawing.FontStyle.Bold);
            this.btnguardarc.ForeColor = System.Drawing.Color.White;
            this.btnguardarc.Location = new System.Drawing.Point(30, 257);
            this.btnguardarc.Name = "btnguardarc";
            this.btnguardarc.Size = new System.Drawing.Size(342, 52);
            this.btnguardarc.TabIndex = 21;
            this.btnguardarc.Text = "Guardar";
            this.btnguardarc.Click += new System.EventHandler(this.btnguardarc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MesloLGL NF", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Categoria";
            // 
            // txtnombrecatecoria
            // 
            this.txtnombrecatecoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombrecatecoria.BackColor = System.Drawing.Color.Transparent;
            this.txtnombrecatecoria.BorderRadius = 10;
            this.txtnombrecatecoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombrecatecoria.DefaultText = "";
            this.txtnombrecatecoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombrecatecoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombrecatecoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecatecoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombrecatecoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecatecoria.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtnombrecatecoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombrecatecoria.Location = new System.Drawing.Point(30, 171);
            this.txtnombrecatecoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombrecatecoria.Name = "txtnombrecatecoria";
            this.txtnombrecatecoria.PasswordChar = '\0';
            this.txtnombrecatecoria.PlaceholderText = "";
            this.txtnombrecatecoria.SelectedText = "";
            this.txtnombrecatecoria.Size = new System.Drawing.Size(342, 48);
            this.txtnombrecatecoria.TabIndex = 2;
            this.txtnombrecatecoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrecatecoria_KeyPress);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dgcategorias
            // 
            this.dgcategorias.AllowUserToAddRows = false;
            this.dgcategorias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.dgcategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgcategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgcategorias.ColumnHeadersHeight = 30;
            this.dgcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgcategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.id,
            this.nombrecategoria});
            this.dgcategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcategorias.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgcategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.dgcategorias.Location = new System.Drawing.Point(0, 0);
            this.dgcategorias.Name = "dgcategorias";
            this.dgcategorias.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgcategorias.RowHeadersVisible = false;
            this.dgcategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcategorias.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgcategorias.RowTemplate.Height = 24;
            this.dgcategorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcategorias.Size = new System.Drawing.Size(926, 609);
            this.dgcategorias.TabIndex = 43;
            this.dgcategorias.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgcategorias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.dgcategorias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgcategorias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgcategorias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgcategorias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgcategorias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgcategorias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.dgcategorias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.dgcategorias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgcategorias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcategorias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgcategorias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgcategorias.ThemeStyle.HeaderStyle.Height = 30;
            this.dgcategorias.ThemeStyle.ReadOnly = true;
            this.dgcategorias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.dgcategorias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgcategorias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcategorias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgcategorias.ThemeStyle.RowsStyle.Height = 24;
            this.dgcategorias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.dgcategorias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategorias_CellContentClick);
            this.dgcategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgcategorias_CellPainting);
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
            this.id.HeaderText = "idcategoria";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 149;
            // 
            // nombrecategoria
            // 
            this.nombrecategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombrecategoria.DefaultCellStyle = dataGridViewCellStyle15;
            this.nombrecategoria.FillWeight = 448.8688F;
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.MinimumWidth = 6;
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            this.nombrecategoria.Width = 129;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.txtid);
            this.guna2Panel1.Controls.Add(this.txtindice);
            this.guna2Panel1.Controls.Add(this.txtnombrecatecoria);
            this.guna2Panel1.Controls.Add(this.btnguardarc);
            this.guna2Panel1.Controls.Add(this.btneliminarc);
            this.guna2Panel1.Controls.Add(this.btnlimpiarc);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(56)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(418, 757);
            this.guna2Panel1.TabIndex = 45;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Transparent;
            this.txtid.BorderRadius = 10;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "0";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(266, 83);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(38, 29);
            this.txtid.TabIndex = 25;
            this.txtid.Visible = false;
            // 
            // txtindice
            // 
            this.txtindice.BackColor = System.Drawing.Color.Transparent;
            this.txtindice.BorderRadius = 8;
            this.txtindice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtindice.DefaultText = "-1";
            this.txtindice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtindice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtindice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtindice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtindice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtindice.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtindice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtindice.Location = new System.Drawing.Point(217, 83);
            this.txtindice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtindice.Name = "txtindice";
            this.txtindice.PasswordChar = '\0';
            this.txtindice.PlaceholderText = "";
            this.txtindice.SelectedText = "";
            this.txtindice.Size = new System.Drawing.Size(41, 29);
            this.txtindice.TabIndex = 24;
            this.txtindice.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.btnbuscar);
            this.guna2Panel2.Controls.Add(this.listbuscar);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.txtbusqueda);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(56)))));
            this.guna2Panel2.Location = new System.Drawing.Point(418, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(926, 148);
            this.guna2Panel2.TabIndex = 46;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(178)))), ((int)(((byte)(59)))));
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 40;
            this.btnbuscar.Location = new System.Drawing.Point(845, 46);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 41);
            this.btnbuscar.TabIndex = 14;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.dgcategorias);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(418, 148);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(926, 609);
            this.guna2Panel3.TabIndex = 47;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1344, 757);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorias)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox listbuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnlimpiarc;
        private Guna.UI2.WinForms.Guna2Button btneliminarc;
        private Guna.UI2.WinForms.Guna2Button btnguardarc;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtnombrecatecoria;
        private Guna.UI2.WinForms.Guna2DataGridView dgcategorias;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtindice;
    }
}