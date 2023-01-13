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
    public partial class FrmClientes : Form
    {

        N_Cliente objNegocio = new N_Cliente();
        E_Cliente objEntidad = new E_Cliente();
        public FrmClientes()
        {
            InitializeComponent();
            mostrarTablaCliente();
            ocultarMoverAncharColumnas();
            MostrarTotal();

        }

        public void mostrarTablaCliente()
        {
            N_Cliente objNegocio = new N_Cliente();
            tableClientes.DataSource = objNegocio.ListandoCliente();
        }

        public void ocultarMoverAncharColumnas()
        {
        
            tableClientes.Columns[2].Visible = false;
            tableClientes.Columns[0].DisplayIndex = 5;
            tableClientes.Columns[1].DisplayIndex = 5;

            tableClientes.Columns[3].Width = 340;
            tableClientes.Columns[4].Width = 390;
            tableClientes.Columns[5].Width = 200;
            tableClientes.Columns[0].Width = 45;
            tableClientes.Columns[1].Width = 45;

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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
            frm.ShowDialog();
            frm.Update = false;
            mostrarTablaCliente();
            MostrarTotal();
        }

        private void tableClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableClientes.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Form mensaje = new FrmInformacion("ESTA SEGURO DE QUE DESEA ELIMINAR ESTE CLIENTE");
                DialogResult result = mensaje.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int delete = Convert.ToInt32(tableClientes.Rows[e.RowIndex].Cells[2].Value.ToString());
                    objNegocio.BorrandoClientes(delete);
                    FrmSucess.confirmacionForm("ELIMINADO");
                    mostrarTablaCliente();
                    MostrarTotal();
                }
            }
            else if (tableClientes.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
                frm.Update = true;
                frm.txtIdcliente.Text = tableClientes.Rows[e.RowIndex].Cells["Idcliente"].Value.ToString();
                frm.txtDocumento.Text = tableClientes.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                frm.txtNombre.Text = tableClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                frm.txtFecha.Text = tableClientes.Rows[e.RowIndex].Cells["FechaRegistro"].Value.ToString();


                frm.ShowDialog();
                mostrarTablaCliente();
                MostrarTotal();
            }

        }


        public void MostrarTotal()
        {
            E_Cliente objEntidad = new E_Cliente();
            N_Cliente objNegocio = new N_Cliente();

            objNegocio.MostrandoTotales(objEntidad);

            lblClientes.Text = objEntidad.TotalClientes;


        }

        //private void btnExel_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

        //    worksheet = workbook.Sheets[1];
        //    worksheet.Name = "Clientes";

        //    for (int i = 3; i < tableClientes.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = tableClientes.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 2; i < tableClientes.Rows.Count; i++)
        //    {
        //        for (int j = 2; j < tableClientes.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = tableClientes.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //    app.Visible = true;
        //}

        private void btnNuevoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D1))
            {
                {
                    FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
                    frm.ShowDialog();
                    frm.Update = false;
                    mostrarTablaCliente();
                    MostrarTotal();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
