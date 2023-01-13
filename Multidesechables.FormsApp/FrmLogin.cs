using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.LogicaDeNegocio;

namespace Multidesechables.FormsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            claveOculta();
            //mostrandoclave();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



       

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textuser_Enter(object sender, EventArgs e)
        {

            if (textuser.Text == "USUARIO")
            {
                textuser.Text = "";
                textuser.ForeColor = Color.LightGray;
            }
        }

        private void textuser_Leave(object sender, EventArgs e)
        {

            if (textuser.Text == "")
            {
                textuser.Text = "USUARIO";
                textuser.ForeColor = Color.DimGray;
            }
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "CONTRASEÑA") 
            {
                textpass.Text = "";
                textpass.ForeColor = Color.LightGray;
               // textpass.UseSystemPasswordChar = true;
            }
        }

        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.DimGray;
               // textpass.UseSystemPasswordChar = false;
            }
        }

        
     
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            List<E_Usuario> TEST = new N_Usuario().Listar();

            E_Usuario ousuario = new N_Usuario().Listar().Where(u => u.Documento == textuser.Text && u.Clave == textpass.Text).FirstOrDefault();



            if (ousuario != null)
            {


                FrmInicio form = new FrmInicio(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_clossing;
            }
            else
            {
                //MessageBox.Show("No se encontro el usuario", "Mensage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                FrmDenegacionAceso.confirmacionForm("ACCESO DENEGADO");
            }


        }
        private void frm_clossing(object sender , FormClosingEventArgs e)
        {
            textuser.Text = "";
            textpass.Text ="";
            this.Show();
        }


        private void claveOculta()
        {
            mostrarclave.BringToFront();
            textpass.PasswordChar = '*';

            textpass.UseSystemPasswordChar = true;
        }

        //private void mostrandoclave()
        // {
        //     ocultarclave.BringToFront();
        //     textpass.PasswordChar = '\0';

        //     textpass.UseSystemPasswordChar = false;
        // }


        private void ocultarclave_Click(object sender, EventArgs e)
        {


            mostrarclave.BringToFront();
            textpass.PasswordChar = '*';


            textpass.UseSystemPasswordChar = true;




        }


        private void mostrarclave_Click(object sender, EventArgs e)
        {

            ocultarclave.BringToFront();
            textpass.PasswordChar = '\0';

            textpass.UseSystemPasswordChar = false;


        }



    }
}
