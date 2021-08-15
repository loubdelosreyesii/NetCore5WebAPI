using AutoMapper;
using NetCore5WebAPI.Data;
using NetCore5WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5WebAPI.Configurations
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<Clinic, ClinicDTO>().ReverseMap();
            CreateMap<Clinic, CreateClinicDTO>().ReverseMap();
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDTO>().ReverseMap();

        }
    }
}
