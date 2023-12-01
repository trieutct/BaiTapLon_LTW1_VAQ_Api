using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Applicationn.Dto;
using Shop.Applicationn.Services;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post(ProductDto product)
        {
            if (_productService.Add(product))
            {
                return NoContent();
            }
            return Ok("Sản phẩm đã tồn tại");
        }
        [HttpPut("{id}")]
        public IActionResult Put(ProductDto product)
        {
            if (_productService.Update(product))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_productService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì sản phẩm này không tồn tại");
        }
    }
}
