using AutoMapper;
using dotnetcore.Controllers.Resources;
using dotnetcore.Models;

namespace dotnetcore.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
        }
    }
}