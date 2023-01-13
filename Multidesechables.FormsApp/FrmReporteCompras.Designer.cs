
namespace Multidesechables.FormsApp
{
    partial class FrmReporteCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexportar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscarresultado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboproveedor = new System.Windows.Forms.ComboBox();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxNUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tablerepotecompras = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewBrand = new Bunifu.Framework.UI.BunifuThinButton2();
            this.wrapperProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablerepotecompras)).BeginInit();
            this.wrapperProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(524, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 243;
            this.label4.Text = "PROVEEDOR";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnexportar
            // 
            this.btnexportar.Activecolor = System.Drawing.Color.Green;
            this.btnexportar.BackColor = System.Drawing.Color.Green;
            this.btnexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexportar.BorderRadius = 7;
            this.btnexportar.ButtonText = "DESCARGAR";
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.DisabledColor = System.Drawing.Color.Gray;
            this.btnexportar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnexportar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnexportar.Iconimage")));
            this.btnexportar.Iconimage_right = null;
            this.btnexportar.Iconimage_right_Selected = null;
            this.btnexportar.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnexportar.Iconimage_Selected")));
            this.btnexportar.IconMarginLeft = 0;
            this.btnexportar.IconMarginRight = 0;
            this.btnexportar.IconRightVisible = true;
            this.btnexportar.IconRightZoom = 0D;
            this.btnexportar.IconVisible = true;
            this.btnexportar.IconZoom = 50D;
            this.btnexportar.IsTab = false;
            this.btnexportar.Location = new System.Drawing.Point(53, 129);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Normalcolor = System.Drawing.Color.Green;
            this.btnexportar.OnHovercolor = System.Drawing.Color.Lime;
            this.btnexportar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnexportar.selected = false;
            this.btnexportar.Size = new System.Drawing.Size(123, 31);
            this.btnexportar.TabIndex = 246;
            this.btnexportar.Text = "DESCARGAR";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnexportar.Textcolor = System.Drawing.Color.White;
            this.btnexportar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 237;
            this.label1.Text = "FECHA INICIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(189, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 238;
            this.label6.Text = "BUSCAR POR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(280, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 242;
            this.label3.Text = "FECHA FIN";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // btnbuscarresultado
            // 
            this.btnbuscarresultado.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarresultado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarresultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarresultado.BorderRadius = 7;
            this.btnbuscarresultado.ButtonText = "BUSCAR";
            this.btnbuscarresultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarresultado.DisabledColor = System.Drawing.Color.White;
            this.btnbuscarresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarresultado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnbuscarresultado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnbuscarresultado.Iconimage")));
            this.btnbuscarresultado.Iconimage_right = null;
            this.btnbuscarresultado.Iconimage_right_Selected = null;
            this.btnbuscarresultado.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnbuscarresultado.Iconimage_Selected")));
            this.btnbuscarresultado.IconMarginLeft = 0;
            this.btnbuscarresultado.IconMarginRight = 0;
            this.btnbuscarresultado.IconRightVisible = true;
            this.btnbuscarresultado.IconRightZoom = 0D;
            this.btnbuscarresultado.IconVisible = true;
            this.btnbuscarresultado.IconZoom = 50D;
            this.btnbuscarresultado.IsTab = false;
            this.btnbuscarresultado.Location = new System.Drawing.Point(898, 38);
            this.btnbuscarresultado.Name = "btnbuscarresultado";
            this.btnbuscarresultado.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarresultado.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarresultado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnbuscarresultado.selected = false;
            this.btnbuscarresultado.Size = new System.Drawing.Size(99, 31);
            this.btnbuscarresultado.TabIndex = 247;
            this.btnbuscarresultado.Text = "BUSCAR";
            this.btnbuscarresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbuscarresultado.Textcolor = System.Drawing.Color.White;
            this.btnbuscarresultado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarresultado.Click += new System.EventHandler(this.btnbuscarresultado_Click);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbusqueda);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnexportar);
            this.panel1.Controls.Add(this.btnlimpiarbuscador);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.cbobusqueda);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBoxNUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 169);
            this.panel1.TabIndex = 0;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusqueda.Location = new System.Drawing.Point(507, 134);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(152, 13);
            this.txtbusqueda.TabIndex = 243;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(949, 131);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 245;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.White;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(895, 132);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(42, 23);
            this.btnbuscar.TabIndex = 244;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(341, 132);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(116, 21);
            this.cbobusqueda.TabIndex = 242;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnbuscarresultado);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cboproveedor);
            this.panel5.Controls.Add(this.txtfechafin);
            this.panel5.Controls.Add(this.txtfechainicio);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(-3, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1169, 108);
            this.panel5.TabIndex = 2;
            // 
            // cboproveedor
            // 
            this.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproveedor.FormattingEnabled = true;
            this.cboproveedor.Location = new System.Drawing.Point(633, 48);
            this.cboproveedor.Name = "cboproveedor";
            this.cboproveedor.Size = new System.Drawing.Size(177, 21);
            this.cboproveedor.TabIndex = 240;
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(372, 49);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(97, 20);
            this.txtfechafin.TabIndex = 238;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(166, 49);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 234;
            this.label2.Text = "Reporte Compras";
            // 
            // pictureBoxNUsuario
            // 
            this.pictureBoxNUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNUsuario.Image")));
            this.pictureBoxNUsuario.Location = new System.Drawing.Point(498, 126);
            this.pictureBoxNUsuario.Name = "pictureBoxNUsuario";
            this.pictureBoxNUsuario.Size = new System.Drawing.Size(180, 34);
            this.pictureBoxNUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNUsuario.TabIndex = 247;
            this.pictureBoxNUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 248;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.tablerepotecompras);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.btnExcel);
            this.panel9.Controls.Add(this.btnNewBrand);
            this.panel9.Location = new System.Drawing.Point(3, 178);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1153, 486);
            this.panel9.TabIndex = 5;
            // 
            // tablerepotecompras
            // 
            this.tablerepotecompras.AllowUserToAddRows = false;
            this.tablerepotecompras.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablerepotecompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablerepotecompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablerepotecompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablerepotecompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.tablerepotecompras.EnableHeadersVisualStyles = false;
            this.tablerepotecompras.Location = new System.Drawing.Point(53, 45);
            this.tablerepotecompras.MultiSelect = false;
            this.tablerepotecompras.Name = "tablerepotecompras";
            this.tablerepotecompras.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tablerepotecompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablerepotecompras.RowTemplate.Height = 28;
            this.tablerepotecompras.Size = new System.Drawing.Size(948, 386);
            this.tablerepotecompras.TabIndex = 236;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(1345, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "EDITAR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(1482, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "ELIMINAR";
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.ButtonText = "EXCEL";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleCornerRadius = 20;
            this.btnExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.IdleForecolor = System.Drawing.Color.White;
            this.btnExcel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.Location = new System.Drawing.Point(1382, 90);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(201, 54);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewBrand
            // 
            this.btnNewBrand.ActiveBorderThickness = 1;
            this.btnNewBrand.ActiveCornerRadius = 20;
            this.btnNewBrand.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNewBrand.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewBrand.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNewBrand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewBrand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewBrand.BackgroundImage")));
            this.btnNewBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewBrand.ButtonText = "NUEVA MARCA";
            this.btnNewBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBrand.ForeColor = System.Drawing.Color.White;
            this.btnNewBrand.IdleBorderThickness = 1;
            this.btnNewBrand.IdleCornerRadius = 20;
            this.btnNewBrand.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNewBrand.IdleForecolor = System.Drawing.Color.White;
            this.btnNewBrand.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNewBrand.Location = new System.Drawing.Point(1382, 22);
            this.btnNewBrand.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNewBrand.Name = "btnNewBrand";
            this.btnNewBrand.Size = new System.Drawing.Size(201, 54);
            this.btnNewBrand.TabIndex = 2;
            this.btnNewBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrapperProduct
            // 
            this.wrapperProduct.Controls.Add(this.panel1);
            this.wrapperProduct.Controls.Add(this.panel9);
            this.wrapperProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperProduct.Location = new System.Drawing.Point(0, 0);
            this.wrapperProduct.Name = "wrapperProduct";
            this.wrapperProduct.Size = new System.Drawing.Size(1166, 730);
            this.wrapperProduct.TabIndex = 3;
            // 
            // FrmReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 730);
            this.Controls.Add(this.wrapperProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteCompras";
            this.Text = "FrmReporteCompras";
            this.Load += new System.EventHandler(this.FrmReporteCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablerepotecompras)).EndInit();
            this.wrapperProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnexportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private Bunifu.Framework.UI.BunifuFlatButton btnbuscarresultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboproveedor;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView tablerepotecompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewBrand;
        private System.Windows.Forms.FlowLayoutPanel wrapperProduct;
        private System.Windows.Forms.PictureBox pictureBoxNUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}