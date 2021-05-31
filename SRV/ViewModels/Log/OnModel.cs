using BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModels.Log
{
    public class OnModel
    {
        [Required(ErrorMessage ="用户名不可为空")]
        public string Name { set; get; }
        [Required(ErrorMessage = "密码不可为空")]
        public string Password { set; get; }
        //public string Captcha { set; get; }

        public bool RememberMe { set; get; }

    }
}
