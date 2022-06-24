using AutoMapper;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Queries;
using MediatR;

using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace Biotekno_Task.Api.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Model.Product>>
    {
        private readonly IProductRepository _product;
        private IMapper _mapper;
    
        public GetProductsQueryHandler(IProductRepository product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        Task<IEnumerable<Product>> IRequestHandler<GetProductsQuery, IEnumerable<Product>>.Handle(GetProductsQuery request, CancellationToken cancellationToken)
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
            result = _mapper.ProjectTo<IEnumerable<Model.Product>>(query);


            return result;
        }
    }
}
