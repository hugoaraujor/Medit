using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class OcupacionesBAL
    {

        private OcupacionesManager umanager;
        private OcupacionesManager UManager
        {
            get
            {
                return umanager ?? (umanager = new OcupacionesManager());
            }
        }


        public bool ExisteOcupacion(string ocupacion)
        {
            return UManager.ExisteOcupacion(ocupacion);
        }

        public List<DataEntities.OcupacionesDTO> GetOcupaciones()
        {
            return UManager.GetOcupaciones();
        }

        public void InsertCity(OcupacionesDTO ocupacion)
        {
            UManager.InsertOcupacion(ocupacion);
        }

        public void EditCity(OcupacionesDTO ocupacion)
        {
            UManager.Edit(ocupacion);
        }
        public void DeleteUser(int IdOcupacion)
        {
            UManager.Delete(IdOcupacion);
        }

    }
}
