using BLL.Response;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IUserService
    {
        Response<User> Login (User user);
        Response<User> Register(User user);
    }
}
