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
    public class CitiesManager
    {
        // Return a datatable to fill up te Comboboxes
         public DataTable GetCityTable()
        {
            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Ciudad", typeof(string));
            table.Columns.Add("Estado", typeof(int));
            using (var db = new DataModel.AGILMEDEntities())
            {
                foreach (var entity in db.Ciudades)
                {
                    var row = table.NewRow();
                    row["Id"] = entity.Id;
                    row["Ciudad"] = entity.Ciudad;
               //     row["Estado"] = entity.Estado;
                    table.Rows.Add(row);
                }
            } 
            return table;
        }
        #region GetCity
        public CiudadesDTO GetCity(int idCity)
        {
            CiudadesDTO city = new CiudadesDTO();
            using (var db = new DataModel.AGILMEDEntities())
            {
                var Locatedcity = (from x in db.Ciudades where x.Id == idCity
                                   select new CiudadesDTO()
                                   {
                                       Id = x.Id,
                                              Ciudad =x.Ciudad,
                                              Estado=x.Estado
                                     }).FirstOrDefault();
                if (Locatedcity != null)
                {
                    city = Locatedcity;
                }
               
            }
            return city;
        }

#endregion
        #region Select

        public List<CiudadesDTO> GetCities()
            {
                List<CiudadesDTO> cities = new List<CiudadesDTO>();
                using (var db = new DataModel.AGILMEDEntities())
                {
                    cities = (from x in db.Ciudades
                             select new CiudadesDTO
                             {
                                 Id = x.Id,
                                 Ciudad = x.Ciudad,
                                 Estado = x.Estado

                             }).ToList();
                }
                return cities;
            }

            #endregion

            #region Insert

            public void InsertCity(CiudadesDTO NewCity)
            {
                var x = NewCity;
                using (var db = new DataModel.AGILMEDEntities())
                {
                db.Ciudades.Add(new Ciudades()
                {    Ciudad = x.Ciudad,
                     Estado = x.Estado
                        });
                   
                    db.SaveChanges();
                }
            }

            #endregion
            #region Delete

            public void Delete(int IdCity)
            {
            using (var db = new DataModel.AGILMEDEntities())
            {
                Ciudades Locatedcity = (from x in db.Ciudades
                                   where x.Id == IdCity
                                   select x).FirstOrDefault<Ciudades>();
                if (Locatedcity != null)
                {
                    db.Ciudades.Remove(Locatedcity);
                    db.SaveChanges();
                 }
              }
             }

            #endregion
            #region Existe

            public bool ExisteCity(string city)
            {
                bool resp = false;
                using (var db = new DataModel.AGILMEDEntities())
                {
                   Ciudades City = (from x in db.Ciudades where x.Ciudad.ToUpper()==city.ToUpper() select x).FirstOrDefault();
                    if (City != null)
                    {
                        resp = true;
                    }

                }
                return resp;
            }
            #endregion


            #region Edit

            public void Edit(CiudadesDTO EditedCity)
            {
             var x = EditedCity;
             Ciudades Ed_City = new Ciudades()
                {

                 Id=x.Id,
                Estado = x.Estado,
                Ciudad = x.Ciudad
                };

            try
            {
                using (var db = new DataModel.AGILMEDEntities())
                {
                    var pac = (from p in db.Ciudades where p.Id == EditedCity.Id select p).FirstOrDefault();
                    if (pac != null)
                    {
                        pac = Ed_City;
                        db.SaveChanges();
                    }
                    db.Entry(pac).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
              }
              catch (DbEntityValidationException e)
              { }
            }

            #endregion
        }
    }

