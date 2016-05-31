using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class SubProductosBAL
    {
        private SubProductoManager umanager;
         private SubProductoManager UManager
        {
            get
            {
                return umanager ?? (umanager = new SubProductoManager());
            }
        }


        public bool ExistePac(int codigosubproducto,int codigoparent)
        {
            return UManager.Existe( codigosubproducto, codigoparent);
        }

     
        public void InsertSubproducto(SubproductoDTO cargo,int parentcode)
        {
            UManager.Insert(cargo,parentcode);
        }

        public void EditSubproducto(SubproductoDTO Subproduct)
        {
            UManager.Edit(Subproduct);
        }
        public void DeleteSubproducto(int IdSubproducto)
        {
            UManager.Delete(IdSubproducto);
        }
    }
}