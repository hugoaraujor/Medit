using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities;
using DataModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
namespace BussinessLayer
{
      public class UsuariosManager
    {
        #region Select
        public UsuariosDTO GetUser(string loginname,string passw)
        {
            UsuariosDTO user = new UsuariosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                user = (from x in db.Usuarios
                        where ((x.Usuario == loginname && x.password == passw) && x.activo == true)
                         select new UsuariosDTO
                         {
                             UsuarioId = x.UsuarioId,
                             Nombres = x.Nombres,
                             activo = x.activo,
                             Correo = x.Correo,
                             Rol = x.Rol,
                             telefono = x.telefono,
                             TipodeAcceso = x.TipodeAcceso,
                             password = x.password,
                             Usuario = x.Usuario
                         }).SingleOrDefault<UsuariosDTO>();
            }
            return user;
        }
        public List<UsuariosDTO> GetUsers()
        {
            List<UsuariosDTO> users = new List<UsuariosDTO>();
            using (var db = new DataModel.AGILMEDEntities())
            {
              users = (from x in db.Usuarios where x.activo==true select new UsuariosDTO { UsuarioId= x.UsuarioId,
                                                                         Nombres=x.Nombres,
                                                                         activo=x.activo,
                                                                         Correo=x.Correo,
                                                                          Rol=x.Rol,
                                                                          telefono=x.telefono,
                                                                          TipodeAcceso=x.TipodeAcceso,
                                                                          password=x.password,
                                                                          Usuario=x.Usuario}).ToList();
            }
            return users;
        }
        public DataTable GetUsersTable()
        {
            var table = new DataTable();

            table.Columns.Add("UsuarioId", typeof(int));
            table.Columns.Add("Usuario", typeof(string));
            table.Columns.Add("Nombres", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Activo", typeof(bool));

            using (var db = new DataModel.AGILMEDEntities())
            {


                var queryresults = from a in db.Usuarios
                                   select new { UsuarioId= a.UsuarioId, Usuario=a.Usuario,Nombres=a.Nombres,Telefono=a.telefono,Activo=a.activo};

            //    if (filter != "")
              //      queryresults = queryresults.Where(x => (x.Tipo.ToUpper() + x.descripción.ToUpper() + x.Grupo.ToUpper()).IndexOf(filter.ToUpper()) > -1);

                foreach (var entity in queryresults)
                {
                    var row = table.NewRow();
                    row["UsuarioId"] = entity.UsuarioId;
                    row["Usuario"] = entity.Usuario;
                    row["Nombres"] = entity.Nombres;
                    row["Telefono"] = entity.Telefono;
                    table.Rows.Add(row);
                }
            }
            return table;


        }
        public UsuariosDTO GetUser(int iduser)
        {
           UsuariosDTO users = new UsuariosDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                users = (from x in db.Usuarios where x.UsuarioId==iduser
                         select new UsuariosDTO
                         {
                             UsuarioId = x.UsuarioId,
                             Nombres = x.Nombres,
                             activo = x.activo,
                             Correo = x.Correo,
                             Rol = x.Rol,
                             telefono = x.telefono,
                             TipodeAcceso = x.TipodeAcceso,
                             password=x.password,
                             Usuario = x.Usuario
                         }).SingleOrDefault();
            }
            return users;
        }
        #endregion

        #region Insert

        public void InsertUser(UsuariosDTO Newuser)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                db.Usuarios.Add(new Usuarios  {
                    UsuarioId = Newuser.UsuarioId,
                    Nombres = Newuser.Nombres,
                    activo = Newuser.activo,
                    Correo = Newuser.Correo,
                    Rol = Newuser.Rol,
                    telefono = Newuser.telefono,
                    TipodeAcceso = Newuser.TipodeAcceso,
                    Usuario = Newuser.Usuario,
                    Modulos=Newuser.Modulos,
                    created=Newuser.created,
                    password=Newuser.password,
                    lastlogin= Newuser.lastlogin
                });
                 db.SaveChanges();
            }
        }

        #endregion
        #region Delete

        public void Delete(int IdUsuario)
        {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Usuarios User = (from x in db.Usuarios where x.UsuarioId == IdUsuario select x).FirstOrDefault();
                if (User != null)
                {
                    db.Usuarios.Remove(User);
                    db.SaveChanges();
                }

            }
        }

        #endregion
        #region Existe

        public bool ExisteUser(string Usuario, string pasw)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Usuarios User = (from x in db.Usuarios where x.Usuario == Usuario && x.password == pasw select x).FirstOrDefault<Usuarios>();
                if (User != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        public bool ExisteUser(string Usuario)
        {
            bool resp = false;
            using (var db = new DataModel.AGILMEDEntities())
            {
                Usuarios User = (from x in db.Usuarios where x.Usuario == Usuario  select x).FirstOrDefault<Usuarios>();
                if (User != null)
                {
                    resp = true;
                }

            }
            return resp;
        }
        #endregion
      
     
        #region Edit

        public void Edit(UsuariosDTO EditedUsuario)
        {
            
            Usuarios Ed_User = new Usuarios 
            {
                UsuarioId = EditedUsuario.UsuarioId,
                Nombres = EditedUsuario.Nombres,
                activo = EditedUsuario.activo,
                Correo = EditedUsuario.Correo,
                Rol = EditedUsuario.Rol,
                telefono = EditedUsuario.telefono,
                TipodeAcceso = EditedUsuario.TipodeAcceso,
                Usuario = EditedUsuario.Usuario
            };

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var User = (from x in db.Usuarios where x.UsuarioId == EditedUsuario.UsuarioId select x).FirstOrDefault();
                    if (User != null)
                    {
                        User = Ed_User;
                        db.SaveChanges();
                    }
             //    db.Entry(User).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {

                foreach (DbEntityValidationResult entityErr in e.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                                            error.PropertyName, error.ErrorMessage);
                    }
                }


            }
        }

        #endregion
    }
}
