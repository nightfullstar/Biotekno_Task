using Biotekno_Task.Api.Model;
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
        [HttpPost(Name = "CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] JObject orderdata)
        {
            return null;
        }
     
    }
}
