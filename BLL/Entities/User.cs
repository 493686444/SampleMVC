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
        public int Id { get; set; }

        [Required(ErrorMessage = "用户名不可空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }
        public bool? Gender { set; get; } 
        public int? Year { set; get; }
        public int? EmailId { set; get; }
        public Email Email { set; get; }
        public string IconPath { get; set; }
        public bool PasswordTest(string password)
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
