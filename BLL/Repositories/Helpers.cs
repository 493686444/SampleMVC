using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Repositories
{
    public static class Helpers
    {
        public static void EndTransaction() 
        {
            SqlDbContext context = HttpContext.Current.Items["context"] as SqlDbContext;
            context.Database.CurrentTransaction.Commit();
        }
    }
}
