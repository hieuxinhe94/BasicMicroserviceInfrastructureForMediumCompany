using AutoMapper;
using Bll.Interfaces;
using Core.ViewModel;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Service.ViewModel;
using System.Linq;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: api/Product
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var list = _productService.GetAllWithoutPagination()
                .Select(t => _mapper.Map<ProductViewModel>(t));

            return Ok(list);
        }

        [HttpGet]
        [Route("GetBySection")]
        public IActionResult Get(string section, [FromQuery] SearchViewModel searchModel)
        {
            var list = _productService.GetProductBySection(section, searchModel)
                .Select(t => _mapper.Map<ProductViewModel>(t));

            return Ok(list);
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult Get([FromQuery] SearchViewModel searchModel)
        {
            var list = _productService.GetAllWithPagination(searchModel)
                .Select(t => _mapper.Map<ProductViewModel>(t));

            return Ok(list);
        }

        // GET: api/Product/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult Post([FromBody] ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Ok(_productService.CreateAsync(_mapper.Map<Product>(viewModel)).Result);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Post(int id, [FromBody] ProductCategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Ok(_productService.UpdateAsync(id, _mapper.Map<Product>(viewModel)).Result);
            }
            return BadRequest();
        }
    }
}
