
namespace Multidesechables.FormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.wrapperProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNewBrand = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btndatosnegocio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btngenerarcodigo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.wrapperProduct.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(-3, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1169, 54);
            this.panel5.TabIndex = 2;
            // 
            // wrapperProduct
            // 
            this.wrapperProduct.Controls.Add(this.panel1);
            this.wrapperProduct.Controls.Add(this.panel9);
            this.wrapperProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperProduct.Location = new System.Drawing.Point(0, 0);
            this.wrapperProduct.Name = "wrapperProduct";
            this.wrapperProduct.Size = new System.Drawing.Size(1194, 770);
            this.wrapperProduct.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.bunifuThinButton22);
            this.panel9.Controls.Add(this.btndatosnegocio);
            this.panel9.Controls.Add(this.btngenerarcodigo);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.btnExcel);
            this.panel9.Controls.Add(this.btnNewBrand);
            this.panel9.Location = new System.Drawing.Point(3, 85);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1153, 507);
            this.panel9.TabIndex = 5;
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
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.bunifuThinButton22.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton22.ButtonText = "********";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(864, 90);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(200, 200);
            this.bunifuThinButton22.TabIndex = 23;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndatosnegocio
            // 
            this.btndatosnegocio.ActiveBorderThickness = 1;
            this.btndatosnegocio.ActiveCornerRadius = 20;
            this.btndatosnegocio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btndatosnegocio.ActiveForecolor = System.Drawing.Color.White;
            this.btndatosnegocio.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btndatosnegocio.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btndatosnegocio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndatosnegocio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndatosnegocio.BackgroundImage")));
            this.btndatosnegocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndatosnegocio.ButtonText = "DATOS DE NEGOCIO";
            this.btndatosnegocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndatosnegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatosnegocio.ForeColor = System.Drawing.Color.White;
            this.btndatosnegocio.IdleBorderThickness = 1;
            this.btndatosnegocio.IdleCornerRadius = 20;
            this.btndatosnegocio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btndatosnegocio.IdleForecolor = System.Drawing.Color.White;
            this.btndatosnegocio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btndatosnegocio.Location = new System.Drawing.Point(463, 90);
            this.btndatosnegocio.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.btndatosnegocio.Name = "btndatosnegocio";
            this.btndatosnegocio.Size = new System.Drawing.Size(200, 200);
            this.btndatosnegocio.TabIndex = 22;
            this.btndatosnegocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btngenerarcodigo
            // 
            this.btngenerarcodigo.ActiveBorderThickness = 1;
            this.btngenerarcodigo.ActiveCornerRadius = 20;
            this.btngenerarcodigo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btngenerarcodigo.ActiveForecolor = System.Drawing.Color.White;
            this.btngenerarcodigo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btngenerarcodigo.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btngenerarcodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btngenerarcodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngenerarcodigo.BackgroundImage")));
            this.btngenerarcodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngenerarcodigo.ButtonText = "GENERAR CODIGO BARRA";
            this.btngenerarcodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcodigo.ForeColor = System.Drawing.Color.White;
            this.btngenerarcodigo.IdleBorderThickness = 1;
            this.btngenerarcodigo.IdleCornerRadius = 20;
            this.btngenerarcodigo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btngenerarcodigo.IdleForecolor = System.Drawing.Color.White;
            this.btngenerarcodigo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.btngenerarcodigo.Location = new System.Drawing.Point(58, 90);
            this.btngenerarcodigo.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.btngenerarcodigo.Name = "btngenerarcodigo";
            this.btngenerarcodigo.Size = new System.Drawing.Size(200, 200);
            this.btngenerarcodigo.TabIndex = 21;
            this.btngenerarcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(813, 33);
            this.label4.TabIndex = 75;
            this.label4.Text = "HAS ENTRADO AL MODULO DE MANTENIMIENTO DEL SISTEMA EL CUAL TIENEN ACESSO LOS ADMI" +
    "NISTRADORES TENEN CUENTA QUE CUALQUIER CAMBIO QUE SE HAGA  DENTRO DE ESTE MODULO" +
    " PUEDE INTERFERIR EN TODO EL SISTEMA ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(49, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 770);
            this.Controls.Add(this.wrapperProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.wrapperProduct.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel wrapperProduct;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewBrand;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 btndatosnegocio;
        private Bunifu.Framework.UI.BunifuThinButton2 btngenerarcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

