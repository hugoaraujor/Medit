using System.Collections.Generic;
using System.Linq;
using DataModel;
using DataEntities;
using System.Data.Entity.Validation;
using System.Data;

namespace BussinessLayer
{
   public  class EdoManager
    {
          // Return a datatable to fill up te Comboboxes
            public DataTable GetEstadosTable()
            {
                var table = new DataTable();
                  table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Estado", typeof(string));
                using (var db = new DataModel.AGILMEDEntities())
                {
                    foreach (var entity in db.Estados)
                    {
                        var row = table.NewRow();
                        row["Id"] = entity.Id;
                        row["Estado"] = entity.Estado;
                  
                        table.Rows.Add(row);
                    }
                }
                return table;
            }
            #region GetEstado
            public EstadosDTO GetEstado(int idEdo)
            {
                EstadosDTO estado = new EstadosDTO();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var LocatedEdo = (from x in db.Estados
                                       where x.Id == idEdo
                                       select new EstadosDTO()
                                       {
                                           Id = x.Id,
                                           Estado = x.Estado
                                       }).FirstOrDefault();
                    if (LocatedEdo != null)
                    {
                        estado = LocatedEdo;
                    }

                }
                return estado;
            }

            #endregion
            #region Select

            public List<EstadosDTO> GetEstados()
            {
                List<EstadosDTO> Estadoslst = new List<EstadosDTO>();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    Estadoslst = (from x in db.Estados
                              select new EstadosDTO
                              {
                                  Id = x.Id,
                                  Estado = x.Estado

                              }).ToList();
                }
                return Estadoslst;
            }

            #endregion

            #region Insert

            public void InsertEstado(EstadosDTO NewEstado)
            {
                var x = NewEstado;
                using (var db = new DataModel.AGILMEDEntities())
                {
                    db.Estados.Add(new Estados()
                    {  Estado = x.Estado
                    });

                    db.SaveChanges();
                }
            }

            #endregion
            #region Delete

            public void Delete(int IdEstado)
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    Estados LocatedEdo = (from x in db.Estados
                                            where x.Id == IdEstado
                                            select x).FirstOrDefault<Estados>();
                    if (LocatedEdo != null)
                    {
                        db.Estados.Remove(LocatedEdo);
                        db.SaveChanges();
                    }
                }
            }

            #endregion
            #region Existe

            public bool ExisteEstado(string Estado)
            {
                bool resp = false;
                using (var db = new DataModel.AGILMEDEntities())
                {
                    Estados Edo = (from x in db.Estados where x.Estado.ToUpper() == Estado.ToUpper() select x).FirstOrDefault();
                    if (Edo != null)
                    {
                        resp = true;
                    }

                }
                return resp;
            }
            #endregion


            #region Edit

            public void Edit(EstadosDTO EditedEdo)
            {
                var x = EditedEdo;
                Estados Ed_Edo = new Estados()
                {   Id = x.Id,
                    Estado = x.Estado, };
                try
                {
                    using (var db = new DataModel.AGILMEDEntities())
                    {
                        var pac = (from p in db.Estados where p.Id == EditedEdo.Id select p).FirstOrDefault();
                        if (pac != null)
                        {
                            pac = Ed_Edo;
                            db.SaveChanges();
                        }
                        db.Entry(pac).State = System.Data.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                catch (DbEntityValidationException e)
                { }
            }

            #endregion
        
    }
}
