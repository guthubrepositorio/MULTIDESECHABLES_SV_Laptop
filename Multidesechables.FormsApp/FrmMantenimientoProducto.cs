using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multidesechables.FormsApp.Herramientas;
using BarcodeLib;
using System.Windows.Forms;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.LogicaDeNegocio;


namespace Multidesechables.FormsApp
{
    public partial class FrmMantenimientoProducto : Form
    {
        FrmProductos frm = new FrmProductos();
        E_Producto objEntidades = new E_Producto();
        N_Producto objNegocio = new N_Producto();

        public bool Update = false;

        public FrmMantenimientoProducto()
        {
            InitializeComponent();
            ListarCategorias();
        }

        public void ListarCategorias()
        {
            N_Categoria objNegocio = new N_Categoria();
            cmbCategorias.DataSource = objNegocio.ListandoCategoria("");
            cmbCategorias.ValueMember = "Idcategoria";
            cmbCategorias.DisplayMember = "Descripcion";
        }

        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }



        private bool ValidarDatos()
        {
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



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    // objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                    objEntidades.Codigo = textCode.Text;
                    objEntidades.Nombre = txtNombre.Text.ToUpper();
                    objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;
                    objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

                    if (ValidarDatos()) 
                    {
                        objNegocio.CreandoProductos(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Close();
                    }
                   

                }
                catch(Exception ex)
                {
                    MessageBox.Show("error"+ex);
                    //FrmexepcionVacio.confirmacionForm("ERROR INESPERADO INGRESAR LOS DATOS CORRECTAMENTE");
                }
            }
              if (Update == true)
              {
                    try
                    {
                        objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                        objEntidades.Codigo = textCode.Text;
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;
                        objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                        
                       if(ValidarDatos())
                    {
                        objNegocio.ActualizandoProductos(objEntidades);
                        FrmSucess.confirmacionForm("EDITADO");
                        Close();
                    }
                      
                        Update = false;

                    }
                    catch(Exception ex)
                    {
                        FrmexepcionVacio.confirmacionForm("NO SE PUDO EDITAR");
                    }
              }          
        }

        private void FrmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");

            //TipoBarra objtipobarra = TipoBarraLogica.Instancia.ObtenerTipoBarra();
            //if (objtipobarra.IdTipoBarra != 0)
            //{
            //    TipoBarraCodigo.TipoCodigo = (Enum.IsDefined(typeof(BarcodeLib.TYPE), objtipobarra.Value)) ? ((BarcodeLib.TYPE)objtipobarra.Value) : ((BarcodeLib.TYPE)0);
            //}
        }

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
                if (Update == false)
                {
                    try
                    {
                  
                        objEntidades.Codigo = textCode.Text;
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;
                        objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

                        if (ValidarDatos())
                        {
                            objNegocio.CreandoProductos(objEntidades);
                            FrmSucess.confirmacionForm("GUARDADO");
                            Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        FrmexepcionVacio.confirmacionForm("NO SE PERMITEN DATOS VACIOS");
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        objEntidades.Idproducto = Convert.ToInt32(txtIdproducto.Text);
                        objEntidades.Codigo = textCode.Text;
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.Descripcion = txtDescripcion.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;
                        objEntidades.Idcategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

                        if(ValidarDatos())
                        {
                            objNegocio.ActualizandoProductos(objEntidades);
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

            //Close();

        }

        private void btngenerarcodigo_Click(object sender, EventArgs e)
        {

        }
    }


}