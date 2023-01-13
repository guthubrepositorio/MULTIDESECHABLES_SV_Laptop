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
    public partial class FrmMantenimientoProveedor : Form
    {
        FrmProveedor frm = new FrmProveedor();
        E_Proveedor objEntidades = new E_Proveedor();
        N_Proveedor objNegocio = new N_Proveedor();
      
        public bool Update = false;

        public FrmMantenimientoProveedor()
        {
            InitializeComponent();


        }

        private void closeFormProveedor_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtDocumento.Text == "")
            {
                ok = false;
                mgdocumento("ingrese el numero de Documento");
            }
            if (txtRazonSocial.Text == "")
            {
                ok = false;

                mgrazonsocial("ingrese la razon social");
            }
            if (txtCorreo.Text == "")
            {
                ok = false;
                mgcorreo("ingrese el correo");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;

                mgtelefono("ingrese el telefono");
            }

            return ok;
        }
        private void mgdocumento(string msg)
        {
            lblDc.Text = "        " + msg;
            lblDc.Visible = true;
        }
        private void mgrazonsocial(string msg)
        {
            lblrazon.Text = "        " + msg;
            lblrazon.Visible = true;
        }
        private void mgcorreo(string msg)
        {
            lblcorreo.Text = "        " + msg;
            lblcorreo.Visible = true;
        }
        private void mgtelefono(string msg)
        {
            lbltelefono.Text = "        " + msg;
            lbltelefono.Visible = true;
        }
        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            lblDc.Visible = false;
        }

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            lblrazon.Visible = false;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            lblcorreo.Visible = false;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            lbltelefono.Visible = false;
        }







        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {

                    objEntidades.Documento = txtDocumento.Text.ToUpper();
                    objEntidades.RazonSocial = txtRazonSocial.Text.ToUpper();
                    objEntidades.Correo = txtCorreo.Text;
                    objEntidades.Telefono = txtTelefono.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;

                    if (ValidarDatos())
                    {
                        objNegocio.CreandoProveedores(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO GUARDAR EL PROVEEDOR" + ex);
                }
            }
            if (Update == true)
            {
                try
                {
                    objEntidades.Idproveedor = Convert.ToInt32(txtIdproveedor.Text);
                    objEntidades.Documento = txtDocumento.Text.ToUpper();
                    objEntidades.RazonSocial = txtRazonSocial.Text.ToUpper();
                    objEntidades.Correo = txtCorreo.Text;
                    objEntidades.Telefono = txtTelefono.Text;
                    objEntidades.FechaRegistro = txtFecha.Text;
                    if(ValidarDatos())
                    {
                        objNegocio.ActualizandoProveedores(objEntidades);
                        FrmSucess.confirmacionForm("EDITADO");
                        Close();
                    }
                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO EDITAR" + ex);
                }
            }

        }

        private void FrmMantenimientoProveedor_Load(object sender, EventArgs e)
        {

           txtFecha.Text =DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRazonSocial.Focus();
            }

        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCorreo.Focus();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Update == false)
                {
                    try
                    {

                        objEntidades.Documento = txtDocumento.Text.ToUpper();
                        objEntidades.RazonSocial = txtRazonSocial.Text.ToUpper();
                        objEntidades.Correo = txtCorreo.Text;
                        objEntidades.Telefono = txtTelefono.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;

                        //((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString();
                        //((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString();
                        // objEntidades.Estado = Convert.ToBoolean((OpcionCombo)cmbEstado.SelectedValue
                        //objEntidades.Estado = Convert.ToBoolean(cmbEstado.Text);
                        if(ValidarDatos())
                        {
                            objNegocio.CreandoProveedores(objEntidades);
                            FrmSucess.confirmacionForm("GUARDADO");
                            Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NO SE PUDO GUARDAR EL PROVEEDOR" + ex);
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        objEntidades.Idproveedor = Convert.ToInt32(txtIdproveedor.Text);
                        objEntidades.Documento = txtDocumento.Text.ToUpper();
                        objEntidades.RazonSocial = txtRazonSocial.Text.ToUpper();
                        objEntidades.Correo = txtCorreo.Text;
                        objEntidades.Telefono = txtTelefono.Text;
                        objEntidades.FechaRegistro = txtFecha.Text;

                        if (ValidarDatos())
                        {
                            objNegocio.ActualizandoProveedores(objEntidades);
                            FrmSucess.confirmacionForm("EDITADO");
                            Close();
                        }
                        Update = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NO SE PUDO EDITAR" + ex);
                    }
                }
            }
        }

      
    }
}


