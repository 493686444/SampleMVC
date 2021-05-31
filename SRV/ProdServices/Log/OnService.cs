using BLL.Entities;
using BLL.Repositories;
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
        public string Servicing(OnModel model)
        {
            UserRepository repository = new UserRepository();
            User user = repository.GetUserByName(model.Name);
            if (user == null)
            {
                return "该用户不存在";
            }
            else
            {
                bool result = user.LogOn(model.Password);
                if (result)
                {
                    return "登录成功";
                }
                else
                {
                    return "密码错误";
                }

            }



        }
    }
}
