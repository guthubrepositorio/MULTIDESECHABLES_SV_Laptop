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
    public partial class FrmMantenimientoEmpleado : Form
    {
        FrmEmpleado frm = new FrmEmpleado();
        E_Empleado objEntidades = new E_Empleado();
        N_Empleado objNegocio = new N_Empleado();
        public bool Update = false;



        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            cbosexo.Items.Add(new OpcionCombo() { Valor = "Masculino", Texto = "Masculino" });
            cbosexo.Items.Add(new OpcionCombo() { Valor = "Femenino", Texto = "Femenino" });
            cbosexo.DisplayMember = "Texto";
            cbosexo.ValueMember = "Valor";
            cbosexo.SelectedIndex = 0;

        }
        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtnombrecompleto.Text == "")
            {
                ok = false;
                mgnombrecompleto("ingrese el nombre completo");
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
            if (txtresidencia.Text == "")
            {
                ok = false;

                mgresidencia("ingrese la residencia");
            }
            if (txtdui.Text == "")
            {
                ok = false;
                mgdui("ingrese el dui");
            }
            //if (txtsexo.Text == "")
            //{
            //    ok = false;

            //    mgsexo("ingrese el genero de sexo");
            //}
            if (txthorarioentrada.Text == "")
            {
                ok = false;
                mgentrada("ingrese el horario de entrada");
            }
            if (txthorariosalida.Text == "")
            {
                ok = false;
                mgsalida("ingrese el horario de salida");
            }
            if (txtdiasdescanso.Text == "")
            {
                ok = false;
                mgdescanso("ingrese los dias de descanso");
            }
            if (txtencargadode.Text == "")
            {
                ok = false;
                mgencargado("ingrese el area de la que se encarga");
            }
            if (txtsalariobruto.Text == "")
            {
                ok = false;
                mgsalario("ingrese el salario");
            }
            if (txtdescuentos.Text == "")
            {
                ok = false;
                mgdescuento("ingrese  el descuento");
            }
            if (txtsueldoneto.Text == "")
            {
                ok = false;
                mgsueldo("ingrese  el sueldo");
            }
            return ok;
        }

        private void mgnombrecompleto(string msg)
        {
            lblnombrecomple.Text = "        " + msg;
           lblnombrecomple.Visible = true;
        }
        private void mgtelefono(string msg)
        {
            lbltelefono.Text = "        " + msg;
            lbltelefono.Visible = true;
        }
        private void mgcorreo(string msg)
        {
            lblcorreo.Text = "        " + msg;
            lblcorreo.Visible = true;
        }
        private void mgresidencia(string msg)
        {
            lblresidencia.Text = "        " + msg;
            lblresidencia.Visible = true;
        }
        private void mgdui(string msg)
        {
            lbldui.Text = "        " + msg;
            lbldui.Visible = true;
        }
 
        private void mgentrada(string msg)
        {
            lblentrada.Text = "        " + msg;
            lblentrada.Visible = true;
        }
        private void mgsalida(string msg)
        {
            lblsalida.Text = "        " + msg;
            lblsalida.Visible = true;
        }

        private void mgdescanso(string msg)
        {
            lbldescanso.Text = "        " + msg;
            lbldescanso.Visible = true;
        }
        private void mgencargado(string msg)
        {
            lblentrada.Text = "        " + msg;
            lblentrada.Visible = true;
        }

        private void mgsalario(string msg)
        {
            lblsalario.Text = "        " + msg;
            lblsalario.Visible = true;
        }
        private void mgdescuento(string msg)
        {
            lbldescuentos.Text = "        " + msg;
            lbldescuentos.Visible = true;
        }
        private void mgsueldo(string msg)
        {
            lblsueldoneto.Text = "        " + msg;
            lblsueldoneto.Visible = true;
        }

        private void txtnombrecompleto_Enter(object sender, EventArgs e)
        {
            lblnombrecomple.Visible = false;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            lbltelefono.Visible = false;
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            lblcorreo.Visible = false;
        }

        private void txtresidencia_Enter(object sender, EventArgs e)
        {
            lblresidencia.Visible = false;
        }

        private void txtdui_Enter(object sender, EventArgs e)
        {
            lbldui.Visible = false;
        }

        private void txtsexo_Enter(object sender, EventArgs e)
        {
            lblsexo.Visible = false;
        }

        private void txthorarioentrada_Enter(object sender, EventArgs e)
        {
            lblentrada.Visible = false;
        }

        private void txthorariosalida_Enter(object sender, EventArgs e)
        {
            lblsalida.Visible = false;
        }

        private void txtdiasdescanso_Enter(object sender, EventArgs e)
        {
            lbldescanso.Visible = false;
        }

        private void txtencargadode_Enter(object sender, EventArgs e)
        {
            lblencargadode.Visible = false;
        }

        private void txtsalariobruto_Enter(object sender, EventArgs e)
        {
            lblsalario.Visible = false;
        }

        private void txtdescuentos_Enter(object sender, EventArgs e)
        {
            lbldescuentos.Visible = false;
        }

        private void txtsueldoneto_Enter(object sender, EventArgs e)
        {
            lblsueldoneto.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    if (txtsalariobruto.Text == "")
                    {
                        mgsalario("Formato moneda incorrecto");
                        return;
                    }
                    if (txtdescuentos.Text == "")
                    {
                        mgdescuento("Formato moneda incorrecto");
                        return;
                    }
                    if (txtsueldoneto.Text == "")
                    {
                        mgsueldo("Formato moneda incorrecto");
                        return;
                    }

                    objEntidades.NombreCompleto = txtnombrecompleto.Text;
                    objEntidades.Telefono = txtTelefono.Text;
                    objEntidades.Correo = txtcorreo.Text;
                    objEntidades.Residencia = txtresidencia.Text.ToUpper();
                    objEntidades.Dui = txtdui.Text;
                    objEntidades.Sexo = cbosexo.Text;
                    objEntidades.HorarioEntrada = txthorarioentrada.Text.ToUpper();
                    objEntidades.HorarioSalida = txthorariosalida.Text.ToUpper();
                    objEntidades.DiasDescanso = txtdiasdescanso.Text.ToUpper();
                    objEntidades.EncargadoDe = txtencargadode.Text.ToUpper();
                    objEntidades.SalarioBruto = Convert.ToDecimal(txtsalariobruto.Text);
                    objEntidades.Descuentos = Convert.ToDecimal(txtdescuentos.Text);
                    objEntidades.SueldoNeto = Convert.ToDecimal(txtsueldoneto.Text);

                    if (ValidarDatos())
                    {
                        objNegocio.CreandoEmpleado(objEntidades);
                        FrmSucess.confirmacionForm("GUARDADO");
                        Limpiar();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("NO SE PUDO GUARDAR EL USUARIO" + ex);
                }
            }





            if (Update == true)
            {
                try
                {
                    if (txtsalariobruto.Text == "")
                    {
                        mgsalario("Formato moneda incorrecto");
                        return;
                    }
                    if (txtdescuentos.Text == "")
                    {
                        mgdescuento("Formato moneda incorrecto");
                        return;
                    }
                    if (txtsueldoneto.Text == "")
                    {
                        mgsueldo("Formato moneda incorrecto");
                        return;
                    }

                    objEntidades.IdEmpleado = Convert.ToInt32(txtid.Text);
                    objEntidades.NombreCompleto = txtnombrecompleto.Text;
                    objEntidades.Telefono = txtTelefono.Text;
                    objEntidades.Correo = txtcorreo.Text;
                    objEntidades.Residencia = txtresidencia.Text.ToUpper();               
                    objEntidades.Dui = txtdui.Text;
                    objEntidades.Sexo = cbosexo.Text;
                    objEntidades.HorarioEntrada = txthorarioentrada.Text.ToUpper();
                    objEntidades.HorarioSalida = txthorariosalida.Text.ToUpper();
                    objEntidades.DiasDescanso = txtdiasdescanso.Text.ToUpper();
                    objEntidades.EncargadoDe = txtencargadode.Text.ToUpper();
                    objEntidades.SalarioBruto = Convert.ToDecimal(txtsalariobruto.Text);
                    objEntidades.Descuentos = Convert.ToDecimal(txtdescuentos.Text);
                    objEntidades.SueldoNeto = Convert.ToDecimal(txtsueldoneto.Text);
                    if (ValidarDatos())
                    {
                        objNegocio.ActualizandoEmpleado(objEntidades);
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
        private void calcularcambio()
        {

            if (txtsalariobruto.Text.Trim() == "")
            {
                MessageBox.Show("debe ingresar el salario y el descuento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal descuento;
            decimal salario = Convert.ToDecimal(txtsalariobruto.Text);

            if (txtdescuentos.Text.Trim() == "")
            {
                txtdescuentos.Text = "0";
            }
            if (decimal.TryParse(txtdescuentos.Text.Trim(), out descuento))
            {
                {
                    decimal sueldo = salario - descuento;
                    txtsueldoneto.Text = sueldo.ToString("0.00");
                }
            }

        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtnombrecompleto.Text = "";
            txtTelefono.Text = "";
            txtresidencia.Text = "";
            txtcorreo.Text = "";
            txtdui.Text = "";
            txthorarioentrada.Text = "";
            txthorariosalida.Text = "";
            txtdiasdescanso.Text = "";
            txtencargadode.Text = "";
            txtsalariobruto.Text = "";
            txtdescuentos.Text = "";
            txtsueldoneto.Text = "";
        }

        private void closeFormCategory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnombrecompleto_KeyPress(object sender, KeyPressEventArgs e)
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
                txtresidencia.Focus();
            }
        }

        private void txtresidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdui.Focus();
            }
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbosexo.Focus();
            }
        }

        private void cbosexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthorarioentrada.Focus();
            }
        }

        private void txthorarioentrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txthorariosalida.Focus();
            }
        }

        private void txthorariosalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdiasdescanso.Focus();
            }
        }

        private void txtdiasdescanso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtencargadode.Focus();
            }
        }

        private void txtencargadode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtsalariobruto.Focus();
            }
        }
        private void txtsalariobruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtsalariobruto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
                txtdescuentos.Focus();
            }

        }

        private void txtdescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtdescuentos.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
        private void txtdescuentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txtsueldoneto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtsueldoneto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
                        if (txtsalariobruto.Text == "")
                        {
                            mgsalario("Formato moneda incorrecto");
                            return;
                        }
                        if (txtdescuentos.Text == "")
                        {
                            mgdescuento("Formato moneda incorrecto");
                            return;
                        }
                        if (txtsueldoneto.Text == "")
                        {
                            mgsueldo("Formato moneda incorrecto");
                            return;
                        }

                        objEntidades.NombreCompleto = txtnombrecompleto.Text;
                        objEntidades.Telefono = txtTelefono.Text;
                        objEntidades.Correo = txtcorreo.Text;
                        objEntidades.Residencia = txtresidencia.Text.ToUpper();
                        objEntidades.Dui = txtdui.Text;
                        objEntidades.Sexo = cbosexo.Text;
                        objEntidades.HorarioEntrada = txthorarioentrada.Text.ToUpper();
                        objEntidades.HorarioSalida = txthorariosalida.Text.ToUpper();
                        objEntidades.DiasDescanso = txtdiasdescanso.Text.ToUpper();
                        objEntidades.EncargadoDe = txtencargadode.Text.ToUpper();
                        objEntidades.SalarioBruto = Convert.ToDecimal(txtsalariobruto.Text);
                        objEntidades.Descuentos = Convert.ToDecimal(txtdescuentos.Text);
                        objEntidades.SueldoNeto = Convert.ToDecimal(txtsueldoneto.Text);

                        if (ValidarDatos())
                        {
                            objNegocio.CreandoEmpleado(objEntidades);
                            FrmSucess.confirmacionForm("GUARDADO");
                            Limpiar();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("NO SE PUDO GUARDAR EL USUARIO" + ex);
                    }
                }

                if (Update == true)
                {
                    try
                    {
                        if (txtsalariobruto.Text == "")
                        {
                            mgsalario("Formato moneda incorrecto");
                            return;
                        }
                        if (txtdescuentos.Text == "")
                        {
                            mgdescuento("Formato moneda incorrecto");
                            return;
                        }
                        if (txtsueldoneto.Text == "")
                        {
                            mgsueldo("Formato moneda incorrecto");
                            return;
                        }

                        objEntidades.IdEmpleado = Convert.ToInt32(txtid.Text);
                        objEntidades.NombreCompleto = txtnombrecompleto.Text;
                        objEntidades.Telefono = txtTelefono.Text;
                        objEntidades.Correo = txtcorreo.Text;
                        objEntidades.Residencia = txtresidencia.Text.ToUpper();
                        objEntidades.Dui = txtdui.Text;
                        objEntidades.Sexo = cbosexo.Text;
                        objEntidades.HorarioEntrada = txthorarioentrada.Text.ToUpper();
                        objEntidades.HorarioSalida = txthorariosalida.Text.ToUpper();
                        objEntidades.DiasDescanso = txtdiasdescanso.Text.ToUpper();
                        objEntidades.EncargadoDe = txtencargadode.Text.ToUpper();
                        objEntidades.SalarioBruto = Convert.ToDecimal(txtsalariobruto.Text);
                        objEntidades.Descuentos = Convert.ToDecimal(txtdescuentos.Text);
                        objEntidades.SueldoNeto = Convert.ToDecimal(txtsueldoneto.Text);
                        if (ValidarDatos())
                        {
                            objNegocio.ActualizandoEmpleado(objEntidades);
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
