using AutoMapper;
using Site.Mappers;

namespace Site.Extensions
{
    public static class MappingExtensions
    {
        public static IServiceCollection AddMapping(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));
            return services;
        }
    }
}
