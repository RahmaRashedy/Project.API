using ClassLibrary1.BL.Dtos.Product;
using ClassLibrary1.BL.Manager.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.API.Last.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductManager productManager, ILogger<ProductController> logger)
        {
            _productManager = productManager;
        }
        [HttpGet("getAllProduct")]
        public ActionResult<IEnumerable<DetailsProductDto>> GetAll()
        {
            var products = _productManager.GetAll();
            return Ok(products);
        }
        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<DetailsProductDto> GetById(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;

        }
        [Authorize]
        [HttpGet]
        public ActionResult<DetailsProductDto> GetProducts(string category = null!, string name = null!)
        {
            var productts = _productManager.GetProductsByCategoryandName(category,name);
            return Ok(productts);
        }
        [HttpPost]
        public ActionResult<AddProductDto> Add(AddProductDto addProductDto)
        {

            var url = imageToURL(addProductDto.URL);
            _productManager.Add(addProductDto, url);

            return Ok(new { Message = "Product Created Successfully" });
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _productManager.Delete(id);
            return Ok(new { Message = "Product Deleted Successfully" });
        }
        [HttpPut("{id:int}")]
        public ActionResult Update(int id, [FromForm] UpdateProductDto updateProductDto)
        {
            updateProductDto.Id = id;

            var url = imageToURL(updateProductDto.URL);
            _productManager.Update(updateProductDto, url);
            return Ok(new { Message = "Product updated Successfully" });
        }
        private string imageToURL(IFormFile file)
    {
        //cheake on Extension
        var extention = Path.GetExtension(file.FileName);
        //Store image

        var newFileName = $"{Guid.NewGuid()}{extention}";
        var directory = Path.Combine(Environment.CurrentDirectory, "Images"); // Combine directory path
        var fullPath = Path.Combine(directory, newFileName); // Combine full file path


        using var stream = new FileStream(fullPath, FileMode.Create);
        file.CopyTo(stream);

        //Generate URL
        var url = $"{Request.Scheme}://{Request.Host}/Images/{newFileName}";
        return url;
    }
    }
}
