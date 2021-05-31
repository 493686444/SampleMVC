using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "用户名不可空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }
        public bool Gender { set; get; } = true;//此处设置默认值,是测试的需要


        public bool LogOn(string password)
        {
            if (password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   

    }
}
