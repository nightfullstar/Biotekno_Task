using AutoWrapper.Wrappers;
using Biotekno_Task.Api.Model;
using MediatR;

namespace Biotekno_Task.Api.Requests
{
    public class CreateOrderRequest : IRequest<ApiResponse>
    {
        private OrderRequest request;

        public CreateOrderRequest(OrderRequest request)
        {
            this.request = request;
        }
    }
}
