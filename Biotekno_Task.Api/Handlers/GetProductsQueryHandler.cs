using AutoMapper;
using Biotekno_Task.Api.Core.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Queries;
using MediatR;

namespace Biotekno_Task.Api.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Model.Product>>
    {
        private readonly IProductRepository _product;
        private IMapper _mapper;
    private Serilog.ILogger _logger;
        public GetProductsQueryHandler(IProductRepository product, IMapper mapper, Serilog.ILogger logger)
        {
            _product = product;
            _mapper = mapper;
            _logger = logger;
        }

        async Task<List<Product>> IRequestHandler<GetProductsQuery, List<Product>>.Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            List<Model.Product> result;
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
            _logger.Debug(result.Count.ToString() + "results came in and mapped.");

            return result;
        }
    }
}
