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
    public class N_Producto
    {
       
        D_Producto objDato = new D_Producto();
        E_Producto objNegocio = new E_Producto();


        public List<E_Producto> Listar()
        {
            return objDato.Listar();
        }


        public DataTable ListandoProductos()
        {
            return objDato.ListarProductos();
        }

        public DataTable BuscandoProductos(string buscar)
        {
            objNegocio.Buscar = buscar;
            return objDato.BuscarProductos(objNegocio);
        }

        public void CreandoProductos(E_Producto Producto)
        {
            objDato.CrearProductos(Producto);
        }

        public void ActualizandoProductos(E_Producto Producto)
        {
            objDato.ActualizarProducto(Producto);
        }

        public void CreandoProductosEstado(E_Producto Producto)
        {
            objDato.CrearProductosEstado(Producto);
        }

        public void ActualizandoProductosEstado(E_Producto Producto)
        {
            objDato.ActualizarProductoEstado(Producto);
        }


        public void BorrandoProductos(int idproductos)
        {
            objDato.BorrarProductos(idproductos);
        }

        public void MostrandoTotales(E_Producto Producto)
        {
            objDato.mostrarTotales(Producto);
        }
    }
}
