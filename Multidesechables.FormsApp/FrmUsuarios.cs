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
    public partial class FrmUsuarios : Form
    {
        N_Usuario objNegocio = new N_Usuario();
        E_Usuario objEntidades = new E_Usuario();
        public FrmUsuarios()
        {
            InitializeComponent();
            mostrarTablaUsaurio();
            ocultarMoverAncharColumnas();
            MostrarTotal();
        }
        public void mostrarTablaUsaurio()
        {
            N_Usuario objNegocio = new N_Usuario();
            dgvdata.DataSource = objNegocio.ListandoUsuario();
        }
        public void ocultarMoverAncharColumnas()
        {
     
            dgvdata.Columns[0].DisplayIndex = 9;
            dgvdata.Columns[1].Visible = false;
            dgvdata.Columns[0].Width = 42;
         
            dgvdata.Columns[2].Width = 100;
            dgvdata.Columns[3].Width = 200;
            dgvdata.Columns[4].Width = 120;
            dgvdata.Columns[5].Width = 100;
            dgvdata.Columns[6].Width = 200;
            dgvdata.Columns[7].Visible = false;
            dgvdata.Columns[8].Width = 155;
            dgvdata.Columns[9].Width = 50;
        }


        public void BuscarUsuario(string buscar)
        {
            N_Usuario objNegocio = new N_Usuario();
            dgvdata.DataSource = objNegocio.BuscandoUsuario(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(txtBuscar.Text);
        }




        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmDetalleUsuario frm = new FrmDetalleUsuario();
            frm.ShowDialog();
            frm.Update = false;
            mostrarTablaUsaurio();
            MostrarTotal();
        }
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                {
                    FrmDetalleUsuario frm = new FrmDetalleUsuario();
                    frm.Update = true;
                    //frm.txtindice.Text = e.RowIndex.ToString();
                    frm.txtid.Text = dgvdata.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
                    frm.txtdocumento.Text = dgvdata.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                    frm.txtnombrecompleto.Text = dgvdata.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                    frm.txtresidencia.Text = dgvdata.Rows[e.RowIndex].Cells["Residencia"].Value.ToString();
                    frm.txtTelefono.Text = dgvdata.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    frm.txtcorreo.Text = dgvdata.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    frm.txtclave.Text = dgvdata.Rows[e.RowIndex].Cells["Clave"].Value.ToString();
                    frm.txtconfirmarclave.Text = dgvdata.Rows[e.RowIndex].Cells["Clave"].Value.ToString();

                    frm.ShowDialog();
                    mostrarTablaUsaurio();
                    MostrarTotal();
                }
            }
        }




        public void MostrarTotal()
        {
            E_Usuario objEntidad = new E_Usuario();
            N_Usuario objNegocio = new N_Usuario();

            objNegocio.MostrandoTotales(objEntidad);
            lblUsuario.Text = objEntidad.TotalUsuario;
            lblAdministrador.Text = objEntidad.TotalAdministrador;
            lblEmpleados.Text = objEntidad.TotalEmpleado;

        }

        
    }
}
