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
    public class NavigationController : ControllerBase
    {
        private readonly INavigationBusiness _navigationBusiness;

        private readonly IMapper _mapper;

        public NavigationController(IMapper mapper, INavigationBusiness navigationBusiness)
        {
            _navigationBusiness = navigationBusiness;
            _mapper = mapper;
        }

        // GET: api/ProductCategory
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_navigationBusiness.GetAllWithoutPagination());
        }

        // GET: api/ProductCategory/GetById/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_navigationBusiness.GetByIdAsync(id));
        }

        // POST: api/ProductCategory
        [HttpPost]
        [Route("Create")]
        public IActionResult Post([FromBody] NavigationViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_navigationBusiness.CreateAsync(_mapper.Map<Navigation>(vm)).Result);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Post(int id, [FromBody] NavigationViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_navigationBusiness.UpdateAsync(id, _mapper.Map<Navigation>(vm)));
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_navigationBusiness.DeleteAsync(id));
        }
    }
}