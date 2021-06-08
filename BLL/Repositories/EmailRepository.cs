using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class EmailRepository:BaseRepository
    {
        public Email GetEmailByUserId(int userId) 
        {
            User user = context.Set<User>().Find(userId);
            Email email = context.Set<Email>().Find(user.EmailId);
            return email;
        }
    }
}
