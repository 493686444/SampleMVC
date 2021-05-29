using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository
    {
        public SqlDbContext context { get; set; }
        public User GetUser(int ID) 
        {
            User user=context.Set<User>().Find(ID);
            return user;
        }
        public int SaveUser(User user)
        {
            context.Set<User>().Add(user);
            context.SaveChanges();
            return user.ID;
        }
    }
}
