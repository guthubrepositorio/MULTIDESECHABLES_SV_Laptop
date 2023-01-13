using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multidesechables.FormsApp
{
    public partial class FrmSucess : Form
    {
        public FrmSucess(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        private void FrmSucess_Load(object sender, EventArgs e)
        {
            esclarecer.ShowAsyc(this);
        }

        public static void confirmacionForm(string mensaje)
        {
            FrmSucess frm = new FrmSucess(mensaje);
            frm.ShowDialog();
        }

        private void closeSuccess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeSuccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                this.Close();

            }
        }
    }
}



        