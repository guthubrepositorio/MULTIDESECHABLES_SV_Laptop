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
using Multidesechables.FormsApp.Utilidades;
namespace Multidesechables.FormsApp.Complementos
{
    public partial class ListaProveedores : Form
    {
        N_Proveedor objNegocio = new N_Proveedor();
        E_Proveedor objEntidad = new E_Proveedor();
        public E_Proveedor _Proveedor { get; set; }
        public ListaProveedores()
        {
            InitializeComponent();
            mostrarTablaProveedor();
            ocultarMoverAncharColumnas();
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {

        }
        public void mostrarTablaProveedor()
        {
            N_Proveedor objNegocio = new N_Proveedor();
            tableProveedor.DataSource = objNegocio.ListandoProveedores();
        }
        public void ocultarMoverAncharColumnas()
        {

            tableProveedor.Columns[0].Visible = false;
            tableProveedor.Columns[1].Width = 300;
            tableProveedor.Columns[2].Width = 300;
            tableProveedor.Columns[3].Visible = false;
            tableProveedor.Columns[4].Visible = false;
            tableProveedor.Columns[5].Visible = false;

        }
        public void buscarProveedores(string buscar)
        {
            N_Proveedor objNegocio = new N_Proveedor();
            tableProveedor.DataSource = objNegocio.BuscandoProveedores(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarProveedores(txtBuscar.Text);
        }
        private void tableProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Proveedor = new E_Proveedor()
                {
                    Idproveedor = Convert.ToInt32(tableProveedor.Rows[iRow].Cells["Idproveedor"].Value.ToString()),
                    Documento = tableProveedor.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = tableProveedor.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeFormProveedor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
