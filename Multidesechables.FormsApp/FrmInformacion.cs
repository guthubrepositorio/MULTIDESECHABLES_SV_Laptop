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
    public partial class FrmInformacion : Form
    {
        public FrmInformacion(string mensaje)  
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }

        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            esclarecer.ShowAsyc(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
