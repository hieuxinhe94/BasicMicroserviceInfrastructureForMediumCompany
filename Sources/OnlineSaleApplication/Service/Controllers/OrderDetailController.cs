using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailBusiness _orderDetailBusiness;

        private readonly IMapper _mapper;

        public OrderDetailController(IMapper mapper, IOrderDetailBusiness orderDetailBusiness)
        {
            _orderDetailBusiness = orderDetailBusiness;
            _mapper = mapper;
        }

        // GET: api/OrderDetail
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrderDetail/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST: api/OrderDetail
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OrderDetail/5
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
