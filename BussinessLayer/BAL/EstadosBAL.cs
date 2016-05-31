using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    class EstadosBAL
    {
           private EdoManager umanager;
            private EdoManager UManager
            {
                get
                {
                    return umanager ?? (umanager = new EdoManager());
                }
            }


            public bool ExisteEstado(string EdoName)
            {
                return UManager.ExisteEstado(EdoName);
            }

            public List<EstadosDTO> GetEstados()
            {
                return UManager.GetEstados();
            }

            public void InsertEstado(EstadosDTO Edo)
            {
                UManager.InsertEstado(Edo);
            }

            public void EditEstado(EstadosDTO Estado)
            {
                UManager.Edit(Estado);
            }
            public void DeleteUser(int IdEdo)
            {
                UManager.Delete(IdEdo);
            }

        
    }
}
