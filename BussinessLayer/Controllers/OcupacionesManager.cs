using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BussinessLayer
{
    public class OcupacionesManager
    {
        // Return a datatable to fill up te Comboboxes
        public DataTable GetOcupacionesTable()
        {
            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Ocupacion", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                foreach (var entity in db.Ocupaciones)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Ocupacion"] = entity.Ocupacion;
                    table.Rows.Add(row);
               }
            }
            return table;
        }
        #region GetOcupaciones
        public OcupacionesDTO GetOcupacion(int idOcupacion)
        {  OcupacionesDTO ocupacion = new OcupacionesDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {  var LocatedOcup = (from x in db.Ocupaciones
                                   where x.Id == idOcupacion
                                   select new OcupacionesDTO()
                                   {  Id = x.Id,
                                      Ocupacion= x.Ocupacion
                                   }).FirstOrDefault();
                if (LocatedOcup != null)
                {    ocupacion = LocatedOcup;
                }
            }
            return ocupacion;
        }

        #endregion
        #region Select
        //GETOCUPACIONES: Lista de Ocupaciones
        public List<OcupacionesDTO> GetOcupaciones()
        {
            List<OcupacionesDTO> ocupacioneslst = new List<OcupacionesDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                ocupacioneslst = (from x in db.Ocupaciones
                          select new OcupacionesDTO
                          {
                              Id = x.Id,
                              Ocupacion = x.Ocupacion,
                             

                          }).ToList();
            }
            return ocupacioneslst;
        }

        #endregion

        #region Insert

        public void InsertOcupacion(OcupacionesDTO NewOcupacion)
        {
            var x = NewOcupacion;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Ocupaciones.Add(new  DataModel.Ocupaciones()
                {
                    Ocupacion = x.Ocupacion
                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdOcupacion)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Ocupaciones LocatedOcupacion = (from x in db.Ocupaciones
                                        where x.Id == IdOcupacion
                                        select x).FirstOrDefault<Ocupaciones>();
                if (LocatedOcupacion!= null)
                {
                    db.Ocupaciones.Remove(LocatedOcupacion);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe

        public bool ExisteOcupacion(string ocupacion)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
               Ocupaciones Ocup = (from x in db.Ocupaciones where x.Ocupacion.ToUpper() == ocupacion.ToUpper() select x).FirstOrDefault();
                if (Ocup != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(OcupacionesDTO EditedOcupacion)
        {
            var x = EditedOcupacion;
            Ocupaciones Ed_Ocup = new Ocupaciones()
            {
                Id = x.Id,
                Ocupacion = x.Ocupacion
            };
            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Ocupaciones where p.Id == EditedOcupacion.Id select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac = Ed_Ocup;
                        db.SaveChanges();
                    }
                    db.Entry(pac).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch 
            { }
        }

        #endregion
    }
}
