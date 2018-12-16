using AutoMapper;
using Bll.Interfaces;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Service.ViewModel;
using System.Collections.Generic;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryBusiness _productCategoryBusiness;

        private readonly IMapper _mapper;

        public ProductCategoryController(IMapper mapper, IProductCategoryBusiness productCategoryBusiness)
        {
            _productCategoryBusiness = productCategoryBusiness;
            _mapper = mapper;
        }

        // GET: api/ProductCategory
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productCategoryBusiness.GetAllWithoutPagination());
        }

        // GET: api/ProductCategory/GetById/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_productCategoryBusiness.GetByIdAsync(id));
        }

        // POST: api/ProductCategory
        [HttpPost]
        [Route("Create")]
        public IActionResult Post([FromBody] ProductCategoryViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_productCategoryBusiness.CreateAsync(_mapper.Map<ProductCategory>(vm)).Result);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Post(int id, [FromBody] ProductCategoryViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_productCategoryBusiness.UpdateAsync(id, _mapper.Map<ProductCategory>(vm)));
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productCategoryBusiness.DeleteAsync(id));
        }
    }
}
