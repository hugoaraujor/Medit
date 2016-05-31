using DataEntities;
namespace BussinessLayer
{
    public class ClinicaBAL
    {

        private ClinicaManager umanager;
        private ClinicaManager UManager
        {
            get
            {
                return umanager ?? (umanager = new ClinicaManager());
            }
        }


        public void InsertCity(ClinicaDTO clinica)
        {
            UManager.Insertclinica(clinica);
        }

        public void EditCity(ClinicaDTO clinica)
        {
            UManager.Edit(clinica);
        }
       
    }
}
