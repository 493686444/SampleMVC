using AutoMapper;
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
        public static int GetUserId(int id, string userInfoPassword)
        {
            UserRepository userRepository = new UserRepository();
            BLL.Entities.User user = userRepository.GetUserById(id);
            bool result = user.PasswordTest(userInfoPassword);   //
            if (result)
            {
                return id;
            }
            else
            {
                throw new ArgumentException("存储密码异常");
            }
        }
        public static MapperConfiguration config;
        public static IMapper mapper;
        static Helpers()  //静态构造函数 不加public
        {
            config = new MapperConfiguration
                (
                cfg =>
                {
                    cfg.CreateMap<BLL.Entities.User, ViewModels.User.IndexModel>();
                    cfg.CreateMap<SRV.ViewModels.User.IndexModel, BLL.Entities.User>();

                    cfg.CreateMap<BLL.Entities.Email, ViewModels.User.EmailModel>();
                }//预连接
                 );
            mapper = config.CreateMapper();//创建映射器
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
