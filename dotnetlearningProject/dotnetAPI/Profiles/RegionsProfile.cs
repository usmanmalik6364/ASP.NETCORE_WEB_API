using AutoMapper;
using dotnetAPI.Models.Domain;
using dotnetAPI.Models.DTO;

namespace dotnetAPI.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Region, RegionDTO>();
        }
    }
}
