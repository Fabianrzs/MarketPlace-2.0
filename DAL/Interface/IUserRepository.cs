using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(string userName);
        bool IsActive(string userName);
        User Login(string userName, string password);
        int Register(User users);

    }
}
