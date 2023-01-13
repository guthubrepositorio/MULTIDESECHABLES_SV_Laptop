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
    public partial class FrmDenegacionAceso : Form
    {
        public FrmDenegacionAceso(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        private void FrmDenegacionAceso_Load(object sender, EventArgs e)
        {

        }


        public static void confirmacionForm(string mensaje)
        {
            FrmDenegacionAceso frm = new FrmDenegacionAceso(mensaje);
            frm.ShowDialog();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.Close();

           
        }

    }
}
