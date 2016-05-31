using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataModel;
using DataEntities;

namespace BussinessLayer
{
   public  class SintomasManager
    {
        public DataTable Getsintomas()
        {
            var table = new DataTable();


            table.Columns.Add("id", typeof(int));
            table.Columns.Add("sintoma", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.sintomas  select x);
                foreach (var entity in query)
                {
                    var row = table.NewRow();
                    row["id"] = entity.idsintoma;
                    row["sintoma"] = entity.sintoma;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public SintomasDTO Getsintoma(int idSintoma)
        {
            SintomasDTO query;
            using (var db = new DataModel.AGILMEDEntities())
            {
                 query = (from x in db.sintomas where x.idsintoma==idSintoma select new SintomasDTO { sintoma=x.sintoma,idsintoma=x.idsintoma }).FirstOrDefault();
                
            }
            return query;
        }
        #region Insert

        public void Insert(SintomasDTO NewSintoma)
        {
            var x = NewSintoma;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.sintomas.Add(new sintomas
                { sintoma = x.sintoma });

                db.SaveChanges();
            }
        }

        #endregion
    }
}
