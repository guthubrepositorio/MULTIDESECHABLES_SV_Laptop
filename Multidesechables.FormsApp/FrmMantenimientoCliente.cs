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
    public partial class FrmMantenimientoCliente : Form
    {

        FrmClientes frm = new FrmClientes();
        E_Cliente objEntidades = new E_Cliente();
        N_Cliente objNegocio = new N_Cliente();

        public bool Update = false;


        public FrmMantenimientoCliente()
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
                msgdocumento("Falta el Documento");
            }
            if (txtNombre.Text == "")
            {
                ok = false;

                msgerror("Falta el nombre");
            }
         
            return ok;
            
        }


        private void msgerror(string msg)
        {
            lblerror.Text = "        " + msg;
            lblerror.Visible = true;

        }

        private void msgdocumento(string msg)
        {
            lblDo.Text = "        " + msg;
            lblDo.Visible = true;
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            lblDo.Visible = false;
        }


        private void txtNombre_Enter(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {

                try
                {
                    
                    objEntidades.Documento = txtDocumento.Text.ToUpper();
                    objEntidades.Nombre = txtNombre.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;

                    if(ValidarDatos())
                    {
                        objNegocio.CreandoClientes(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Close();

                    }

                }

                catch (Exception ex)
                {
                    FrmexepcionVacio.confirmacionForm("Error");
                  

                }

            }

            if (Update == true)
             {
                try
                {
                    objEntidades.Idcliente = Convert.ToInt32(txtIdcliente.Text);
                    objEntidades.Documento = txtDocumento.Text.ToUpper();
                    objEntidades.Nombre = txtNombre.Text.ToUpper();
                    objEntidades.FechaRegistro = txtFecha.Text;

                    if (ValidarDatos())
                    {
                        objNegocio.ActualizandoClientes(objEntidades);
                        FrmSucess.confirmacionForm("EDITADO");

                        Close();
                    }
             
                    Update = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("NO SE PUDO EDITAR" + ex);
                }
             }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

                if (Update == false)
                {
                    try
                    {

                        objEntidades.Documento = txtDocumento.Text.ToUpper();
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;


                        if (ValidarDatos())
                        {
                            objNegocio.CreandoClientes(objEntidades);
                            FrmSucess.confirmacionForm("GUARDADO");
                            Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NO SE PUDO GUARDAR EL CLIENTE" + ex);
                    }
                }
                if (Update == true)
                {
                    try
                    {
                        objEntidades.Idcliente = Convert.ToInt32(txtIdcliente.Text);
                        objEntidades.Documento = txtDocumento.Text.ToUpper();
                        objEntidades.Nombre = txtNombre.Text.ToUpper();
                        objEntidades.FechaRegistro = txtFecha.Text;

                        if(ValidarDatos())
                        {
                            objNegocio.ActualizandoClientes(objEntidades);
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

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

    }
}
