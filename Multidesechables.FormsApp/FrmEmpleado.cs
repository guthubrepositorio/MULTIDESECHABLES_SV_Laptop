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

namespace Multidesechables.FormsApp
{
    public partial class FrmEmpleado : Form
    {
        N_Empleado objNegocio = new N_Empleado();
        E_Empleado objEntidad = new E_Empleado();


        public FrmEmpleado()
        {
            InitializeComponent();
            mostrarTablaEmpleado();
            ocultarMoverAncharColumnas();
            MostrarTotal();
        }

        public void mostrarTablaEmpleado()
        {
            N_Empleado objNegocio = new N_Empleado();
            tableEmpleado.DataSource = objNegocio.ListandoEmpleado();
        }

        public void ocultarMoverAncharColumnas()
        {

            tableEmpleado.Columns[0].DisplayIndex = 15;
            tableEmpleado.Columns[1].DisplayIndex = 15;
            tableEmpleado.Columns[0].Width = 65;
            tableEmpleado.Columns[1].Width = 85;

            tableEmpleado.Columns[2].Visible = false;
            tableEmpleado.Columns[3].Width = 250;
            tableEmpleado.Columns[4].Width = 100;
            tableEmpleado.Columns[5].Width = 250;
            tableEmpleado.Columns[6].Width = 200;
            tableEmpleado.Columns[7].Width = 110;
            tableEmpleado.Columns[8].Width = 100;
            tableEmpleado.Columns[9].Width = 150;
            tableEmpleado.Columns[10].Width = 150;
            tableEmpleado.Columns[11].Width = 155;
            tableEmpleado.Columns[12].Width = 200;
            tableEmpleado.Columns[13].Width = 130;
            tableEmpleado.Columns[14].Width = 130;
            tableEmpleado.Columns[15].Width = 130;

        }
        public void buscarEmpleado(string buscar)
        {
            N_Empleado objNegocio = new N_Empleado();
            tableEmpleado.DataSource = objNegocio.BuscandoEmpleado(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarEmpleado(txtBuscar.Text);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEmpleado frm = new FrmMantenimientoEmpleado();
            frm.ShowDialog();
            frm.Update = false;
            mostrarTablaEmpleado();
            MostrarTotal();
        }

        public void MostrarTotal()
        {
            E_Empleado objEntidad = new E_Empleado();
            N_Empleado objNegocio = new N_Empleado();

            objNegocio.MostrandoTotales(objEntidad);
            lblEmpleados.Text = objEntidad.TotalEmpleado;
          

        }



        private void tableEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                if (tableEmpleado.Rows[e.RowIndex].Cells["eliminar"].Selected)
                {
                    Form mensaje = new FrmInformacion("ESTA SEGURO DE QUE DESEA ELIMINAR ESTE EMPLEADO");
                    DialogResult result = mensaje.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        int delete = Convert.ToInt32(tableEmpleado.Rows[e.RowIndex].Cells[2].Value.ToString());
                        objNegocio.BorrandoEmpleado(delete);
                        FrmSucess.confirmacionForm("ELIMINADO");
                        mostrarTablaEmpleado();
                        MostrarTotal();
                    }
                }
                else if (tableEmpleado.Rows[e.RowIndex].Cells["editar"].Selected)
                {
                    FrmMantenimientoEmpleado frm = new FrmMantenimientoEmpleado();
                    frm.Update = true;
                    frm.txtid.Text = tableEmpleado.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
                    frm.txtnombrecompleto.Text = tableEmpleado.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                    frm.txtTelefono.Text = tableEmpleado.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    frm.txtcorreo.Text = tableEmpleado.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    frm.txtresidencia.Text = tableEmpleado.Rows[e.RowIndex].Cells["Residencia"].Value.ToString();
                    frm.txtdui.Text = tableEmpleado.Rows[e.RowIndex].Cells["Dui"].Value.ToString();
                    frm.cbosexo.Text = tableEmpleado.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                    frm.txthorarioentrada.Text = tableEmpleado.Rows[e.RowIndex].Cells["HorarioEntrada"].Value.ToString();
                    frm.txthorariosalida.Text = tableEmpleado.Rows[e.RowIndex].Cells["HorarioSalida"].Value.ToString();
                    frm.txtdiasdescanso.Text = tableEmpleado.Rows[e.RowIndex].Cells["DiasDescanso"].Value.ToString();
                    frm.txtencargadode.Text = tableEmpleado.Rows[e.RowIndex].Cells["EncargadoDe"].Value.ToString();
                    frm.txtsalariobruto.Text = tableEmpleado.Rows[e.RowIndex].Cells["SalarioBruto"].Value.ToString();
                    frm.txtdescuentos.Text = tableEmpleado.Rows[e.RowIndex].Cells["Descuentos"].Value.ToString();
                    frm.txtsueldoneto.Text = tableEmpleado.Rows[e.RowIndex].Cells["SueldoNeto"].Value.ToString();

                    frm.ShowDialog();
                    mostrarTablaEmpleado();
                    MostrarTotal();

                }

            }
            catch /*(Exception ex)*/
            {
                MessageBox.Show("error" /*+ ex*/);


            }





        }
    }
}
