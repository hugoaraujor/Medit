using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
   public class EmpresasDTO
    {
            public int Id { get; set; }
            public string Empresa { get; set; }
            public string RIF { get; set; }
            public string Direccion { get; set; }
            public string Contacto { get; set; }
            public string Telefonos { get; set; }
            public string Correo { get; set; }
            public byte[] created { get; set; }
            public Nullable<bool> Active { get; set; }
            public Nullable<bool> Aseguradora { get; set; }
            public Nullable<int> creditodias { get; set; }
            public Nullable<decimal> limite { get; set; }
    }
}
