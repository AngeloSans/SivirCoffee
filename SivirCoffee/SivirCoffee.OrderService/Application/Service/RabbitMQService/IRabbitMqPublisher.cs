namespace SivirCoffee.OrderService.Application.Service.RabbitMQService
{
    public interface IRabbitMqPublisher
    {
        void Publish<T>(T message);
    }
}
