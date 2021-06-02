using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository:BaseRepository
    {
        public User GetUserByID(int ID) 
        {
            User user=context.Set<User>().Find(ID);
            return user;
        }
        public User GetUserByName(string name)
        {
            User user = context.Set<User>()
                               .Where(u => u.Name == name)
                               .SingleOrDefault();
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
