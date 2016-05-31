using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class DocumentosDTO
    {
           public long idDocumento { get; set; }
           public Nullable<long> idPaciente { get; set; }
           public string TipoDocumento { get; set; }
           public string observaciones { get; set; }
           public string Archivo { get; set; }
       
    }
}
