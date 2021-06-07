using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SRV.ViewModels.User;

namespace SRV.ProdServices.User
{
    public class IndexService
    {
        UserRepository userRepository = new UserRepository();
        public SRV.ViewModels.User.IndexModel Sevicing(int cookieId)
        {
            BLL.Entities.User user = userRepository.GetUserById(cookieId);

            IndexModel model = new IndexModel();
            Helpers.mapper.Map(user, model);//映射ing
            return model;
        }
        public void Sevicing(IndexModel model)
        {
            BLL.Entities.User user = new BLL.Entities.User();
            Helpers.mapper.Map(model, user);
            user.Email.Value = model.EmailValue;
            user.Email.Activated = model.EmailActivated;
            userRepository.ChangeUser(user);
        }
    }
}
