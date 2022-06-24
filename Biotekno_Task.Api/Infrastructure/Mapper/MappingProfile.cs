using AutoMapper;
using Biotekno_Task.Api.Entity;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;


namespace Biotekno_Task.Api.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
        {
            CreateMap<Entity.BaseEntity, Model.BaseModel>().IncludeAllDerived().ReverseMap();
            CreateMap<Entity.Product, Model.Product>()
                .ForMember(dest => dest.Id,act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.Category, act => act.MapFrom(src => src.Category))
                .ForMember(dest => dest.Unit, act => act.MapFrom(src => src.Unit))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice)).ReverseMap();

            CreateMap<IQueryable<Entity.Product>, IEnumerable<Model.Product>>().ReverseMap();

        }
    }
}
