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
    public partial class FrmProductos : Form

    {

        N_Producto objNegocio = new N_Producto();
        E_Producto objEntidad = new E_Producto();
        public E_Producto _Producto { get; set; }

        public FrmProductos()
        {
            InitializeComponent();
            mostrarTablaProducto();
            ocultarMoverAncharColumnas();
            MostrarTotal();
        }

        public void mostrarTablaProducto()
        {
            N_Producto objNegocio = new N_Producto();
            tableProducts.DataSource = objNegocio.ListandoProductos();
        }

        public void ocultarMoverAncharColumnas()
        {

            tableProducts.Columns[2].Visible = false;
            //tableProducts.Columns[0].DisplayIndex = 12;
            //tableProducts.Columns[1].DisplayIndex = 12;
            //tableProducts.Columns[1].DisplayIndex = 12;
            tableProducts.Columns[3].Width = 155;
            tableProducts.Columns[4].Width = 195;
            tableProducts.Columns[5].Width = 200;
            tableProducts.Columns[6].Width = 220;
            tableProducts.Columns[7].Width = 220;
            tableProducts.Columns[8].Width = 200;
            tableProducts.Columns[9].Width = 200;
            //tableProducts.Columns[10].Visible = false;
            tableProducts.Columns[10].Width = 120;
            tableProducts.Columns[11].Width = 125;
            tableProducts.Columns[12].Width = 125;
            tableProducts.Columns[13].Visible = false;
            //tableProducts.Columns[11].Width = 65;
            tableProducts.Columns[0].Width = 80;
            tableProducts.Columns[1].Width = 90;
        }

        public void buscarProductos(string buscar)
        {
            N_Producto objNegocio = new N_Producto();
            tableProducts.DataSource = objNegocio.BuscandoProductos(buscar);
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarProductos(txtBuscar.Text);
        }

        private void btnNuevoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D1))
            {
                {
                    {
                        FrmMantenimientoProducto frm = new FrmMantenimientoProducto();
                        frm.ShowDialog();
                        frm.Update = false;
                        mostrarTablaProducto();
                        MostrarTotal();
                    }
                }
            }
        }

        private void btnNewCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D2))
            {
                {
                    {
                        FrmCategoria frma = new FrmCategoria();
                        frma.ShowDialog();
                        MostrarTotal();
                    }
                }
            }
        }


        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProducto frm = new FrmMantenimientoProducto();
            frm.ShowDialog();
            frm.Update = false;
            mostrarTablaProducto();
            MostrarTotal();
        }

        //private void btnNewCategory_Click(object sender, EventArgs e)
        //{
        //    FrmCategoria frma = new FrmCategoria();
        //    frma.ShowDialog();
        //    MostrarTotal();
        //}


        private void tableProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (tableProducts.Rows[e.RowIndex].Cells["eliminar"].Selected)
                {
                    Form mensaje = new FrmInformacion("ESTA SEGURO DE QUE DESEA ELIMINAR ESTE PRODUCTO");
                    DialogResult result = mensaje.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        int delete = Convert.ToInt32(tableProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
                        objNegocio.BorrandoProductos(delete);
                        FrmSucess.confirmacionForm("ELIMINADO");
                        mostrarTablaProducto();
                        MostrarTotal();
                    }
                }
                else if (tableProducts.Rows[e.RowIndex].Cells["editar"].Selected)
                {
                    FrmMantenimientoProducto frm = new FrmMantenimientoProducto();
                    frm.Update = true;
                    frm.txtIdproducto.Text = tableProducts.Rows[e.RowIndex].Cells["Idproducto"].Value.ToString();
                    frm.textCode.Text = tableProducts.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    frm.txtNombre.Text = tableProducts.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    frm.txtDescripcion.Text = tableProducts.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    frm.txtFecha.Text = tableProducts.Rows[e.RowIndex].Cells["FechaRegistro"].Value.ToString();
                    frm.cmbCategorias.Text = tableProducts.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();

                    frm.ShowDialog();
                    mostrarTablaProducto();
                    MostrarTotal();

                }

            }
            catch /*(Exception ex)*/
            {
                MessageBox.Show("error" /*+ ex*/);


            }

        }

        public void MostrarTotal()
        {
            E_Producto objEntidad = new E_Producto();
            N_Producto objNegocio = new N_Producto();

            objNegocio.MostrandoTotales(objEntidad);
            lblCategorias.Text = objEntidad.Totalcategorias;
            lblProductos.Text = objEntidad.Totalproductos;
            lblTotalStock.Text = objEntidad.SumStock;

        }

        private void tableProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum > 0)
            {

                _Producto = new E_Producto()
                {
                    Idproducto = Convert.ToInt32(tableProducts.Rows[iRow].Cells["Idproducto"].Value.ToString()),
                    Codigo = tableProducts.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = tableProducts.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(tableProducts.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Stockminimo = Convert.ToInt32(tableProducts.Rows[iRow].Cells["Stockminimo"].Value.ToString()),
                    Stockmaximo = Convert.ToInt32(tableProducts.Rows[iRow].Cells["Stockmaximo"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(tableProducts.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(tableProducts.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void tableProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.tableProducts.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (e.Value.ToString() == "No disponible")
                        {

                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.Black;
                        }

                        if (e.Value.ToString() == "Agotandose")
                        {

                            e.CellStyle.BackColor = Color.Yellow;
                            e.CellStyle.ForeColor = Color.Red;
                        }

                        if (e.Value.ToString() == "Stock Maximo")
                        {

                            e.CellStyle.BackColor = Color.GreenYellow;
                            e.CellStyle.ForeColor = Color.Black;
                        }


                        if (e.Value.ToString() == "disponible")
                        {
                            e.CellStyle.ForeColor = Color.SeaGreen;
                        }

                        if (e.Value.ToString() == "ingrese stock Minimo")
                        {
                            e.CellStyle.BackColor = Color.LightBlue;
                            e.CellStyle.ForeColor = Color.Black;
                        }
                        if (e.Value.ToString() == "ingrese stock Maximo")
                        {
                            e.CellStyle.BackColor = Color.LightBlue;
                            e.CellStyle.ForeColor = Color.Black;
                        }


                    }
                }
            }

        }
    }  
}

