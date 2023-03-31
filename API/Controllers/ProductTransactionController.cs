using EcommerceContract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductTransactionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductController> _logger;
        IProductTransactionAppService _productAppService;
        public ProductTransactionController(ILogger<ProductController> logger, IProductTransactionAppService productAppService)
        {
            _logger = logger;
            _productAppService = productAppService;
        }

        [HttpPost("add")]
        public bool add()
        {
            var result = _productAppService.CreateInTransaction();
            return result;
        }
    }
}