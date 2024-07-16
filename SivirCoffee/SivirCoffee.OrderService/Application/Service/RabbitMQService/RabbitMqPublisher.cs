using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using SivirCoffee.OrderService.Infraestructure;
using System.Text;
using System.Text.Json;

namespace SivirCoffee.OrderService.Application.Service.RabbitMQService
{
    public class RabbitMQPublisher : IRabbitMqPublisher
    {
        private readonly RabbitMQConfig _config;
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public RabbitMQPublisher(IOptions<RabbitMQConfig> options)
        {
            _config = options.Value;
            var factory = new ConnectionFactory() { HostName = _config.HostName };
            _connection = factory.CreateConnectionAsync();
            _channel = _connection.CreateChannelAsync();
            _channel.ExchangeDeclare(exchange: _config.ExchangeName, type: ExchangeType.Direct);
            _channel.QueueDeclare(queue: _config.QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: _config.QueueName, exchange: _config.ExchangeName, routingKey: _config.RoutingKey);
        }

        public void Publish<T>(T message)
        {
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
            _channel.BasicPublish(exchange: _config.ExchangeName, routingKey: _config.RoutingKey, basicProperties: null, body: body);
        }
    }
}
