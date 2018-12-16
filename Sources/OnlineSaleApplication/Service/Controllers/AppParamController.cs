using AutoMapper;
using Bll.Interfaces;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Service.ViewModel;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppParamController : ControllerBase
    {
        private readonly IAppParamBusiness _appParamService;

        private readonly IMapper _mapper;

        public AppParamController(IMapper mapper, IAppParamBusiness appParamService)
        {
            _appParamService = appParamService;
            _mapper = mapper;
        }

        // GET: api/AppParam
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appParamService.GetAllWithoutPagination());
        }

        // GET: api/AppParam/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_appParamService.GetByIdAsync(id));
        }

        // POST: api/AppParam
        [HttpPost]
        [Route("Create")]
        public IActionResult Post([FromBody] AppParamViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_appParamService.CreateAsync(_mapper.Map<ApplicationParam>(vm)).Result);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Post(int id, [FromBody] AppParamViewModel vm)
        {
            if (ModelState.IsValid)
            {
                return Ok(_appParamService.UpdateAsync(id, _mapper.Map<ApplicationParam>(vm)));
            }
            return BadRequest();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_appParamService.Delete(id));
        }
    }
}
