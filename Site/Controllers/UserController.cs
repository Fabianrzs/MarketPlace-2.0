using AutoMapper;
using BLL.Interface;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Service;

namespace Site.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwt;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IJwtService jwt, IMapper mapper)
        {
            _userService = userService;
            _jwt = jwt;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public ActionResult<UserModel> Login(UserInputModel userInput)
        {
            
            var request = _userService.Login(_mapper.Map<User>(userInput));
            if(request.Error)
            {
                return BadRequest(request.Message);
            }

            var clainUser = _jwt.GetJwtToken(request.Data);

            return Ok(clainUser);
        }

        [HttpPost("Register")]
        public ActionResult<UserModel> Register(UserInputModel userInput)
        {
            var request = _userService.Register(_mapper.Map<User>(userInput));
            if (request.Error)
            {
                return BadRequest(request.Message);
            }

            var clainUser = _jwt.GetJwtToken(request.Data);

            return Ok(clainUser);
        }            

    }
}
