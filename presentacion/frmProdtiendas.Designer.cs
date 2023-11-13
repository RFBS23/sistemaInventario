namespace presentacion
{
    partial class frmProdtiendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgverproductostienda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtindice = new Guna.UI2.WinForms.Guna2TextBox();
            this.idproductotienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgverproductostienda)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgverproductostienda
            // 
            this.dgverproductostienda.AllowUserToAddRows = false;
            this.dgverproductostienda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dgverproductostienda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgverproductostienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgverproductostienda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgverproductostienda.ColumnHeadersHeight = 30;
            this.dgverproductostienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgverproductostienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductotienda,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.nombrecategoria,
            this.nombretalla,
            this.colores,
            this.stock,
            this.numcaja,
            this.precioventa,
            this.fecharegistro,
            this.btneliminar});
            this.dgverproductostienda.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgverproductostienda.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgverproductostienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgverproductostienda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dgverproductostienda.Location = new System.Drawing.Point(0, 52);
            this.dgverproductostienda.Name = "dgverproductostienda";
            this.dgverproductostienda.ReadOnly = true;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("MesloLGL NF", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgverproductostienda.RowHeadersVisible = false;
            this.dgverproductostienda.RowHeadersWidth = 51;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("MesloLGL NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgverproductostienda.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgverproductostienda.RowTemplate.Height = 24;
            this.dgverproductostienda.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgverproductostienda.Size = new System.Drawing.Size(1326, 718);
            this.dgverproductostienda.TabIndex = 8;
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
            this.dgverproductostienda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MesloLGL NF", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgverproductostienda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgverproductostienda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgverproductostienda.ThemeStyle.HeaderStyle.Height = 30;
            this.dgverproductostienda.ThemeStyle.ReadOnly = true;
            this.dgverproductostienda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgverproductostienda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgverproductostienda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgverproductostienda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgverproductostienda.ThemeStyle.RowsStyle.Height = 24;
            this.dgverproductostienda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dgverproductostienda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgverproductostienda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgverproductostienda_CellContentClick);
            this.dgverproductostienda.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgverproductostienda_CellPainting);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.txtid);
            this.guna2Panel1.Controls.Add(this.txtindice);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1326, 52);
            this.guna2Panel1.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.BorderRadius = 10;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "0";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("MesloLGL NF", 10.2F);
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(71, 14);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(53, 29);
            this.txtid.TabIndex = 63;
            this.txtid.Visible = false;
            // 
            // txtindice
            // 
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
            this.txtindice.Location = new System.Drawing.Point(22, 14);
            this.txtindice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtindice.Name = "txtindice";
            this.txtindice.PasswordChar = '\0';
            this.txtindice.PlaceholderText = "";
            this.txtindice.SelectedText = "";
            this.txtindice.Size = new System.Drawing.Size(41, 29);
            this.txtindice.TabIndex = 62;
            this.txtindice.Visible = false;
            // 
            // idproductotienda
            // 
            this.idproductotienda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproductotienda.HeaderText = "idusuario";
            this.idproductotienda.MinimumWidth = 6;
            this.idproductotienda.Name = "idproductotienda";
            this.idproductotienda.ReadOnly = true;
            this.idproductotienda.Visible = false;
            this.idproductotienda.Width = 129;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle17;
            this.descripcion.FillWeight = 0.570844F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 149;
            // 
            // nombrecategoria
            // 
            this.nombrecategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombrecategoria.DefaultCellStyle = dataGridViewCellStyle18;
            this.nombrecategoria.HeaderText = "Categoria";
            this.nombrecategoria.MinimumWidth = 6;
            this.nombrecategoria.Name = "nombrecategoria";
            this.nombrecategoria.ReadOnly = true;
            this.nombrecategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombrecategoria.Width = 129;
            // 
            // nombretalla
            // 
            this.nombretalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretalla.DefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colores.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle21;
            this.stock.HeaderText = "Cantidades";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 139;
            // 
            // numcaja
            // 
            this.numcaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numcaja.DefaultCellStyle = dataGridViewCellStyle22;
            this.numcaja.HeaderText = "N° Caja";
            this.numcaja.MinimumWidth = 6;
            this.numcaja.Name = "numcaja";
            this.numcaja.ReadOnly = true;
            this.numcaja.Width = 109;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioventa.DefaultCellStyle = dataGridViewCellStyle23;
            this.precioventa.HeaderText = "Precio";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 99;
            // 
            // fecharegistro
            // 
            this.fecharegistro.HeaderText = "Fecha Añadida";
            this.fecharegistro.MinimumWidth = 6;
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Width = 169;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btneliminar.HeaderText = "Eliminar";
            this.btneliminar.MinimumWidth = 6;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Width = 96;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmProdtiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 770);
            this.Controls.Add(this.dgverproductostienda);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdtiendas";
            this.Text = "frmProdtiendas";
            this.Load += new System.EventHandler(this.frmProdtiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgverproductostienda)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgverproductostienda;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtindice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductotienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colores;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}