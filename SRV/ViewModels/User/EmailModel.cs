using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModels.User
{
    public class EmailModel
    {
        public string Value { set; get; }
        public bool Activated { set; get; }
        public string AuthCode { get; set; }

    }
}
