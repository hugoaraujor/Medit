using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using BussinessLayer;

namespace BussinessLayer
{
    public class CargosClasesBAL
    {
        private CargoClasesManager umanager;
        private CargoClasesManager UManager
        {
            get
            {
                return umanager ?? (umanager = new CargoClasesManager());
            }
        }


        public bool ExistePac(string ClaseName,int tipo)
        {
            return UManager.ExisteClase(ClaseName,tipo);
        }

        public List<CargosClasesDTO> GetCargos(int tipo)
        {
            return UManager.GetClases(tipo);
        }

        public void InsertCity(CargosClasesDTO cargo)
        {
            UManager.InsertClase(cargo);
        }

        public void EditCity(CargosClasesDTO cargoclase)
        {
            UManager.Edit(cargoclase);
        }
        public void DeleteCargoclase(int IdCargoclase)
        {
            UManager.Delete(IdCargoclase);
        }
    }
}
