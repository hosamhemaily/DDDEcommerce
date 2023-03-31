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
        private readonly IPublishEndpoint _publishEndpoint;

        IOrderAppService _orderAppService;
        public OrderCreatedConsumer(
            IOrderAppService orderAppService,
            IPublishEndpoint publishEndpoint)
        {
            _orderAppService= orderAppService;
            _publishEndpoint = publishEndpoint;

    }


    public async Task Consume(ConsumeContext<OrderCreated> context)
        {
            try
            {
                _orderAppService.OrderDonePurshase(new OrderDTO
                {
                    ID = context.Message.ID,
                    Products = context.Message.Products.Select(x => new EcommerceContract.ProductDTO { productid = x.productid, quantity = x.quantity }).ToList()
                });
            }
            catch (Exception)
            {
                _publishEndpoint.Publish(new OrderFailed { id = context.Message.ID });
                
            }
            //var jsonMessage = JsonConvert.SerializeObject(context.Message);
         
          //  Console.WriteLine($"OrderCreated message: {jsonMessage}");
        }
    }
}
