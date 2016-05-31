using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class MedicosDTO
    {
        
            public int doctorid { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string telefono { get; set; }
            public string telefono2 { get; set; }
            public bool? activo { get; set; }
            public string horariodeconsulta { get; set; }
            public int especialidad { get; set; }
            public string ncm { get; set; }
            public bool? especialista { get; set; }
        
    }
}
