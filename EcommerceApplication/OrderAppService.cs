using EcommerceContract;
using EcommerceDomain.Products;
using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Dynamic;
using System.Text;

namespace EcommerceApplication
{
    public class OrderAppService : IOrderAppService
    {
        //IrepoProduct _product;
        //IrepoProductTransaction _productTransaction;
        //IUnitOfWork _unitofwork;

        public OrderAppService(
            //IrepoProduct product, IrepoProductTransaction productTransaction, IUnitOfWork unitofwork
            )
        {
            //_product= product;
            //_productTransaction= productTransaction;
            //_unitofwork= unitofwork;
        }

        public bool OrderDonePurshase()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "ordercreated",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            var consumer = new EventingBasicConsumer(channel);
            string message = string.Empty;
            //consumer.Received += (model, ea) =>
            //{
            //    var body = ea.Body.ToArray();

            //    message = Encoding.UTF8.GetString(body);
            //    // Console.WriteLine($" [x] Received {message}");
            //    var orderqueue = JsonConvert.DeserializeObject<OrderQueue>(message);
               
            //};
            //channel.BasicConsume(queue: "ordercreated",
            //                     autoAck: true,
            //                     consumer: consumer);
            


            //update avialable quantity for the product to be decreased for every product with order quantity
            //foreach (var item in order.Products)
            //{
            //    _product.updateQuantity(item.productid, item.quantity);
            //    var transaction =  ProductTransaction.Create(item.quantity, item.productid, Types.purshase);
            //    _productTransaction.add(transaction);
            //    _unitofwork.Save();
            //}

            // throw new NotImplementedException();
            return true;
        }
    }
}