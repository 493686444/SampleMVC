using BLL.Entities;
using BLL.Repositories;
using Global;
using SRV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ProdServices
{
    public class RegisterService
    {
        public string Servicing(RegisterModel model)
        {
            UserRepository repository = new UserRepository();
            User user = repository.GetUserByName(model.Name);
            if (user!=null)
            {
                return "用户名已存在";
            }
            else
            {
                if (model.Password==model.PasswordSecond)
                {
                    User newuser = new User();
                    newuser.Name = model.Name;
                    newuser.Password = model.Password.MD5Encrypt();   //加密
                    repository.SaveUser(newuser);
                    return "注册成功";
                }
                else
                {
                    return "两次密码不一样";
                }
                
            }
           
        }
    }
}
