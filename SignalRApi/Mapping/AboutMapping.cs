﻿using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLater.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping : Profile 
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();

        }
    }
}
