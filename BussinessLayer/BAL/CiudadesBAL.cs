using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class CiudadesBAL
    {

        private CitiesManager umanager;
        private CitiesManager UManager
        {
            get
            {
                return umanager ?? (umanager = new CitiesManager());
            }
        }


        public bool ExistePac(string CityName)
        {
            return UManager.ExisteCity(CityName);
        }

        public List<CiudadesDTO> GetCities()
        {
            return UManager.GetCities();
        }

        public void InsertCity(CiudadesDTO City)
        {
            UManager.InsertCity(City);
        }

        public void EditCity(CiudadesDTO City)
        {
            UManager.Edit(City);
        }
        public void DeleteUser(int IdCity)
        {
            UManager.Delete(IdCity);
        }

    }
}
