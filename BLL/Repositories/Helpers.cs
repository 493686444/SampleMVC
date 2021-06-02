using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            using (DbContextTransaction transaction = context.Database.CurrentTransaction)//注意此处要调用而不是新生成一个
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw new Exception("事务提交异常call");
                }
            }

        }
    }
}
