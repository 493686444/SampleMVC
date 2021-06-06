using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public bool Activated { get; set; } = false;

    }
}
