using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.LogicaDeNegocio;

namespace Multidesechables.FormsApp.Complementos
{
    public partial class ListaClientes : Form
    {
        N_Cliente objNegocio = new N_Cliente();
        E_Cliente objEntidad = new E_Cliente();
        public E_Cliente _Cliente { get; set; }

        public ListaClientes()
        {
            InitializeComponent();
            mostrarTablaCliente();
            ocultarMoverAncharColumnas();
        }

        private void closeFormProveedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void mostrarTablaCliente()
        {
            N_Cliente objNegocio = new N_Cliente();
            tableClientes.DataSource = objNegocio.ListandoCliente();
        }

        public void ocultarMoverAncharColumnas()
        {

            
            tableClientes.Columns[0].Visible = false;
            tableClientes.Columns[1].Width = 340;
            tableClientes.Columns[2].Width = 390;
            tableClientes.Columns[3].Visible = false;



        }

        public void buscarClientes(string buscar)
        {
            N_Cliente objNegocio = new N_Cliente();
            tableClientes.DataSource = objNegocio.BuscandoClientes(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarClientes(txtBuscar.Text);
        }

        private void tableClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                _Cliente = new E_Cliente()
                {
                    Documento = tableClientes.Rows[iRow].Cells["Documento"].Value.ToString(),
                    Nombre = tableClientes.Rows[iRow].Cells["Nombre"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
