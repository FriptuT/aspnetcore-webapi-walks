using AutoMapper;
using Refreshing.API.Models.Domain;
using Refreshing.API.Models.DTO;

namespace Refreshing.API.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            // reverse map applies the automap also for regionDto - region
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

        }
    }
}
