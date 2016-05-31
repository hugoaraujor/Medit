using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
   public class CargosBAL
    {
        private CargosManager umanager;
        private CargosManager UManager
        {
            get
            {
                return umanager ?? (umanager = new CargosManager());
            }
        }


        public bool ExistePac(string CargosName)
        {
            return UManager.ExisteCargo(CargosName);
        }

        public List<CargosDTO> GetCargos()
        {
            return UManager.GetCargos();
        }

        public void InsertCity(CargosDTO cargo)
        {
            UManager.InsertCargo(cargo);
        }

        public void EditCity(CargosDTO cargo)
        {
            UManager.Edit(cargo);
        }
        public void DeleteUser(int IdCargo)
        {
            UManager.Delete(IdCargo);
        }
    }
}
