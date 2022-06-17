using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using BrothersCarMovers.Entities;
using BrothersCarMovers.Common.ViewModels;

namespace BrothersCarMovers.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserVM, User>();
        }
    }
}
