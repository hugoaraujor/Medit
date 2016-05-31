using DataEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TipoCargosManager
    {

        public DataTable GetTipodeCargos()
        {
            var table = new DataTable();
            IEnumerable<TipodeCargosDTO> Tiposdecargos;
            table.Columns.Add("TipoCargoId", typeof(int));
            table.Columns.Add("TipocargoDesc", typeof(string));


            using (var db = new DataModel.AGILMEDEntities())
            {
                Tiposdecargos = (from x in db.TipodeCargos
                                 select new TipodeCargosDTO
                                 {
                                     TipocargoDesc = x.TipocargoDesc,
                                     TipoCargoId = x.TipoCargoId
                                 }).ToList();
            }

            foreach (var entity in Tiposdecargos)
            {
                var row = table.NewRow();
                row["TipoCargoId"] = entity.TipoCargoId;
                row["TipocargoDesc"] = entity.TipocargoDesc.ToString();
                table.Rows.Add(row);
            }

            return table;
        }
        public string GetTipodeCargosDesc(int tipo)
        {
            TipodeCargosDTO tipodecargo=new TipodeCargosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
             tipodecargo= (from x in db.TipodeCargos
                                     where x.TipoCargoId == tipo
                                     select new TipodeCargosDTO
                                     {
                                         TipocargoDesc = x.TipocargoDesc,
                                         TipoCargoId = x.TipoCargoId
                                     }).SingleOrDefault();
            }

      
            return tipodecargo.TipocargoDesc.ToString();
        }
    }
}
