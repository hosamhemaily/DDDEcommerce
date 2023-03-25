using EcommerceContract;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductController> _logger;
        IOrderAppService _orderAppService;
        public OrderController(ILogger<ProductController> logger, IOrderAppService orderAppService)
        {
            _logger = logger;
            _orderAppService = orderAppService;
        }

        //[HttpGet(Name = "orderdone")]
        //public bool OrderDone()
        //{
        //    var result = _orderAppService.OrderDonePurshase();
        //    return result;
        //}
    }
}