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
    public partial class FrmCategoria : Form

    {
        N_Categoria objNegocio = new N_Categoria();
        E_Categoria objEntidad = new E_Categoria();
        
        
        private string idcategoria;
        private bool Editarse = false; 
      

        public FrmCategoria()
        {
            InitializeComponent();
            
        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Evento Load
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        public void accionesTabla()
        {
            tablaCategoria.Columns[0].Visible = false;
            tablaCategoria.Columns[1].Width = 110;
            tablaCategoria.Columns[2].Width = 370;

            tablaCategoria.ClearSelection();
            
        }


        private bool ValidarDatos()
        {
            bool ok = true;
            if (texCodigo.Text == "")
            {
                ok = false;
                mgcodigo("ingrese el codigo");
            }
            if (texDescripcion.Text == "")
            {
                ok = false;

                mgdescripcion("ingrese la descripcion de la categoria");
            }
           
            return ok;
        }

        private void mgcodigo(string msg)
        {
            lblcodigo.Text = "        " + msg;
            lblcodigo.Visible = true;
        }

        private void mgdescripcion(string msg)
        {
            lbldescripcion.Text = "        " + msg;
            lbldescripcion.Visible = true;
        }
        private void texCodigo_Enter(object sender, EventArgs e)
        {
            lblcodigo.Visible = false;
        }

        private void texDescripcion_Enter(object sender, EventArgs e)
        {
            lbldescripcion.Visible = false;
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Categoria objNegocio = new N_Categoria();
            tablaCategoria.DataSource = objNegocio.ListandoCategoria(buscar);
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBuscar.Text);
        }

        private void limpiarCajas()
        {
            Editarse = false;
            texCodigo.Text = "";
            texDescripcion.Text = "";
            
            texCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                Editarse = true; 
                idcategoria = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                texCodigo.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                texDescripcion.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)

            {
                try
                {
                    objEntidad.Codigo = texCodigo.Text;
                    objEntidad.Descripcion = texDescripcion.Text.ToUpper();

                    if (ValidarDatos())
                    {
                        objNegocio.InsertandoCategoria(objEntidad);
                        FrmSucess.confirmacionForm("GUARDADO");
                        mostrarBuscarTabla("");
                        limpiarCajas();
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);

                }
            }

            if (Editarse == true)

            {
                try
                {
                    objEntidad.Idcategoria = Convert.ToInt32(idcategoria);
                    objEntidad.Codigo = texCodigo.Text;
                    objEntidad.Descripcion = texDescripcion.Text.ToUpper();
                    if (ValidarDatos())
                    {
                        objNegocio.EditandoCategoria(objEntidad);
                        FrmSucess.confirmacionForm("EDITADO");
                        mostrarBuscarTabla("");
                        limpiarCajas();
                    }
                    Editarse = false;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resultado = new DialogResult();
                FrmInformacion frm = new FrmInformacion("ESTAS SEGURO DE QUE DESEAS ELIMINAR EL REGISTRO");
                resultado = frm.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                        objEntidad.Idcategoria = Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                        objNegocio.EliminandoCategoria(objEntidad);
                        FrmSucess.confirmacionForm("ELIMINADO");
                        mostrarBuscarTabla("");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("SELECIONE LA FILA DEL TEXTO QUE DESEA ELIMINAR" + ex);
            }

            /*
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                try
                {
                    objEntidad.Id = Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminandoCategoria(objEntidad);

                    MessageBox.Show("Eliminar Categoria");
                    mostrarBuscarTabla("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            */

        }

       

        private void texCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                texDescripcion.Focus();    
            }


        }

 
    }
}


