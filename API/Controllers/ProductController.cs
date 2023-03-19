using EcommerceContract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductController> _logger;
        IProductAppService _productAppService;
        public ProductController(ILogger<ProductController> logger, IProductAppService productAppService)
        {
            _logger = logger;
            _productAppService = productAppService;
        }

        [HttpGet(Name = "Get")]
        public IEnumerable<ProductGetBase> Get()
        {
            var result = _productAppService.Get();
            return result;
        }
    }
}