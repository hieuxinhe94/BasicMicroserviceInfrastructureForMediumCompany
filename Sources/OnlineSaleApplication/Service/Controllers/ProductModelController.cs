using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductModelController : ControllerBase
    {
        private readonly IProductModelBusiness _productModelBusiness;

        private readonly IMapper _mapper;

        public ProductModelController(IMapper mapper, IProductModelBusiness productModelBusiness)
        {
            _productModelBusiness = productModelBusiness;
            _mapper = mapper;
        }

        // GET: api/ProductModel
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductModel/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST: api/ProductModel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ProductModel/5
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
