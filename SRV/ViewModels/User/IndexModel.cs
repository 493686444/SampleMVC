using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SRV.ViewModels.User
{
   public class IndexModel
    {
        public bool? Gender { set; get; }
        public int? Year { set; get; }
        public HttpPostedFileBase icon { set; get; }
        public string IconPath { set; get; }
    }
}
