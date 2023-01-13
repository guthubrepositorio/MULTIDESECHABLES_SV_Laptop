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
    public class N_Compra
    {

        private D_Compra objcd_compra = new D_Compra();


        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(E_Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public E_Compra ObtenerCompra(string numero)
        {

            E_Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<E_DetalleCompra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }
    }
}
