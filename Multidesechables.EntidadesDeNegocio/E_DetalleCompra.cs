using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_DetalleCompra
    {
        //private int _idDetalleCompra;
        //private E_Compra _idcompra;
        //private E_Producto _idproducto;
        //private decimal _precioCompra;
        //private decimal _precioVenta;
        //private int _cantidad;
        //private decimal _montoTotal;
        //private string fechaRegistro;

        public int IdDetalleCompra { get; set; }
        public E_Producto oProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }


    }


}
