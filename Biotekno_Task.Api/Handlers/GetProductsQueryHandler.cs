using Biotekno_Task.Api.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Queries;
using MediatR;
using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace Biotekno_Task.Api.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
    {
        private readonly IProductRepository _product;
        private readonly IMapper _mapper;    
        public GetProductsQueryHandler(IProductRepository product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            dynamic result;
            dynamic query;
            if (request.Category != null)
            {
                query = _product.GetProductListByCategory(request.Category);
            }
         else
            {
                query = _product.GetAll();
            }
            //result = _mapper.Map<List<Entity.Product>, List<Product>>(query);
            result = _mapper.Map <List<Model.Product>>(query);
            return result;
        }
    }
}
