
namespace Multidesechables.FormsApp.Herramientas
{
    partial class FrmInicioBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioBarra));
            this.btngenerarmanualmente = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btngenerarmasivamente = new FontAwesome.Sharp.IconButton();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenerarmanualmente
            // 
            this.btngenerarmanualmente.BackColor = System.Drawing.SystemColors.Control;
            this.btngenerarmanualmente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarmanualmente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btngenerarmanualmente.FlatAppearance.BorderSize = 2;
            this.btngenerarmanualmente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarmanualmente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarmanualmente.ForeColor = System.Drawing.Color.Black;
            this.btngenerarmanualmente.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btngenerarmanualmente.IconColor = System.Drawing.Color.Black;
            this.btngenerarmanualmente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarmanualmente.IconSize = 100;
            this.btngenerarmanualmente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerarmanualmente.Location = new System.Drawing.Point(38, 73);
            this.btngenerarmanualmente.Name = "btngenerarmanualmente";
            this.btngenerarmanualmente.Size = new System.Drawing.Size(143, 134);
            this.btngenerarmanualmente.TabIndex = 59;
            this.btngenerarmanualmente.Text = "Generar Manualmente";
            this.btngenerarmanualmente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarmanualmente.UseVisualStyleBackColor = false;
            this.btngenerarmanualmente.Click += new System.EventHandler(this.btngenerarmanualmente_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(444, 37);
            this.label1.TabIndex = 58;
            this.label1.Text = " GENERADOR DE CODIGO BARRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btngenerarmasivamente
            // 
            this.btngenerarmasivamente.BackColor = System.Drawing.SystemColors.Control;
            this.btngenerarmasivamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarmasivamente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btngenerarmasivamente.FlatAppearance.BorderSize = 2;
            this.btngenerarmasivamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarmasivamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarmasivamente.ForeColor = System.Drawing.Color.Black;
            this.btngenerarmasivamente.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btngenerarmasivamente.IconColor = System.Drawing.Color.Black;
            this.btngenerarmasivamente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarmasivamente.IconSize = 100;
            this.btngenerarmasivamente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerarmasivamente.Location = new System.Drawing.Point(258, 73);
            this.btngenerarmasivamente.Name = "btngenerarmasivamente";
            this.btngenerarmasivamente.Size = new System.Drawing.Size(143, 134);
            this.btngenerarmasivamente.TabIndex = 57;
            this.btngenerarmasivamente.Text = "Generar Masivamente";
            this.btngenerarmasivamente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarmasivamente.UseVisualStyleBackColor = false;
            this.btngenerarmasivamente.Click += new System.EventHandler(this.btngenerarmasivamente_Click);
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.cerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormulario.Image")));
            this.cerrarFormulario.Location = new System.Drawing.Point(396, 0);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(48, 37);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarFormulario.TabIndex = 60;
            this.cerrarFormulario.TabStop = false;
            this.cerrarFormulario.Click += new System.EventHandler(this.cerrarFormulario_Click);
            // 
            // FrmInicioBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 222);
            this.Controls.Add(this.cerrarFormulario);
            this.Controls.Add(this.btngenerarmanualmente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngenerarmasivamente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicioBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicioBarra";
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btngenerarmanualmente;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btngenerarmasivamente;
        private System.Windows.Forms.PictureBox cerrarFormulario;
    }
}