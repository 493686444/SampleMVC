using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModels.User
{
   public class IndexModel
    {
        public bool? Gender { set; get; }
        public int? Yesr { set; get; }
        public Email Email { set; get; }

    }
}
