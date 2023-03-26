using EcommerceContract;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SharedAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        IOrderAppService _orderAppService;
        public OrderCreatedConsumer(
            IOrderAppService orderAppService
            )
        {
            _orderAppService= orderAppService;
        }

      
        public async Task Consume(ConsumeContext<OrderCreated> context)
        {
            //var jsonMessage = JsonConvert.SerializeObject(context.Message);
            _orderAppService.OrderDonePurshase(new OrderDTO
            {
                ID = context.Message.ID,
                Products = context.Message.Products.Select(x => new EcommerceContract.ProductDTO { productid = x.productid, quantity = x.quantity }).ToList()
            });
          //  Console.WriteLine($"OrderCreated message: {jsonMessage}");
        }
    }
}
