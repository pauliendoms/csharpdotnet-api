using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using parkeer_api.Dto;

namespace parkeer_api.Mappings
{
    public class ParkingProfile:Profile
    {
        public ParkingProfile()
        {
            CreateMap<Parking, ParkingReadDto>();
            CreateMap<ParkingWriteDto, Parking>();
        }
    }
}