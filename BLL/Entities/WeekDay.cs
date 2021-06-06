using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class WeekDay   //这个类是不是要放在
    {
        public int Id { set; get; }
        public bool Selected { set; get; } = false;
        public DayOfWeek DayOfWeek { set; get; }
    }
}
