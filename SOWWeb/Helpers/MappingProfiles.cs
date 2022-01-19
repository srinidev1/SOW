using AutoMapper;
using SOWWeb.Core.Entities;
using SOWWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWWeb.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Corporation, CorporationVM>().ReverseMap();
        }
    }
}
