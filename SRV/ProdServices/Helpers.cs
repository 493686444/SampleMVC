using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SRV.ProdServices
{
    public static class Helpers
    {
        public static int GetUserID(int id,string userInfoPassword)
        {
            UserRepository userRepository = new UserRepository();
            BLL.Entities.User user =userRepository.GetUserById(id);
            bool result = user.PasswordTest(userInfoPassword);
            if (result)
            {
                return id;
            }
            else
            {
                throw new ArgumentException("存储密码异常");
            }
        }
        
        public static void EndTransaction() 
        {
            BLL.Repositories.Helpers.EndTransaction();
        } 
       
        public static void RollBack() 
        {
            BLL.Repositories.Helpers.RollBack();
        }
        
    }
}
