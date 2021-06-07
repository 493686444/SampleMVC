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
            BLL.Entities.User user = repository.GetUserByName(model.Name);
            if (user!=null)
            {
                return "用户名已存在";
            }
            else
            {
                if (model.Password==model.PasswordSecond)
                {
                    BLL.Entities.User newuser = new BLL.Entities.User();
                    newuser.Name = model.Name;
                    newuser.Password = model.Password.MD5Encrypt();   //因为涉及到加密,所以没办法AutoMapper
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
