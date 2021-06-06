using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Supervision
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explain { get; set; }
        //public List<string> Lables { get; set; }   //需要js,暂时搁置
        public DateTime Starting { get; set; }
        public DateTime Ended { get; set; }
        public List<WeekDay> WeekDays { get; set; }
            = new List<WeekDay>()
            {
                new WeekDay { DayOfWeek=DayOfWeek.Sunday },
                new WeekDay { DayOfWeek=DayOfWeek.Monday },
                new WeekDay { DayOfWeek=DayOfWeek.Tuesday},
                new WeekDay { DayOfWeek=DayOfWeek.Wednesday },
                new WeekDay { DayOfWeek=DayOfWeek.Thursday },
                new WeekDay { DayOfWeek=DayOfWeek.Friday },
                new WeekDay { DayOfWeek=DayOfWeek.Saturday }
            };

    }
}

