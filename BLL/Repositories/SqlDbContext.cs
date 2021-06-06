using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.Log = Console.WriteLine;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>();
            modelBuilder.Entity<User>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
