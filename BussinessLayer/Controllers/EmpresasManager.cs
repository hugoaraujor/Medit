using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataModel;
using System.Data;
namespace BussinessLayer
{
    public class EmpresasManager
    {
        // Return a datatable to fill up te Comboboxes
        public DataTable GetEmpresasTable(int Clase)
        {
            bool? seguro = false;
            if (Clase == 1)
                seguro = true;
            
                          
            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("empresa", typeof(string));
            table.Columns.Add("Rif", typeof(string));
            table.Columns.Add("Direccion", typeof(string));
            table.Columns.Add("Contacto", typeof(string));
            table.Columns.Add("Telefonos", typeof(string));
            table.Columns.Add("Correo", typeof(string));
            table.Columns.Add("Active", typeof(bool));
            table.Columns.Add("Aseguradora", typeof(bool));
            table.Columns.Add("Credito", typeof(int));
            table.Columns.Add("Limite", typeof(Decimal));

            using (var db = new DataModel.AGILMEDEntities())
            {
                foreach (var entity in db.Empresas)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["empresa"] = entity.Empresa;
                    row["Rif"] = entity.RIF;
                    row["Direccion"] = entity.Direccion;
                    row["Contacto"] = entity.Contacto;
                    row["Telefonos"] = entity.Telefonos;
                    row["Correo"] = entity.Correo;

                    if (entity.Active == null)
                        entity.Active = true;
                        
                        row["Active"] = entity.Active;

                    if (entity.Aseguradora == null)
                        entity.Aseguradora = false;

                    row["Aseguradora"] = entity.Aseguradora;
                    if (entity.creditodias == null)
                        entity.creditodias = 0;
                    row["credito"] = entity.creditodias;
                    if (entity.limite == null)
                        entity.limite = 0;
                    row["Limite"] = entity.limite;
                    table.Rows.Add(row);
                }
            }
            if (table!= null)
                 table= table.Select("Aseguradora='"+seguro+"'","empresa").CopyToDataTable();
           return table;
        }
        #region Select
        //get empresas: param 0 para empresas:1 para Aseguradoras
        public List<EmpresasDTO> GetEmpresas(int Clase)
        {
            bool? seguro = false;
            if (Clase == 1)
                seguro = true;
            List<EmpresasDTO> EmpresasLst = new List<EmpresasDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
                EmpresasLst = (from x in db.Empresas where x.Aseguradora==seguro
                         select new EmpresasDTO
                         {
                             Id = x.Id,
                             Empresa = x.Empresa,
                             RIF = x.RIF,
                             Direccion = x.Direccion,
                             Contacto = x.Contacto,
                             Telefonos = x.Telefonos,
                             Correo = x.Correo,
                             Active = x.Active,
                             Aseguradora = x.Aseguradora,
                             creditodias = x.creditodias,
                             limite = x.limite

                         }).ToList();
            }
            return EmpresasLst;
        }
        public EmpresasDTO GetEmpresa(int idempresa)
        {
            EmpresasDTO EmpresasLst = new EmpresasDTO();
         
               
                using (var db = new DataModel.AGILMEDEntities())
                {
                    EmpresasLst = (from x in db.Empresas
                                   where x.Id == idempresa
                                   select new EmpresasDTO
                                   {
                                       Id = x.Id,
                                       Empresa = x.Empresa,
                                       RIF = x.RIF,
                                       Direccion = x.Direccion,
                                       Contacto = x.Contacto,
                                       Telefonos = x.Telefonos,
                                       Correo = x.Correo,
                                       Active = x.Active,
                                       Aseguradora = x.Aseguradora,
                                       creditodias = x.creditodias,
                                       limite = x.limite

                                   }).FirstOrDefault();
            }
            return EmpresasLst;
        }
        #endregion

        #region Insert

        public void InsertEmpresa(EmpresasDTO NewEmpresa)
        {
            var x = NewEmpresa;
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Empresas.Add(new Empresas()
                {
                    Id = x.Id,
                    Empresa = x.Empresa,
                    RIF = x.RIF,
                    Direccion = x.Direccion,
                    Contacto = x.Contacto,
                    Telefonos = x.Telefonos,
                    Correo = x.Correo,
                    Active = x.Active,
                    Aseguradora = x.Aseguradora,
                    creditodias = x.creditodias,
                    limite = x.limite
                });
                db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdEmpresa)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Empresas Emp = (from x in db.Empresas where x.Id == IdEmpresa select x).FirstOrDefault();
                if (Emp != null)
                {
                    db.Empresas.Remove(Emp);
                    db.SaveChanges();
                }

            }
        }

        #endregion
        #region Existe
        public bool ExisteAseguradora(string emp)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Empresas Emp = (from x in db.Empresas where (x.Empresa.ToUpper() == emp.ToUpper() && (x.Aseguradora== true)) select x).FirstOrDefault();
                if (Emp != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        public bool ExisteEmpresa(string emp)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Empresas Emp = (from x in db.Empresas where x.Empresa.ToUpper() == emp.ToUpper() select x).FirstOrDefault();
                if (Emp != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion


        #region Edit

        public void Edit(EmpresasDTO EditedEmp)
        {
            var x = EditedEmp;
           Empresas Ed_Emp = new Empresas
            {
               Id = x.Id,
               Empresa = x.Empresa,
               RIF = x.RIF,
               Direccion = x.Direccion,
               Contacto = x.Contacto,
               Telefonos = x.Telefonos,
               Correo = x.Correo,
               Active = x.Active,
               Aseguradora = x.Aseguradora,
               creditodias = x.creditodias,
               limite = x.limite

           };

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var Empre = (from a in db.Empresas where a.Id == EditedEmp.Id select a).FirstOrDefault();
                    if (Empre != null)
                    {
                        Empre = Ed_Emp;
                        db.SaveChanges();
                    }
                    db.Entry(Empre).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch 
            { }
        }

        #endregion
    }
}
