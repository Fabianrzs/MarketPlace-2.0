using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Mappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<User, UserInputModel>().ReverseMap();
        }
    }
}
