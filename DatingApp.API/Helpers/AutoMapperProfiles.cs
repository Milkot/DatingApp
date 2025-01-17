using System.Linq;
using AutoMapper;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
             src.Photos.FirstOrDefault(p => p.IsMain).Url))
             .ForMember(dest => dest.Age,
              opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>().ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
             src.Photos.FirstOrDefault(p => p.IsMain).Url))
             .ForMember(dest => dest.Age,
              opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoForDetailedDto>();

            // Le Mapping est réalisé par convention, un objet ou une propriété de même nom ou de même type est reconnu
        }
        
    }
}