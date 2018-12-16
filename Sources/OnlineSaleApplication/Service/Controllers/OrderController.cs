using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBusiness _orderBusiness;

        private readonly IMapper _mapper;

        public OrderController(IMapper mapper, IOrderBusiness orderBusiness)
        {
            _orderBusiness = orderBusiness;
            _mapper = mapper;
        }

        // GET: api/Order
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Order/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST: api/Order
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
