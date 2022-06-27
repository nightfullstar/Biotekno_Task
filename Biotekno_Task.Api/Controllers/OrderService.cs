using AutoWrapper.Wrappers;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Biotekno_Task.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderService : ControllerBase
    {
        private readonly IMediator _mediator;
            public OrderService(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("OrderRequest")]
        public async Task<ApiResponse> CreateOrder([FromBody] OrderRequest request)
        {
            var query = new CreateOrderRequest(request);
            var result = await _mediator.Send(query);

            return result;
        }
     
    }
}
