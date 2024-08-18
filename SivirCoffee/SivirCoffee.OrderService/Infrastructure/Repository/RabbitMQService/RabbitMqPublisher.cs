using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using SivirCoffee.OrderService.Infraestructure;
using System.Text;
using System.Text.Json;

namespace SivirCoffee.OrderService.Application.Service.RabbitMQService
{
    public class RabbitMQPublisher
    {
        private readonly RabbitMQConfig _config;
        private readonly Task<IConnection> _connection;
        private readonly IModel _channel;
        private const string _exchange = "Tracking Service";

        public RabbitMQPublisher()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            _connection = factory.CreateConnectionAsync();
            _channel = _connection.Cr
            _channel.ExchangeDeclare(exchange: _config.ExchangeName, type: ExchangeType.Direct);
            _channel.QueueDeclare(queue: _config.QueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: _config.QueueName, exchange: _config.ExchangeName, routingKey: _config.RoutingKey);
        }
        
        public void Publish(object data, string routingKey)
        {
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data));
            _channel.BasicPublish(_exchange, routingKey, null, body);
        }
    }
}


