using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataModel;
using System.Data;
namespace BussinessLayer
{
    public class IngresosManager
    {
        public List<IngresosDTO> GetIngresosActivos()
        {
            List<IngresosDTO> Lista = new List<IngresosDTO>();
            IQueryable<IngresosDTO> query;

            using (var db = new DataModel.AGILMEDEntities())
            {


                query = from x in db.Ingresos
                        where x.procesada == null
                        select new IngresosDTO
                        {
                            admisionid = x.admisionid,
                            ceduladebeneficiario = x.ceduladebeneficiario,
                            aseguradoraid = x.aseguradoraid,
                            cedulapaciente = x.cedulapaciente,
                            cedulatrabajador = x.cedulatrabajador,
                            clave = x.clave,
                            //    created=x.created,
                            esbeneficiario = x.esbeneficiario,
                            dependienteid = x.dependienteid,

                            fechaingreso = x.fechaingreso,
                            fechasalida = x.fechasalida,
                            empresaid = x.empresaid,
                            ticket = x.ticket,
                            trabajadorid = x.trabajadorid,
                            tipodeingreso = x.tipodeingreso,
                            nombrepaciente = x.nombrepaciente,
                            motivo = x.motivo,
                            observaciones = x.observaciones,
                            procesada = x.procesada,
                            refieremedico = x.refieremedico,
                            usuarioid = x.usuarioid

                        };


                Lista = query.ToList<IngresosDTO>();
            }
            return Lista;
        }

        public DataTable GetSeguros(PacienteDTO paciente)
        {
            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Seguro", typeof(string));

            using (var db = new DataModel.AGILMEDEntities())
            {
                var query = (from x in db.Empresas
                             where (x.Id == paciente.ASEGURADORA || x.Id == paciente.ASEGURADORA2 && x.Aseguradora == true && x.Active == true)
                             select new EmpresasDTO
                             {
                                 Empresa = x.Empresa,
                                 Id = x.Id
                             });

                foreach (var entity in query)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Seguro"] = entity.Empresa;

                    table.Rows.Add(row);
                }

            }
            return table;
        }
        public EntryView getDataView(string cedula)
        {
            EntryView Nview = new EntryView();

            using (var db = new DataModel.AGILMEDEntities())
            {
                try
                {
                    var query = (from x in db.PACIENTES
                                 join a in db.Dependientes on x.PACIENTEID equals a.PacienteId
                                 where (x.IDENTIFICACION == cedula || a.Identificacion == cedula)
                                 orderby x.IDENTIFICACION
                                 select new EntryView
                                 {
                                     Cedula = x.IDENTIFICACION,
                                     cedulabeneficiario = a.Identificacion,
                                     nombreAutorizado = x.NOMBRES + " " + x.APELLIDOS,
                                     nombreBeneficiario = a.Nombre,
                                     Fecha = DateTime.Now,
                                     idpaciente = x.PACIENTEID,
                                     idbeneficiario = a.Dependienteid,

                                     parentesco = (DependientesDTO.parentesco)a.Parentesco,
                                     esbeneficiario = true,
                                     tipoingreso = 1,
                                     idempresa = x.EMPRESA,
                                     idaseguradora = x.ASEGURADORA
                                 }).First();

                    if (cedula == query.Cedula)
                    {
                        query.esbeneficiario = false;
                        query.nombreBeneficiario = query.nombreAutorizado;
                        query.idbeneficiario = 0;
                        query.parentesco = 0;

                    }

                    if (query != null)
                    {
                        Nview = query;
                    }
                }
                catch
                {

                }
            }
            return Nview;
        }

        #region Insert
        public IngresosDTO getIngresoDat(long idadmision)
        {
            IngresosDTO Nview = new IngresosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                try
                {
                   Nview = (from x in db.Ingresos
                                 where x.admisionid==idadmision
                                 select new IngresosDTO 
                                 {  
                                      admisionid=x.admisionid,
                                       ceduladebeneficiario=x.ceduladebeneficiario,
                                        cedulapaciente=x.cedulapaciente,
                                        cedulatrabajador=x.cedulatrabajador,
                                        nombrepaciente=x.nombrepaciente,
                                         fechaingreso = x.fechaingreso,
                                         fechasalida=x.fechasalida,
                                         //  idpaciente = x.PACIENTEID,
                                          dependienteid = x.dependienteid,
                                          trabajadorid=x.trabajadorid,
                                          tipodeingreso = x.tipodeingreso,
                                     empresaid=x.empresaid,
                                     aseguradoraid=x.aseguradoraid
                                                                  
                                 }).First();

                   
                }
                catch
                {

                }
            }
           
            return Nview;
        }
        public void InsertIngreso(IngresosDTO NewIngreso)
        {
            var x = NewIngreso;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Ingresos.Add(new DataModel.Ingresos()
                {

                    ceduladebeneficiario = x.ceduladebeneficiario,
                    cedulapaciente = x.cedulapaciente,
                    cedulatrabajador = x.cedulatrabajador,
                    clave = x.clave,
                    dependienteid = x.dependienteid,
                    esbeneficiario = (bool)x.esbeneficiario,
                    fechaingreso = x.fechaingreso,
                    fechasalida = x.fechasalida,
                    motivo = x.motivo,
                    nombrepaciente = x.nombrepaciente,
                    observaciones = x.observaciones,
                    procesada = x.procesada,
                    ticket = x.ticket,
                    tipodeingreso = x.tipodeingreso,
                    trabajadorid = x.trabajadorid,
                    usuarioid = x.usuarioid,
                    refieremedico = x.refieremedico,
                    empresaid = x.empresaid,
                    aseguradoraid = x.aseguradoraid


                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdIngreso)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Ingresos LocatedIngreso = (from x in db.Ingresos
                                           where x.admisionid == IdIngreso
                                           select x).FirstOrDefault<Ingresos>();
                if (LocatedIngreso != null)
                {
                    db.Ingresos.Remove(LocatedIngreso);
                    db.SaveChanges();
                }
            }
        }

        #endregion



        #region Edit

        public void Edit(IngresosDTO EditedIngreso)
        {
            var x = EditedIngreso;
            //Ingresos Ed_Ingreso = new Ingresos()

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Ingresos where p.admisionid == EditedIngreso.admisionid select p).FirstOrDefault();
                    if (pac != null)
                    {

                        pac.admisionid = x.admisionid;
                        pac.ceduladebeneficiario = x.ceduladebeneficiario;
                        pac.cedulapaciente = x.cedulapaciente;
                        pac.cedulatrabajador = x.cedulatrabajador;
                        pac.clave = x.clave;
                        pac.dependienteid = x.dependienteid;
                        pac.esbeneficiario = (bool)x.esbeneficiario;
                        pac.fechaingreso = x.fechaingreso;
                        pac.fechasalida = x.fechasalida;
                        pac.motivo = x.motivo;
                        pac.nombrepaciente = x.nombrepaciente;
                        pac.observaciones = x.observaciones;
                        pac.procesada = x.procesada;
                        pac.refieremedico = x.refieremedico;
                        pac.ticket = x.ticket;
                        pac.tipodeingreso = x.tipodeingreso;
                        pac.trabajadorid = x.trabajadorid;
                        pac.usuarioid = x.usuarioid;
                        pac.refieremedico = x.refieremedico;
                        pac.empresaid = x.empresaid;
                        pac.aseguradoraid = x.aseguradoraid;


                        db.SaveChanges();
                    }

                }
            }
            catch
            { }
        }

        #endregion
    }
}
