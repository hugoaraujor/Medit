using BussinessLayer;
using DataEntities;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{ 
    public class SubProductoManager
    {
        #region Insert

        public void Insert(SubproductoDTO SubP,int parent)
        {
            var x = SubP;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Subproductos.Add(new Subproductos()
                {
                    cantidad = x.cantidad,
                     parentid=parent,
                     cargoid=x.cargoid,
                     subprodid=parent
                      
                });

                db.SaveChanges();
            }
        }

        #endregion
        #region Delete
        public void Delete(int IdSubP)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Subproductos LocatedSubP = (from x in db.Subproductos
                                        where x.subprodid == IdSubP
                                        select x).FirstOrDefault();
                if (LocatedSubP != null)
                {
                    db.Subproductos.Remove(LocatedSubP);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe

        public bool Existe(int codigosubproducto, int codigoparent)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Subproductos SubP = (from x in db.Subproductos where x.parentid == codigoparent && x.cargoid==codigosubproducto select x).FirstOrDefault();
                if (SubP != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(SubproductoDTO EditedSubP)
        {
            var x = EditedSubP;
            Subproductos Ed_SubP = new Subproductos()
            {
                     cantidad=x.cantidad,
                      parentid=x.parentid,
                       cargoid=x.cargoid,
                        subprodid=x.subprodid
                      
            };

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Subproductos where p.subprodid== EditedSubP.subprodid select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac.cantidad = x.cantidad;
                        pac.parentid = x.parentid;
                        pac.cargoid = x.cargoid;
                        pac.subprodid = x.subprodid;
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
