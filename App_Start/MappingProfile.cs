using AutoMapper;
using codefirstapp.Dtos;
using codefirstapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirstapp.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Players, PlayersDto>();
            Mapper.CreateMap<PlayersDto, Players>();
        }
    }
}