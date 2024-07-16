using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SivirCoffee.OrderService.Infraestructure;
using SivirCoffee.OrderService.Service;
using SivirCoffee.OrderService.Infrastructure.Repository;
using SivirCoffee.OrderService.Infrastructure;
using SivirCoffee.OrderService.Application.Service.RabbitMQService;
using SivirCoffee.OrderService.Application.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OrderDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


//rabbitmqCOnfigurations

builder.Services.Configure<RabbitMQConfig>(builder.Configuration.GetSection("RabbitMQConfig"));
//builder.Services.AddSingleton<IRabbitMqPublisher, RabbitMQPublisher>();
//services.AddSingleton<IHostedService, RabbitMQConsumer>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();


builder.Services.AddScoped<IOrderService, OrderService>();


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
