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
                    transaction.Commit();   //其实这里报了异常,并准队数据库操作的话  会自动回滚的

                    HttpContext.Current.Items.Remove("context");
                    //防止被子Action错用   但是这样就变一次action一个连接数据库了

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw new Exception("事务提交异常call");
                }
            }
        }
        public static void RollBack()
        {
            SqlDbContext context = HttpContext.Current.Items["context"] as SqlDbContext;
            using (DbContextTransaction transaction = context.Database.CurrentTransaction)
            {
                transaction.Rollback();
            }
        }

    }
}
