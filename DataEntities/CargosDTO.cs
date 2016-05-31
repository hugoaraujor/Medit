using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
   public  class CargosDTO
    {
        public int CargoId { get; set; }
        public Nullable<int> Tipocargo { get; set; }
        public Nullable<int> Grupo { get; set; }
        public string descripción { get; set; }
        public Nullable<decimal> coste { get; set; }
        public Nullable<decimal> precio1 { get; set; }
        public Nullable<decimal> precio2 { get; set; }
        public Nullable<decimal> precio3 { get; set; }
        public Nullable<decimal> precio4 { get; set; }
        public Nullable<decimal> precio5 { get; set; }
        public Nullable<bool> inventario { get; set; }
        public Nullable<bool> Kit { get; set; }
        public Nullable<bool> agrupable { get; set; }
        public string presentacion { get; set; }
        public string indicaciones { get; set; }
        public Nullable<bool> activo { get; set; }
        public string via { get; set; }
    }

   

   
}
