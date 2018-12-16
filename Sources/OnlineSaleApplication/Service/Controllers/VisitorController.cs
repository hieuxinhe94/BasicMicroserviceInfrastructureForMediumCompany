using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly IVisitorBusiness _visitorBusiness;

        private readonly IMapper _mapper;

        public VisitorController(IMapper mapper, IVisitorBusiness visitorBusiness)
        {
            _visitorBusiness = visitorBusiness;
            _mapper = mapper;
        }

        // GET: api/Visitor
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Visitor/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST: api/Visitor
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Visitor/5
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
