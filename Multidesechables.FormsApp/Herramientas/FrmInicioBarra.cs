using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multidesechables.FormsApp.Herramientas
{
    public partial class FrmInicioBarra : Form
    {
        public FrmInicioBarra()
        {
            InitializeComponent();
        }

        
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btngenerarmanualmente_Click(object sender, EventArgs e)
        {
            FrmImagenBarra frm = new FrmImagenBarra();
            frm.ShowDialog();
        }

        private void btngenerarmasivamente_Click(object sender, EventArgs e)
        {

            FrmMasivo frm = new FrmMasivo();
            frm.ShowDialog();
        }

 
        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
