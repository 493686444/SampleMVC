using BLL.Entities;
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
        public static int? GetUserID()
        {
            var userInfo = HttpContext.Current.Request.Cookies["User"].Values;
            if (userInfo==null)
            {
                return null;
            }

            int userInfoID = Convert.ToInt32(userInfo["ID"]);

            UserRepository userRepository = new UserRepository();
            User user=userRepository.GetUserByID(userInfoID);
            bool result = user.PasswordTest(userInfo["Password"]);

            if (result)
            {
                return userInfoID;
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
    }
}
