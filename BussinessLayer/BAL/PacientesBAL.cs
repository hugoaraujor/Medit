using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class PacientesBAL
    {

        private PacientesManager umanager;
        private PacientesManager UManager
        {
            get
            {
                return umanager ?? (umanager = new PacientesManager());
            }
        }

        public bool ExistePac(string IdPac)
        {
            return UManager.ExistePaciente(IdPac);
        }

        public List<PacienteDTO> GetPacientes()
        {
            return UManager.GetPacientes();
        }

        public void InsertUser(PacienteDTO paciente)
        {
            UManager.InsertPaciente(paciente);
        }

        public void EditUser(PacienteDTO paciente)
        {
            UManager.Edit(paciente);
        }
        public void DeleteUser(long pacId)
        {
            UManager.Delete(pacId);
        }

    }
}
