using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BussinessLayer;
namespace BussinessLayer
{
    public class MedicinasManager
    {
        public DataTable GetExamenesLaboratorio()
        {
            var table = new DataTable();


            table.Columns.Add("id", typeof(int));
            table.Columns.Add("examen", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.Cargos where x.activo == true && x.Tipocargo == 4 select x);
                foreach (var entity in query)
                {
                    var row = table.NewRow();
                    row["id"] = entity.CargoId;
                    row["examen"] = entity.descripción;
                    //     row["Estado"] = entity.Estado;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public DataTable Getmedicinas()
        {
            var table = new DataTable();
                
          
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("medicamento", typeof(string));
            table.Columns.Add("presentacion", typeof(string));
            table.Columns.Add("indicaciones", typeof(string));
            table.Columns.Add("via", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query =(from x in db.Cargos where x.activo== true && x.Tipocargo==1 select x);
                foreach (var entity in query)
                {
                    var row = table.NewRow();
                    row["id"] = entity.CargoId;
                    row["medicamento"] = entity.descripción;
                    row["presentacion"] = entity.presentacion;
                    row["indicaciones"] = entity.indicaciones;
                   row["via"] = entity.via;
                    //     row["Estado"] = entity.Estado;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public DataTable Getpresentaciones(string medicamentostr)
        {
            var table = new DataTable();


            table.Columns.Add("id", typeof(int));
            table.Columns.Add("medicamento", typeof(string));
            table.Columns.Add("presentacion", typeof(string));
            table.Columns.Add("indicaciones", typeof(string));
            table.Columns.Add("via", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.Cargos where x.activo == true && x.Tipocargo == 1 && x.descripción == medicamentostr select x);
                foreach (var entity in query)
                {
                    var row = table.NewRow();
                    row["id"] = entity.CargoId;
                    row["medicamento"] = entity.descripción;
                    row["presentacion"] = entity.presentacion;
                    row["indicaciones"] = entity.indicaciones;
                    row["via"] = entity.via;
                    //     row["Estado"] = entity.Estado;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public string Getindicaciones(int medid)
        {
            string result = "";
            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.Cargos where x.activo == true && x.Tipocargo == 1 && x.CargoId == medid select x).FirstOrDefault();
                result = query.indicaciones;
               
            }
            return result;
        }
    }
}
