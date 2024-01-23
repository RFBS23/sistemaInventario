namespace presentacion
{
    partial class frmReportesVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesVentas));
            this.txtfechainicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechafin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnbuscar = new Guna.UI2.WinForms.Guna2Button();
            this.dgreportesventa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.listbuscar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgreportesventa)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.Animated = true;
            this.txtfechainicio.BorderRadius = 15;
            this.txtfechainicio.Checked = true;
            this.txtfechainicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.FillColor = System.Drawing.SystemColors.Window;
            this.txtfechainicio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtfechainicio.Location = new System.Drawing.Point(160, 71);
            this.txtfechainicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtfechainicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(449, 59);
            this.txtfechainicio.TabIndex = 0;
            this.txtfechainicio.Value = new System.DateTime(2024, 1, 22, 7, 6, 21, 183);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("MesloLGL Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(9, 9);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(837, 130);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Reporte de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Fin:";
            // 
            // txtfechafin
            // 
            this.txtfechafin.Animated = true;
            this.txtfechafin.BorderRadius = 15;
            this.txtfechafin.Checked = true;
            this.txtfechafin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.FillColor = System.Drawing.SystemColors.Window;
            this.txtfechafin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtfechafin.Location = new System.Drawing.Point(732, 71);
            this.txtfechafin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtfechafin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(449, 59);
            this.txtfechafin.TabIndex = 5;
            this.txtfechafin.Value = new System.DateTime(2024, 1, 22, 7, 6, 21, 183);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Animated = true;
            this.btnbuscar.BorderRadius = 10;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbuscar.Font = new System.Drawing.Font("MesloLGL NF", 10F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Image = global::presentacion.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(1193, 71);
            this.btnbuscar.MinimumSize = new System.Drawing.Size(174, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(174, 59);
            this.btnbuscar.TabIndex = 67;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgreportesventa
            // 
            this.dgreportesventa.AllowUserToAddRows = false;
            this.dgreportesventa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgreportesventa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgreportesventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgreportesventa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgreportesventa.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportesventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgreportesventa.ColumnHeadersHeight = 30;
            this.dgreportesventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgreportesventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.tipodocumento,
            this.numerodocumento,
            this.usuarioregistro,
            this.documento,
            this.nombrecliente,
            this.codigoproducto,
            this.nombreproducto,
            this.categoria,
            this.precioventa,
            this.cantidad,
            this.subtotal,
            this.montototal});
            this.dgreportesventa.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgreportesventa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgreportesventa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgreportesventa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreportesventa.Location = new System.Drawing.Point(0, 0);
            this.dgreportesventa.Name = "dgreportesventa";
            this.dgreportesventa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportesventa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgreportesventa.RowHeadersVisible = false;
            this.dgreportesventa.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgreportesventa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgreportesventa.RowTemplate.Height = 24;
            this.dgreportesventa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgreportesventa.Size = new System.Drawing.Size(1486, 468);
            this.dgreportesventa.TabIndex = 69;
            this.dgreportesventa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgreportesventa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgreportesventa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgreportesventa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgreportesventa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgreportesventa.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgreportesventa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreportesventa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgreportesventa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgreportesventa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgreportesventa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgreportesventa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgreportesventa.ThemeStyle.HeaderStyle.Height = 30;
            this.dgreportesventa.ThemeStyle.ReadOnly = true;
            this.dgreportesventa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgreportesventa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgreportesventa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgreportesventa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgreportesventa.ThemeStyle.RowsStyle.Height = 24;
            this.dgreportesventa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgreportesventa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnexcel
            // 
            this.btnexcel.AnimatedGIF = true;
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexcel.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcel.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnexcel.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnexcel.ImageRotate = 0F;
            this.btnexcel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnexcel.Location = new System.Drawing.Point(251, 145);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnexcel.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexcel.Size = new System.Drawing.Size(63, 51);
            this.btnexcel.TabIndex = 70;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // listbuscar
            // 
            this.listbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listbuscar.Location = new System.Drawing.Point(645, 153);
            this.listbuscar.Name = "listbuscar";
            this.listbuscar.Size = new System.Drawing.Size(344, 36);
            this.listbuscar.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Buscar Por:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.BorderRadius = 10;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Location = new System.Drawing.Point(1008, 144);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.Size = new System.Drawing.Size(355, 62);
            this.txtbuscar.TabIndex = 74;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.38028F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.61972F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1492, 710);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgreportesventa);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 239);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1486, 468);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.Controls.Add(this.btnexcel);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtfechainicio);
            this.guna2Panel1.Controls.Add(this.txtbuscar);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.listbuscar);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtfechafin);
            this.guna2Panel1.Controls.Add(this.btnbuscar);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1486, 230);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Descargar En Excel";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 179;
            // 
            // tipodocumento
            // 
            this.tipodocumento.HeaderText = "Tipo Documento";
            this.tipodocumento.MinimumWidth = 6;
            this.tipodocumento.Name = "tipodocumento";
            this.tipodocumento.ReadOnly = true;
            this.tipodocumento.Width = 179;
            // 
            // numerodocumento
            // 
            this.numerodocumento.HeaderText = "Numero de Venta";
            this.numerodocumento.MinimumWidth = 6;
            this.numerodocumento.Name = "numerodocumento";
            this.numerodocumento.ReadOnly = true;
            this.numerodocumento.Width = 189;
            // 
            // usuarioregistro
            // 
            this.usuarioregistro.HeaderText = "Usuario";
            this.usuarioregistro.MinimumWidth = 6;
            this.usuarioregistro.Name = "usuarioregistro";
            this.usuarioregistro.ReadOnly = true;
            this.usuarioregistro.Width = 109;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento del cliente";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 249;
            // 
            // nombrecliente
            // 
            this.nombrecliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombrecliente.HeaderText = "Nombre del cliente";
            this.nombrecliente.MinimumWidth = 6;
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.ReadOnly = true;
            this.nombrecliente.Width = 219;
            // 
            // codigoproducto
            // 
            this.codigoproducto.HeaderText = "Codigo Producto";
            this.codigoproducto.MinimumWidth = 6;
            this.codigoproducto.Name = "codigoproducto";
            this.codigoproducto.ReadOnly = true;
            this.codigoproducto.Width = 189;
            // 
            // nombreproducto
            // 
            this.nombreproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreproducto.HeaderText = "Nombre del Producto";
            this.nombreproducto.MinimumWidth = 6;
            this.nombreproducto.Name = "nombreproducto";
            this.nombreproducto.ReadOnly = true;
            this.nombreproducto.Width = 229;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoria.FillWeight = 0.570844F;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 129;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioventa.HeaderText = "Precio de Venta";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.precioventa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioventa.Width = 166;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 119;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 129;
            // 
            // montototal
            // 
            this.montototal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.montototal.FillWeight = 113.9045F;
            this.montototal.HeaderText = "Monto Total";
            this.montototal.MinimumWidth = 6;
            this.montototal.Name = "montototal";
            this.montototal.ReadOnly = true;
            this.montototal.Width = 149;
            // 
            // frmReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1492, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReportesVentas";
            this.Text = "frmReportesVentas";
            this.Load += new System.EventHandler(this.frmReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgreportesventa)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker txtfechainicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtfechafin;
        private Guna.UI2.WinForms.Guna2Button btnbuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgreportesventa;
        private Guna.UI2.WinForms.Guna2ImageButton btnexcel;
        private Guna.UI2.WinForms.Guna2ComboBox listbuscar;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn montototal;
    }
}