using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class EspecialidadesManager
    {
       

            // Return a datatable to fill up te Comboboxes
            public DataTable GetEspecialidadesTable()
            {
                var table = new DataTable();

                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Especialidad", typeof(string));
                
                using (var db = new DataModel.AGILMEDEntities())
                {
                    foreach (var entity in db.Especialidades)
                    {
                        var row = table.NewRow();
                        row["Id"] = entity.Id;
                        row["Especialidad"] = entity.Especialidad;
                        
                        table.Rows.Add(row);
                    }
                }
                return table;
            }
            #region GetCity
            public EspecialidadDTO GetEspecialidad(int idesp)
            {
            EspecialidadDTO espec= new EspecialidadDTO();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var Locatedesp = (from x in db.Especialidades
                                       where x.Id == idesp
                                       select new EspecialidadDTO()
                                       {
                                           Id = x.Id,
                                            Especialidad = x.Especialidad
                                           
                                       }).FirstOrDefault();
                    if (Locatedesp != null)
                    {
                    espec = Locatedesp;
                    }

                }
                return espec;
            }

            #endregion
            #region Select

            public List<EspecialidadDTO> GetEspecialidades() 
            {
                List<EspecialidadDTO> esp= new List<EspecialidadDTO>();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    esp = (from x in db.Especialidades
                              select new EspecialidadDTO
                              {
                                  Id = x.Id,
                                  Especialidad = x.Especialidad
                                  

                              }).ToList();
                }
                return esp;
            }

            #endregion

            #region Insert

            public void Insert(EspecialidadDTO NewEsp)
            {
                var x = NewEsp;
                using (var db = new DataModel.AGILMEDEntities())
                {
                    db.Especialidades.Add(new Especialidades()
                    {
                         Especialidad=x.Especialidad,
                        Id=x.Id
                    });

                    db.SaveChanges();
                }
            }

            #endregion
            #region Delete

            public void Delete(int IdEsp)
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    Especialidades LocatedEsp = (from x in db.Especialidades
                                            where x.Id == IdEsp
                                            select x).FirstOrDefault<Especialidades>();
                    if (LocatedEsp != null)
                    {
                        db.Especialidades.Remove(LocatedEsp);
                        db.SaveChanges();
                    }
                }
            }

            #endregion
            #region Existe

            public bool ExisteEsp(string EspStr)
            {
                bool resp = false;
                using (var db = new DataModel.AGILMEDEntities())
                {
                    Especialidades City = (from x in db.Especialidades where x.Especialidad.ToUpper() == EspStr.ToUpper() select x).FirstOrDefault();
                    if (City != null)
                    {
                        resp = true;
                    }

                }
                return resp;
            }
            #endregion


            #region Edit

            public void Edit(EspecialidadDTO EditedEsp)
            {
                var x = EditedEsp;
               

                try
                {
                    using (var db = new DataModel.AGILMEDEntities())
                    {
                        var pac = (from p in db.Especialidades where p.Id == EditedEsp.Id select p).FirstOrDefault();
                        if (pac != null)
                        {
                        pac.Especialidad = x.Especialidad;
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

