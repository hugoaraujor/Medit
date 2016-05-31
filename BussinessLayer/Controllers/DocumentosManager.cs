using DataEntities;
using DataModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BussinessLayer
{
    public class DocumentosManager
    {
        #region Select

        public DocumentosDTO GetDocumento(int idDoc)
        {
            DocumentosDTO Doc = new DocumentosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var LocatedDoc = (from x in db.Documentos  where  x.idDocumento == idDoc
                                          select new DocumentosDTO()
                                          {idDocumento=x.idDocumento,
                                          idPaciente=x.idPaciente,
                                          observaciones=x.observaciones,
                                          TipoDocumento=x.TipoDocumento
                                          }).FirstOrDefault();
                if (LocatedDoc != null)
                {
                    Doc = LocatedDoc;
                }

            }
            return Doc;
        }

        public IEnumerable<DocumentosDTO> GetDocumentos(long idp)
        {
            PacientesManager pm = new PacientesManager();
            return pm.GetDocumentos(idp);
        }
        #endregion

        #region Insert

        public void InsertDoc(DocumentosDTO NewDocumento)
        {
            var x = NewDocumento;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Documentos.Add(new Documentos()
                {
                   Archivo=x.Archivo,
                    idPaciente = x.idPaciente,
                    observaciones = x.observaciones,
                    TipoDocumento = x.TipoDocumento
                    
                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdDoc)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Documentos LocatedDoc = (from x in db.Documentos
                                           where x.idDocumento == IdDoc
                                           select x).FirstOrDefault();

                if (LocatedDoc!= null)
                {
                    db.Documentos.Remove(LocatedDoc);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        
        #region Edit

        public void Edit(DocumentosDTO EditedDoc)
        {
            var x = EditedDoc;
            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var Dpac = (from p in db.Documentos where p.idDocumento == EditedDoc.idDocumento select p).FirstOrDefault();
                    if (Dpac != null)
                    {
                        Dpac.idDocumento = x.idDocumento;
                        Dpac.idPaciente = x.idPaciente;
                        Dpac.observaciones = x.observaciones;
                        Dpac.TipoDocumento = x.TipoDocumento;
                        Dpac.Archivo = x.Archivo;

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
