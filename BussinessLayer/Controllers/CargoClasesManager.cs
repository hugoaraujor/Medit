using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataEntities;
using System.Data.Entity.Validation;
using System.Data;
namespace BussinessLayer
{
    public class CargoClasesManager
    {

        // Return a datatable to fill up te Comboboxes
        public DataTable GetClasesTable(int idtipo)
        {
            var table = new DataTable();
            table.Columns.Add("ClaseId", typeof(int));
            table.Columns.Add("Clase", typeof(string));
            table.Columns.Add("TipoCargoId", typeof(int));
   
            using (var db = new DataModel.AGILMEDEntities())
            {
                var Claseslst = (from x in db.CargosClases
                                 where x.TipoCargoId == idtipo
                                 select new CargosClasesDTO
                                 {
                                     ClaseId = x.ClaseId,
                                     TipoCargoId = x.TipoCargoId,
                                     Clase = x.Clase,
                                    
                                 });

                foreach (var entity in Claseslst)
                {
                  
                    var row = table.NewRow();
                    row["ClaseId"] = entity.ClaseId;
                    row["Clase"] = entity.Clase;
                    row["TipoCargoId"] = entity.TipoCargoId;
                  
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        #region GetEstado
        public CargosClasesDTO GetClase(int idclase)
        {
            CargosClasesDTO clase = new CargosClasesDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var Locatedclase = (from x in db.CargosClases
                                  where x.ClaseId == idclase
                                  select new CargosClasesDTO()
                                  {
                                      ClaseId = x.ClaseId,
                                      TipoCargoId = x.TipoCargoId,
                                      Clase = x.Clase
                                  }).FirstOrDefault();
                if (Locatedclase != null)
                {
                    clase = Locatedclase;
                }

            }
            return clase;
        }

        #endregion
        #region Select

        public List<CargosClasesDTO> GetClases(int tipo)
        {
            List<CargosClasesDTO> Claseslst = new List<CargosClasesDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                Claseslst = (from x in db.CargosClases where x.TipoCargoId==tipo
                             select new CargosClasesDTO
                              {
                                 ClaseId = x.ClaseId,
                                 TipoCargoId = x.TipoCargoId,
                                 Clase = x.Clase
                          
                                      
                             }).ToList();
            }
            return Claseslst;
        }

        #endregion

        #region Insert

        public void InsertClase(CargosClasesDTO NewClase)
        {
            var x = NewClase;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.CargosClases.Add(new CargosClases() {
                    ClaseId = x.ClaseId,
                    TipoCargoId = x.TipoCargoId,
                    Clase = x.Clase
                    
                });

                db.SaveChanges();


            }
        }

        #endregion
        #region Delete

        public void Delete(int IdClase)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
               CargosClases Locatedclase = (from x in db.CargosClases
                                      where x.ClaseId== IdClase
                                      select x).FirstOrDefault<CargosClases>();
                if (Locatedclase != null)
                {
                    db.CargosClases.Remove(Locatedclase);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe

        public bool ExisteClase(string ClaseDes,int tipo)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                CargosClases Edo = (from x in db.CargosClases where x.Clase.ToUpper() == ClaseDes.ToUpper() && x.TipoCargoId==tipo select x).FirstOrDefault();
                if (Edo != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(CargosClasesDTO Editedclass)
        {
            var x = Editedclass;
           
            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.CargosClases where p.ClaseId == Editedclass.ClaseId select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac.ClaseId = x.ClaseId;
                        pac.TipoCargoId = x.TipoCargoId;
                        pac.Clase = x.Clase;
    
                        db.SaveChanges();
                    }
                   
                }
            }
            catch (DbEntityValidationException e)
            { }
        }

        #endregion

    }
}

