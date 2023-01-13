
namespace Multidesechables.FormsApp
{
    partial class FrmLogin
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radiusElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mostrarclave = new System.Windows.Forms.PictureBox();
            this.ocultarclave = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarclave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarclave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(this.pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(251, 427);
            panel1.TabIndex = 8;
            panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Multidesechables.FormsApp.Properties.Resources.Logo_modified;
            this.pictureBox1.Location = new System.Drawing.Point(28, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // radiusElipse
            // 
            this.radiusElipse.ElipseRadius = 10;
            this.radiusElipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN";
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpass.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textpass.Location = new System.Drawing.Point(328, 206);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(421, 20);
            this.textpass.TabIndex = 11;
            this.textpass.Text = "CONTRASEÑA";
            this.textpass.Enter += new System.EventHandler(this.textpass_Enter);
            this.textpass.Leave += new System.EventHandler(this.textpass_Leave);
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textuser.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textuser.Location = new System.Drawing.Point(328, 102);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(421, 20);
            this.textuser.TabIndex = 10;
            this.textuser.Text = "USUARIO";
            this.textuser.Enter += new System.EventHandler(this.textuser_Enter);
            this.textuser.Leave += new System.EventHandler(this.textuser_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(827, 427);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 317;
            this.lineShape2.X2 = 768;
            this.lineShape2.Y1 = 235;
            this.lineShape2.Y2 = 235;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 317;
            this.lineShape1.X2 = 768;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 130;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.BorderRadius = 7;
            this.btnIngresar.ButtonText = "INGRESAR";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresar.Iconimage = null;
            this.btnIngresar.Iconimage_right = null;
            this.btnIngresar.Iconimage_right_Selected = null;
            this.btnIngresar.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Iconimage_Selected")));
            this.btnIngresar.IconMarginLeft = 0;
            this.btnIngresar.IconMarginRight = 0;
            this.btnIngresar.IconRightVisible = true;
            this.btnIngresar.IconRightZoom = 0D;
            this.btnIngresar.IconVisible = true;
            this.btnIngresar.IconZoom = 50D;
            this.btnIngresar.IsTab = false;
            this.btnIngresar.Location = new System.Drawing.Point(317, 348);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnIngresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.btnIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresar.selected = false;
            this.btnIngresar.Size = new System.Drawing.Size(185, 37);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.Textcolor = System.Drawing.Color.White;
            this.btnIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 7;
            this.btnCancelar.ButtonText = "CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage_Selected")));
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 50D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(584, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(185, 37);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mostrarclave
            // 
            this.mostrarclave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostrarclave.Image = ((System.Drawing.Image)(resources.GetObject("mostrarclave.Image")));
            this.mostrarclave.Location = new System.Drawing.Point(717, 206);
            this.mostrarclave.Name = "mostrarclave";
            this.mostrarclave.Size = new System.Drawing.Size(20, 20);
            this.mostrarclave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mostrarclave.TabIndex = 20;
            this.mostrarclave.TabStop = false;
            this.mostrarclave.Click += new System.EventHandler(this.mostrarclave_Click);
            // 
            // ocultarclave
            // 
            this.ocultarclave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultarclave.Image = ((System.Drawing.Image)(resources.GetObject("ocultarclave.Image")));
            this.ocultarclave.Location = new System.Drawing.Point(717, 206);
            this.ocultarclave.Name = "ocultarclave";
            this.ocultarclave.Size = new System.Drawing.Size(20, 20);
            this.ocultarclave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarclave.TabIndex = 22;
            this.ocultarclave.TabStop = false;
            this.ocultarclave.Click += new System.EventHandler(this.ocultarclave_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(827, 427);
            this.Controls.Add(this.mostrarclave);
            this.Controls.Add(this.ocultarclave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarclave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarclave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse radiusElipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textuser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.PictureBox mostrarclave;
        private System.Windows.Forms.PictureBox ocultarclave;
    }
}