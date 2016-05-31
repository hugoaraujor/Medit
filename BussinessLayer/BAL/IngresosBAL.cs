using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class IngresosBAL
    {
        private IngresosManager umanager;
        private IngresosManager UManager
        {
            get
            {
                return umanager ?? (umanager = new IngresosManager());
            }
        }

         public EntryView getDataView(string Cedula)
        {
            return UManager.getDataView(Cedula);
        }
   
        //public List<IngresosDTO> GetIngresosAbiertos()
        //{
        //    return UManager.GetIngresosAbiertos();
        //}

        public void InsertIngreso(IngresosDTO ingreso)
        {
            UManager.InsertIngreso(ingreso);
        }

        public void listaaseguradoras(PacienteDTO paciente)
        {

            UManager.GetSeguros(paciente);
        }
        //public void CerrarIngreso(int IdIngreso)
        //{
        //    UManager.Cerrar(IdIngreso);
        //}

    }
}
