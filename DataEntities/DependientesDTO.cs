using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DataEntities
{
   
    public partial class DependientesDTO
    {
        public enum parentesco
        {

            Conyugue = 0,

            Madre = 1,

            Padre = 2,

            Hijo = 3,

            Hija = 4,

            Otro = 5
        };

        public long Dependienteid { get; set; }
        public string Nombre { get; set; }
        public parentesco Parentesco { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public Nullable<long> PacienteId { get; set; }
    }
}
