using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public  class UsuariosDTO
    {
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public bool activo { get; set; }
        public int TipodeAcceso { get; set; }
        public string Modulos { get; set; }
        public Nullable<System.DateTime> lastlogin { get; set; }
        public byte[] created { get; set; }
        public Nullable<decimal> Rol { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }
        public string Nombres { get; set; }
        public string password { get; set; }
    }
}
