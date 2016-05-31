using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataModel;
using System.Data.Entity.Validation;
namespace BussinessLayer
{
    public class DependientesManager
    {
        #region Select

        public DependientesDTO GetDependiente(int idDependiente)
        {
            DependientesDTO DepPac = new DependientesDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var LocatedDependiente = (from x in db.Dependientes
                                   where x.Dependienteid == idDependiente
                                   select new DependientesDTO()
                                   {
                                       Nombre = x.Nombre,
                                       Identificacion = x.Identificacion,
                                       PacienteId=x.PacienteId,
                                       FechaNacimiento=x.FechaNacimiento,
                                       Parentesco=(DependientesDTO.parentesco)x.Parentesco
            }).FirstOrDefault();
                if (LocatedDependiente != null)
                {
                    DepPac = LocatedDependiente;
                }

            }
            return DepPac;
        }

       
        #endregion

        #region Insert

        public void InsertDep(DependientesDTO NewDependiente)
        {
            var x = NewDependiente;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Dependientes.Add(new Dependientes()
                {
                    Nombre = x.Nombre,
                    Identificacion = x.Identificacion,
                    PacienteId = x.PacienteId,
                    FechaNacimiento = x.FechaNacimiento,
                    Parentesco=((int)x.Parentesco)
                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdDependiente)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Dependientes LocatedDep = (from x in db.Dependientes
                                           where x.Dependienteid == IdDependiente select x).FirstOrDefault();
                
                if (LocatedDep != null)
                {
                    db.Dependientes.Remove(LocatedDep);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe
         // Busca Dependiente por el mismo nombre para evitar duplsicaods que sean del mismo paciente
         //pueden haber dos nombres iguales pero dependientes de diferentes pacientes
         //Uso; ExisteDep("hugo araujo", 1);
        public bool ExisteDep(string DepNombre,long idpaciente)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Dependientes Dep = (from x in db.Dependientes where (x.PacienteId==idpaciente && x.Nombre.ToUpper()==DepNombre.ToUpper())
                                      select x).FirstOrDefault();
                if (Dep != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(DependientesDTO EditedDependiente)
        {
            var x = EditedDependiente;
            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Dependientes where p.Dependienteid == EditedDependiente.Dependienteid select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac.Dependienteid = x.Dependienteid;
                        pac.Nombre = x.Nombre;
                        pac.FechaNacimiento = x.FechaNacimiento;
                        pac.Parentesco = (int)x.Parentesco;
                        pac.PacienteId = x.PacienteId;
                        pac.Identificacion = x.Identificacion;

                     }


                        db.SaveChanges();
                 }
            }
            catch (DbEntityValidationException e)
            {

            }
        }

        #endregion
    }
}
