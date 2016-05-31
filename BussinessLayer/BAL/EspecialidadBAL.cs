using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class EspecialidadBAL
    {

        private EspecialidadesManager umanager;
        private EspecialidadesManager UManager
        {
            get
            {
                return umanager ?? (umanager = new EspecialidadesManager());
            }
        }
        public String GetEsp(int Esp)
        {
            EspecialidadDTO ne = new EspecialidadDTO();
           ne= UManager.GetEspecialidad(Esp);
            return ne.Especialidad;
        }

        public bool ExistePac(string EspName)
        {
            return UManager.ExisteEsp(EspName);
        }

        public List<EspecialidadDTO> GetCities()
        {
            return UManager.GetEspecialidades();
        }

        public void Insert(EspecialidadDTO Espec)
        {
            UManager.Insert(Espec);
        }

        public void Edit(EspecialidadDTO Espec)
        {
            UManager.Edit(Espec);
        }
        public void Delete(int IdEsp)
        {
            UManager.Delete(IdEsp);
        }

    }
}
