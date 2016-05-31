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
    public class MedicosManager
    {
        // Return a datatable to fill up te Comboboxes
        public DataTable GetDoctorTable(string filter)
        {



            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Médico", typeof(string));
            table.Columns.Add("Especialidad", typeof(string));
            table.Columns.Add("Teléfonos", typeof(string));
            //   IQueryable<MedicosDTO> queryresults;
            using (var db = new DataModel.AGILMEDEntities())
            {
                var queryresults = (from a in db.medicos
                                    join b in db.Especialidades
                                    on a.especialidad equals b.Id
                                    where a.activo == true
                                    orderby a.especialidad, a.apellidos + "," + a.nombres
                                    select
                                    new { Id = a.doctorid, Especialidad = b.Especialidad, Medico = a.apellidos + ", " + a.nombres, Telefonos = a.telefono + ";" + a.telefono2, Esp = a.especialista });
                if (filter != "" && filter.Length > 1)
                    queryresults = queryresults.Where(x => (x.Medico.ToUpper() + x.Especialidad.ToUpper()).IndexOf(filter.ToUpper()) > -1);
                else
                {

                    if (filter == "*")//especialista
                        queryresults = queryresults.Where(x => (x.Esp == true));
                    if (filter == "$")//MedicosGenerales
                        queryresults = queryresults.Where(x => (x.Esp != true));
                    if (filter == ".")//Especialidad
                    {
                        var especialstr = filter.Replace('.', ' ').TrimStart();
                        queryresults = queryresults.Where(x => (x.Especialidad == especialstr.ToString()));
                    }
                }
                foreach (var entity in queryresults)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Médico"] = entity.Medico;
                    row["Especialidad"] = entity.Especialidad;
                    row["Teléfonos"] = entity.Telefonos;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        #region GetDoctor
        public MedicosDTO GetDoctor(int idDoctor)
        {
            MedicosDTO Doctor = new MedicosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var LocatedDoctor = (from x in db.medicos
                                     where x.doctorid == idDoctor
                                     select new MedicosDTO()
                                     {
                                         doctorid = x.doctorid,
                                         nombres = x.nombres,
                                         apellidos = x.apellidos,
                                         telefono = x.telefono,
                                         telefono2 = x.telefono2,
                                         activo = x.activo,
                                         horariodeconsulta = x.horariodeconsulta,
                                         especialidad = (int)x.especialidad,
                                         ncm = x.ncm,
                                         especialista = x.especialista

                                     }).FirstOrDefault();
                if (LocatedDoctor != null)
                {
                    Doctor = LocatedDoctor;
                }

            }
            return Doctor;
        }

        #endregion
        public int CountDoctorsbyEspecialidad(int especialidadid)
        {
            int cuantos = 0;
            MedicosDTO Doctor = new MedicosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                cuantos = (from x in db.medicos
                           where x.especialidad == especialidadid
                           select x).Count();

            }
            return cuantos;
        }

        #region Insert

        public int InsertDoctor(MedicosDTO NewDoctor)
        {
            int retorno = 0;
            var x = NewDoctor;

            medicos c = new medicos()
            {
                doctorid = x.doctorid,
                nombres = x.nombres,
                apellidos = x.apellidos,
                telefono = x.telefono,
                telefono2 = x.telefono2,
                activo = x.activo,
                horariodeconsulta = x.horariodeconsulta,
                especialidad = x.especialidad,
                ncm = x.ncm,
                especialista = x.especialista
            };
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.medicos.Add(c);
                db.SaveChanges();
                db.Entry(c).GetDatabaseValues();
                retorno = c.doctorid;
            }
            return retorno;
        }

        #endregion
        #region Delete

        public void Delete(int IdDoctor)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                medicos LocatedDoctor = (from x in db.medicos
                                         where x.doctorid == IdDoctor
                                         select x).FirstOrDefault<medicos>();
                if (LocatedDoctor != null)
                {
                    db.medicos.Remove(LocatedDoctor);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe

        public bool ExisteDoctor(string Doctor)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                medicos Doc = (from x in db.medicos where (x.nombres + " " + x.apellidos).ToUpper() == Doctor.ToUpper() select x).FirstOrDefault();
                if (Doc != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(MedicosDTO EditedDoctor)
        {
            var x = EditedDoctor;

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.medicos where p.doctorid == EditedDoctor.doctorid select p).FirstOrDefault();
                    if (pac != null)
                    {

                        pac.doctorid = x.doctorid;
                        pac.nombres = x.nombres;
                        pac.apellidos = x.apellidos;
                        pac.telefono = x.telefono;
                        pac.telefono2 = x.telefono2;
                        pac.activo = x.activo;
                        pac.horariodeconsulta = x.horariodeconsulta;
                        pac.especialidad = x.especialidad;
                        pac.ncm = x.ncm;
                        pac.especialista = x.especialista;
                        db.SaveChanges();
                    }
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            { }
        }

        #endregion
    }
}
