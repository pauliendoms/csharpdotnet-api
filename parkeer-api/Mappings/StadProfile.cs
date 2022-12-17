using AutoMapper;
using parkeer_api.Dto;

namespace parkeer_api.Mappings
{
    public class StadProfile:Profile
    {
        public StadProfile()
        {
            CreateMap<Stad, StadReadDto>();
            CreateMap<StadWriteDto, Stad>();
        }
    }
}