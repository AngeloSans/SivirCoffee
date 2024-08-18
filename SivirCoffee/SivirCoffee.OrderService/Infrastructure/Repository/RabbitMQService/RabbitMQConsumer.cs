using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using SivirCoffee.OrderService.Infraestructure;

namespace SivirCoffee.OrderService.Application.Service.RabbitMQService
{
    public class RabbitMQConsumer
    {
        private readonly RabbitMQConfig _rabbbitMQConfig;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        
        public RabbitMQConsumer(IOptions<RabbitMQConfig> options, IServiceProvider serviceProvider)
        {
            _rabbbitMQConfig = options.Value;
            _serviceProvider = serviceProvider;

            var factory = new ConnectionFactory() { HostName = _rabbbitMQConfig.HostName };
            _connection = factory.CreateConnectionAsync();
            _channel = _connection.CreateChannelAsync();
            _channel.ExchangeDeclare
        }
    }
}