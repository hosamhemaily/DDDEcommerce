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

namespace EcommerceApplication.Event
{
    public class OrderCanceledConsumer : IConsumer<OrderCanceled>
    {
        private readonly IPublishEndpoint _publishEndpoint;

        IOrderAppService _orderAppService;
        public OrderCanceledConsumer(
            IOrderAppService orderAppService,
            IPublishEndpoint publishEndpoint)
        {
            _orderAppService = orderAppService;
            _publishEndpoint = publishEndpoint;

        }


        public async Task Consume(ConsumeContext<OrderCanceled> context)
        {
            try
            {
                _orderAppService.OrderCanceled(new OrderDTO { ID = context .Message.ID} );
            }
            catch (Exception)
            {
               // _publishEndpoint.Publish(new OrderFailed { id = context.Message.id });

            }
            //var jsonMessage = JsonConvert.SerializeObject(context.Message);

            //  Console.WriteLine($"OrderCreated message: {jsonMessage}");
        }
    }
}
