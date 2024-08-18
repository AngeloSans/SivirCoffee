namespace SivirCoffee.OrderService.Application.Service.RabbitMQService
{
    public interface IRabbitMqPublisher
    {
        Task Publish(Object data, string routingKey);
    }
}
