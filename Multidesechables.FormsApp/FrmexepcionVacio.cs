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
    public partial class FrmexepcionVacio : Form
    {
        public FrmexepcionVacio(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        private void FrmexepcionVacio_Load(object sender, EventArgs e)
        {
             esclarecer.ShowAsyc(this);
        }

        public static void confirmacionForm(string mensaje)
        {
            FrmexepcionVacio frm = new FrmexepcionVacio(mensaje);
            frm.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.Close();
            // this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
