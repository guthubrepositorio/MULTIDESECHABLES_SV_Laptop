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
namespace Multidesechables.FormsApp
{
    public partial class FrmProveedor : Form
    {
        
        N_Proveedor objNegocio = new N_Proveedor();
        E_Proveedor objEntidad = new E_Proveedor();
        public E_Proveedor _Proveedor { get; set; }
        public FrmProveedor()
        {
            InitializeComponent();
            mostrarTablaProveedor();
            ocultarMoverAncharColumnas();
            MostrarTotal();
        }

        public void mostrarTablaProveedor()
        {
            N_Proveedor objNegocio = new N_Proveedor();
            tableProveedor.DataSource = objNegocio.ListandoProveedores();
        }

        public void ocultarMoverAncharColumnas()
        {
            //tableProducts.Columns[5].Visible = false;
            //tableProducts.Columns[8].Visible = false;


            tableProveedor.Columns[2].Visible = false;
            tableProveedor.Columns[0].DisplayIndex = 7;
            tableProveedor.Columns[1].DisplayIndex = 7;

            tableProveedor.Columns[3].Width = 140;
            tableProveedor.Columns[4].Width = 260;
            tableProveedor.Columns[5].Width = 280;
            tableProveedor.Columns[6].Width = 90;
            //tableProveedor.Columns[7].Width = 90;
           // tableProveedor.Columns[8].Width = 65;
            tableProveedor.Columns[0].Width = 45;
            tableProveedor.Columns[1].Width = 45;
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

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProveedor frm = new FrmMantenimientoProveedor();
            frm.ShowDialog();
            frm.Update = false;
            mostrarTablaProveedor();
            MostrarTotal();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
          
           

        }

        private void tableProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableProveedor.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form mensaje = new FrmInformacion("ESTA SEGURO DE QUE DESEA ELIMINAR ESTE PROVEEDOR");
                DialogResult result = mensaje.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int delete = Convert.ToInt32(tableProveedor.Rows[e.RowIndex].Cells[2].Value.ToString());
                    objNegocio.BorrandoProveedores(delete);
                    FrmSucess.confirmacionForm("ELIMINADO");
                    mostrarTablaProveedor();
                    MostrarTotal();
                }
            }
            else if (tableProveedor.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                   FrmMantenimientoProveedor frm = new FrmMantenimientoProveedor();
                    frm.Update = true;
                    frm.txtIdproveedor.Text = tableProveedor.Rows[e.RowIndex].Cells["Idproveedor"].Value.ToString();
                    frm.txtDocumento.Text = tableProveedor.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                    frm.txtRazonSocial.Text = tableProveedor.Rows[e.RowIndex].Cells["RazonSocial"].Value.ToString();

                    frm.txtCorreo.Text = tableProveedor.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    frm.txtTelefono.Text = tableProveedor.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    frm.txtFecha.Text = tableProveedor.Rows[e.RowIndex].Cells["FechaRegistro"].Value.ToString();
                    

                    frm.ShowDialog();
                    mostrarTablaProveedor();
                    MostrarTotal();
            }
    
        }


        public void MostrarTotal()
        {
            E_Proveedor objEntidad = new E_Proveedor();
            N_Proveedor objNegocio = new N_Proveedor();

            objNegocio.MostrandoTotales(objEntidad);
           
            lblProveedores.Text = objEntidad.Totalproveedores;
     

        }

        //private void btnExel_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

        //    worksheet = workbook.Sheets[1];
        //    worksheet.Name = "Proveedor";

        //    for (int i = 3; i < tableProveedor.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = tableProveedor.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 2; i < tableProveedor.Rows.Count; i++)
        //    {
        //        for (int j = 2; j < tableProveedor.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = tableProveedor.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //    app.Visible = true;
        //}

        private void btnNuevoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D1))
            {
                {
                    FrmMantenimientoProveedor frm = new FrmMantenimientoProveedor();
                    frm.ShowDialog();
                    frm.Update = false;
                    mostrarTablaProveedor();
                    MostrarTotal();
                }
            }
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
    }
}
