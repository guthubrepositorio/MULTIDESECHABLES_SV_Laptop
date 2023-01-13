
namespace Multidesechables.FormsApp
{
    partial class FrmSucess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.closeSuccess = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.esclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(223)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 235);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblMessage.Location = new System.Drawing.Point(31, 251);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(174, 23);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "MENSAJE";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeSuccess
            // 
            this.closeSuccess.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.closeSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(38)))), ((int)(((byte)(190)))));
            this.closeSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeSuccess.BorderRadius = 4;
            this.closeSuccess.ButtonText = "ACEPTAR";
            this.closeSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSuccess.DisabledColor = System.Drawing.Color.Gray;
            this.closeSuccess.Iconcolor = System.Drawing.Color.Transparent;
            this.closeSuccess.Iconimage = null;
            this.closeSuccess.Iconimage_right = null;
            this.closeSuccess.Iconimage_right_Selected = null;
            this.closeSuccess.Iconimage_Selected = null;
            this.closeSuccess.IconMarginLeft = 0;
            this.closeSuccess.IconMarginRight = 0;
            this.closeSuccess.IconRightVisible = true;
            this.closeSuccess.IconRightZoom = 0D;
            this.closeSuccess.IconVisible = true;
            this.closeSuccess.IconZoom = 90D;
            this.closeSuccess.IsTab = false;
            this.closeSuccess.Location = new System.Drawing.Point(34, 286);
            this.closeSuccess.Name = "closeSuccess";
            this.closeSuccess.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(38)))), ((int)(((byte)(190)))));
            this.closeSuccess.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(38)))), ((int)(((byte)(190)))));
            this.closeSuccess.OnHoverTextColor = System.Drawing.Color.White;
            this.closeSuccess.selected = false;
            this.closeSuccess.Size = new System.Drawing.Size(179, 42);
            this.closeSuccess.TabIndex = 3;
            this.closeSuccess.Text = "ACEPTAR";
            this.closeSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeSuccess.Textcolor = System.Drawing.Color.White;
            this.closeSuccess.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSuccess.Click += new System.EventHandler(this.closeSuccess_Click);
            this.closeSuccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.closeSuccess_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // esclarecer
            // 
            this.esclarecer.Delay = 0;
            // 
            // FrmSucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 351);
            this.Controls.Add(this.closeSuccess);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSucess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSucess";
            this.Load += new System.EventHandler(this.FrmSucess_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuFlatButton closeSuccess;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition esclarecer;
    }
}