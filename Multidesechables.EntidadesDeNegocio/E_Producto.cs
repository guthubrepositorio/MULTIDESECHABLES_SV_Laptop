using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Producto
    
  {
        private int idproducto;
        private string codigo;
        private string descripcion;
        private string nombre;
        private decimal precioCompra;
        private decimal precioVenta;
        private int stock;
        private int stockminimo;
        private int stockmaximo;
        private string estado;
        private string fechaRegistro;
        public E_Categoria oCategoria { get; set; }
        private int idcategoria;
        private string buscar;
        private string totalcategorias;
        private string totalproductos;
        private string sumStock;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Stockminimo { get => stockminimo; set => stockminimo = value; }
        public int Stockmaximo { get => stockmaximo; set => stockmaximo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Buscar { get => buscar; set => buscar = value; }
        public string Totalcategorias { get => totalcategorias; set => totalcategorias = value; }
        public string Totalproductos { get => totalproductos; set => totalproductos = value; }
        public string SumStock { get => sumStock; set => sumStock = value; }
    }
}

