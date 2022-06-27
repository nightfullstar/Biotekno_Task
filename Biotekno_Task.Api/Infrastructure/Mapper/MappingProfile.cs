using AutoMapper;
using Biotekno_Task.Api.Core.Entity;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;


namespace Biotekno_Task.Api.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
        {
            CreateMap<Core.Entity.BaseEntity, Model.BaseModel>().IncludeAllDerived().ReverseMap();
            CreateMap<Core.Entity.Product, Model.Product>()
                .ForMember(dest => dest.Id,act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.Category, act => act.MapFrom(src => src.Category))
                .ForMember(dest => dest.Unit, act => act.MapFrom(src => src.Unit))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice)).ReverseMap();

            CreateMap<IQueryable<Core.Entity.Product>, IEnumerable<Model.Product>>().ReverseMap();

            CreateMap<OrderRequest, Order>()
                .ForMember(dest => dest.CustomerName, act => act.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.CustomerGsm, act => act.MapFrom(src => src.CustomerGSM))
                .ForMember(dest => dest.CustomerEmail, act => act.MapFrom(src => src.CustomerEmail))
                .ReverseMap();

        }
    }
}
