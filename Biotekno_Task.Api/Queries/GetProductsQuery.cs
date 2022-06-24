using Biotekno_Task.Api.Model;
using MediatR;

namespace Biotekno_Task.Api.Queries
{
    public class GetProductsQuery : IRequest<List<Product>>
    {
        public string Category { get; }
        public GetProductsQuery(string category)
        {
            Category = category;
        }
    }
}
