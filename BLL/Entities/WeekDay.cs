using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class WeekDay
    {
        public int Id { set; get; }
        public bool Selected { set; get; } = false;
        public DayOfWeek DayOfWeek { set; get; }
    }
}
