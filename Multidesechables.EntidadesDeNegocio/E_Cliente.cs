using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Cliente
    {
        private int _idcliente;
        private string _documento;
        private string _nombre;
        private string _fechaRegistro;
        private string _buscar;
        private string _totalClientes;

        public int Idcliente { get => _idcliente; set => _idcliente = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string Buscar { get => _buscar; set => _buscar = value; }
        public string TotalClientes { get => _totalClientes; set => _totalClientes = value; }
    }
}
