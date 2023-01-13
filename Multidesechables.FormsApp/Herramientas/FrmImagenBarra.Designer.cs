
namespace Multidesechables.FormsApp.Herramientas
{
    partial class FrmImagenBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagenBarra));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btngenerarimagen = new FontAwesome.Sharp.IconButton();
            this.btngenerardocumento = new FontAwesome.Sharp.IconButton();
            this.cboorientacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbotipocodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkmostrardescripcion = new System.Windows.Forms.CheckBox();
            this.chkmostrarcodigo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnumeroetiquetas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroetiquetas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
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
            this.btngenerarimagen.Location = new System.Drawing.Point(690, 176);
            this.btngenerarimagen.Name = "btngenerarimagen";
            this.btngenerarimagen.Size = new System.Drawing.Size(125, 52);
            this.btngenerarimagen.TabIndex = 17;
            this.btngenerarimagen.Text = "Generar Imagen";
            this.btngenerarimagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarimagen.UseVisualStyleBackColor = false;
            this.btngenerarimagen.Click += new System.EventHandler(this.btngenerarimagen_Click);
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
            this.btngenerardocumento.Location = new System.Drawing.Point(690, 113);
            this.btngenerardocumento.Name = "btngenerardocumento";
            this.btngenerardocumento.Size = new System.Drawing.Size(125, 52);
            this.btngenerardocumento.TabIndex = 16;
            this.btngenerardocumento.Text = "Generar Documento";
            this.btngenerardocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerardocumento.UseVisualStyleBackColor = false;
            this.btngenerardocumento.Click += new System.EventHandler(this.btngenerardocumento_Click);
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
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.progressBar1.Location = new System.Drawing.Point(7, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(671, 31);
            this.progressBar1.TabIndex = 18;
            // 
            // chkmostrardescripcion
            // 
            this.chkmostrardescripcion.AutoSize = true;
            this.chkmostrardescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkmostrardescripcion.Location = new System.Drawing.Point(130, 20);
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
            this.chkmostrarcodigo.Location = new System.Drawing.Point(11, 20);
            this.chkmostrarcodigo.Name = "chkmostrarcodigo";
            this.chkmostrarcodigo.Size = new System.Drawing.Size(97, 17);
            this.chkmostrarcodigo.TabIndex = 0;
            this.chkmostrarcodigo.Text = "Mostrar Codigo";
            this.chkmostrarcodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cboorientacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbotipocodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(379, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 125);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkmostrardescripcion);
            this.groupBox3.Controls.Add(this.chkmostrarcodigo);
            this.groupBox3.Location = new System.Drawing.Point(10, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "En Etiqueta";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(114, 43);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(219, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // txtnumeroetiquetas
            // 
            this.txtnumeroetiquetas.Location = new System.Drawing.Point(114, 99);
            this.txtnumeroetiquetas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtnumeroetiquetas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnumeroetiquetas.Name = "txtnumeroetiquetas";
            this.txtnumeroetiquetas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnumeroetiquetas.Size = new System.Drawing.Size(219, 20);
            this.txtnumeroetiquetas.TabIndex = 7;
            this.txtnumeroetiquetas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(114, 70);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de Etiquetas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnumeroetiquetas);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etiqueta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 296;
            this.label6.Text = "Buscar Productos";
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(114, 12);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(37, 23);
            this.btnbuscarproducto.TabIndex = 295;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.cerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormulario.Image")));
            this.cerrarFormulario.Location = new System.Drawing.Point(816, 3);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(48, 31);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarFormulario.TabIndex = 61;
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
            this.header.Size = new System.Drawing.Size(867, 37);
            this.header.TabIndex = 151;
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
            // FrmImagenBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btngenerarimagen);
            this.Controls.Add(this.btngenerardocumento);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImagenBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImagenBarra";
            this.Load += new System.EventHandler(this.FrmImagenBarra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroetiquetas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btngenerarimagen;
        private FontAwesome.Sharp.IconButton btngenerardocumento;
        private System.Windows.Forms.ComboBox cboorientacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbotipocodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkmostrardescripcion;
        private System.Windows.Forms.CheckBox chkmostrarcodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.NumericUpDown txtnumeroetiquetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox cerrarFormulario;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
    }
}