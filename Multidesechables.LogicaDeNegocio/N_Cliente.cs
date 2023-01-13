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
    public class N_Cliente
    {
        D_Cliente objDato = new D_Cliente();
        E_Cliente objNegocio = new E_Cliente();
        public DataTable ListandoCliente()
        {
            return objDato.ListarClientes();
        }


        public DataTable BuscandoClientes(string buscar)
        {
            objNegocio.Buscar = buscar;
            return objDato.BuscarClientes(objNegocio);
        }

        public void CreandoClientes(E_Cliente Cliente)
        {
            objDato.CrearCliente(Cliente);
        }

        public void ActualizandoClientes(E_Cliente Cliente)
        {
            objDato.ActualizarCliente(Cliente);
        }

        public void BorrandoClientes(int idcliente)
        {
            objDato.BorrarCliente(idcliente);
        }

        public void MostrandoTotales(E_Cliente Cliente)
        {
            objDato.mostrarTotales(Cliente);
        }




    }
}
