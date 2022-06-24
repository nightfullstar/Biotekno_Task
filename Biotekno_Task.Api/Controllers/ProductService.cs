using AutoMapper;
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
        public IMapper _mapper;
        public IProductRepository _product;

        public ProductService(IMediator mediator,IProductRepository product,IMapper mapper)
        {
            _mediator = mediator;
            _product = product;
            _mapper = mapper;
        }
        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts(string category)
        {
            var query = new GetProductsQuery(category);
             var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
