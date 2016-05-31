using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using BussinessLayer;
using System.Data;
namespace BussinessLayer
{
    public class MedicosBAL
    {

        private MedicosDTO umedico;
        private MedicosDTO Umedico
        {
            get
            {
                return umedico ?? (umedico = new MedicosDTO());
            }
        }


        private MedicosManager umanager;
        private MedicosManager UManager
        {
            get
            {
                return umanager ?? (umanager = new MedicosManager());
            }
        }


        public bool ExistePac(string CargosName)
        {
            return UManager.ExisteDoctor(CargosName);
        }

        public DataTable GetDoctoresDAtaTable()
        {
            return UManager.GetDoctorTable("");
        }

        public void InsertDoctor(MedicosDTO cargo)
        {
            UManager.InsertDoctor(cargo);
        }

        public void EditDoctor(MedicosDTO cargo)
        {
            UManager.Edit(cargo);
        }
        public void Delete(int IdDoctor)
        {
            UManager.Delete(IdDoctor);
        }
    }
}
