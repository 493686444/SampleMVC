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
        public IndexModel Sevicing(int Id)
        {
            BLL.Entities.User user = userRepository.GetUserById(Id);

            IndexModel model = new IndexModel();
            Helpers.mapper.Map(user, model);//映射ing
            return model;
        }
        public void Sevicing(IndexModel model,int Id)
        {
            BLL.Entities.User user=userRepository.GetUserById(Id);
            Helpers.mapper.Map(model, user);
            userRepository.UserSaveChanges(user);
        }
        public EmailModel EmailSevicing( int Id) 
        {
            EmailRepository emailRepository = new EmailRepository();
            BLL.Entities.Email email = emailRepository.GetEmailByUserId(Id);
            EmailModel emailModel = new EmailModel();
            Helpers.mapper.Map(email,emailModel);

            return emailModel;
        }
    }
}
