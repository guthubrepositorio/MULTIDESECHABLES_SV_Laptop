using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using Multidesechables.EntidadesDeNegocio;
using Multidesechables.LogicaDeNegocio;
using Multidesechables.FormsApp.Complementos;

namespace Multidesechables.FormsApp
{
    public partial class FrmInicio : Form
    {

        private static E_Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        public FrmInicio(E_Usuario objusuario = null)

        {

            if (objusuario == null)
                usuarioActual = new E_Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;


            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            List<E_Permiso> ListaPermisos = new N_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menu.Items)
            {

                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }


            PantallaOK();
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        public void PantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            imagenFondo.Visible = false;
            if (MenuActivo != null)
            {
                
                MenuActivo.BackColor = Color.Transparent;
                MenuActivo.IconColor = Color.White;
                MenuActivo.ForeColor = Color.White;
            }

            menu.BackColor  = Color.Transparent;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                
                FormularioActivo.Close();
                MenuActivo.IconColor = Color.GreenYellow;
                MenuActivo.ForeColor = Color.GreenYellow;
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.GhostWhite;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();

            Form mensaje = new FrmInformacion("SEGURO QUE QUIERES CERRAR SESIÓN");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                this.Show();
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuusuarios, new FrmUsuarios());
        }



        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuclientes, new FrmClientes());
        }

        private void menuproductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuproductos, new FrmProductos());
      
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuproveedores, new FrmProveedor());
        }
        private void menuventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new FrmVentas(usuarioActual));
        }
        private void menucompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new FrmCompras(usuarioActual));
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes , new FrmReporteCompras()); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          AcercaDe frm = new AcercaDe();
            frm.ShowDialog();
        }

        private void ReporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureporteventas, new FrmReporteVentas());
        }

        private void menumantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenimiento, new FrmMantenimiento());
        }

        private void menuempleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuempleados, new FrmEmpleado());
        }

        private void menuestadostock_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuestadostock, new FrmEstado());
        }

      
    }
}
