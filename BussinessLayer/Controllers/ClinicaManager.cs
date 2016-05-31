using DataEntities;
using DataModel;
using System.Data.Entity.Validation;
using System.Linq;
namespace BussinessLayer
{
    public class ClinicaManager
    {
        public ClinicaDTO NewClinicaDTO(int id,string RIF, string Direccion1, string Direccion2, string Direccion3, string Direccion4, string Ciudad,
                                      string Telefonos, string responsable,
                                           string Correo,string clinica,string dirima,string direxpor,string archivo
                                      )
        {
            ClinicaDTO x = new ClinicaDTO();
            x.IDCLINICA = id;
            x.CLINICA1 = clinica;
            x.RIF = RIF;
            x.Direccion1 = Direccion1;
            x.Direccion2 = Direccion2;
            x.Direccion3 = Direccion3;
            x.Direccion4 = Direccion4;
            x.Ciudad = Ciudad;
            x.Telefonos = Telefonos;
            x.responsable = responsable;
            x.Correo = Correo;
            x.DirectorioImagenes = dirima;
            x.DirectorioExportados = direxpor;
            x.ArchivoLogo = archivo;
            return x;

        }

        #region GetCLINICA
        public ClinicaDTO GetClinica(int idclinica)
            {
                ClinicaDTO clinica = new ClinicaDTO();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var Locatedclinica = (from x in db.CLINICA
                                        where x.IDCLINICA == idclinica
                                        select new ClinicaDTO()
                                        {
                                            CLINICA1 = x.CLINICA1,
                                            RIF = x.RIF,
                                            Direccion1 = x.Direccion1,
                                            Direccion2 = x.Direccion2,
                                            Direccion3 = x.Direccion3,
                                            Direccion4 = x.Direccion4,
                                            Ciudad = x.Ciudad,
                                            Telefonos = x.Telefonos,
                                            responsable = x.responsable,
                                            DirectorioImagenes = x.DirectorioImagenes,
                                            DirectorioExportados = x.DirectorioExportados,
                                            Correo = x.Correo,
                                            ArchivoLogo = x.ArchivoLogo,
                                            numerodeLicencia = x.numerodeLicencia,
                                            FechadeInstalación = x.FechadeInstalación,
                                            IDCLINICA = x.IDCLINICA
                                        }).FirstOrDefault();
                    if (Locatedclinica != null)
                    {
                        clinica = Locatedclinica;
                    }

                }
                return clinica;
            }

            #endregion
           

            #region Insert

            public void Insertclinica(ClinicaDTO Newclinica)
            {
                var x = Newclinica;
                using (var db = new DataModel.AGILMEDEntities())
                {
                    db.CLINICA.Add(new CLINICA()
                    {
                        CLINICA1 = x.CLINICA1,
                        RIF = x.RIF,
                        Direccion1 = x.Direccion1,
                        Direccion2 = x.Direccion2,
                        Direccion3 = x.Direccion3,
                        Direccion4 = x.Direccion4,
                        Ciudad = x.Ciudad,
                        Telefonos = x.Telefonos,
                        responsable = x.responsable,
                        DirectorioImagenes = x.DirectorioImagenes,
                        DirectorioExportados = x.DirectorioExportados,
                        Correo = x.Correo,
                        ArchivoLogo = x.ArchivoLogo,
                        numerodeLicencia = x.numerodeLicencia,
                        FechadeInstalación = x.FechadeInstalación,
                        IDCLINICA = x.IDCLINICA
                    });

                    db.SaveChanges();
                }
            }

            #endregion
           
    

          


            #region Edit

            public bool Edit(ClinicaDTO Editedclinica)
            {
                var x = Editedclinica;
            

                try
                {
                    using (var db = new DataModel.AGILMEDEntities())
                    {
                        var pac = (from p in db.CLINICA where p.IDCLINICA == Editedclinica.IDCLINICA select p).FirstOrDefault();
                        if (pac != null)
                        {
                           // pac = Ed_clinica;
             pac.CLINICA1 = x.CLINICA1;
             pac.RIF = x.RIF;
            pac.Direccion1 = x.Direccion1;
            pac.Direccion2 = x.Direccion2;
             pac.Direccion3 = x.Direccion3;
            pac.Direccion4 = x.Direccion4;
            pac.Ciudad = x.Ciudad;
            pac.Telefonos = x.Telefonos;
            pac.responsable = x.responsable;
            pac.DirectorioImagenes = x.DirectorioImagenes;
            pac.DirectorioExportados = x.DirectorioExportados;
            pac.Correo = x.Correo;
            pac.ArchivoLogo = x.ArchivoLogo;
            pac.numerodeLicencia = x.numerodeLicencia;
            pac.FechadeInstalación = x.FechadeInstalación;
                        pac.IDCLINICA = x.IDCLINICA;

                            db.SaveChanges();
                        }
                        
                        
                    }
                }
                catch (DbEntityValidationException e)
                {
                return false;
                }
            return true;
        }

            #endregion
        }
    }
