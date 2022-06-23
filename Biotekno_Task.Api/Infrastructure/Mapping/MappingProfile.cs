using AutoMapper;

namespace Biotekno_Task.Api.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entity.Product, Model.Product>();
        }
    }
}
