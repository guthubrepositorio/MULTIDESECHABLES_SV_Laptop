using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Multidesechables.AcceesoADatos;
using Multidesechables.EntidadesDeNegocio;


namespace Multidesechables.LogicaDeNegocio
{
    public class N_Usuario


    {

         D_Usuario objcd_usuario = new D_Usuario();
        E_Usuario objNegocio = new E_Usuario();


        public DataTable ListandoUsuario()
        {
            return  objcd_usuario.ListarUsuario();
        }


        public DataTable BuscandoUsuario(string buscar)
        {
            objNegocio.Buscar = buscar;
            return objcd_usuario.BuscarUsuario(objNegocio);
        }


        public List<E_Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }


        public void Registrar(E_Usuario Usuario)
        {
            objcd_usuario.Registrar(Usuario);
        }

        public void Editar(E_Usuario Usuario)
        {
            objcd_usuario.Editar(Usuario);

        }


        public bool Eliminar(E_Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }


        public void MostrandoTotales(E_Usuario Usuario)
        {
            objcd_usuario.mostrarTotales(Usuario);
        }

    }


}
