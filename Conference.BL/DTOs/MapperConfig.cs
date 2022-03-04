using AutoMapper;
using Conference.DL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.BL.DTOs
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<TalkDto, Talk>().ReverseMap();
            CreateMap<SpeakerDto, Speaker>().ReverseMap();
            CreateMap<AtendeeDto, Attendee>().ReverseMap();
        }
    }
}
