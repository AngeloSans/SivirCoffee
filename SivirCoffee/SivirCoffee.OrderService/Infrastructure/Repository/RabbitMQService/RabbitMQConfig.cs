namespace SivirCoffee.OrderService.Infraestructure
{
    public class RabbitMQConfig
    {
        public string HostName { get; set; }
        public string QueuName { get; set; }
        public string ExchangeName { get; set; }
        public string RoutingKey { get; set; }
    }
}
