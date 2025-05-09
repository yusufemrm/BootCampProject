using AutoMapper;
using Business.DTO.Request.Application;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Applicants
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Applicant, CreateApplicationRequest>().ReverseMap();
            CreateMap<Applicant, DTO.Response.Application.CreateApplicationResponse>().ReverseMap();
        }
    }
}
