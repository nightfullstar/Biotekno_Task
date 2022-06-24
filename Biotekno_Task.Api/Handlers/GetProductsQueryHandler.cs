using AutoMapper;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Queries;
using MediatR;

namespace Biotekno_Task.Api.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Model.Product>>
    {
        private readonly IProductRepository _product;
        private IMapper _mapper;
    
        public GetProductsQueryHandler(IProductRepository product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

       async Task<List<Product>> IRequestHandler<GetProductsQuery, List<Product>>.Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            dynamic result;
            dynamic query;
            if (request.Category != null)
            {
                query = await _product.GetProductListByCategory(request.Category);
            }
            else
            {
                query = _product.GetAll().ToList();
            }
            result = _mapper.Map<List<Model.Product>>(query);


            return result;
        }
    }
}
