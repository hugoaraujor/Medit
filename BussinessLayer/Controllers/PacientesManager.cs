using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataEntities;
using System.Data.Entity.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
namespace BussinessLayer
{
    public class PacientesManager
    {
        #region GetPaciente
        public PacienteDTO GetPaciente(long idpac)
        {

            PacienteDTO pacientes = new PacienteDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var Locatedreg = (from x in db.PACIENTES
                                  where x.PACIENTEID == idpac
                                  select new PacienteDTO()
                                  {
                                      PACIENTEID = x.PACIENTEID,
                                      IDENTIFICACION = x.IDENTIFICACION,
                                      NOMBRES = x.NOMBRES,
                                      APELLIDOS = x.APELLIDOS,
                                      FECHANAC = x.FECHANAC,
                                      TIPO = x.TIPO,
                                      DIRECCION = x.DIRECCION,
                                      EMPRESA = x.EMPRESA,
                                      ASEGURADORA = x.ASEGURADORA,
                                      ASEGURADORA2 = x.ASEGURADORA2,
                                      EDOCIVIL = x.EDOCIVIL,
                                      NOMBRECONYUGUE = x.NOMBRECONYUGUE,
                                      TELEFONO = x.TELEFONO,
                                      TELEFONO2 = x.TELEFONO2,
                                      MOVIL = x.MOVIL,
                                      CARGO = x.CARGO,
                                      EQUIPO = x.EQUIPO,
                                      ARCHIVOCEDULA = x.ARCHIVOCEDULA,
                                      SEXO = x.SEXO,
                                      EDAD = x.EDAD,
                                      CREATED = x.CREATED,
                                      ULTIMAVISITA = x.ULTIMAVISITA,
                                      CIUDAD = x.CIUDAD,
                                      ESTADO = x.ESTADO,
                                      NACIONALIDAD = x.NACIONALIDAD,
                                      OBSERVACIONES = x.OBSERVACIONES,
                                      FICHALABORAL = x.FICHALABORAL,
                                      SECTOR = x.SECTOR
                                  }).FirstOrDefault();
                if (Locatedreg != null)
                {
                    pacientes = Locatedreg;
                }

            }
            pacientes.ListaDependientes = GetDependientes(pacientes.PACIENTEID);
            pacientes.ListaDeDocumentos = GetDocumentos(pacientes.PACIENTEID);
            return pacientes;
        }

        #endregion
        #region Select
        public IEnumerable<DocumentosDTO> GetDocumentos(long PacienteID)
        {
            IEnumerable<DocumentosDTO> docs;
            using (var db = new DataModel.AGILMEDEntities())
            {
                docs = (from x in db.Documentos
                        where (x.idPaciente == PacienteID)
                        select new DocumentosDTO
                        {
                            idPaciente = x.idPaciente,
                            idDocumento = x.idDocumento,
                            observaciones = x.observaciones,
                            TipoDocumento = x.TipoDocumento,
                            Archivo = x.Archivo


                        }).ToList();
            }
            return docs;
        }
        public IEnumerable<DependientesDTO> GetDependientes(long PacienteID)
        {
            IEnumerable<DependientesDTO> dependientes;
            using (var db = new DataModel.AGILMEDEntities())
            {
                dependientes = (from x in db.Dependientes
                                where (x.PacienteId == PacienteID)
                                select new DependientesDTO
                                {
                                    Dependienteid = x.Dependienteid,
                                    Nombre = x.Nombre,
                                    Parentesco = (DependientesDTO.parentesco)x.Parentesco,
                                    Identificacion = x.Identificacion,
                                    FechaNacimiento = x.FechaNacimiento,
                                    PacienteId = x.PacienteId

                                }).ToList();
            }
            return dependientes;
        }

        #endregion
        public List<PacienteCatalogView> GetPacientesView(string filter="*")
        {
             List<PacienteCatalogView> pacientesView = new List<PacienteCatalogView>();
             using (var db = new DataModel.AGILMEDEntities())
            {      pacientesView = (from x in db.PACIENTES  select new PacienteCatalogView()
                               { PACIENTEID = x.PACIENTEID,
                                 IDENTIFICACION = x.IDENTIFICACION,
                                 NOMBRES = x.NOMBRES + " " + x.APELLIDOS,
                                 TELEFONO = x.TELEFONO,
                                 TELEFONO2 = x.TELEFONO2,
                                 MOVIL = x.MOVIL,
                                 OBSERVACIONES = x.OBSERVACIONES,
                                 FICHALABORAL = x.FICHALABORAL,
                                 SECTOR = x.SECTOR
                             }).ToList();
                if (filter!="")
                pacientesView = pacientesView.Where(x => (x.IDENTIFICACION.ToUpper() + x.NOMBRES.ToUpper() +  x.FICHALABORAL.ToUpper() + x.SECTOR.ToUpper()).IndexOf(filter.ToUpper()) > -1).ToList();
             }
           return pacientesView;
        }
        public List<PacienteDTO> GetPacientes()
        {
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                pacientes = (from x in db.PACIENTES
                             select new PacienteDTO
                             {
                                 PACIENTEID = x.PACIENTEID,
                                 IDENTIFICACION = x.IDENTIFICACION,
                                 NOMBRES = x.NOMBRES,
                                 APELLIDOS = x.APELLIDOS,
                                 FECHANAC = x.FECHANAC,
                                 TIPO = x.TIPO,
                                 DIRECCION = x.DIRECCION,
                                 EMPRESA = x.EMPRESA,
                                 ASEGURADORA = x.ASEGURADORA,
                                 EDOCIVIL = x.EDOCIVIL,
                                 NOMBRECONYUGUE = x.NOMBRECONYUGUE,
                                 TELEFONO = x.TELEFONO,
                                 TELEFONO2 = x.TELEFONO2,
                                 MOVIL = x.MOVIL,
                                 CARGO = x.CARGO,
                                 EQUIPO = x.EQUIPO,
                                 ARCHIVOCEDULA = x.ARCHIVOCEDULA,
                                 SEXO = x.SEXO,
                                 EDAD = x.EDAD,
                                 CREATED = x.CREATED,
                                 ULTIMAVISITA = x.ULTIMAVISITA,
                                 CIUDAD = x.CIUDAD,
                                 ESTADO = x.ESTADO,
                                 NACIONALIDAD = x.NACIONALIDAD,
                                 OBSERVACIONES = x.OBSERVACIONES,
                                 FICHALABORAL = x.FICHALABORAL,
                                  ASEGURADORA2 = x.ASEGURADORA2
                             }).ToList();
            }
            return pacientes;
        }



        #region Insert

        public void InsertPaciente(PacienteDTO Newpaciente)
        {
            var x = Newpaciente;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.PACIENTES.Add(new PACIENTES()
                {
                    PACIENTEID = x.PACIENTEID,
                    IDENTIFICACION = x.IDENTIFICACION,
                    NOMBRES = x.NOMBRES,
                    APELLIDOS = x.APELLIDOS,
                    FECHANAC = x.FECHANAC,
                    TIPO = x.TIPO,
                    DIRECCION = x.DIRECCION,
                    EMPRESA = x.EMPRESA,
                    ASEGURADORA = x.ASEGURADORA,
                    EDOCIVIL = x.EDOCIVIL,
                    NOMBRECONYUGUE = x.NOMBRECONYUGUE,
                    TELEFONO = x.TELEFONO,
                    TELEFONO2 = x.TELEFONO2,
                    MOVIL = x.MOVIL,
                    CARGO = x.CARGO,
                    EQUIPO = x.EQUIPO,
                    ARCHIVOCEDULA = x.ARCHIVOCEDULA,
                    SEXO = x.SEXO,
                    EDAD = x.EDAD,
                    CREATED = x.CREATED,
                    ULTIMAVISITA = x.ULTIMAVISITA,
                    CIUDAD = x.CIUDAD,
                    ESTADO = x.ESTADO,
                    NACIONALIDAD = x.NACIONALIDAD,
                    OBSERVACIONES = x.OBSERVACIONES,
                    FICHALABORAL = x.FICHALABORAL,
                    SECTOR = x.SECTOR,
                    ASEGURADORA2 = x.ASEGURADORA2
                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(long IdPaciente)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                PACIENTES Locatedreg = (from x in db.PACIENTES where x.PACIENTEID == IdPaciente select x).FirstOrDefault();
                if (Locatedreg != null)
                {
                    db.PACIENTES.Remove(Locatedreg);
                    db.SaveChanges();
                }

            }
        }

        #endregion
        #region Existe

        public bool ExistePaciente(string idpaciente)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                PACIENTES User = (from x in db.PACIENTES where x.IDENTIFICACION == idpaciente select x).FirstOrDefault();
                if (User != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        public long RetornaIdPaciente(string idpaciente)
        {
            long indice = 0;
            using (var db = new DataModel.AGILMEDEntities())
            {
                PACIENTES pac = (from x in db.PACIENTES where x.IDENTIFICACION == idpaciente select x).FirstOrDefault();
                if (pac != null)
                    indice = pac.PACIENTEID;
                else
                    indice = 0;
            }
            return indice;
        }
        #endregion


        #region Edit

        public void Edit(PacienteDTO EditedPaciente)
        {
            var x = EditedPaciente;


            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    PACIENTES pac = db.PACIENTES.Find(EditedPaciente.PACIENTEID);
                    if (pac != null)
                    {
                        pac.IDENTIFICACION = x.IDENTIFICACION;
                        pac.NOMBRES = x.NOMBRES;
                        pac.APELLIDOS = x.APELLIDOS;
                        pac.FECHANAC = x.FECHANAC;
                        pac.TIPO = x.TIPO;
                        pac.DIRECCION = x.DIRECCION;
                        pac.EMPRESA = x.EMPRESA;
                        pac.ASEGURADORA = x.ASEGURADORA;
                        pac.EDOCIVIL = x.EDOCIVIL;
                        pac.NOMBRECONYUGUE = x.NOMBRECONYUGUE;
                        pac.TELEFONO = x.TELEFONO;
                        pac.TELEFONO2 = x.TELEFONO2;
                        pac.MOVIL = x.MOVIL;
                        pac.CARGO = x.CARGO;
                        pac.EQUIPO = x.EQUIPO;
                        pac.ARCHIVOCEDULA = x.ARCHIVOCEDULA;
                        pac.SEXO = x.SEXO;
                        pac.EDAD = x.EDAD;
                        pac.ULTIMAVISITA = x.ULTIMAVISITA;
                        pac.CIUDAD = x.CIUDAD;
                        pac.ESTADO = x.ESTADO;
                        pac.NACIONALIDAD = x.NACIONALIDAD;
                        pac.OBSERVACIONES = x.OBSERVACIONES;
                        pac.FICHALABORAL = x.FICHALABORAL;
                        pac.SECTOR = x.SECTOR;
                        pac.ASEGURADORA2 = x.ASEGURADORA2;
                    }

                    db.Entry(pac).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {

                //    foreach (DbEntityValidationResult entityErr in e.EntityValidationErrors)
                //    {
                //        foreach (DbValidationError error in entityErr.ValidationErrors)
                //        {
                //            Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                //                                error.PropertyName, error.ErrorMessage);
                //        }
                //    }


            }
        }

        #endregion
     
}
}


    

