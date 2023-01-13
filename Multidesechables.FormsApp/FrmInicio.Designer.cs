
namespace Multidesechables.FormsApp
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menumantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuempleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuestadostock = new FontAwesome.Sharp.IconMenuItem();
            this.menureporteventas = new FontAwesome.Sharp.IconMenuItem();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.Panel();
            this.imagenFondo = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pictureBox1.Image = global::Multidesechables.FormsApp.Properties.Resources.Logo_modified;
            this.pictureBox1.Location = new System.Drawing.Point(31, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // menumantenimiento
            // 
            this.menumantenimiento.AutoSize = false;
            this.menumantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menumantenimiento.ForeColor = System.Drawing.Color.White;
            this.menumantenimiento.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menumantenimiento.IconColor = System.Drawing.Color.White;
            this.menumantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenimiento.IconSize = 25;
            this.menumantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenimiento.Name = "menumantenimiento";
            this.menumantenimiento.Size = new System.Drawing.Size(150, 45);
            this.menumantenimiento.Text = "Mantenimiento";
            this.menumantenimiento.Click += new System.EventHandler(this.menumantenimiento_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menureportes.ForeColor = System.Drawing.Color.White;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.White;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 25;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(150, 45);
            this.menureportes.Text = "Reporte Compra";
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuproveedores.ForeColor = System.Drawing.Color.White;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.White;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 25;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(150, 45);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuclientes.ForeColor = System.Drawing.Color.White;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuclientes.IconColor = System.Drawing.Color.White;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 25;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(150, 45);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menucompras.ForeColor = System.Drawing.Color.White;
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompras.IconColor = System.Drawing.Color.White;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 25;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(150, 45);
            this.menucompras.Text = "Compras";
            this.menucompras.Click += new System.EventHandler(this.menucompras_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuventas.ForeColor = System.Drawing.Color.White;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.White;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 25;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(150, 45);
            this.menuventas.Text = "Ventas";
            this.menuventas.Click += new System.EventHandler(this.menuventas_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuproductos.ForeColor = System.Drawing.Color.White;
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuproductos.IconColor = System.Drawing.Color.White;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.IconSize = 25;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(150, 45);
            this.menuproductos.Text = "Productos";
            this.menuproductos.Click += new System.EventHandler(this.menuproductos_Click);
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuusuarios.ForeColor = System.Drawing.Color.White;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuusuarios.IconColor = System.Drawing.Color.White;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 25;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(150, 45);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menuproductos,
            this.menucompras,
            this.menuventas,
            this.menuproveedores,
            this.menuclientes,
            this.menuempleados,
            this.menuestadostock,
            this.menureportes,
            this.menureporteventas,
            this.menumantenimiento});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 38);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(15, 150, 15, 2);
            this.menu.Size = new System.Drawing.Size(200, 692);
            this.menu.TabIndex = 26;
            this.menu.Text = "menuStrip1";
            // 
            // menuempleados
            // 
            this.menuempleados.AutoSize = false;
            this.menuempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuempleados.ForeColor = System.Drawing.Color.White;
            this.menuempleados.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.menuempleados.IconColor = System.Drawing.Color.White;
            this.menuempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuempleados.IconSize = 25;
            this.menuempleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuempleados.Name = "menuempleados";
            this.menuempleados.Size = new System.Drawing.Size(150, 45);
            this.menuempleados.Text = "Empleados";
            this.menuempleados.Click += new System.EventHandler(this.menuempleados_Click);
            // 
            // menuestadostock
            // 
            this.menuestadostock.AutoSize = false;
            this.menuestadostock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuestadostock.ForeColor = System.Drawing.Color.White;
            this.menuestadostock.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.menuestadostock.IconColor = System.Drawing.Color.White;
            this.menuestadostock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuestadostock.IconSize = 25;
            this.menuestadostock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuestadostock.Name = "menuestadostock";
            this.menuestadostock.Size = new System.Drawing.Size(150, 45);
            this.menuestadostock.Text = "Estado de Producto";
            this.menuestadostock.Click += new System.EventHandler(this.menuestadostock_Click);
            // 
            // menureporteventas
            // 
            this.menureporteventas.AutoSize = false;
            this.menureporteventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menureporteventas.ForeColor = System.Drawing.Color.White;
            this.menureporteventas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureporteventas.IconColor = System.Drawing.Color.White;
            this.menureporteventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureporteventas.IconSize = 25;
            this.menureporteventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureporteventas.Name = "menureporteventas";
            this.menureporteventas.Size = new System.Drawing.Size(150, 45);
            this.menureporteventas.Text = "Reporte Ventas";
            this.menureporteventas.Click += new System.EventHandler(this.ReporteVentas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1134, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1082, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1013, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(51, 32);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1086, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(31, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contenedor.Controls.Add(this.imagenFondo);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(200, 38);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(966, 692);
            this.contenedor.TabIndex = 28;
            // 
            // imagenFondo
            // 
            this.imagenFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.imagenFondo.Image = ((System.Drawing.Image)(resources.GetObject("imagenFondo.Image")));
            this.imagenFondo.Location = new System.Drawing.Point(0, 0);
            this.imagenFondo.Name = "imagenFondo";
            this.imagenFondo.Size = new System.Drawing.Size(1166, 730);
            this.imagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenFondo.TabIndex = 26;
            this.imagenFondo.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(27, 153);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(133, 22);
            this.lblusuario.TabIndex = 27;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.BarraTitulo.Controls.Add(this.LblHora);
            this.BarraTitulo.Controls.Add(this.pictureBox2);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1166, 38);
            this.BarraTitulo.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.LblHora.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHora.Location = new System.Drawing.Point(194, 4);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(64, 31);
            this.LblHora.TabIndex = 28;
            this.LblHora.Text = "label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem menumantenimiento;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imagenFondo;
        private FontAwesome.Sharp.IconMenuItem menureporteventas;
        private FontAwesome.Sharp.IconMenuItem menuempleados;
        private FontAwesome.Sharp.IconMenuItem menuestadostock;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer1;
    }
}