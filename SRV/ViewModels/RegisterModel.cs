using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "用户名不可为空")]
        public string Name { set; get; }
        [Required(ErrorMessage = "密码不可为空")]
        public string Password { set; get; }

        [Required(ErrorMessage = "请输入确认密码")]
        public string PasswordSecond { get; set; }
    }
}
