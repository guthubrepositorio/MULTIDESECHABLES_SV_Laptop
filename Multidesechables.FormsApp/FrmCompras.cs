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
using Multidesechables.FormsApp.Complementos;

namespace Multidesechables.FormsApp
{


    public partial class FrmCompras : Form
    {

        private E_Usuario _Usuario;

       
        public FrmCompras(E_Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
          
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

         
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        private bool ValidarDatos()
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool ok = true;
            if (txtdocumento.Text == "")
            {
                ok = false;
                mgdocumento("ingrese el numero de documento");
            }
            if (txtrazonsocial.Text == "")
            {
                ok = false;

                mgrazon("ingrese la razon social");
            }
            if (txtCodigoproducto.Text == "")
            {
                ok = false;

                mgcodigoproducto("ingrese el codigo");
            }            
            if (txtProducto.Text == "")
            {
                ok = false;

                mgproducto("ingrese la descripcion del producto");
            }
            if (txtPreciocompra.Text == "")
            {
                ok = false;

                mgpreciocompra("ingrese el Precio de compra del producto");
            }
            if (txtPrecioventa.Text == "")
            {
                ok = false;

                mgprecioventa("ingrese Precio de venta del producto");
            }
            ////if (int.Parse(txtidproducto.Text) == 0)
            ////{
            ////    mgproducto("Debe seleccionar un producto");

            //}
            if (!decimal.TryParse(txtPreciocompra.Text, out preciocompra))
            {
                mgpreciocompra("Formato moneda incorrecto");
                //txtPreciocompra.Select();               
            }
            if (!decimal.TryParse(txtPrecioventa.Text, out precioventa))
            {
                mgprecioventa("Formato moneda incorrecto");
                //txtPrecioventa.Select();
            }
            return ok;
        }
        private void mgdocumento(string msg)
        {
            lbldocumento.Text = "        " + msg;
            lbldocumento.Visible = true;
        }
        private void mgrazon(string msg)
        {
            lblrazon.Text = "        " + msg;
            lblrazon.Visible = true;
        }
        private void mgcodigoproducto(string msg)
        {
            lblcodigoproducto.Text = "        " + msg;
            lblcodigoproducto.Visible = true;
        }
        private void mgproducto(string msg)
        {
            lblnombreproducto.Text = "        " + msg;
            lblnombreproducto.Visible = true;
        }
        private void mgpreciocompra(string msg)
        {
            lblpreciocompra.Text = "        " + msg;
            lblpreciocompra.Visible = true;
        }
        private void mgprecioventa(string msg)
        {
            lblprecioventa.Text = "        " + msg;
            lblprecioventa.Visible = true;
        }
        private void txtdocumento_Enter(object sender, EventArgs e)
        {
            lbldocumento.Visible = false;
        }
        private void txtrazonsocial_Enter(object sender, EventArgs e)
        {
            lblrazon.Visible = false;
        }
        private void txtCodigoproducto_Enter(object sender, EventArgs e)
        {
            //lblcodigoproducto.Visible = false;
        }
        private void txtProducto_Enter(object sender, EventArgs e)
        {
            lblnombreproducto.Visible = false;
        }
        private void txtPreciocompra_Enter(object sender, EventArgs e)
        {
            lblpreciocompra.Visible = false;
        }
        private void txtPrecioventa_Enter(object sender, EventArgs e)
        {
            lblprecioventa.Visible = false;
        }
        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new ListaProveedores())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.Idproveedor.ToString();
                    txtdocumento.Text = modal._Proveedor.Documento;
                    txtrazonsocial.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                   txtdocumento.Select();
                }

            }
        }
        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new ListaProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.Idproducto.ToString();
                    txtCodigoproducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPreciocompra.Text = modal._Producto.PrecioCompra.ToString("0.00");
                    txtPrecioventa.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtstockminimo.Text = modal._Producto.Stockminimo.ToString();
                    txtstockmaximo.Text = modal._Producto.Stockmaximo.ToString();
                    //txtPreciocompra.Select();
                }
                else
                {
                    txtCodigoproducto.Select();
                }

            }
        }
 
        private void txtCodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                E_Producto oProducto = new N_Producto().Listar().Where(p => p.Codigo == txtCodigoproducto.Text).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigoproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.Idproducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPreciocompra.Text =oProducto.PrecioCompra.ToString();
                    txtPrecioventa.Text = oProducto.PrecioVenta.ToString();
                    txtstock.Text = oProducto.Stock.ToString();
                    txtstockminimo.Text = oProducto.Stockminimo.ToString();
                    txtstockmaximo.Text = oProducto.Stockmaximo.ToString();
                }
                else
                {
                    txtCodigoproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtProducto.Text = "";
                    txtPreciocompra.Text = "";
                    txtPrecioventa.Text = "";
                }
            }
        }
       
        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal Preciocompra = 0;
            decimal Precioventa = 0;
            bool producto_existe = false;


            if (ValidarDatos())

            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            if (!decimal.TryParse(txtPreciocompra.Text, out Preciocompra))
            {
                mgpreciocompra("Formato moneda incorrecto");
                return;
            }
            if (!decimal.TryParse(txtPrecioventa.Text, out Precioventa))
            {
                mgprecioventa("Formato de moneda incorrecta");
                return;
            }

            if (txtPreciocompra.Text == "0.00")
            {
                mgpreciocompra("el precio no puede ser de 0.00");
                return;
            }
            if (txtPrecioventa.Text == "0.00")
            {
                mgprecioventa("el precio no puede ser de 0.00");
                return;
            }

            int cantidad = Convert.ToInt32(txtcantidad.Text);
            int stock = Convert.ToInt32(txtstock.Text);
            int stockmaximo = Convert.ToInt32(txtstockmaximo.Text);


            if (stock == stockmaximo)
            {

                MessageBox.Show("No puedes comprar mas producto ya que alcanso su stock maximo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              
            }

            if (stock + cantidad > stockmaximo)
            {

                MessageBox.Show(" la cantidad no puede sobrepasar el stockmaximo ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            foreach (DataGridViewRow fila in tableCompras.Rows)
            {
                if (fila.Cells["Idproducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe)
                {
                    tableCompras.Rows.Add(new object[] {
                    txtidproducto.Text,
                    txtProducto.Text,
                    Preciocompra.ToString("0.00"),
                    Precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * Preciocompra).ToString("0.00")
                   });
                    calcularTotal();
                    limpiarProducto();
                    txtCodigoproducto.Select();
                }
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (tableCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tableCompras.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotalpagar.Text = total.ToString("0.00");
        }
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtCodigoproducto.Text = "";
            txtCodigoproducto.BackColor = Color.White;
            txtProducto.Text = "";
            txtPreciocompra.Text = "";
            txtPrecioventa.Text = "";
            txtstock.Text = "";
            txtstockminimo.Text = "";
            txtstockmaximo.Text = "";
            txtcantidad.Value = 1;
        }
        private void tableCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tableCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableCompras.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    tableCompras.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }
        private void txtPreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }




        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tableCompras.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("idproducto", typeof(int));
            detalle_compra.Columns.Add("precioCompra", typeof(decimal));
            detalle_compra.Columns.Add("precioVenta", typeof(decimal));
            detalle_compra.Columns.Add("cantidad", typeof(int));
            detalle_compra.Columns.Add("montoTotal", typeof(decimal));
            detalle_compra.Columns.Add("fechaRegistro", typeof(string));

            foreach (DataGridViewRow row in tableCompras.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["idproducto"].Value.ToString()),
                       row.Cells["precioCompra"].Value.ToString(),
                       row.Cells["precioVenta"].Value.ToString(),
                       row.Cells["cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            int idcorrelativo = new N_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:0000000000}", idcorrelativo);

            E_Compra oCompra = new E_Compra()
            {
                oUsuario = new E_Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new E_Proveedor() { Idproveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txtTotalpagar.Text),

                FechaRegistro = Convert.ToDateTime(txtfecha.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new N_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtidproveedor.Text = "0";
                txtdocumento.Text = "";
                txtrazonsocial.Text = "";
                tableCompras.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btndetalleCompra_Click(object sender, EventArgs e)
        {
            DetalleCompra frma = new DetalleCompra();
           frma.ShowDialog();       
        }

       
    }
}
