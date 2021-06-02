using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Repositories
{
    public class BaseRepository
    {
        public SqlDbContext context { get; set; }
        public BaseRepository()//所有repository都是用同一个context
        {
            if (HttpContext.Current.Items["context"] != null)
            {
                context = HttpContext.Current.Items["context"] as SqlDbContext;
            }
            else
            {
                context = new SqlDbContext();
                HttpContext.Current.Items["context"] = context;
                context.Database.BeginTransaction();
            }
        }
    }
}
