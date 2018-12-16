using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductViewController : ControllerBase
    {
        private readonly IProductViewBusiness _productViewBusiness;

        private readonly IMapper _mapper;

        public ProductViewController(IMapper mapper, IProductViewBusiness productViewBusiness)
        {
            _productViewBusiness = productViewBusiness;
            _mapper = mapper;
        }

        // GET: api/ProductView
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductView/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST: api/ProductView
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ProductView/5
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
