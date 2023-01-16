using Entity;
using Site.Models;

namespace Site.Service
{
    public interface IJwtService
    {
        UserModel GetJwtToken(User user);
    }
}
