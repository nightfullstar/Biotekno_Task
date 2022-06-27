using AutoMapper;
using AutoWrapper.Wrappers;
using Biotekno_Task.Api.Infrastructure.Interfaces;
using Biotekno_Task.Api.Model;
using Biotekno_Task.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biotekno_Task.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductService : ControllerBase
    {
        public IMediator _mediator;

        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetProducts")]
        public async Task<ApiResponse> GetProducts(string? category)
        {
            var query = new GetProductsQuery(category);
             var result = await _mediator.Send(query);
            return new ApiResponse(result.Count.ToString() + " results have been loaded.",result);
        }
    }
}
