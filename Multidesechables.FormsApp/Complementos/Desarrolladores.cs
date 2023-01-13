using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multidesechables.FormsApp.Complementos
{
    public partial class Desarrolladores : Form
    {
        public Desarrolladores()
        {
            InitializeComponent();
        }

        private void closeFormProveedor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
