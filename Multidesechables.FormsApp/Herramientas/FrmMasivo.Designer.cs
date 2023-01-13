
namespace Multidesechables.FormsApp.Herramientas
{
    partial class FrmMasivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasivo));
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btngenerardocumento = new FontAwesome.Sharp.IconButton();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            this.btncargar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.lblresumen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cboorientacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbotipocodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkmostrardescripcion = new System.Windows.Forms.CheckBox();
            this.chkmostrarcodigo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngenerarimagen = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // btngenerardocumento
            // 
            this.btngenerardocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btngenerardocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerardocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerardocumento.ForeColor = System.Drawing.Color.White;
            this.btngenerardocumento.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btngenerardocumento.IconColor = System.Drawing.Color.White;
            this.btngenerardocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerardocumento.IconSize = 40;
            this.btngenerardocumento.Location = new System.Drawing.Point(333, 220);
            this.btngenerardocumento.Name = "btngenerardocumento";
            this.btngenerardocumento.Size = new System.Drawing.Size(125, 52);
            this.btngenerardocumento.TabIndex = 146;
            this.btngenerardocumento.Text = "Generar Documento";
            this.btngenerardocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerardocumento.UseVisualStyleBackColor = false;
            this.btngenerardocumento.Click += new System.EventHandler(this.btngenerardocumento_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btndescargar.IconColor = System.Drawing.Color.ForestGreen;
            this.btndescargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btndescargar.IconSize = 17;
            this.btndescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndescargar.Location = new System.Drawing.Point(451, 45);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(120, 21);
            this.btndescargar.TabIndex = 140;
            this.btndescargar.Text = "Descargar Plantilla";
            this.btndescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncargar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btncargar.IconColor = System.Drawing.Color.RoyalBlue;
            this.btncargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncargar.IconSize = 18;
            this.btncargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncargar.Location = new System.Drawing.Point(451, 19);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(120, 21);
            this.btncargar.TabIndex = 139;
            this.btncargar.Text = "Cargar";
            this.btncargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndescargar);
            this.groupBox1.Controls.Add(this.btncargar);
            this.groupBox1.Controls.Add(this.txtarchivo);
            this.groupBox1.Controls.Add(this.lblresumen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 75);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo";
            // 
            // txtarchivo
            // 
            this.txtarchivo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtarchivo.Location = new System.Drawing.Point(76, 20);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.ReadOnly = true;
            this.txtarchivo.Size = new System.Drawing.Size(369, 20);
            this.txtarchivo.TabIndex = 136;
            // 
            // lblresumen
            // 
            this.lblresumen.AutoSize = true;
            this.lblresumen.BackColor = System.Drawing.Color.White;
            this.lblresumen.ForeColor = System.Drawing.Color.Blue;
            this.lblresumen.Location = new System.Drawing.Point(77, 47);
            this.lblresumen.Name = "lblresumen";
            this.lblresumen.Size = new System.Drawing.Size(57, 13);
            this.lblresumen.TabIndex = 138;
            this.lblresumen.Text = "lblresumen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "Seleccionar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Resumen :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 220);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 50);
            this.progressBar1.TabIndex = 144;
            // 
            // cboorientacion
            // 
            this.cboorientacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboorientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboorientacion.FormattingEnabled = true;
            this.cboorientacion.Location = new System.Drawing.Point(135, 46);
            this.cboorientacion.Name = "cboorientacion";
            this.cboorientacion.Size = new System.Drawing.Size(164, 21);
            this.cboorientacion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Orientación Documento:";
            // 
            // cbotipocodigo
            // 
            this.cbotipocodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipocodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipocodigo.FormattingEnabled = true;
            this.cbotipocodigo.Location = new System.Drawing.Point(135, 19);
            this.cbotipocodigo.Name = "cbotipocodigo";
            this.cbotipocodigo.Size = new System.Drawing.Size(164, 21);
            this.cbotipocodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Codigo:";
            // 
            // chkmostrardescripcion
            // 
            this.chkmostrardescripcion.AutoSize = true;
            this.chkmostrardescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkmostrardescripcion.Location = new System.Drawing.Point(135, 21);
            this.chkmostrardescripcion.Name = "chkmostrardescripcion";
            this.chkmostrardescripcion.Size = new System.Drawing.Size(120, 17);
            this.chkmostrardescripcion.TabIndex = 1;
            this.chkmostrardescripcion.Text = "Mostrar Descripción";
            this.chkmostrardescripcion.UseVisualStyleBackColor = true;
            // 
            // chkmostrarcodigo
            // 
            this.chkmostrarcodigo.AutoSize = true;
            this.chkmostrarcodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkmostrarcodigo.Location = new System.Drawing.Point(16, 21);
            this.chkmostrarcodigo.Name = "chkmostrarcodigo";
            this.chkmostrarcodigo.Size = new System.Drawing.Size(97, 17);
            this.chkmostrarcodigo.TabIndex = 0;
            this.chkmostrarcodigo.Text = "Mostrar Codigo";
            this.chkmostrarcodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkmostrardescripcion);
            this.groupBox3.Controls.Add(this.chkmostrarcodigo);
            this.groupBox3.Location = new System.Drawing.Point(305, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 48);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "En Etiqueta";
            // 
            // btngenerarimagen
            // 
            this.btngenerarimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btngenerarimagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarimagen.ForeColor = System.Drawing.Color.White;
            this.btngenerarimagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btngenerarimagen.IconColor = System.Drawing.Color.White;
            this.btngenerarimagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarimagen.IconSize = 40;
            this.btngenerarimagen.Location = new System.Drawing.Point(483, 220);
            this.btngenerarimagen.Name = "btngenerarimagen";
            this.btngenerarimagen.Size = new System.Drawing.Size(125, 52);
            this.btngenerarimagen.TabIndex = 148;
            this.btngenerarimagen.Text = "Generar Imagen";
            this.btngenerarimagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarimagen.UseVisualStyleBackColor = false;
            this.btngenerarimagen.Click += new System.EventHandler(this.btngenerarimagen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cboorientacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbotipocodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 77);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion";
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.cerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormulario.Image")));
            this.cerrarFormulario.Location = new System.Drawing.Point(609, 3);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(52, 34);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarFormulario.TabIndex = 149;
            this.cerrarFormulario.TabStop = false;
            this.cerrarFormulario.Click += new System.EventHandler(this.cerrarFormulario_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.cerrarFormulario);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(661, 37);
            this.header.TabIndex = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Multidesechables.FormsApp.Properties.Resources.Logo_modified;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 317);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btngenerardocumento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btngenerarimagen);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMasivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMasivo";
            this.Load += new System.EventHandler(this.FrmMasivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btngenerardocumento;
        private FontAwesome.Sharp.IconButton btndescargar;
        private FontAwesome.Sharp.IconButton btncargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.Label lblresumen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cboorientacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbotipocodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkmostrardescripcion;
        private System.Windows.Forms.CheckBox chkmostrarcodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btngenerarimagen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox cerrarFormulario;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}