
namespace Multidesechables.FormsApp
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.tableClientes = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewBrand = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNuevoCliente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wrapperProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.wrapperProduct.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableClientes
            // 
            this.tableClientes.AllowUserToAddRows = false;
            this.tableClientes.AllowUserToDeleteRows = false;
            this.tableClientes.AllowUserToOrderColumns = true;
            this.tableClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableClientes.BackgroundColor = System.Drawing.Color.White;
            this.tableClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClientes.ColumnHeadersVisible = false;
            this.tableClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.eliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableClientes.GridColor = System.Drawing.Color.LightGray;
            this.tableClientes.Location = new System.Drawing.Point(22, 173);
            this.tableClientes.Name = "tableClientes";
            this.tableClientes.ReadOnly = true;
            this.tableClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableClientes.RowHeadersVisible = false;
            this.tableClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableClientes.Size = new System.Drawing.Size(1023, 373);
            this.tableClientes.TabIndex = 18;
            this.tableClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableClientes_CellContentClick);
            // 
            // editar
            // 
            this.editar.HeaderText = "editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 426;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 425;
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
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(79, 96);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 15);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(753, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "FECHA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(371, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "NOMBRE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(19, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "DOCUMENTO";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(50, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(45, 84);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(256, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(193)))), ((int)(((byte)(134)))));
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnNewBrand.BackColor = System.Drawing.SystemColors.Control;
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
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.ActiveBorderThickness = 1;
            this.btnNuevoCliente.ActiveCornerRadius = 20;
            this.btnNuevoCliente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNuevoCliente.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoCliente.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNuevoCliente.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.BackgroundImage")));
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoCliente.ButtonText = "NUEVO CLIENTE";
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.IdleBorderThickness = 1;
            this.btnNuevoCliente.IdleCornerRadius = 20;
            this.btnNuevoCliente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNuevoCliente.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevoCliente.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btnNuevoCliente.Location = new System.Drawing.Point(50, 22);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(194, 54);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            this.btnNuevoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNuevoCliente_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(22, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(336, 73);
            this.panel8.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(784, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 88);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(15, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 73);
            this.panel6.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(388, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 88);
            this.panel2.TabIndex = 1;
            // 
            // lblClientes
            // 
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Gray;
            this.lblClientes.Location = new System.Drawing.Point(215, 6);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(83, 48);
            this.lblClientes.TabIndex = 3;
            this.lblClientes.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lblClientes);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(9, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 79);
            this.panel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 88);
            this.panel1.TabIndex = 0;
            // 
            // wrapperProduct
            // 
            this.wrapperProduct.Controls.Add(this.panel1);
            this.wrapperProduct.Controls.Add(this.panel2);
            this.wrapperProduct.Controls.Add(this.panel3);
            this.wrapperProduct.Controls.Add(this.panel9);
            this.wrapperProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperProduct.Location = new System.Drawing.Point(0, 0);
            this.wrapperProduct.Name = "wrapperProduct";
            this.wrapperProduct.Size = new System.Drawing.Size(1166, 730);
            this.wrapperProduct.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.tableClientes);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.txtBuscar);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Controls.Add(this.pictureBox6);
            this.panel9.Controls.Add(this.btnExcel);
            this.panel9.Controls.Add(this.btnNewBrand);
            this.panel9.Controls.Add(this.btnNuevoCliente);
            this.panel9.Location = new System.Drawing.Point(3, 97);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1151, 600);
            this.panel9.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 730);
            this.Controls.Add(this.wrapperProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.wrapperProduct.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableClientes;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewBrand;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoCliente;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel wrapperProduct;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}