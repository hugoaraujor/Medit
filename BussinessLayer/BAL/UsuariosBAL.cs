using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
namespace BussinessLayer
{
    public class UsuariosBAL
    {
      
            private UsuariosManager umanager;
            private UsuariosManager UManager
            {
                get
                {
                    return umanager ?? (umanager = new UsuariosManager());
                }
            }

        public UsuariosDTO GetUser(string loginname,string passw)
        {
            return UManager.GetUser(loginname,passw);
        }
        public bool ExisteUser(string usuarioDTO, string psw)
            {
                return UManager.ExisteUser(usuarioDTO, psw);
            }

            public List<UsuariosDTO> GetUsers()
            {
                return UManager.GetUsers();
            }

            public void InsertUser(UsuariosDTO user)
            {
                UManager.InsertUser(user);
            }

            public void EditUser(UsuariosDTO user)
            {
                UManager.Edit(user);
            }
            public void DeleteUser(UsuariosDTO user)
            {
                UManager.Delete(user.UsuarioId);
            }

        }
    }

