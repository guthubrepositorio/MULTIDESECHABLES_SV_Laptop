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
    public partial class FrmDetalleUsuario : Form
    {
        FrmUsuarios frm = new FrmUsuarios();
        E_Usuario objEntidades = new E_Usuario();
        N_Usuario objNegocio = new N_Usuario();
        public bool Update = false;


        public FrmDetalleUsuario()
        {
            InitializeComponent();
        }

        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetalleUsuario_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<E_Rol> listaRol = new N_Rol().Listar();

            foreach (E_Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
        }


        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtdocumento.Text == "")
            {
                ok = false;
                mgdocumento("ingrese el numero de Documento");
            }
            if (txtnombrecompleto.Text == "")
            {
                ok = false;

                mgnombre("ingrese el nombre de usuario");
            }
            if (txtresidencia.Text == "")
            {
                ok = false;

                mgresidencia("ingrese la residencia del usuario");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;

                mgtelefono("ingrese el telefono");
            }
            if (txtcorreo.Text == "")
            {
                ok = false;
                mgcorreo("ingrese el correo");
            }
            if (txtclave.Text == "")
            {
                ok = false;

                mgclave("ingrese la clave");
            }
            if (txtconfirmarclave.Text == "")
            {
                ok = false;
                mgConfirmacion("ingrese la confirmacion de la clave");
            }
            
            return ok;
        }
        private void mgdocumento(string msg)
        {
            lblDc.Text = "        " + msg;
            lblDc.Visible = true;
        }
        private void mgnombre(string msg)
        {
            lblNu.Text = "        " + msg;
            lblNu.Visible = true;
        }
        private void mgresidencia(string msg)
        {
            lblresi.Text = "        " + msg;
            lblresi.Visible = true;
        }
        private void mgtelefono(string msg)
        {
            lblTele.Text = "        " + msg;
            lblTele.Visible = true;
        }

        private void mgcorreo(string msg)
        {
            lblCorr.Text = "        " + msg;
            lblCorr.Visible = true;
        }
        private void mgclave(string msg)
        {
            lblCla.Text = "        " + msg;
            lblCla.Visible = true;
        }
        private void mgConfirmacion(string msg)
        {
            lblConCla.Text = "        " + msg;
            lblConCla.Visible = true;
        }
        private void txtdocumento_Enter(object sender, EventArgs e)
        {
            lblDc.Visible = false;
        }
        
        private void txtnombrecompleto_Enter(object sender, EventArgs e)
        {
            lblNu.Visible = false;
        }
        private void txtresidencia_Enter(object sender, EventArgs e)
        {
            lblresi.Visible = false;
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            lblTele.Visible = false;
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            lblCorr.Visible = false;
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            lblCla.Visible = false;
        }

        private void txtconfirmarclave_Enter(object sender, EventArgs e)
        {
            lblConCla.Visible = false;
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {                    
                        objEntidades.Documento = txtdocumento.Text;
                        objEntidades.NombreCompleto = txtnombrecompleto.Text;
                        objEntidades.Residencia = txtresidencia.Text;
                        objEntidades.Telefono = txtTelefono.Text;
                        objEntidades.Correo = txtcorreo.Text;
                        objEntidades.Clave = txtclave.Text;
                        objEntidades.oRol = new E_Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) };
                        objEntidades.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                    if (ValidarDatos())
                    {
                        objNegocio.Registrar(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Limpiar();
                    }
                       

                }

                catch(Exception ex)
                {
                 MessageBox.Show("NO SE PUDO GUARDAR EL USUARIO" + ex);
                }
            }





            if (Update == true)
            {
               

                try
                {
                    objEntidades.IdUsuario = Convert.ToInt32(txtid.Text);
                    objEntidades.Documento = txtdocumento.Text;
                    objEntidades.NombreCompleto = txtnombrecompleto.Text;
                    objEntidades.Residencia = txtresidencia.Text;
                    objEntidades.Telefono = txtTelefono.Text;
                    objEntidades.Correo = txtcorreo.Text;
                    objEntidades.Clave = txtclave.Text;
                    objEntidades.oRol = new E_Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) };
                    objEntidades.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                    if (ValidarDatos())
                    {
                        objNegocio.Editar(objEntidades);
                        FrmSucess.confirmacionForm("EDITADO");
                        Close();
                        Limpiar();
                    }
                   


                    Update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO EDITAR" + ex);
                }

                   
            }
        }

        private void Limpiar()
        {

            //txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtresidencia.Text = "";
            txtTelefono.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            txtdocumento.Select();
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtnombrecompleto.Focus();
            }
        }

        private void txtnombrecompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtresidencia.Focus();
            }
        }

        private void txtresidencia_KeyPress(object sender, KeyPressEventArgs e)
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
                txtcorreo.Focus();
            }
        }
        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtclave.Focus();
            }
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtconfirmarclave.Focus();
            }
        }

        private void txtconfirmarclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cborol.Focus();
            }
        }

        private void cborol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               cboestado.Focus();
            }
        }

        private void cboestado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
              if (Update == false)
              {
                try
                {

                    {

                        objEntidades.Documento = txtdocumento.Text;
                        objEntidades.NombreCompleto = txtnombrecompleto.Text;
                        objEntidades.Residencia = txtresidencia.Text;
                        objEntidades.Telefono = txtTelefono.Text;
                        objEntidades.Correo = txtcorreo.Text;
                        objEntidades.Clave = txtclave.Text;
                        objEntidades.oRol = new E_Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) };
                        objEntidades.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                            if (ValidarDatos())
                            {
                                objNegocio.Registrar(objEntidades);
                                FrmSucess.confirmacionForm("GUARDADO");
                                Limpiar();


                            }
                    };

                }

                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO GUARDAR EL PRODUCTO" + ex);
                }
              }





              if (Update == true)
              {


                try
                {
                    objEntidades.IdUsuario = Convert.ToInt32(txtid.Text);
                    objEntidades.Documento = txtdocumento.Text;
                    objEntidades.NombreCompleto = txtnombrecompleto.Text;
                    objEntidades.Residencia = txtresidencia.Text;
                    objEntidades.Telefono = txtTelefono.Text;
                    objEntidades.Correo = txtcorreo.Text;
                    objEntidades.Clave = txtclave.Text;
                    objEntidades.oRol = new E_Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) };
                    objEntidades.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

                        if (ValidarDatos())
                        {
                            objNegocio.Editar(objEntidades);
                            FrmSucess.confirmacionForm("EDITADO");
                            Close();
                            Limpiar();


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
