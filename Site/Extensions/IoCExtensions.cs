using BLL.Interface;
using BLL.Service;
using DAL.Base;
using DAL.Interface;
using Microsoft.Extensions.Configuration;
using Site.Service;

namespace Site.Middelwors
{
    public static class IoCExtensions
    {

        public static IServiceCollection AddDependency(IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IConfiguration>(configuration);

            services.AddSingleton<IConnectionManager, ConnectionManager>();
            services.AddScoped<IJwtService, JwtService>();

            #region Repositories 
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion


            #region Services 
            services.AddScoped<IUserService, UserService>();
            #endregion

            return services;
        }

    }
}
