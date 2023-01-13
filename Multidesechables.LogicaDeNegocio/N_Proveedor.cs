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
    public class N_Proveedor
    {


        D_Proveedor objDato = new D_Proveedor();
        E_Proveedor objNegocio = new E_Proveedor();


        public List<E_Proveedor> Listar()
        {
            return objDato.Listar();
        }


        public DataTable ListandoProveedores()
          {
              return objDato.ListarProveedor();
          }
        
        

        public DataTable BuscandoProveedores(string buscar)
        {
            objNegocio.Buscar = buscar;
            return objDato.BuscarProveedor(objNegocio);
        }

        public void CreandoProveedores(E_Proveedor Proveedor)
        {
            objDato.CrearProveedor(Proveedor);
        }

        public void ActualizandoProveedores(E_Proveedor Proveedor)
        {
            objDato.ActualizarProveedor(Proveedor);
        }

        public void BorrandoProveedores(int idproveedores)
        {
            objDato.BorrarProveedor(idproveedores);
        }

        public void MostrandoTotales(E_Proveedor Proveedor)
        {
            objDato.mostrarTotales(Proveedor);
        }

    }
}
