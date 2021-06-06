using BLL.Entities;
using BLL.Repositories;
using Global;
using SRV.ViewModels.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ProdServices.Log
{
    public class OnService
    {
        public int? Servicing(OnModel model,out string result)
        {
            UserRepository repository = new UserRepository();
            BLL.Entities.User user = repository.GetUserByName(model.Name);
            if (user == null)
            {
                result = "该用户不存在";
                return null;
            }
            else
            {
                bool LogOnable = user.PasswordTest(model.Password.MD5Encrypt());
                if (LogOnable)
                {
                    result = "登录成功";
                    return user.ID;
                   
                }
                else
                {
                    result = "密码错误";
                    return null;
                }
            }
           
          


        }
    }
}
