using AutoMapper;
using BB2020.Api.Resources;
using BB2020.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BB2020.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();

            CreateMap<UserResource, User>();
        }
    }
}
