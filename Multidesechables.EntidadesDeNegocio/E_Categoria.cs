using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Categoria
    {

        private int _idcategoria;
        private string _codigo;       
        private string _descripcion;

        public int Idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}



