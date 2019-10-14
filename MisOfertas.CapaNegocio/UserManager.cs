using MisOfertas.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio
{
    public class UserManager : IMaintanable<User>
    {
        
        
        public UserManager()
        {
            
        }

        public Response<User> Create(User user)
        {
            try
            {
                if (!(user.Email.Length >= 5))
                {
                    return new Response<User> { Message = "Please, check the Email format" };
                }
                if (!(user.Password.Length >= 5))
                {
                    return new Response<User> { Message = "The length of password must be 5 digits" };
                }
                if (!(user.Rut.Length >= 8 && user.Rut.Length <= 9))
                {
                    return new Response<User> { Message = "Please, check the Rut" };
                }
                if (!(user.IdUser >= 0 && user.IdUser <= 3))
                {
                    return new Response<User> { Message = "Error checking the user" };
                }

                CommonContext.GetInstance().Users.Add(user);
                CommonContext.GetInstance().SaveChanges();

                return new Response<User> { IsSuccess = true, Answer = user, Message = "User created" };
            }
            catch (Exception ex)
            {
                return new Response<User> { Message = ex.ToString() };
            }
            
        }

        public Response<User> Delete(int id)
        {
            int userExist = CommonContext.GetInstance().Users.Where(u => u.IdUser == id).Count();
            if(!(userExist > 0))
            {
                return new Response<User> { Message="This user id doesn't exist" };
            }

            var userToEliminate = CommonContext.GetInstance().Users.SingleOrDefault(u => u.IdUser == id);
            CommonContext.GetInstance().Users.Remove(userToEliminate);
            CommonContext.GetInstance().SaveChanges();
            return new Response<User> { IsSuccess = true, Answer = null, Message = "Delete of user success" };
        }

        public Response<User> Delete(string nombre)
        {
            var userToDelete = CommonContext.GetInstance().Users.Where(u => u.Email.Equals(nombre)).FirstOrDefault();
            CommonContext.GetInstance().Users.Remove(userToDelete);
            return new Response<User> { IsSuccess=true, Answer=null, Message="Deleted of user success"};
        }

        

        public List<User> ToList()
        {
            return CommonContext.GetInstance().Users.ToList();
        }
        

        public Response<User> Update(int id, User obj)
        {
            throw new NotImplementedException();
        }
    }
}
