using MisOfertas.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio
{
    public class SessionManager
    {
        public SessionManager()
        {

        }

        public UserSession Login(UserLoginRequest user)
        {
            //Daniel 123
            var userHelper = CommonContext.GetInstance().Users.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (!(userHelper == null))
            {
                return new UserSession { IsSuccess = true,
                    Email =userHelper.Email,
                    Rut =userHelper.Rut,
                    Message ="Session Open",
                    IdUserType =userHelper.IdUserType
                };
            }

            return new UserSession {
                IsSuccess =false,
                Message ="Session not created"
            };
            
        }
    }
}
