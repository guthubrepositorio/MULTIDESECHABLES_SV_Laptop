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
    public partial class ListaProductos : Form
    {

        N_Producto objNegocio = new N_Producto();
        E_Producto objEntidad = new E_Producto();
        public E_Producto _Producto { get; set; }

        public ListaProductos()
        {
            InitializeComponent();
            mostrarTablaProducto();
            ocultarMoverAncharColumnas();
        }

        private void closeFormProveedor_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void mostrarTablaProducto()
        {
            N_Producto objNegocio = new N_Producto();
            tableProducts.DataSource = objNegocio.ListandoProductos();
        }
        public void ocultarMoverAncharColumnas()
        {
            tableProducts.Columns[0].Visible = false;
            tableProducts.Columns[1].Width = 100;
            tableProducts.Columns[2].Width = 200;
            tableProducts.Columns[3].Width = 200;
            tableProducts.Columns[4].Width = 200;
            tableProducts.Columns[5].Width = 175;
            tableProducts.Columns[6].Width = 175;
            tableProducts.Columns[7].Width = 250;
            tableProducts.Columns[8].Width = 250;
            tableProducts.Columns[9].Width = 250;
            tableProducts.Columns[10].Width = 250;
            tableProducts.Columns[11].Visible = false;
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
