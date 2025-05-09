using AutoMapper;
using Business.DTO.Request.Bootcamp;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Bootcamps
{
    public class BootcampProfile : Profile
    {
        public BootcampProfile()
        {
            CreateMap<Bootcamp, CreateBootcampRequest>().ReverseMap();
            CreateMap<Bootcamp, DTO.Response.Bootcamp.CreateBootcampResponse>().ReverseMap();

        }
    }
}
