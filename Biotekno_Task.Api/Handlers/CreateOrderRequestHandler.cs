using AutoMapper;
using AutoWrapper.Wrappers;
using Biotekno_Task.Api.Core.Interfaces;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Requests;
using MediatR;

namespace Biotekno_Task.Api.Handlers
{
    public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, ApiResponse>
    {
        private readonly IOrderRepository _order;
        private IMapper _mapper;
        private ISendMailProducer _sendMailProducer;

        public CreateOrderRequestHandler(IOrderRepository order, IMapper mapper, ISendMailProducer sendMailProducer)
        {
            _order = order;
            _mapper = mapper;
            _sendMailProducer = sendMailProducer;
        }

        public Task<ApiResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {

          _order.AddOrder()
        }
    }
}
