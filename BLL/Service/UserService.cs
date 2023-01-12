using BLL.Interface;
using BLL.Response;
using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConnectionManager _connection;
        public UserService(IUserRepository userRepository, IConnectionManager connection)
        {
            _connection = connection;
            _userRepository = userRepository;
        }

        public Response<User> Login(User user)
        {
            try
            {
                _connection.Open();
                user.Encript();
                var response = _userRepository.Login(user.UserName, user.Password);
                return new Response<User>(response);
            }
            catch (Exception e)
            {
                _connection.Close();
                return new Response<User>(e.Message);
            }
        }

        public Response<User> Register(User user)
        {
            try
            {
                _connection.Open();
                user.Encript();
                var response = _userRepository.Register(user);
                return new Response<User>(user);

            }
            catch (Exception e)
            {
                _connection.Close();
                return new Response<User>(e.Message);
            }
        }

    }
}
