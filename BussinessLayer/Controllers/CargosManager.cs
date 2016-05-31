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

    public class CargosManager
    {
        // Return a datatable to fill up te Comboboxes
        public DataTable GetCargosTable(string filter)
        {
            var table = new DataTable();

            table.Columns.Add("CargoId", typeof(int));
            table.Columns.Add("Tipocargo", typeof(string));
            table.Columns.Add("Grupo", typeof(string));
            table.Columns.Add("descripción", typeof(string));
           

            using (var db = new DataModel.AGILMEDEntities())
            {
                //where a.Tipocargo == tipo
                var queryresults = from a in db.Cargos
                                   join ba in db.TipodeCargos on a.Tipocargo equals ba.TipoCargoId
                                   join c in db.CargosClases on a.Grupo equals c.ClaseId orderby ba.TipocargoDesc, c.Clase, a.descripción ascending
                                   select new { CargoId = a.CargoId, Tipo = ba.TipocargoDesc, Grupo = c.Clase, descripción = a.descripción };

                if (filter != "")
                    queryresults = queryresults.Where(x => (x.Tipo.ToUpper() + x.descripción.ToUpper() + x.Grupo.ToUpper()).IndexOf(filter.ToUpper()) > -1);

                foreach (var entity in queryresults)
                {
                    var row = table.NewRow();
                    row["CargoId"] = entity.CargoId;
                    row["Tipocargo"] = entity.Tipo;
                    row["Grupo"] = entity.Grupo;
                    row["descripción"] = entity.descripción;

                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public DataTable GetSubComponentes(int cargoid)
        {
            var table = new DataTable();

            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Parentid", typeof(int));
            table.Columns.Add("subproductoid", typeof(int));
            table.Columns.Add("descripcion", typeof(string));
            using (var db = new DataModel.AGILMEDEntities())
            {
                var queryresults = from a in db.Subproductos
                                   join ba in db.Cargos on a.cargoid equals ba.CargoId
                                   where (a.parentid==cargoid && a.cargoid!=cargoid)
                                   select new {cantidad=a.cantidad ,CargoId = a.cargoid, parentid = a.parentid,subproductoid=a.subprodid ,descripcion=ba.descripción};


                foreach (var entity in queryresults)
                {
                    var row = table.NewRow();
                    row["Cantidad"] = entity.cantidad;
                    row["Codigo"] = entity.CargoId;
                    row["Parentid"] = entity.parentid;
                    row["subproductoid"] = entity.subproductoid;
                    row["descripcion"] = entity.descripcion;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        #region GetSubcomponentes
        #region GetTablaCargossubcomponentes //Agrupables
        public DataTable GetCargoComponente(int id)
        {
            var table = new DataTable();

            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Codigo", typeof(string));
            table.Columns.Add("Concepto", typeof(string));

            using (var db = new DataModel.AGILMEDEntities())
            {
                var queryresults = from a in db.Cargos where (a.agrupable==true)
                                   select new { CargoId = a.CargoId, descripción = a.descripción };

             
                foreach (var entity in queryresults)
                {
                    var row = table.NewRow();
                    row["Cantidad"] = 0;
                    row["Codigo"] = entity.CargoId;
                    row["Concepto"] = entity.descripción;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        #region GetCity
        public CargosDTO GetCargo(int idCargo)
        {
            CargosDTO cargo = new CargosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var Locatedcargo = (from x in db.Cargos
                                    where x.CargoId == idCargo
                                    select new CargosDTO()
                                    {
                                        CargoId = x.CargoId,
                                        Tipocargo = x.Tipocargo,
                                        Grupo = x.Grupo,
                                        descripción = x.descripción,
                                        coste = x.coste,
                                        precio1 = x.precio1,
                                        precio2 = x.precio2,
                                        precio3 = x.precio3,
                                        precio4 = x.precio4,
                                        precio5 = x.precio5,
                                        inventario = x.inventario,
                                        Kit = x.Kit
                                    }).FirstOrDefault();
                if (Locatedcargo != null)
                {
                    cargo = Locatedcargo;
                }

            }
            return cargo;
        }

        #endregion
        #region Select

        public List<CargosDTO> GetCargos()
        {
            List<CargosDTO> cargos = new List<CargosDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                cargos = (from x in db.Cargos
                          select new CargosDTO
                          {
                              CargoId = x.CargoId,
                              Tipocargo = x.Tipocargo,
                              Grupo = x.Grupo,
                              descripción = x.descripción,
                              coste = x.coste,
                              precio1 = x.precio1,
                              precio2 = x.precio2,
                              precio3 = x.precio3,
                              precio4 = x.precio4,
                              precio5 = x.precio5,
                              inventario = x.inventario,
                              Kit = x.Kit

                          }).ToList();
            }

            return cargos;
        }

        #endregion

        #region Insert

        public int InsertCargo(CargosDTO NewCargo)
        {
            int retorno = 0;
            var x = NewCargo;
            Cargos c = new Cargos()
            {
                CargoId = x.CargoId,
                Tipocargo = x.Tipocargo,
                Grupo = x.Grupo,
                descripción = x.descripción,
                coste = x.coste,
                precio1 = x.precio1,
                precio2 = x.precio2,
                precio3 = x.precio3,
                precio4 = x.precio4,
                precio5 = x.precio5,
                inventario = x.inventario,
                Kit = x.Kit,
                agrupable = x.agrupable


            };
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Cargos.Add(c);
                db.SaveChanges();
                db.Entry(c).GetDatabaseValues();
                retorno =c.CargoId;
            }
            return retorno;
        }

        #endregion
        #region Delete

        public void Delete(int IdCargo)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Cargos Locatedcargo = (from x in db.Cargos
                                       where x.CargoId == IdCargo
                                       select x).FirstOrDefault<Cargos>();
                if (Locatedcargo != null)
                {
                    db.Cargos.Remove(Locatedcargo);
                    db.SaveChanges();
                }
            }
        }

        #endregion
        #region Existe

        public bool ExisteCargo(string cargoDescripcion)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Cargos City = (from x in db.Cargos where x.descripción.ToUpper() == cargoDescripcion.ToUpper() select x).FirstOrDefault();
                if (City != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(CargosDTO EditedCargo)
        {
            var x = EditedCargo;
            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Cargos where p.CargoId == EditedCargo.CargoId select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac.Tipocargo = x.Tipocargo;
                        pac.Grupo = x.Grupo;
                        pac.descripción = x.descripción;
                        pac.coste = x.coste;
                        pac.precio1 = x.precio1;
                        pac.precio2 = x.precio2;
                        pac.precio3 = x.precio3;
                        pac.precio4 = x.precio4;
                        pac.precio5 = x.precio5;
                        pac.inventario = x.inventario;
                        pac.Kit = x.Kit;
                        pac.agrupable = x.agrupable;
                        db.SaveChanges();
                    }

                }
            }
            catch (DbEntityValidationException e)
            { }
        }

        #endregion
    }

    #endregion
    #endregion
}

