using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
   public class DiagnosticoManager
    {
        public List<string> Getsintomas()
        {
            List<string> L = new List<string>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.diagnosticos
                            select new DiagnosticosDTO{diagnostico = x.diagnostico,id = x.id}).ToList<DiagnosticosDTO>();
                foreach (var entity in query)
                {
                    L.Add(entity.diagnostico);
                   
                }
                return L;
            }
           
        }
       
    }
}
