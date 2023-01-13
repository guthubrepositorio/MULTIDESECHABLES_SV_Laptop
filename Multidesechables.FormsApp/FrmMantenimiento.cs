using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multidesechables.FormsApp.Herramientas;
using Multidesechables.FormsApp.Complementos;
namespace Multidesechables.FormsApp
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void btngenerarcodigo_Click(object sender, EventArgs e)
        {
            FrmInicioBarra frm = new FrmInicioBarra();
            frm.ShowDialog();
        }

        private void btndatosnegocio_Click(object sender, EventArgs e)
        {
            FrmNegocio frm = new FrmNegocio();
            frm.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bntContactos_Click(object sender, EventArgs e)
        {
            Desarrolladores frm = new Desarrolladores();
            frm.ShowDialog();
        }
    }
}
