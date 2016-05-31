using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
   public  class CiudadesDTO
    {
        public int Id { get; set; }
        public string Ciudad { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
