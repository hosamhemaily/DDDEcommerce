
using EcommerceApplication;
using EcommerceApplication.Application;
using EcommercePersistence;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterPersistence(builder.Configuration["Database"].ToString());

builder.Services.RegisterApplication();

builder.Services.AddMassTransit(config =>
{
    config.AddConsumer<OrderCreatedConsumer>();
    config.UsingRabbitMq((ctx, cfg) =>
    {
        cfg.Host("amqp://guest:guest@localhost:5672");
        cfg.ReceiveEndpoint("order-qu", c =>
        {
            c.ConfigureConsumer<OrderCreatedConsumer>(ctx);
        });
    });
});


//builder.Services.AddMassTransit(mt => mt.UsingRabbitMq((cntxt, cfg) => {
//    cfg.Host("localhost", "/", c => {
//        c.Username("guest");
//        c.Password("guest");
//    });
//    cfg.ReceiveEndpoint("order-queue", (c) => {

//        c.Consumer<OrderCreatedConsumer>();
//    });
//}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
