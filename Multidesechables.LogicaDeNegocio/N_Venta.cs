using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Multidesechables.AcceesoADatos;
using Multidesechables.EntidadesDeNegocio;

namespace Multidesechables.LogicaDeNegocio
{
   public class N_Venta
    {
       
        private D_Venta objcd_venta = new D_Venta();


        public int ObtenerCorrelativo()
        {
            return objcd_venta.ObtenerCorrelativo();
        }

        public bool Registrar(E_Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

        public E_Venta ObtenerVenta(string numero)
        {
            E_Venta oVenta = objcd_venta.ObtenerVenta(numero);

            if (oVenta.IdVenta != 0)
            {
                List<E_DetalleVenta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta);
                oVenta.oDetalle_Venta = oDetalleVenta;
            }

            return oVenta;
        }

    }
}
