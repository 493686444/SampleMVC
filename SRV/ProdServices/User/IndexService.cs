using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRV.ViewModels.User;
namespace SRV.ProdServices.User
{
    public class IndexService
    {
  
        public SRV.ViewModels.User.IndexModel Sevicing(int cookieId, string cookiePassword)
        {
            UserRepository userRepository = new UserRepository();
            BLL.Entities.User user =userRepository.GetUserById(cookieId);
            bool result=user.PasswordTest(cookiePassword);
            IndexModel model = new IndexModel();

            //var config = new MapperConfiguration();

            if (result)
            {
                return model;
            }
            else
            {
                throw new Exception("存在cookie造假");
            }
        }
    }
}
