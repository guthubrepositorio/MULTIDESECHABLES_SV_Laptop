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
    public partial class FrmVentas : Form
    {
        //FrmClientes frm = new FrmClientes();
        //E_Cliente objEntidades = new E_Cliente();
        //N_Cliente objNegocio = new N_Cliente();

        //FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
        //vfr.Update = false;




        private E_Usuario _Usuario;
        public FrmVentas(E_Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void btndetalleCompra_Click(object sender, EventArgs e)
        {
            DetalleVenta frma = new DetalleVenta();
            frma.ShowDialog();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtidproducto.Text = "0";

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txtTotalpagar.Text = "0";
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
            //if (txtdocumentocliente.Text == "")
            //{
            //    ok = false;
            //    mgdocumento("ingrese el numero de documento");
            //}
            //if (txtnombreCliente.Text == "")
            //{
            //    ok = false;

            //    mgrazon("ingrese el cliente");
            //}
            if (txtCodigoproducto.Text == "")
            {
                ok = false;

                mgcodigoproducto("ingrese el codigo del producto");
            }
            if (txtProducto.Text == "")
            {
                ok = false;

                mgproducto("ingrese la descripcion del producto");
            }
            if (txtprecio.Text == "")
            {
                ok = false;

                mgprecio("ingrese el Precio del producto");
            }
           
            
            return ok;
        }



        private bool DatosClientes()
        {
            bool ok = true;
            if (txtdocumentocliente.Text == "")
            {
                ok = false;
                mgdocumento("ingrese el numero de documento");
            }
            if (txtnombreCliente.Text == "")
            {
                ok = false;

                mgrazon("ingrese el cliente");
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
        private void mgprecio(string msg)
        {
            lblpreciocompra.Text = "        " + msg;
            lblpreciocompra.Visible = true;
        }
        private void mgprecioventa(string msg)
        {
            lblprecioventa.Text = "        " + msg;
            lblprecioventa.Visible = true;
        }

        private void txtdocumentocliente_Enter(object sender, EventArgs e)
        {
            lbldocumento.Visible = false;
        }

        private void txtnombreCliente_Enter(object sender, EventArgs e)
        {
            lblrazon.Visible = false;
        }

        private void txtCodigoproducto_Enter(object sender, EventArgs e)
        {
            lblcodigoproducto.Visible = false;
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            lblnombreproducto.Visible = false;
        }

        private void txtprecio_Enter(object sender, EventArgs e)
        {
            lblpreciocompra.Visible = false;
        }

        private void txtstock_Enter(object sender, EventArgs e)
        {
            lblprecioventa.Visible = false;
        }

        private void btnbuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new ListaClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdocumentocliente.Text = modal._Cliente.Documento;
                    txtnombreCliente.Text = modal._Cliente.Nombre;
                    txtCodigoproducto.Select();
                }
                else
                {
                    txtdocumentocliente.Select();
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
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtstockminimo.Text = modal._Producto.Stockminimo.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodigoproducto.Select();
                }

            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;
            if (ValidarDatos())

                if (int.Parse(txtidproducto.Text) == 0)
                {
                    mgproducto("igrese los datos");
                    return;
                }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                mgprecio("Formato moneda incorrecto");
                txtprecio.Select();
                return;
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in tableVentas.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                    tableVentas.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txtProducto.Text,
                        precio.ToString("0.00"),
                        txtcantidad.Value.ToString(),
                        (txtcantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txtCodigoproducto.Select();
            }

        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (tableVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tableVentas.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotalpagar.Text = total.ToString("0.00");
        }
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtCodigoproducto.Text = "";
            txtProducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtstockminimo.Text = "";
            txtcantidad.Value = 1;
        }

        private void tableVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
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
        private void tableVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableVentas.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                        tableVentas.Rows.RemoveAt(index);
                        calcularTotal();
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void calcularcambio()
        {

            if (txtTotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

          




            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");

                }
            }



        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(txtTotalpagar.Text);
          
            if (total >= 100)
            {
                if (DatosClientes());
                if (txtdocumentocliente.Text == "")
                {
                    MessageBox.Show("La venta es mayor de $100.00 debe ingresar el numero de documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtnombreCliente.Text == "")
                {
                    MessageBox.Show("La venta es mayor de $100.00debe ingresar el nombre completo del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            
            }
          


            if (txtpagocon.Text == "")
            {
                MessageBox.Show("Debe ingresar el pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tableVentas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("idproducto", typeof(int));
            detalle_venta.Columns.Add("precioVenta", typeof(decimal));
            detalle_venta.Columns.Add("cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in tableVentas.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["idproducto"].Value.ToString(),
                    row.Cells["precio"].Value.ToString(),
                    row.Cells["cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new N_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:0000000000}", idcorrelativo);
            calcularcambio();

          

            E_Venta oVenta = new E_Venta()
            {


          

                oUsuario = new E_Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,

                
                DocumentoCliente = txtdocumentocliente.Text,
                NombreCliente = txtnombreCliente.Text,
                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalpagar.Text),
                FechaRegistro =Convert.ToDateTime(txtfecha.Text)
               

           };
       
            string mensaje = string.Empty;
            bool respuesta = new N_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {

                    var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtdocumentocliente.Text = "";
                txtnombreCliente.Text = "";
                tableVentas.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtCodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                E_Producto oProducto = new N_Producto().Listar().Where(p => p.Codigo == txtCodigoproducto.Text == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigoproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.Idproducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtstock.Text = oProducto.Stock.ToString();
                    txtstockminimo.Text = oProducto.Stockminimo.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodigoproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtProducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtstockminimo.Text = "";
                    txtcantidad.Value = 1;
                }
            }
        }

        private void btnCrearcliente_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente frma = new FrmMantenimientoCliente();
            frma.ShowDialog();
        }

       
    }
}
