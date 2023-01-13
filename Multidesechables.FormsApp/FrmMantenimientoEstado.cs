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
    public partial class FrmMantenimientoEstado : Form
    {
        FrmProductos frm = new FrmProductos();
        E_Producto objEntidades = new E_Producto();
        N_Producto objNegocio = new N_Producto();

        public bool Update = false;


        public FrmMantenimientoEstado()
        {
            InitializeComponent();
            ListarCategorias();
        }

        private void FrmMantenimientoEstado_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }



        public void ListarCategorias()
        {
            N_Categoria objNegocio = new N_Categoria();
            cmbCategorias.DataSource = objNegocio.ListandoCategoria("");
            cmbCategorias.ValueMember = "Idcategoria";
            cmbCategorias.DisplayMember = "Descripcion";
        }


        private bool ValidarDatos()
        {
            
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool ok = true;
            if (textCode.Text == "")
            {
                ok = false;
                mgcodigo("ingrese el codigo del producto");
            }
            if (txtNombre.Text == "")
            {
                ok = false;

                mgnombre("ingrese el nombre del producto");
            }
            if (txtDescripcion.Text == "")
            {
                ok = false;

                mgdescripcion("ingrese la descripcion del producto");
            }
            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                ok = false;
                mgpreciocompra("Formato moneda incorrecto");
                
                //txtPreciocompra.Select();               
            }
            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                ok = false;
                mgprecioventa("Formato moneda incorrecto");
                //txtPrecioventa.Select();
            }

            if (txtstockminmo.Text == "")
            {
                ok = false;
                mgstockminimo("ingrese el stock en numeros");
            }
            if (txtstockmaximo.Text == "")
            {
                ok = false;
                mgstockmaximo("ingrese el stock en numero");
            }


            return ok;
        }

        private void mgcodigo(string msg)
        {
            lblcodigo.Text = "        " + msg;
            lblcodigo.Visible = true;
        }
        private void mgnombre(string msg)
        {
            lblnombre.Text = "        " + msg;
            lblnombre.Visible = true;
        }
        private void mgdescripcion(string msg)
        {
            lbldescripcion.Text = "        " + msg;
            lbldescripcion.Visible = true;
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
        private void mgstockminimo(string msg)
        {
            lblstockminimo.Text = "        " + msg;
            lblstockminimo.Visible = true;
        }
        private void mgstockmaximo(string msg)
        {
            lblstockmaximo.Text = "        " + msg;
            lblstockmaximo.Visible = true;
        }


        private void textCode_Enter(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            lbldescripcion.Visible = false;
        }
        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            lbldescripcion.Visible = false;
        }
        private void txtpreciocompra_Enter(object sender, EventArgs e)
        {
            lblpreciocompra.Visible = false;
        }

        private void txtprecioventa_Enter(object sender, EventArgs e)
        {
            lblprecioventa.Visible = false;
        }

        private void txtstockminmo_Enter(object sender, EventArgs e)
        {
            lblstockminimo.Visible = false;
        }

        private void txtstockmaximo_Enter(object sender, EventArgs e)
        {
            lblstockmaximo.Visible = false;
        }


        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    if (txtpreciocompra.Text == "")
                    {
                        mgpreciocompra("Formato moneda incorrecto");
                        return;
                    }
                    if (txtprecioventa.Text == "")
                    {
                        mgprecioventa("Formato moneda incorrecto");
                        return;
                    }

                    if (txtstockminmo.Text == "")
                    {
                        mgstockminimo("ingrese el stock en numeros");
                        return;
                    }
                    if (txtstockmaximo.Text == "")
                    {
                        mgstockmaximo("ingrese el stock en numero");
                        return;
                    }
                    // objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                    objEntidades.Codigo = textCode.Text;
                    objEntidades.Nombre = txtNombre.Text.ToUpper();
                    objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;
                    objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                    objEntidades.PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text);
                    objEntidades.PrecioVenta = Convert.ToDecimal(txtprecioventa.Text);
                    objEntidades.Stockminimo = Convert.ToInt32(txtstockminmo.Text);
                    objEntidades.Stockmaximo = Convert.ToInt32(txtstockmaximo.Text);

                    if (ValidarDatos())
                    {
                        objNegocio.CreandoProductosEstado(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                    //FrmexepcionVacio.confirmacionForm("ERROR INESPERADO INGRESAR LOS DATOS CORRECTAMENTE");
                }
            }
            if (Update == true)
            {
                try
                {
                    if (txtpreciocompra.Text == "")
                    {
                        mgpreciocompra("Formato moneda incorrecto");
                        return;
                    }
                    if (txtprecioventa.Text == "")
                    {
                        mgprecioventa("Formato moneda incorrecto");
                        return;
                    }
                    if (txtstockminmo.Text == "")
                    {
                        mgstockminimo("ingrese el stock en numeros");
                        return;
                    }
                    if (txtstockmaximo.Text == "")
                    {
                        mgstockmaximo("ingrese el stock en numero");
                        return;
                    }

                    objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                    objEntidades.Codigo = textCode.Text;
                    objEntidades.Nombre = txtNombre.Text.ToUpper();
                    objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;
                    objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                    objEntidades.PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text);
                    objEntidades.PrecioVenta = Convert.ToDecimal(txtprecioventa.Text);
                    objEntidades.Stockminimo = Convert.ToInt32(txtstockminmo.Text);
                    objEntidades.Stockmaximo = Convert.ToInt32(txtstockmaximo.Text);

                    if (ValidarDatos())
                    {
                        objNegocio.ActualizandoProductosEstado(objEntidades);
                        FrmSucess.confirmacionForm("EDITADO");
                        Close();
                    }

                    Update = false;

                }
                catch (Exception ex)
                {
                    FrmexepcionVacio.confirmacionForm("NO SE PUDO EDITAR");
                }
            }
        }

        //private void Limpiar()
        //{
        //    txtIdproducto.Text = "0";
        //    textCode.Text = "";
        //    txtNombre.Text = "";
        //    txtDescripcion.Text = "";
        //    txtFecha.Text = "";
        //    txtpreciocompra.Text = "0.00";
        //    txtprecioventa.Text = "0.00";
        //    txtstockminmo.Text = "";
        //    txtstockmaximo.Text = "";
        //}

        private void textCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbCategorias.Focus();
            }
        }

        private void cmbCategorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpreciocompra.Focus();
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtprecioventa.Focus();
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtstockminmo.Focus();
            }
        }

        private void txtstockminmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtstockminmo.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtstockmaximo.Focus();
            }
        }

        private void txtstockmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtstockmaximo.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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




            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Update == false)
                {
                    try
                    {

                        if (txtpreciocompra.Text == "")
                        {
                            mgpreciocompra("Formato moneda incorrecto");
                            return;
                        }
                        if (txtprecioventa.Text == "")
                        {
                            mgprecioventa("Formato moneda incorrecto");
                            return;
                        }
                        if (txtstockminmo.Text == "")
                        {
                            mgstockminimo("ingrese el stock en numeros");
                            return;
                        }
                        if (txtstockmaximo.Text == "")
                        {
                            mgstockmaximo("ingrese el stock en numero");
                            return;
                        }

                        // objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                        objEntidades.Codigo = textCode.Text;
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;
                        objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                        objEntidades.PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text);
                        objEntidades.PrecioVenta = Convert.ToDecimal(txtprecioventa.Text);
                        objEntidades.Stockminimo = Convert.ToInt32(txtstockminmo.Text);
                        objEntidades.Stockmaximo = Convert.ToInt32(txtstockmaximo.Text);

                        if (ValidarDatos())
                        {
                            objNegocio.CreandoProductosEstado(objEntidades);
                            FrmSucess.confirmacionForm("GUARDADO");
                            Close();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex);
                        //FrmexepcionVacio.confirmacionForm("ERROR INESPERADO INGRESAR LOS DATOS CORRECTAMENTE");
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        if (txtpreciocompra.Text == "")
                        {
                            mgpreciocompra("Formato moneda incorrecto");
                            return;
                        }
                        if (txtprecioventa.Text == "")
                        {
                            mgprecioventa("Formato moneda incorrecto");
                            return;
                        }
                        if (txtstockminmo.Text == "")
                        {
                            mgstockminimo("ingrese el stock en numeros");
                            return;
                        }
                        if (txtstockmaximo.Text == "")
                        {
                            mgstockmaximo("ingrese el stock en numero");
                            return;
                        }

                        objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                        objEntidades.Codigo = textCode.Text;
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;
                        objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                        objEntidades.PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text);
                        objEntidades.PrecioVenta = Convert.ToDecimal(txtprecioventa.Text);
                        objEntidades.Stockminimo = Convert.ToInt32(txtstockminmo.Text);
                        objEntidades.Stockmaximo = Convert.ToInt32(txtstockmaximo.Text);

                        if (ValidarDatos())
                        {
                            objNegocio.ActualizandoProductosEstado(objEntidades);
                            FrmSucess.confirmacionForm("EDITADO");
                            Close();
                        }

                        Update = false;

                    }
                    catch (Exception ex)
                    {
                        FrmexepcionVacio.confirmacionForm("NO SE PUDO EDITAR");
                    }
                }
            }
        }
    }
}
