using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidesechables.EntidadesDeNegocio
{
    public class E_Proveedor
    {
        private int _idproveedor;
        private string _documento;
        private string _razonSocial;
        private string _correo;
        private string _telefono;
        private string _fechaRegistro;
        private string _totalproveedores;
        private string _buscar;

        public int Idproveedor { get => _idproveedor; set => _idproveedor = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string Totalproveedores { get => _totalproveedores; set => _totalproveedores = value; }
        public string Buscar { get => _buscar; set => _buscar = value; }
    }
}
