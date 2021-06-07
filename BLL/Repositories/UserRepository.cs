using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : BaseRepository
    {
        public User GetUserById(int Id)
        {
            User user = context.Set<User>().Find(Id);
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
            return user.Id;
        }
        public void UserSaveChanges(User user)
        {
            context.SaveChanges();
        }
    }
}
