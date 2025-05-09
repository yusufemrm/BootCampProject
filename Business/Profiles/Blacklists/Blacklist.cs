using AutoMapper;
using Business.DTO.Request.Blacklist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Instructors
{
    public class Blacklist : Profile
    {
        public Blacklist()
        {
            CreateMap<Blacklist,CreateBlacklistRequest>().ReverseMap();
            CreateMap<Blacklist,DTO.Response.BlacklistResponse.CreateBlacklistResponse>().ReverseMap();
        }
    }
}
